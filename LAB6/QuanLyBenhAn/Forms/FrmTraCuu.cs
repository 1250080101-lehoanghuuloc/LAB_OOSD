using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QuanLyBenhAn.Forms
{
    public partial class FrmTraCuu : Form
    {
        public FrmTraCuu()
        {
            InitializeComponent();
            this.Load += FrmTraCuu_Load;
        }

        private void FrmTraCuu_Load(object sender, EventArgs e)
        {
            TimKiem();
        }

        // Tìm theo mã hồ sơ / họ tên / điện thoại (để trống = bỏ qua điều kiện đó)
        private void TimKiem()
        {
            string query = @"SELECT b.MaHoSo AS [Mã hồ sơ],
                                    b.HoTen AS [Họ tên],
                                    CONVERT(VARCHAR(10), b.NgaySinh, 103) AS [Ngày sinh],
                                    b.DienThoai AS [Điện thoại],
                                    b.DiaChi AS [Địa chỉ],
                                    (SELECT COUNT(*) FROM PhieuKham p WHERE p.MaHoSo = b.MaHoSo) AS [Số lần khám]
                             FROM BenhNhan b
                             WHERE (@ma = '' OR b.MaHoSo LIKE '%' + @ma + '%')
                               AND (@ten = '' OR b.HoTen LIKE N'%' + @ten + N'%')
                               AND (@dt = '' OR b.DienThoai LIKE '%' + @dt + '%')
                             ORDER BY b.MaHoSo";
            dgvBenhNhan.DataSource = Db.GetData(query,
                new SqlParameter("@ma", txtMa.Text.Trim()),
                new SqlParameter("@ten", txtTen.Text.Trim()),
                new SqlParameter("@dt", txtDT.Text.Trim()));

            dgvLichSu.DataSource = null;
            dgvToa.DataSource = null;
            dgvXN.DataSource = null;
            if (picAnh.Image != null)
            {
                picAnh.Image.Dispose();
                picAnh.Image = null;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtTen.Clear();
            txtDT.Clear();
            TimKiem();
        }

        // Chọn bệnh nhân -> xem ảnh + lịch sử khám
        private void dgvBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string ma = dgvBenhNhan.Rows[e.RowIndex].Cells["Mã hồ sơ"].Value.ToString();
            dgvLichSu.DataSource = Db.GetLichSuKham(ma);
            dgvToa.DataSource = null;
            dgvXN.DataSource = null;

            // Ảnh 3x4
            if (picAnh.Image != null)
            {
                picAnh.Image.Dispose();
                picAnh.Image = null;
            }
            object anh = Db.ExecuteScalar("SELECT Anh FROM BenhNhan WHERE MaHoSo = @ma", new SqlParameter("@ma", ma));
            if (anh != null && anh != DBNull.Value)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream((byte[])anh))
                    using (Image img = Image.FromStream(ms))
                    {
                        picAnh.Image = new Bitmap(img);
                    }
                }
                catch (Exception)
                {
                    picAnh.Image = null;
                }
            }
        }

        // Chọn 1 lần khám -> xem toa thuốc + xét nghiệm
        private void dgvLichSu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int maPhieu = Convert.ToInt32(dgvLichSu.Rows[e.RowIndex].Cells["Mã phiếu"].Value);
            dgvToa.DataSource = Db.GetToaThuoc(maPhieu);
            dgvXN.DataSource = Db.GetKetQuaXN(maPhieu);
        }
    }
}
