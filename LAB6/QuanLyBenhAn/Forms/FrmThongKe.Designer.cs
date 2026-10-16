namespace QuanLyBenhAn.Forms
{
    partial class FrmThongKe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTu = new System.Windows.Forms.Label();
            this.dtpTu = new System.Windows.Forms.DateTimePicker();
            this.lblDen = new System.Windows.Forms.Label();
            this.dtpDen = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.lblTitleKhoa = new System.Windows.Forms.Label();
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.lblTitleBS = new System.Windows.Forms.Label();
            this.dgvBS = new System.Windows.Forms.DataGridView();
            this.lblTitleThuoc = new System.Windows.Forms.Label();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.lblTitleDoanhThu = new System.Windows.Forms.Label();
            this.lblLePhi = new System.Windows.Forms.Label();
            this.lblVienPhi = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.SuspendLayout();

            // lblTu
            this.lblTu.Name = "lblTu";
            this.lblTu.Location = new System.Drawing.Point(25, 23);
            this.lblTu.TabIndex = 0;
            this.lblTu.AutoSize = true;
            this.lblTu.Text = "Từ ngày:";

            // dtpTu
            this.dtpTu.Name = "dtpTu";
            this.dtpTu.Location = new System.Drawing.Point(90, 20);
            this.dtpTu.Size = new System.Drawing.Size(110, 22);
            this.dtpTu.TabIndex = 1;
            this.dtpTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // lblDen
            this.lblDen.Name = "lblDen";
            this.lblDen.Location = new System.Drawing.Point(225, 23);
            this.lblDen.TabIndex = 2;
            this.lblDen.AutoSize = true;
            this.lblDen.Text = "Đến ngày:";

            // dtpDen
            this.dtpDen.Name = "dtpDen";
            this.dtpDen.Location = new System.Drawing.Point(295, 20);
            this.dtpDen.Size = new System.Drawing.Size(110, 22);
            this.dtpDen.TabIndex = 3;
            this.dtpDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // btnThongKe
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Location = new System.Drawing.Point(430, 18);
            this.btnThongKe.Size = new System.Drawing.Size(100, 26);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);

            // lblTitleKhoa
            this.lblTitleKhoa.Name = "lblTitleKhoa";
            this.lblTitleKhoa.Location = new System.Drawing.Point(25, 62);
            this.lblTitleKhoa.TabIndex = 5;
            this.lblTitleKhoa.AutoSize = true;
            this.lblTitleKhoa.Text = "Số lượt khám theo khoa:";
            this.lblTitleKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitleKhoa.ForeColor = System.Drawing.Color.Navy;

            // dgvKhoa
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.Location = new System.Drawing.Point(28, 87);
            this.dgvKhoa.Size = new System.Drawing.Size(420, 200);
            this.dgvKhoa.TabIndex = 6;
            this.dgvKhoa.AllowUserToAddRows = false;
            this.dgvKhoa.AllowUserToDeleteRows = false;
            this.dgvKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoa.ReadOnly = true;
            this.dgvKhoa.RowHeadersWidth = 51;
            this.dgvKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // lblTitleBS
            this.lblTitleBS.Name = "lblTitleBS";
            this.lblTitleBS.Location = new System.Drawing.Point(465, 62);
            this.lblTitleBS.TabIndex = 7;
            this.lblTitleBS.AutoSize = true;
            this.lblTitleBS.Text = "Số lượt khám theo bác sĩ:";
            this.lblTitleBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitleBS.ForeColor = System.Drawing.Color.Navy;

            // dgvBS
            this.dgvBS.Name = "dgvBS";
            this.dgvBS.Location = new System.Drawing.Point(468, 87);
            this.dgvBS.Size = new System.Drawing.Size(407, 200);
            this.dgvBS.TabIndex = 8;
            this.dgvBS.AllowUserToAddRows = false;
            this.dgvBS.AllowUserToDeleteRows = false;
            this.dgvBS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBS.ReadOnly = true;
            this.dgvBS.RowHeadersWidth = 51;
            this.dgvBS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // lblTitleThuoc
            this.lblTitleThuoc.Name = "lblTitleThuoc";
            this.lblTitleThuoc.Location = new System.Drawing.Point(25, 302);
            this.lblTitleThuoc.TabIndex = 9;
            this.lblTitleThuoc.AutoSize = true;
            this.lblTitleThuoc.Text = "Thuốc được kê nhiều nhất:";
            this.lblTitleThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitleThuoc.ForeColor = System.Drawing.Color.Navy;

            // dgvThuoc
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.Location = new System.Drawing.Point(28, 327);
            this.dgvThuoc.Size = new System.Drawing.Size(420, 190);
            this.dgvThuoc.TabIndex = 10;
            this.dgvThuoc.AllowUserToAddRows = false;
            this.dgvThuoc.AllowUserToDeleteRows = false;
            this.dgvThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.ReadOnly = true;
            this.dgvThuoc.RowHeadersWidth = 51;
            this.dgvThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // lblTitleDoanhThu
            this.lblTitleDoanhThu.Name = "lblTitleDoanhThu";
            this.lblTitleDoanhThu.Location = new System.Drawing.Point(465, 302);
            this.lblTitleDoanhThu.TabIndex = 11;
            this.lblTitleDoanhThu.AutoSize = true;
            this.lblTitleDoanhThu.Text = "Doanh thu trong kỳ:";
            this.lblTitleDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitleDoanhThu.ForeColor = System.Drawing.Color.Navy;

            // lblLePhi
            this.lblLePhi.Name = "lblLePhi";
            this.lblLePhi.Location = new System.Drawing.Point(465, 335);
            this.lblLePhi.TabIndex = 12;
            this.lblLePhi.AutoSize = true;
            this.lblLePhi.Text = "Tổng lệ phí đăng ký / gia hạn: 0 đ";

            // lblVienPhi
            this.lblVienPhi.Name = "lblVienPhi";
            this.lblVienPhi.Location = new System.Drawing.Point(465, 370);
            this.lblVienPhi.TabIndex = 13;
            this.lblVienPhi.AutoSize = true;
            this.lblVienPhi.Text = "Tổng viện phí: 0 đ";

            // lblTong
            this.lblTong.Name = "lblTong";
            this.lblTong.Location = new System.Drawing.Point(465, 420);
            this.lblTong.TabIndex = 14;
            this.lblTong.AutoSize = true;
            this.lblTong.Text = "TỔNG DOANH THU: 0 đ";
            this.lblTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTong.ForeColor = System.Drawing.Color.Firebrick;

            // FrmThongKe
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.lblTu);
            this.Controls.Add(this.dtpTu);
            this.Controls.Add(this.lblDen);
            this.Controls.Add(this.dtpDen);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.lblTitleKhoa);
            this.Controls.Add(this.dgvKhoa);
            this.Controls.Add(this.lblTitleBS);
            this.Controls.Add(this.dgvBS);
            this.Controls.Add(this.lblTitleThuoc);
            this.Controls.Add(this.dgvThuoc);
            this.Controls.Add(this.lblTitleDoanhThu);
            this.Controls.Add(this.lblLePhi);
            this.Controls.Add(this.lblVienPhi);
            this.Controls.Add(this.lblTong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.DateTimePicker dtpTu;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.DateTimePicker dtpDen;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblTitleKhoa;
        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.Label lblTitleBS;
        private System.Windows.Forms.DataGridView dgvBS;
        private System.Windows.Forms.Label lblTitleThuoc;
        private System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.Label lblTitleDoanhThu;
        private System.Windows.Forms.Label lblLePhi;
        private System.Windows.Forms.Label lblVienPhi;
        private System.Windows.Forms.Label lblTong;
    }
}
