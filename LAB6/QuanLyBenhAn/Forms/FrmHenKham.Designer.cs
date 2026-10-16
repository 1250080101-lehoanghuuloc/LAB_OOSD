namespace QuanLyBenhAn.Forms
{
    partial class FrmHenKham
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
            this.lblMaHoSo = new System.Windows.Forms.Label();
            this.txtMaHoSo = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.lblNgayGio = new System.Windows.Forms.Label();
            this.dtpNgayGio = new System.Windows.Forms.DateTimePicker();
            this.lblQuy = new System.Windows.Forms.Label();
            this.txtQuy = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnDatHen = new System.Windows.Forms.Button();
            this.btnHuyHen = new System.Windows.Forms.Button();
            this.lblQuyenLoi = new System.Windows.Forms.Label();
            this.lblTitleHen = new System.Windows.Forms.Label();
            this.dgvHen = new System.Windows.Forms.DataGridView();
            this.lblTitleAll = new System.Windows.Forms.Label();
            this.dgvHenAll = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvHen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHenAll)).BeginInit();
            this.SuspendLayout();

            // lblNav
            this.lblNav.Name = "lblNav";
            this.lblNav.Location = new System.Drawing.Point(25, 15);
            this.lblNav.TabIndex = 0;
            this.lblNav.AutoSize = true;
            this.lblNav.Text = "[Bệnh nhân]  [Khám sức khỏe định kỳ]  [Lịch hẹn]";
            this.lblNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNav.ForeColor = System.Drawing.Color.Navy;

            // lblMaHoSo
            this.lblMaHoSo.Name = "lblMaHoSo";
            this.lblMaHoSo.Location = new System.Drawing.Point(25, 53);
            this.lblMaHoSo.TabIndex = 1;
            this.lblMaHoSo.AutoSize = true;
            this.lblMaHoSo.Text = "Mã hồ sơ:";

            // txtMaHoSo
            this.txtMaHoSo.Name = "txtMaHoSo";
            this.txtMaHoSo.Location = new System.Drawing.Point(105, 50);
            this.txtMaHoSo.Size = new System.Drawing.Size(100, 22);
            this.txtMaHoSo.TabIndex = 2;

            // btnTim
            this.btnTim.Name = "btnTim";
            this.btnTim.Location = new System.Drawing.Point(215, 48);
            this.btnTim.Size = new System.Drawing.Size(90, 26);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm hồ sơ";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);

            // lblThongTin
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Location = new System.Drawing.Point(320, 54);
            this.lblThongTin.TabIndex = 4;
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Text = "Chưa chọn hồ sơ bệnh nhân";
            this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblThongTin.ForeColor = System.Drawing.Color.Gray;

            // lblNgayGio
            this.lblNgayGio.Name = "lblNgayGio";
            this.lblNgayGio.Location = new System.Drawing.Point(25, 94);
            this.lblNgayGio.TabIndex = 5;
            this.lblNgayGio.AutoSize = true;
            this.lblNgayGio.Text = "Ngày giờ hẹn:";

            // dtpNgayGio
            this.dtpNgayGio.Name = "dtpNgayGio";
            this.dtpNgayGio.Location = new System.Drawing.Point(125, 91);
            this.dtpNgayGio.Size = new System.Drawing.Size(170, 22);
            this.dtpNgayGio.TabIndex = 6;
            this.dtpNgayGio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayGio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpNgayGio.ValueChanged += new System.EventHandler(this.dtpNgayGio_ValueChanged);

            // lblQuy
            this.lblQuy.Name = "lblQuy";
            this.lblQuy.Location = new System.Drawing.Point(320, 94);
            this.lblQuy.TabIndex = 7;
            this.lblQuy.AutoSize = true;
            this.lblQuy.Text = "Quý:";

            // txtQuy
            this.txtQuy.Name = "txtQuy";
            this.txtQuy.Location = new System.Drawing.Point(355, 91);
            this.txtQuy.Size = new System.Drawing.Size(90, 22);
            this.txtQuy.TabIndex = 8;
            this.txtQuy.ReadOnly = true;

            // lblGhiChu
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Location = new System.Drawing.Point(470, 94);
            this.lblGhiChu.TabIndex = 9;
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Text = "Ghi chú:";

            // txtGhiChu
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Location = new System.Drawing.Point(525, 91);
            this.txtGhiChu.Size = new System.Drawing.Size(350, 22);
            this.txtGhiChu.TabIndex = 10;

            // btnDatHen
            this.btnDatHen.Name = "btnDatHen";
            this.btnDatHen.Location = new System.Drawing.Point(25, 130);
            this.btnDatHen.Size = new System.Drawing.Size(140, 32);
            this.btnDatHen.TabIndex = 11;
            this.btnDatHen.Text = "Đặt lịch hẹn";
            this.btnDatHen.UseVisualStyleBackColor = true;
            this.btnDatHen.Click += new System.EventHandler(this.btnDatHen_Click);

            // btnHuyHen
            this.btnHuyHen.Name = "btnHuyHen";
            this.btnHuyHen.Location = new System.Drawing.Point(175, 130);
            this.btnHuyHen.Size = new System.Drawing.Size(150, 32);
            this.btnHuyHen.TabIndex = 12;
            this.btnHuyHen.Text = "Hủy hẹn đã chọn";
            this.btnHuyHen.UseVisualStyleBackColor = true;
            this.btnHuyHen.Click += new System.EventHandler(this.btnHuyHen_Click);

            // lblQuyenLoi
            this.lblQuyenLoi.Name = "lblQuyenLoi";
            this.lblQuyenLoi.Location = new System.Drawing.Point(345, 139);
            this.lblQuyenLoi.TabIndex = 13;
            this.lblQuyenLoi.AutoSize = true;
            this.lblQuyenLoi.Text = "Quyền lợi: 01 lần khám sức khỏe định kỳ MIỄN PHÍ mỗi quý (hồ sơ còn hạn).";
            this.lblQuyenLoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.lblQuyenLoi.ForeColor = System.Drawing.Color.DarkGreen;

            // lblTitleHen
            this.lblTitleHen.Name = "lblTitleHen";
            this.lblTitleHen.Location = new System.Drawing.Point(25, 180);
            this.lblTitleHen.TabIndex = 14;
            this.lblTitleHen.AutoSize = true;
            this.lblTitleHen.Text = "Lịch hẹn khám định kỳ của bệnh nhân:";

            // dgvHen
            this.dgvHen.Name = "dgvHen";
            this.dgvHen.Location = new System.Drawing.Point(28, 205);
            this.dgvHen.Size = new System.Drawing.Size(847, 190);
            this.dgvHen.TabIndex = 15;
            this.dgvHen.AllowUserToAddRows = false;
            this.dgvHen.AllowUserToDeleteRows = false;
            this.dgvHen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHen.ReadOnly = true;
            this.dgvHen.RowHeadersWidth = 51;
            this.dgvHen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // lblTitleAll
            this.lblTitleAll.Name = "lblTitleAll";
            this.lblTitleAll.Location = new System.Drawing.Point(25, 410);
            this.lblTitleAll.TabIndex = 16;
            this.lblTitleAll.AutoSize = true;
            this.lblTitleAll.Text = "Các lịch hẹn sắp tới của tất cả bệnh nhân:";

            // dgvHenAll
            this.dgvHenAll.Name = "dgvHenAll";
            this.dgvHenAll.Location = new System.Drawing.Point(28, 435);
            this.dgvHenAll.Size = new System.Drawing.Size(847, 115);
            this.dgvHenAll.TabIndex = 17;
            this.dgvHenAll.AllowUserToAddRows = false;
            this.dgvHenAll.AllowUserToDeleteRows = false;
            this.dgvHenAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHenAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHenAll.ReadOnly = true;
            this.dgvHenAll.RowHeadersWidth = 51;
            this.dgvHenAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // FrmHenKham
            this.ClientSize = new System.Drawing.Size(900, 565);
            this.Controls.Add(this.lblNav);
            this.Controls.Add(this.lblMaHoSo);
            this.Controls.Add(this.txtMaHoSo);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.lblNgayGio);
            this.Controls.Add(this.dtpNgayGio);
            this.Controls.Add(this.lblQuy);
            this.Controls.Add(this.txtQuy);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.btnDatHen);
            this.Controls.Add(this.btnHuyHen);
            this.Controls.Add(this.lblQuyenLoi);
            this.Controls.Add(this.lblTitleHen);
            this.Controls.Add(this.dgvHen);
            this.Controls.Add(this.lblTitleAll);
            this.Controls.Add(this.dgvHenAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHenKham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hẹn khám sức khỏe định kỳ theo quý";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHenAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNav;
        private System.Windows.Forms.Label lblMaHoSo;
        private System.Windows.Forms.TextBox txtMaHoSo;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Label lblNgayGio;
        private System.Windows.Forms.DateTimePicker dtpNgayGio;
        private System.Windows.Forms.Label lblQuy;
        private System.Windows.Forms.TextBox txtQuy;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnDatHen;
        private System.Windows.Forms.Button btnHuyHen;
        private System.Windows.Forms.Label lblQuyenLoi;
        private System.Windows.Forms.Label lblTitleHen;
        private System.Windows.Forms.DataGridView dgvHen;
        private System.Windows.Forms.Label lblTitleAll;
        private System.Windows.Forms.DataGridView dgvHenAll;
    }
}
