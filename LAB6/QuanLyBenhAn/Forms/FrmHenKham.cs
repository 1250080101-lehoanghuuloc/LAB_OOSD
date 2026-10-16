using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBenhAn.Forms
{
    public partial class FrmHenKham : Form
    {
        private string maHoSo = null;       // hồ sơ đang chọn
        private DateTime? hetHan = null;    // hạn hồ sơ

        public FrmHenKham()
        {
            InitializeComponent();
            this.Load += FrmHenKham_Load;
        }

        private void FrmHenKham_Load(object sender, EventArgs e)
        {
            dtpNgayGio.Value = DateTime.Now.AddDays(1);
            CapNhatQuy();
            LoadHenAll();
        }

        private static int Quy(DateTime d)
        {
            return (d.Month - 1) / 3 + 1;
        }

        private void CapNhatQuy()
        {
            txtQuy.Text = "Quý " + Quy(dtpNgayGio.Value) + "/" + dtpNgayGio.Value.Year;
        }

        private void dtpNgayGio_ValueChanged(object sender, EventArgs e)
        {
            CapNhatQuy();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ma = txtMaHoSo.Text.Trim();
            if (ma == "")
            {
                MessageBox.Show("Vui lòng nhập Mã hồ sơ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hoTen;
            DateTime? ngaySinh;
            if (!Db.LayThongTinHoSo(ma, out hoTen, out ngaySinh, out hetHan))
            {
                maHoSo = null;
                lblThongTin.Text = "Không tìm thấy hồ sơ " + ma;
                lblThongTin.ForeColor = Color.Red;
                dgvHen.DataSource = null;
                return;
            }

            maHoSo = ma;
            bool conHan = hetHan.HasValue && hetHan.Value.Date >= DateTime.Today;
            if (conHan)
            {
                lblThongTin.Text = hoTen + "  |  Còn hạn đến " + hetHan.Value.ToString("dd/MM/yyyy");
                lblThongTin.ForeColor = Color.DarkGreen;
            }
            else
            {
                lblThongTin.Text = hoTen + "  |  HẾT HẠN lệ phí - cần gia hạn";
                lblThongTin.ForeColor = Color.Red;
            }
            LoadHen();
        }

        // Lịch hẹn của bệnh nhân đang chọn
        private void LoadHen()
        {
            if (maHoSo == null) return;
            string query = @"SELECT MaHen AS [Mã hẹn],
                                    CONVERT(VARCHAR(10), NgayGioHen, 103) + ' ' + CONVERT(VARCHAR(5), NgayGioHen, 108) AS [Ngày giờ hẹn],
                                    N'Quý ' + CAST(Quy AS VARCHAR(1)) + '/' + CAST(Nam AS VARCHAR(4)) AS [Quý],
                                    GhiChu AS [Ghi chú],
                                    TrangThai AS [Trạng thái]
                             FROM LichHen WHERE MaHoSo = @ma ORDER BY NgayGioHen DESC";
            dgvHen.DataSource = Db.GetData(query, new SqlParameter("@ma", maHoSo));
        }

        // Các lịch hẹn sắp tới (phòng chăm sóc khách hàng theo dõi)
        private void LoadHenAll()
        {
            string query = @"SELECT b.MaHoSo AS [Mã hồ sơ], b.HoTen AS [Họ tên], b.DienThoai AS [Điện thoại],
                                    CONVERT(VARCHAR(10), h.NgayGioHen, 103) + ' ' + CONVERT(VARCHAR(5), h.NgayGioHen, 108) AS [Ngày giờ hẹn],
                                    N'Quý ' + CAST(h.Quy AS VARCHAR(1)) + '/' + CAST(h.Nam AS VARCHAR(4)) AS [Quý],
                                    h.TrangThai AS [Trạng thái]
                             FROM LichHen h JOIN BenhNhan b ON h.MaHoSo = b.MaHoSo
                             WHERE h.TrangThai = N'Đã hẹn' AND h.NgayGioHen >= CAST(GETDATE() AS DATE)
                             ORDER BY h.NgayGioHen";
            dgvHenAll.DataSource = Db.GetData(query);
        }

        // ===== Đặt lịch hẹn =====
        private void btnDatHen_Click(object sender, EventArgs e)
        {
            if (maHoSo == null)
            {
                MessageBox.Show("Vui lòng tìm và chọn hồ sơ bệnh nhân trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime hen = dtpNgayGio.Value;
            if (hen <= DateTime.Now)
            {
                MessageBox.Show("Ngày giờ hẹn phải ở thời điểm sau hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hồ sơ phải còn hạn vào ngày hẹn
            if (!hetHan.HasValue || hetHan.Value.Date < hen.Date)
            {
                MessageBox.Show("Hồ sơ đã (hoặc sẽ) hết hạn lệ phí trước ngày hẹn. Vui lòng gia hạn hồ sơ trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int quy = Quy(hen);
            int nam = hen.Year;

            // Mỗi quý chỉ có 1 lần khám định kỳ miễn phí
            object daHen = Db.ExecuteScalar(
                "SELECT COUNT(*) FROM LichHen WHERE MaHoSo = @ma AND Quy = @q AND Nam = @n AND TrangThai <> N'Hủy'",
                new SqlParameter("@ma", maHoSo), new SqlParameter("@q", quy), new SqlParameter("@n", nam));
            object daKham = Db.ExecuteScalar(
                @"SELECT COUNT(*) FROM PhieuKham WHERE MaHoSo = @ma AND LoaiKham = N'Khám định kỳ'
                    AND DATEPART(QUARTER, NgayGioKham) = @q AND YEAR(NgayGioKham) = @n",
                new SqlParameter("@ma", maHoSo), new SqlParameter("@q", quy), new SqlParameter("@n", nam));

            if ((daHen != null && Convert.ToInt32(daHen) > 0) || (daKham != null && Convert.ToInt32(daKham) > 0))
            {
                MessageBox.Show("Bệnh nhân đã có lịch hẹn / đã khám định kỳ trong quý " + quy + "/" + nam + ".\nMỗi quý chỉ được 01 lần khám định kỳ miễn phí.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlParameter pNgay = new SqlParameter("@ngay", SqlDbType.DateTime);
            pNgay.Value = hen;
            int result = Db.ExecuteNonQuery(
                "INSERT INTO LichHen(MaHoSo, NgayGioHen, Quy, Nam, GhiChu, TrangThai) VALUES (@ma, @ngay, @q, @n, @gc, N'Đã hẹn')",
                new SqlParameter("@ma", maHoSo), pNgay, new SqlParameter("@q", quy), new SqlParameter("@n", nam),
                new SqlParameter("@gc", txtGhiChu.Text.Trim()));

            if (result > 0)
            {
                MessageBox.Show("Đặt lịch hẹn khám định kỳ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGhiChu.Clear();
                LoadHen();
                LoadHenAll();
            }
        }

        // ===== Hủy hẹn =====
        private void btnHuyHen_Click(object sender, EventArgs e)
        {
            if (dgvHen.CurrentRow == null || dgvHen.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn lịch hẹn cần hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvHen.CurrentRow;
            string trangThai = row.Cells["Trạng thái"].Value.ToString();
            if (trangThai != "Đã hẹn")
            {
                MessageBox.Show("Chỉ có thể hủy lịch hẹn ở trạng thái 'Đã hẹn'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn hủy lịch hẹn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.Yes) return;

            int maHen = Convert.ToInt32(row.Cells["Mã hẹn"].Value);
            int result = Db.ExecuteNonQuery("UPDATE LichHen SET TrangThai = N'Hủy' WHERE MaHen = @id AND TrangThai = N'Đã hẹn'",
                new SqlParameter("@id", maHen));
            if (result > 0)
            {
                LoadHen();
                LoadHenAll();
            }
        }
    }
}
