using System;
using System.Data;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmDichVu : Form
    {
        private readonly DichVuService s = new DichVuService();
        private readonly DanhMucService dm = new DanhMucService();
        private readonly string maNVHienTai = "NV01"; // Mã nhân viên mặc định thực hiện ghi nhận

        public FrmDichVu()
        {
            InitializeComponent();
            this.Load += FrmDichVu_Load;
        }

        private void FrmDichVu_Load(object sender, EventArgs e)
        {
            // Tắt sự kiện tạm thời để tránh gọi truy vấn trùng lặp khi đang Binding
            cboPhieu.SelectedIndexChanged -= cboPhieu_SelectedIndexChanged;

            // 1. Nạp danh sách phiếu đang ở vào ComboBox Phiếu
            DataTable dtPhieu = s.LayPhieuDangO();
            if (dtPhieu != null)
            {
                cboPhieu.DataSource = dtPhieu;
                cboPhieu.DisplayMember = "SoPhieuDat";
                cboPhieu.ValueMember = "SoPhieuDat";

                // Nạp danh sách Phòng (tạo bản sao Copy để không bị dính binding với cboPhieu)
                DataTable dtPhong = dtPhieu.Copy();
                cboPhong.DataSource = dtPhong;
                cboPhong.DisplayMember = "SoPhong";
                cboPhong.ValueMember = "SoPhong";
            }

            // 2. Nạp danh sách Dịch vụ vào ComboBox Dịch vụ
            DataTable dtDV = s.LayDichVu();
            if (dtDV != null)
            {
                cboDichVu.DataSource = dtDV;
                cboDichVu.DisplayMember = dtDV.Columns.Contains("TenDV") ? "TenDV" : dtDV.Columns[0].ColumnName;
                cboDichVu.ValueMember = dtDV.Columns.Contains("MaDV") ? "MaDV" : dtDV.Columns[0].ColumnName;
            }

            // 3. Đăng ký lại sự kiện và các Event Handler
            cboPhieu.SelectedIndexChanged += cboPhieu_SelectedIndexChanged;
            btnGhiNhan.Click += btnGhiNhan_Click;

            // 4. Đồng bộ Số phòng và Tải lịch sử dịch vụ lần đầu
            CapNhatSoPhong();
            TaiLichSu();
        }

        // Lấy giá trị chuỗi an toàn từ ComboBox (xử lý DataRowView)
        private string LayGiaTriCombo(ComboBox c)
        {
            if (c == null || c.SelectedValue == null) return "";
            if (c.SelectedValue is DataRowView drv)
            {
                string valueMember = c.ValueMember;
                if (!string.IsNullOrEmpty(valueMember) && drv.Row.Table.Columns.Contains(valueMember))
                {
                    return drv[valueMember]?.ToString() ?? "";
                }
                return drv[0]?.ToString() ?? "";
            }
            return c.SelectedValue.ToString();
        }

        // Cập nhật số phòng tương ứng theo phiếu được chọn
        private void CapNhatSoPhong()
        {
            if (cboPhieu.SelectedItem is DataRowView drv)
            {
                if (drv.Row.Table.Columns.Contains("SoPhong"))
                {
                    cboPhong.SelectedValue = drv["SoPhong"].ToString();
                }
            }
        }

        // Tải danh sách lịch sử sử dụng dịch vụ lên DataGridView
        private void TaiLichSu()
        {
            string soPhieu = LayGiaTriCombo(cboPhieu);
            if (!string.IsNullOrEmpty(soPhieu))
            {
                DataTable dtLichSu = s.LayLichSu(soPhieu);
                dgvSuDungDichVu.DataSource = dtLichSu;

                if (dtLichSu != null)
                {
                    // Định dạng tên tiêu đề cột hiển thị tiếng Việt
                    if (dgvSuDungDichVu.Columns.Contains("SoPhieuSDDV")) dgvSuDungDichVu.Columns["SoPhieuSDDV"].HeaderText = "Số phiếu SD";
                    if (dgvSuDungDichVu.Columns.Contains("SoPhong")) dgvSuDungDichVu.Columns["SoPhong"].HeaderText = "Phòng";
                    if (dgvSuDungDichVu.Columns.Contains("NgaySuDung")) dgvSuDungDichVu.Columns["NgaySuDung"].HeaderText = "Ngày sử dụng";
                    if (dgvSuDungDichVu.Columns.Contains("TenDV")) dgvSuDungDichVu.Columns["TenDV"].HeaderText = "Tên dịch vụ";
                    if (dgvSuDungDichVu.Columns.Contains("SoLuong")) dgvSuDungDichVu.Columns["SoLuong"].HeaderText = "Số lượng";
                    if (dgvSuDungDichVu.Columns.Contains("DonGia"))
                    {
                        dgvSuDungDichVu.Columns["DonGia"].HeaderText = "Đơn giá";
                        dgvSuDungDichVu.Columns["DonGia"].DefaultCellStyle.Format = "N0";
                    }
                    if (dgvSuDungDichVu.Columns.Contains("ThanhTien"))
                    {
                        dgvSuDungDichVu.Columns["ThanhTien"].HeaderText = "Thành tiền";
                        dgvSuDungDichVu.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
                    }

                    dgvSuDungDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            else
            {
                dgvSuDungDichVu.DataSource = null;
            }
        }

        // Sự kiện thay đổi chọn phiếu lưu trú
        private void cboPhieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatSoPhong();
            TaiLichSu();
        }

        // Sự kiện nhấn nút Ghi nhận
        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
            string soPhieuDat = LayGiaTriCombo(cboPhieu);
            string soPhong = LayGiaTriCombo(cboPhong);
            if (string.IsNullOrEmpty(soPhong)) soPhong = cboPhong.Text.Trim();

            string maDV = LayGiaTriCombo(cboDichVu);
            DateTime ngay = dtpNgaySuDung.Value;
            int soLuong = (int)numSoLuong.Value;

            if (string.IsNullOrEmpty(soPhieuDat) || string.IsNullOrEmpty(soPhong) || string.IsNullOrEmpty(maDV))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin phiếu, phòng và dịch vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi hàm GhiNhan từ DichVuService
            KetQuaXuLy kq = s.GhiNhan(soPhieuDat, soPhong, ngay, maNVHienTai, maDV, soLuong);

            MessageBox.Show(kq.ThongBao, "Thông báo", MessageBoxButtons.OK,
                kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (kq.ThanhCong)
            {
                TaiLichSu(); // Làm mới lại bảng DataGridView
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}