using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            Forms.FrmDanhMuc frm = new Forms.FrmDanhMuc();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.FrmSach frm = new Forms.FrmSach();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms.FormDocGia frm = new Forms.FormDocGia();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Forms.FormThongKe frm = new Forms.FormThongKe();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Forms.FormMuonTra frm = new Forms.FormMuonTra();
            frm.Show();
        }
    }
}
