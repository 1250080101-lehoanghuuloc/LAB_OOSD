using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBenhAn.Forms
{
    public partial class FrmDanhMuc : Form
    {
        public FrmDanhMuc()
        {
            InitializeComponent();
            // Đăng ký sự kiện Load để tự động lấy dữ liệu khi mở Form
            this.Load += FrmDanhMuc_Load;
        }

        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            LoadComboKhoa();
            LoadAllData();
        }

        // 1. Tải tất cả các bảng dữ liệu lên DataGridView
        private void LoadAllData()
        {
            LoadDataKhoa();
            LoadDataBacSi();
            LoadDataThuoc();
            LoadDataXetNghiem();
        }

        private void LoadComboKhoa()
        {
            DataTable dt = Db.GetData("SELECT MaKhoa, TenKhoa FROM Khoa ORDER BY TenKhoa");
            cboKhoaBS.DisplayMember = "TenKhoa";
            cboKhoaBS.ValueMember = "MaKhoa";
            cboKhoaBS.DataSource = dt;
        }

        private void LoadDataKhoa()
        {
            string query = "SELECT MaKhoa AS [Mã khoa], TenKhoa AS [Tên khoa] FROM Khoa";
            DataTable dt = Db.GetData(query);
            if (dt != null) dgvKhoa.DataSource = dt;
        }

        private void LoadDataBacSi()
        {
            string query = @"SELECT b.MaBS AS [Mã BS], b.HoTen AS [Họ tên], k.TenKhoa AS [Khoa]
                             FROM BacSi b JOIN Khoa k ON b.MaKhoa = k.MaKhoa";
            DataTable dt = Db.GetData(query);
            if (dt != null) dgvBacSi.DataSource = dt;
        }

        private void LoadDataThuoc()
        {
            string query = "SELECT MaThuoc AS [Mã thuốc], TenThuoc AS [Tên thuốc], DonViTinh AS [ĐVT] FROM Thuoc";
            DataTable dt = Db.GetData(query);
            if (dt != null) dgvThuoc.DataSource = dt;
        }

        private void LoadDataXetNghiem()
        {
            string query = "SELECT MaXN AS [Mã XN], TenXN AS [Tên xét nghiệm] FROM XetNghiem";
            DataTable dt = Db.GetData(query);
            if (dt != null) dgvXetNghiem.DataSource = dt;
        }

        private void CanhBao(string noiDung)
        {
            MessageBox.Show(noiDung, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // 2. Xử lý nút Thêm Khoa
        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaKhoa.Text.Trim();
            string ten = txtTenKhoa.Text.Trim();

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
            {
                CanhBao("Vui lòng nhập đầy đủ Mã khoa và Tên khoa!");
                return;
            }

            int result = Db.ExecuteNonQuery("INSERT INTO Khoa(MaKhoa, TenKhoa) VALUES (@ma, @ten)",
                new SqlParameter("@ma", ma), new SqlParameter("@ten", ten));

            if (result > 0)
            {
                MessageBox.Show("Thêm khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataKhoa();
                LoadComboKhoa();
                txtMaKhoa.Clear();
                txtTenKhoa.Clear();
                txtMaKhoa.Focus();
            }
        }

        // 3. Xử lý nút Thêm Bác sĩ
        private void btnThemBS_Click(object sender, EventArgs e)
        {
            string ma = txtMaBS.Text.Trim();
            string ten = txtTenBS.Text.Trim();
            string maKhoa = cboKhoaBS.SelectedValue as string;

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(maKhoa))
            {
                CanhBao("Vui lòng nhập Mã BS, Họ tên và chọn Khoa!");
                return;
            }

            int result = Db.ExecuteNonQuery("INSERT INTO BacSi(MaBS, HoTen, MaKhoa) VALUES (@ma, @ten, @khoa)",
                new SqlParameter("@ma", ma), new SqlParameter("@ten", ten), new SqlParameter("@khoa", maKhoa));

            if (result > 0)
            {
                MessageBox.Show("Thêm bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataBacSi();
                txtMaBS.Clear();
                txtTenBS.Clear();
                txtMaBS.Focus();
            }
        }

        // 4. Xử lý nút Thêm Thuốc
        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            string ma = txtMaThuoc.Text.Trim();
            string ten = txtTenThuoc.Text.Trim();
            string dvt = txtDVT.Text.Trim();

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
            {
                CanhBao("Vui lòng nhập Mã thuốc và Tên thuốc!");
                return;
            }

            int result = Db.ExecuteNonQuery("INSERT INTO Thuoc(MaThuoc, TenThuoc, DonViTinh) VALUES (@ma, @ten, @dvt)",
                new SqlParameter("@ma", ma), new SqlParameter("@ten", ten), new SqlParameter("@dvt", dvt));

            if (result > 0)
            {
                MessageBox.Show("Thêm thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataThuoc();
                txtMaThuoc.Clear();
                txtTenThuoc.Clear();
                txtDVT.Clear();
                txtMaThuoc.Focus();
            }
        }

        // 5. Xử lý nút Thêm Xét nghiệm
        private void btnThemXN_Click(object sender, EventArgs e)
        {
            string ma = txtMaXN.Text.Trim();
            string ten = txtTenXN.Text.Trim();

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
            {
                CanhBao("Vui lòng nhập Mã XN và Tên xét nghiệm!");
                return;
            }

            int result = Db.ExecuteNonQuery("INSERT INTO XetNghiem(MaXN, TenXN) VALUES (@ma, @ten)",
                new SqlParameter("@ma", ma), new SqlParameter("@ten", ten));

            if (result > 0)
            {
                MessageBox.Show("Thêm xét nghiệm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataXetNghiem();
                txtMaXN.Clear();
                txtTenXN.Clear();
                txtMaXN.Focus();
            }
        }
    }
}
