using QuanLyKhachSan.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmTraPhong : Form
    {
        readonly TraPhongService s = new TraPhongService();
        readonly DanhMucService dm = new DanhMucService();
        BindingList<DenBuItem> db = new BindingList<DenBuItem>();

        public FrmTraPhong()
        {
            InitializeComponent();
        }

        private void Frm_Load(object a, EventArgs e)
        {
            cboDat.SelectedIndexChanged -= cboDat_SelectedIndexChanged;

            cboDat.DataSource = s.LayPhieuDangO();
            cboDat.DisplayMember = "SoPhieuDat";
            cboDat.ValueMember = "SoPhieuDat";

            cboHT.Items.Clear();
            cboHT.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản", "Thẻ", "Ví điện tử" });
            cboHT.SelectedIndex = 0;

            dgvDBChon.DataSource = db;

            cboDat.SelectedIndexChanged += cboDat_SelectedIndexChanged;

            Tai();
        }

        string V(ComboBox c)
        {
            if (c.SelectedValue == null) return "";
            if (c.SelectedValue is DataRowView drv)
            {
                string vm = c.ValueMember;
                if (!string.IsNullOrEmpty(vm) && drv.Row.Table.Columns.Contains(vm))
                    return drv[vm]?.ToString() ?? "";
                return drv[0]?.ToString() ?? "";
            }
            return c.SelectedValue.ToString();
        }

        void Tai()
        {
            string so = V(cboDat);
            if (!string.IsNullOrEmpty(so))
            {
                dgvPhong.DataSource = s.LayPhongTheoPhieu(so);
            }
            else
            {
                dgvPhong.DataSource = null;
            }

            dgvHD.DataSource = s.LayHoaDon();
        }

        private void cboDat_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tai();
        }

        private void dgvPhong_SelectionChanged(object a, EventArgs e)
        {
            if (dgvPhong.CurrentRow == null) return;
            string phong = Convert.ToString(dgvPhong.CurrentRow.Cells["SoPhong"].Value);
            dgvTN.DataSource = s.LayTienNghiPhong(phong);
        }

        private void btnThemDB_Click(object a, EventArgs e)
        {
            if (dgvTN.CurrentRow == null) return;
            string ma = Convert.ToString(dgvTN.CurrentRow.Cells["MaTienNghi"].Value);
            string ten = Convert.ToString(dgvTN.CurrentRow.Cells["TenLoaiTN"].Value);

            foreach (var x in db)
            {
                if (x.MaTienNghi == ma)
                {
                    MessageBox.Show("Tiện nghi đã có trong phiếu đền bù.");
                    return;
                }
            }

            db.Add(new DenBuItem
            {
                MaTienNghi = ma,
                TenLoaiTN = ten,
                MucDoThietHai = txtMucDo.Text.Trim(),
                SoTien = numDenBu.Value
            });
        }

        private void btnLapDB_Click(object a, EventArgs e)
        {
            string phong = "";
            if (dgvPhong.CurrentRow != null)
                phong = Convert.ToString(dgvPhong.CurrentRow.Cells["SoPhong"].Value);

            //var k = s.LapPhieuDenBu(txtSoDB.Text.Trim(), V(cboDat), phong, DateTime.Now, "NV01", new List<DenBuItem>(db));
            //MessageBox.Show(k.ThongBao);
            //if (k.ThanhCong) db.Clear();
        }

        private void btnLapHD_Click(object a, EventArgs e)
        {
            var k = s.LapHoaDon(txtSoHD.Text.Trim(), V(cboDat), DateTime.Now, "NV01", (int)numSoNgay.Value);
            MessageBox.Show(k.ThongBao);
            Tai();
        }

        private void dgvHD_SelectionChanged(object a, EventArgs e)
        {
            if (dgvHD.CurrentRow != null)
            {
                txtSoHD.Text = Convert.ToString(dgvHD.CurrentRow.Cells["SoHoaDon"].Value);
            }
        }

        private void btnThanhToan_Click(object a, EventArgs e)
        {
            string maTT = "TT" + DateTime.Now.ToString("yyyyMMddHHmmss");
            var k = s.ThanhToan(maTT, txtSoHD.Text.Trim(), DateTime.Now, cboHT.Text, numTienTT.Value);
            MessageBox.Show(k.ThongBao);
            Tai();
        }

        private void btnTraPhong_Click(object a, EventArgs e)
        {
            var k = s.TraPhong(V(cboDat), DateTime.Now);
            MessageBox.Show(k.ThongBao);
            Tai();
        }

        private void btnDong_Click(object a, EventArgs e)
        {
            Close();
        }
    }
}