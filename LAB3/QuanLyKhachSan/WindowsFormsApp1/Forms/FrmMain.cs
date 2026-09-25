using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.Forms;
namespace WindowsFormsApp1.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain() { InitializeComponent(); }
        private void btnDanhMuc_Click(object s, EventArgs e)
        {
            using (var f = new FrmDanhMuc()) f.ShowDialog(this);
        }
        private void btnPhong_Click(object s, EventArgs e)
        { 
            using (var f = new FrmPhongTienNghi()) f.ShowDialog(this); 
        }
        private void btnDatPhong_Click(object s, EventArgs e)
        {
            using (var f = new FrmDatPhong()) f.ShowDialog(this);
        }

        private void btnThoat_Click(object s, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Xácnhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var f = new FrmDichVu()) f.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var f = new FrmTraPhong()) f.ShowDialog(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (var f = new FrmThongKe()) f.ShowDialog(this);
        }
    }
}
