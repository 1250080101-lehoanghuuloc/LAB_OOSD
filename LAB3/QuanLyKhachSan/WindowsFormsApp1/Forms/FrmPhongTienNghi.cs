using System;
using System.Data;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmPhongTienNghi : Form
    {
        readonly PhongTienNghiService s = new PhongTienNghiService();
        readonly DanhMucService dm = new DanhMucService();

        public FrmPhongTienNghi()
        {
            InitializeComponent();
            this.Load += FrmPhongTienNghi_Load;
        }

        private void FrmPhongTienNghi_Load(object sender, EventArgs e)
        {
            try
            {
                if (dgvPhong != null)
                    dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Nạp ComboBox an toàn
                NapComboBox(cboKhu, dm.LayKhuVuc(), "TenKhuVuc", "MaKhuVuc");
                NapComboBox(cboTN, s.LayTienNghi(), "MaTienNghi", "MaTienNghi");
                NapComboBox(cboPhong, s.LayPhong(), "SoPhong", "SoPhong");

                // Mặc định tải danh sách phòng
                TaiDuLieuPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khởi tạo form: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void NapComboBox(ComboBox cbo, DataTable dt, string display, string value)
        {
            if (cbo != null && dt != null && dt.Rows.Count > 0)
            {
                cbo.DataSource = dt;
                cbo.DisplayMember = dt.Columns.Contains(display) ? display : dt.Columns[0].ColumnName;
                cbo.ValueMember = dt.Columns.Contains(value) ? value : dt.Columns[0].ColumnName;
            }
        }

        void TaiDuLieuPhong()
        {
            try
            {
                if (dgvPhong != null)
                    dgvPhong.DataSource = s.LayPhong();
            }
            catch { }
        }

        void H(KetQuaXuLy k)
        {
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (k.ThanhCong) TaiDuLieuPhong();
        }

        // --- SỰ KIỆN CLICK NÚT BẤM ---

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            H(s.ThemPhong(txtPhong.Text.Trim(), V(cboKhu), (int)numMax.Value, numGia.Value));
        }


        // --- SỰ KIỆN CHUYỂN BẢNG DỮ LIỆU KHI CLICK TIÊU ĐỀ ---

        private void lblPhong_Click(object sender, EventArgs e)
        {
            TaiDuLieuPhong();
        }

        private void lblTienNghi_Click(object sender, EventArgs e)
        {
            try { if (dgvPhong != null) dgvPhong.DataSource = s.LayTienNghi(); } catch { }
        }

        private void lblLapDat_Click(object sender, EventArgs e)
        {
            try { if (dgvPhong != null) dgvPhong.DataSource = s.LayLapDat(); } catch { }
        }

        string V(ComboBox c)
        {
            return (c != null && c.SelectedValue != null) ? c.SelectedValue.ToString() : "";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}