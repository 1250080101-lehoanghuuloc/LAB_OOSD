namespace QuanLyBenhAn.Forms
{
    partial class FrmTraCuu
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
            this.lblNav = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblDT = new System.Windows.Forms.Label();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.dgvBenhNhan = new System.Windows.Forms.DataGridView();
            this.lblTitleLS = new System.Windows.Forms.Label();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.lblAnh = new System.Windows.Forms.Label();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.lblTitleToa = new System.Windows.Forms.Label();
            this.dgvToa = new System.Windows.Forms.DataGridView();
            this.lblTitleXN = new System.Windows.Forms.Label();
            this.dgvXN = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXN)).BeginInit();
            this.SuspendLayout();

            // lblNav
            this.lblNav.Name = "lblNav";
            this.lblNav.Location = new System.Drawing.Point(25, 15);
            this.lblNav.TabIndex = 0;
            this.lblNav.AutoSize = true;
            this.lblNav.Text = "[Tra cứu]  [Hồ sơ bệnh án]  [Diễn biến điều trị]";
            this.lblNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNav.ForeColor = System.Drawing.Color.Navy;

            // lblMa
            this.lblMa.Name = "lblMa";
            this.lblMa.Location = new System.Drawing.Point(25, 53);
            this.lblMa.TabIndex = 1;
            this.lblMa.AutoSize = true;
            this.lblMa.Text = "Mã hồ sơ:";

            // txtMa
            this.txtMa.Name = "txtMa";
            this.txtMa.Location = new System.Drawing.Point(105, 50);
            this.txtMa.Size = new System.Drawing.Size(90, 22);
            this.txtMa.TabIndex = 2;

            // lblTen
            this.lblTen.Name = "lblTen";
            this.lblTen.Location = new System.Drawing.Point(215, 53);
            this.lblTen.TabIndex = 3;
            this.lblTen.AutoSize = true;
            this.lblTen.Text = "Họ tên:";

            // txtTen
            this.txtTen.Name = "txtTen";
            this.txtTen.Location = new System.Drawing.Point(270, 50);
            this.txtTen.Size = new System.Drawing.Size(150, 22);
            this.txtTen.TabIndex = 4;

            // lblDT
            this.lblDT.Name = "lblDT";
            this.lblDT.Location = new System.Drawing.Point(440, 53);
            this.lblDT.TabIndex = 5;
            this.lblDT.AutoSize = true;
            this.lblDT.Text = "Điện thoại:";

            // txtDT
            this.txtDT.Name = "txtDT";
            this.txtDT.Location = new System.Drawing.Point(520, 50);
            this.txtDT.Size = new System.Drawing.Size(110, 22);
            this.txtDT.TabIndex = 6;

            // btnTim
            this.btnTim.Name = "btnTim";
            this.btnTim.Location = new System.Drawing.Point(650, 48);
            this.btnTim.Size = new System.Drawing.Size(90, 26);
            this.btnTim.TabIndex = 7;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);

            // btnTatCa
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Location = new System.Drawing.Point(750, 48);
            this.btnTatCa.Size = new System.Drawing.Size(100, 26);
            this.btnTatCa.TabIndex = 8;
            this.btnTatCa.Text = "Hiện tất cả";
            this.btnTatCa.UseVisualStyleBackColor = true;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);

            // dgvBenhNhan
            this.dgvBenhNhan.Name = "dgvBenhNhan";
            this.dgvBenhNhan.Location = new System.Drawing.Point(28, 85);
            this.dgvBenhNhan.Size = new System.Drawing.Size(947, 125);
            this.dgvBenhNhan.TabIndex = 9;
            this.dgvBenhNhan.AllowUserToAddRows = false;
            this.dgvBenhNhan.AllowUserToDeleteRows = false;
            this.dgvBenhNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenhNhan.ReadOnly = true;
            this.dgvBenhNhan.RowHeadersWidth = 51;
            this.dgvBenhNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBenhNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBenhNhan_CellClick);

            // lblTitleLS
            this.lblTitleLS.Name = "lblTitleLS";
            this.lblTitleLS.Location = new System.Drawing.Point(25, 225);
            this.lblTitleLS.TabIndex = 10;
            this.lblTitleLS.AutoSize = true;
            this.lblTitleLS.Text = "Lịch sử khám bệnh (nhấp vào dòng để xem toa thuốc, xét nghiệm):";

            // dgvLichSu
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.Location = new System.Drawing.Point(28, 250);
            this.dgvLichSu.Size = new System.Drawing.Size(830, 175);
            this.dgvLichSu.TabIndex = 11;
            this.dgvLichSu.AllowUserToAddRows = false;
            this.dgvLichSu.AllowUserToDeleteRows = false;
            this.dgvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSu.ReadOnly = true;
            this.dgvLichSu.RowHeadersWidth = 51;
            this.dgvLichSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichSu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichSu_CellClick);

            // lblAnh
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Location = new System.Drawing.Point(865, 228);
            this.lblAnh.TabIndex = 12;
            this.lblAnh.AutoSize = true;
            this.lblAnh.Text = "Ảnh 3x4";

            // picAnh
            this.picAnh.Name = "picAnh";
            this.picAnh.Location = new System.Drawing.Point(865, 250);
            this.picAnh.Size = new System.Drawing.Size(110, 147);
            this.picAnh.TabIndex = 13;
            this.picAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // lblTitleToa
            this.lblTitleToa.Name = "lblTitleToa";
            this.lblTitleToa.Location = new System.Drawing.Point(25, 440);
            this.lblTitleToa.TabIndex = 14;
            this.lblTitleToa.AutoSize = true;
            this.lblTitleToa.Text = "Toa thuốc của lần khám đã chọn:";

            // dgvToa
            this.dgvToa.Name = "dgvToa";
            this.dgvToa.Location = new System.Drawing.Point(28, 465);
            this.dgvToa.Size = new System.Drawing.Size(460, 150);
            this.dgvToa.TabIndex = 15;
            this.dgvToa.AllowUserToAddRows = false;
            this.dgvToa.AllowUserToDeleteRows = false;
            this.dgvToa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvToa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToa.ReadOnly = true;
            this.dgvToa.RowHeadersWidth = 51;
            this.dgvToa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // lblTitleXN
            this.lblTitleXN.Name = "lblTitleXN";
            this.lblTitleXN.Location = new System.Drawing.Point(505, 440);
            this.lblTitleXN.TabIndex = 16;
            this.lblTitleXN.AutoSize = true;
            this.lblTitleXN.Text = "Xét nghiệm của lần khám đã chọn:";

            // dgvXN
            this.dgvXN.Name = "dgvXN";
            this.dgvXN.Location = new System.Drawing.Point(508, 465);
            this.dgvXN.Size = new System.Drawing.Size(467, 150);
            this.dgvXN.TabIndex = 17;
            this.dgvXN.AllowUserToAddRows = false;
            this.dgvXN.AllowUserToDeleteRows = false;
            this.dgvXN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXN.ReadOnly = true;
            this.dgvXN.RowHeadersWidth = 51;
            this.dgvXN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // FrmTraCuu
            this.ClientSize = new System.Drawing.Size(1000, 635);
            this.Controls.Add(this.lblNav);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblDT);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnTatCa);
            this.Controls.Add(this.dgvBenhNhan);
            this.Controls.Add(this.lblTitleLS);
            this.Controls.Add(this.dgvLichSu);
            this.Controls.Add(this.lblAnh);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.lblTitleToa);
            this.Controls.Add(this.dgvToa);
            this.Controls.Add(this.lblTitleXN);
            this.Controls.Add(this.dgvXN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTraCuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu hồ sơ bệnh án";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNav;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.DataGridView dgvBenhNhan;
        private System.Windows.Forms.Label lblTitleLS;
        private System.Windows.Forms.DataGridView dgvLichSu;
        private System.Windows.Forms.Label lblAnh;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Label lblTitleToa;
        private System.Windows.Forms.DataGridView dgvToa;
        private System.Windows.Forms.Label lblTitleXN;
        private System.Windows.Forms.DataGridView dgvXN;
    }
}
