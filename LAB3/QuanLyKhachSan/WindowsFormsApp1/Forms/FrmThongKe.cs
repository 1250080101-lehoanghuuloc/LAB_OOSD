using System;
using System.Data;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmThongKe : Form
    {
        readonly ThongKeService s = new ThongKeService();

        public FrmThongKe()
        {
            InitializeComponent();

            // Thiết lập mặc định khoảng thời gian đầu tháng tới hiện tại
            DateTime now = DateTime.Now;
            dtTu.Value = new DateTime(now.Year, now.Month, 1);
            dtDen.Value = now;

            this.Load += FrmThongKe_Load;
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            ThucHienThongKe();
        }

        private void btnTK_Click(object a, EventArgs e)
        {
            if (dtDen.Value.Date < dtTu.Value.Date)
            {
                MessageBox.Show("Đến ngày không được trước từ ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ThucHienThongKe();
        }

        private void ThucHienThongKe()
        {
            try
            {
                // 1. Lấy dữ liệu tổng hợp
                DataTable dtTH = s.TongHop(dtTu.Value, dtDen.Value);
                dgvTongHop.DataSource = dtTH;

                if (dtTH != null && dtTH.Rows.Count > 0)
                {
                    DataRow row = dtTH.Rows[0];

                    int soPhieuDat = row["SoPhieuDat"] != DBNull.Value ? Convert.ToInt32(row["SoPhieuDat"]) : 0;
                    int dangO = row["DangO"] != DBNull.Value ? Convert.ToInt32(row["DangO"]) : 0;
                    int soHoaDon = row["SoHoaDon"] != DBNull.Value ? Convert.ToInt32(row["SoHoaDon"]) : 0;
                    decimal doanhThu = row["DoanhThuHoaDon"] != DBNull.Value ? Convert.ToDecimal(row["DoanhThuHoaDon"]) : 0;
                    decimal denBu = row["TongDenBu"] != DBNull.Value ? Convert.ToDecimal(row["TongDenBu"]) : 0;

                    // Hiển thị trực tiếp dạng Text đẹp mắt đúng giao diện thiết kế
                    lblPhieuDat.Text = $"Phiếu đặt: {soPhieuDat}";
                    lblDangO.Text = $"Đang ở: {dangO}";
                    lblHoaDon.Text = $"Hóa đơn: {soHoaDon}";
                    lblDoanhThu.Text = $"Doanh thu HĐ: {doanhThu:N0} đ";
                    lblDenBu.Text = $"Tổng đền bù: {denBu:N0} đ";
                }

                // 2. Lấy dữ liệu danh sách Dịch vụ sử dụng
                DataTable dtDichVu = s.DichVu(dtTu.Value, dtDen.Value);
                dgvDV.DataSource = dtDichVu;

                if (dgvDV.Columns.Contains("MaDV")) dgvDV.Columns["MaDV"].HeaderText = "Mã DV";
                if (dgvDV.Columns.Contains("TenDV")) dgvDV.Columns["TenDV"].HeaderText = "Tên dịch vụ";
                if (dgvDV.Columns.Contains("TongSoLuong")) dgvDV.Columns["TongSoLuong"].HeaderText = "Tổng số lượng";
                if (dgvDV.Columns.Contains("TongTien"))
                {
                    dgvDV.Columns["TongTien"].HeaderText = "Tổng tiền";
                    dgvDV.Columns["TongTien"].DefaultCellStyle.Format = "N0";
                }

                dgvDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object a, EventArgs e)
        {
            Close();
        }
    }
}