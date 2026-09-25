using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmDatPhong : Form
    {
        private readonly DatPhongService s = new DatPhongService();
        private readonly DanhMucService dm = new DanhMucService();
        private readonly BindingList<PhongDatItem> chon = new BindingList<PhongDatItem>();

        public FrmDatPhong()
        {
            InitializeComponent();
            this.Load += Frm_Load;
        }

        private Control TimControl(string name)
        {
            var controls = this.Controls.Find(name, true);
            return controls.Length > 0 ? controls[0] : null;
        }

        private string LayText(string name)
        {
            var c = TimControl(name);
            return c != null ? c.Text.Trim() : "";
        }

        private string LayComboValue(string name)
        {
            var c = TimControl(name) as ComboBox;
            return (c != null && c.SelectedValue != null) ? c.SelectedValue.ToString() : "";
        }

        private decimal LayNumericValue(string name)
        {
            var c = TimControl(name) as NumericUpDown;
            return c != null ? c.Value : 0;
        }

        private DateTime LayDateValue(string name)
        {
            var c = TimControl(name) as DateTimePicker;
            return c != null ? c.Value : DateTime.Now;
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            try
            {
                var cboKhach = TimControl("cboKhach") as ComboBox;
                if (cboKhach != null)
                {
                    DataTable dtKhach = s.LayKhach();
                    cboKhach.DataSource = dtKhach;
                    cboKhach.DisplayMember = dtKhach != null && dtKhach.Columns.Contains("HoTen") ? "HoTen" : dtKhach.Columns[0].ColumnName;
                    cboKhach.ValueMember = dtKhach != null && dtKhach.Columns.Contains("MaKhach") ? "MaKhach" : dtKhach.Columns[0].ColumnName;
                }

                var cboNV = TimControl("cboNV") as ComboBox;
                if (cboNV != null)
                {
                    DataTable dtNV = dm.LayNhanVien();
                    cboNV.DataSource = dtNV;
                    cboNV.DisplayMember = dtNV != null && dtNV.Columns.Contains("HoTen") ? "HoTen" : dtNV.Columns[0].ColumnName;
                    cboNV.ValueMember = dtNV != null && dtNV.Columns.Contains("MaNV") ? "MaNV" : dtNV.Columns[0].ColumnName;
                }

                var cboKenh = TimControl("cboKenh") as ComboBox;
                if (cboKenh != null)
                {
                    cboKenh.Items.Clear();
                    cboKenh.Items.AddRange(new object[] { "Điện thoại", "Website", "Trực tiếp" });
                    if (cboKenh.Items.Count > 0) cboKenh.SelectedIndex = 0;
                }

                var dgvChon = TimControl("dgvChon") as DataGridView;
                if (dgvChon != null)
                {
                    dgvChon.DataSource = chon;
                }

                Tai();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tai()
        {
            try
            {
                var dgvKhach = TimControl("dgvKhach") as DataGridView;
                if (dgvKhach != null) dgvKhach.DataSource = s.LayKhach();

                var dgvPhong = TimControl("dgvPhong") as DataGridView;
                if (dgvPhong != null) dgvPhong.DataSource = s.LayPhong();

                var dgvPhieu = TimControl("dgvPhieu") as DataGridView;
                if (dgvPhieu != null) dgvPhieu.DataSource = s.LayPhieuDat();
            }
            catch { }
        }

        private void H(KetQuaXuLy k)
        {
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (k.ThanhCong) Tai();
        }

        private void btnThemKhach_Click(object sender, EventArgs e)
        {
            H(s.ThemKhach(LayText("txtMaKH"), LayText("txtTenKH"), LayText("txtCMND"), LayText("txtQT"), LayText("txtSDT")));
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            var dgvPhong = TimControl("dgvPhong") as DataGridView;
            if (dgvPhong == null || dgvPhong.CurrentRow == null) return;

            string p = Convert.ToString(dgvPhong.CurrentRow.Cells["SoPhong"].Value);
            foreach (var x in chon)
            {
                if (x.SoPhong == p)
                {
                    MessageBox.Show("Phòng đã có trong danh sách chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            int n = (int)LayNumericValue("numSoNguoi");
            if (n <= 0) n = 1;
            decimal g = 0;
            if (dgvPhong.CurrentRow.Cells["DonGiaNgay"] != null && dgvPhong.CurrentRow.Cells["DonGiaNgay"].Value != null)
            {
                decimal.TryParse(dgvPhong.CurrentRow.Cells["DonGiaNgay"].Value.ToString(), out g);
            }

            chon.Add(new PhongDatItem { SoPhong = p, SoNguoi = n, DonGiaNgay = g });
        }

        private void btnBoPhong_Click(object sender, EventArgs e)
        {
            var dgvChon = TimControl("dgvChon") as DataGridView;
            if (dgvChon != null && dgvChon.CurrentRow != null && dgvChon.CurrentRow.Index >= 0 && dgvChon.CurrentRow.Index < chon.Count)
            {
                chon.RemoveAt(dgvChon.CurrentRow.Index);
            }
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            string so = LayText("txtSoPhieu");
            string maKhach = LayComboValue("cboKhach");
            string maNV = LayComboValue("cboNV");
            DateTime lap = LayDateValue("dtLap");
            DateTime nhan = LayDateValue("dtNhan");
            DateTime tra = LayDateValue("dtTra");
            decimal coc = LayNumericValue("numCoc");

            var cboKenh = TimControl("cboKenh") as ComboBox;
            string kenh = cboKenh != null ? cboKenh.Text : "";

            H(s.TaoDatPhong(so, maKhach, maNV, lap, nhan, tra, coc, kenh, new List<PhongDatItem>(chon)));
            if (chon.Count > 0) chon.Clear();
        }

        private void dgvPhieu_SelectionChanged(object sender, EventArgs e)
        {
            var dgvPhieu = TimControl("dgvPhieu") as DataGridView;
            if (dgvPhieu == null || dgvPhieu.CurrentRow == null) return;
            try
            {
                string so = Convert.ToString(dgvPhieu.CurrentRow.Cells["SoPhieuDat"].Value);

                var txtPhieuChon = TimControl("txtPhieuChon");
                if (txtPhieuChon != null) txtPhieuChon.Text = so;

                var dgvCT = TimControl("dgvCT") as DataGridView;
                if (dgvCT != null) dgvCT.DataSource = s.LayChiTiet(so);

                var dgvNguoi = TimControl("dgvNguoi") as DataGridView;
                if (dgvNguoi != null) dgvNguoi.DataSource = s.LayNguoiLuuTru(so);
            }
            catch { }
        }

        private void btnThemNguoi_Click(object sender, EventArgs e)
        {
            H(s.ThemNguoiLuuTru(LayText("txtPhieuChon"), LayText("txtNguoiPhong"), LayText("txtNguoiTen"), LayText("txtNguoiCMND"), LayText("txtNguoiQT")));
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            H(s.NhanPhong(LayText("txtPhieuChon"), DateTime.Now));
        }

        private void btnNoShow_Click(object sender, EventArgs e)
        {
            H(s.DanhDauNoShow(LayText("txtPhieuChon")));
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}