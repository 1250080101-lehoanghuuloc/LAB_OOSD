using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBenhAn.Forms
{
    public partial class FrmThongKe : Form
    {
        public FrmThongKe()
        {
            InitializeComponent();
            this.Load += FrmThongKe_Load;
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            dtpTu.Value = new DateTime(DateTime.Today.Year, 1, 1);
            dtpDen.Value = DateTime.Today;
            ThongKe();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKe();
        }

        private SqlParameter[] ThamSoKhoangNgay()
        {
            SqlParameter tu = new SqlParameter("@tu", SqlDbType.DateTime);
            tu.Value = dtpTu.Value.Date;
            SqlParameter den = new SqlParameter("@den", SqlDbType.DateTime);
            den.Value = dtpDen.Value.Date.AddDays(1);   // đến hết ngày cuối
            return new SqlParameter[] { tu, den };
        }

        private void ThongKe()
        {
            if (dtpTu.Value.Date > dtpDen.Value.Date)
            {
                MessageBox.Show("'Từ ngày' phải nhỏ hơn hoặc bằng 'Đến ngày'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lượt khám theo khoa
            dgvKhoa.DataSource = Db.GetData(
                @"SELECT k.TenKhoa AS [Khoa],
                         COUNT(pk.MaPhieuKham) AS [Số lượt khám],
                         ISNULL(SUM(CASE WHEN pk.LoaiKham = N'Khám định kỳ' THEN 1 ELSE 0 END), 0) AS [Khám định kỳ]
                  FROM Khoa k
                  LEFT JOIN PhieuKham pk ON pk.MaKhoa = k.MaKhoa AND pk.NgayGioKham >= @tu AND pk.NgayGioKham < @den
                  GROUP BY k.TenKhoa
                  ORDER BY COUNT(pk.MaPhieuKham) DESC, k.TenKhoa", ThamSoKhoangNgay());

            // Lượt khám theo bác sĩ (trách nhiệm bác sĩ trong các đợt điều trị)
            dgvBS.DataSource = Db.GetData(
                @"SELECT b.HoTen AS [Bác sĩ], k.TenKhoa AS [Khoa], COUNT(pk.MaPhieuKham) AS [Số lượt khám]
                  FROM BacSi b
                  JOIN Khoa k ON b.MaKhoa = k.MaKhoa
                  LEFT JOIN PhieuKham pk ON pk.MaBS = b.MaBS AND pk.NgayGioKham >= @tu AND pk.NgayGioKham < @den
                  GROUP BY b.HoTen, k.TenKhoa
                  ORDER BY COUNT(pk.MaPhieuKham) DESC, b.HoTen", ThamSoKhoangNgay());

            // Thuốc kê nhiều nhất
            dgvThuoc.DataSource = Db.GetData(
                @"SELECT TOP 10 t.TenThuoc AS [Thuốc], COUNT(*) AS [Số toa], SUM(tt.SoLuong) AS [Tổng số lượng]
                  FROM ToaThuoc tt
                  JOIN PhieuKham pk ON tt.MaPhieuKham = pk.MaPhieuKham
                  JOIN Thuoc t ON tt.MaThuoc = t.MaThuoc
                  WHERE pk.NgayGioKham >= @tu AND pk.NgayGioKham < @den
                  GROUP BY t.TenThuoc
                  ORDER BY COUNT(*) DESC, SUM(tt.SoLuong) DESC", ThamSoKhoangNgay());

            // Doanh thu
            object lp = Db.ExecuteScalar(
                "SELECT ISNULL(SUM(LePhi), 0) FROM DangKy WHERE NgayDangKy >= @tu AND NgayDangKy < @den", ThamSoKhoangNgay());
            object vp = Db.ExecuteScalar(
                "SELECT ISNULL(SUM(VienPhi), 0) FROM PhieuKham WHERE NgayGioKham >= @tu AND NgayGioKham < @den", ThamSoKhoangNgay());

            decimal tongLePhi = lp == null ? 0 : Convert.ToDecimal(lp);
            decimal tongVienPhi = vp == null ? 0 : Convert.ToDecimal(vp);

            lblLePhi.Text = "Tổng lệ phí đăng ký / gia hạn: " + tongLePhi.ToString("N0") + " đ";
            lblVienPhi.Text = "Tổng viện phí: " + tongVienPhi.ToString("N0") + " đ";
            lblTong.Text = "TỔNG DOANH THU: " + (tongLePhi + tongVienPhi).ToString("N0") + " đ";
        }
    }
}
