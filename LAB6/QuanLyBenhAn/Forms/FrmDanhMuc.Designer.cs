namespace QuanLyBenhAn.Forms
{
    partial class FrmDanhMuc
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
            this.lblTitleKhoa = new System.Windows.Forms.Label();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.btnThemKhoa = new System.Windows.Forms.Button();
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.lblTitleBS = new System.Windows.Forms.Label();
            this.lblMaBS = new System.Windows.Forms.Label();
            this.txtMaBS = new System.Windows.Forms.TextBox();
            this.lblTenBS = new System.Windows.Forms.Label();
            this.txtTenBS = new System.Windows.Forms.TextBox();
            this.lblKhoaBS = new System.Windows.Forms.Label();
            this.cboKhoaBS = new System.Windows.Forms.ComboBox();
            this.btnThemBS = new System.Windows.Forms.Button();
            this.dgvBacSi = new System.Windows.Forms.DataGridView();
            this.lblTitleThuoc = new System.Windows.Forms.Label();
            this.lblMaThuoc = new System.Windows.Forms.Label();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.lblTenThuoc = new System.Windows.Forms.Label();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.lblDVT = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.lblTitleXN = new System.Windows.Forms.Label();
            this.lblMaXN = new System.Windows.Forms.Label();
            this.txtMaXN = new System.Windows.Forms.TextBox();
            this.lblTenXN = new System.Windows.Forms.Label();
            this.txtTenXN = new System.Windows.Forms.TextBox();
            this.btnThemXN = new System.Windows.Forms.Button();
            this.dgvXetNghiem = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBacSi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXetNghiem)).BeginInit();
            this.SuspendLayout();

            // lblTitleKhoa
            this.lblTitleKhoa.Name = "lblTitleKhoa";
            this.lblTitleKhoa.Location = new System.Drawing.Point(20, 15);
            this.lblTitleKhoa.TabIndex = 0;
            this.lblTitleKhoa.AutoSize = true;
            this.lblTitleKhoa.Text = "KHOA ĐIỀU TRỊ";
            this.lblTitleKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitleKhoa.ForeColor = System.Drawing.Color.Navy;

            // lblMaKhoa
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Location = new System.Drawing.Point(20, 45);
            this.lblMaKhoa.TabIndex = 1;
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Text = "Mã khoa:";

            // txtMaKhoa
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Location = new System.Drawing.Point(90, 42);
            this.txtMaKhoa.Size = new System.Drawing.Size(80, 22);
            this.txtMaKhoa.TabIndex = 2;

            // lblTenKhoa
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Location = new System.Drawing.Point(190, 45);
            this.lblTenKhoa.TabIndex = 3;
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Text = "Tên khoa:";

            // txtTenKhoa
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Location = new System.Drawing.Point(260, 42);
            this.txtTenKhoa.Size = new System.Drawing.Size(210, 22);
            this.txtTenKhoa.TabIndex = 4;

            // btnThemKhoa
            this.btnThemKhoa.Name = "btnThemKhoa";
            this.btnThemKhoa.Location = new System.Drawing.Point(380, 68);
            this.btnThemKhoa.Size = new System.Drawing.Size(90, 28);
            this.btnThemKhoa.TabIndex = 5;
            this.btnThemKhoa.Text = "Thêm";
            this.btnThemKhoa.UseVisualStyleBackColor = true;
            this.btnThemKhoa.Click += new System.EventHandler(this.btnThemKhoa_Click);

            // dgvKhoa
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.Location = new System.Drawing.Point(20, 105);
            this.dgvKhoa.Size = new System.Drawing.Size(450, 180);
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
            this.lblTitleBS.Location = new System.Drawing.Point(510, 15);
            this.lblTitleBS.TabIndex = 7;
            this.lblTitleBS.AutoSize = true;
            this.lblTitleBS.Text = "BÁC SĨ";
            this.lblTitleBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitleBS.ForeColor = System.Drawing.Color.Navy;

            // lblMaBS
            this.lblMaBS.Name = "lblMaBS";
            this.lblMaBS.Location = new System.Drawing.Point(510, 45);
            this.lblMaBS.TabIndex = 8;
            this.lblMaBS.AutoSize = true;
            this.lblMaBS.Text = "Mã BS:";

            // txtMaBS
            this.txtMaBS.Name = "txtMaBS";
            this.txtMaBS.Location = new System.Drawing.Point(580, 42);
            this.txtMaBS.Size = new System.Drawing.Size(80, 22);
            this.txtMaBS.TabIndex = 9;

            // lblTenBS
            this.lblTenBS.Name = "lblTenBS";
            this.lblTenBS.Location = new System.Drawing.Point(680, 45);
            this.lblTenBS.TabIndex = 10;
            this.lblTenBS.AutoSize = true;
            this.lblTenBS.Text = "Họ tên:";

            // txtTenBS
            this.txtTenBS.Name = "txtTenBS";
            this.txtTenBS.Location = new System.Drawing.Point(740, 42);
            this.txtTenBS.Size = new System.Drawing.Size(230, 22);
            this.txtTenBS.TabIndex = 11;

            // lblKhoaBS
            this.lblKhoaBS.Name = "lblKhoaBS";
            this.lblKhoaBS.Location = new System.Drawing.Point(510, 73);
            this.lblKhoaBS.TabIndex = 12;
            this.lblKhoaBS.AutoSize = true;
            this.lblKhoaBS.Text = "Khoa:";

            // cboKhoaBS
            this.cboKhoaBS.Name = "cboKhoaBS";
            this.cboKhoaBS.Location = new System.Drawing.Point(580, 70);
            this.cboKhoaBS.Size = new System.Drawing.Size(200, 24);
            this.cboKhoaBS.TabIndex = 13;
            this.cboKhoaBS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoaBS.FormattingEnabled = true;

            // btnThemBS
            this.btnThemBS.Name = "btnThemBS";
            this.btnThemBS.Location = new System.Drawing.Point(880, 68);
            this.btnThemBS.Size = new System.Drawing.Size(90, 28);
            this.btnThemBS.TabIndex = 14;
            this.btnThemBS.Text = "Thêm";
            this.btnThemBS.UseVisualStyleBackColor = true;
            this.btnThemBS.Click += new System.EventHandler(this.btnThemBS_Click);

            // dgvBacSi
            this.dgvBacSi.Name = "dgvBacSi";
            this.dgvBacSi.Location = new System.Drawing.Point(510, 105);
            this.dgvBacSi.Size = new System.Drawing.Size(460, 180);
            this.dgvBacSi.TabIndex = 15;
            this.dgvBacSi.AllowUserToAddRows = false;
            this.dgvBacSi.AllowUserToDeleteRows = false;
            this.dgvBacSi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBacSi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBacSi.ReadOnly = true;
            this.dgvBacSi.RowHeadersWidth = 51;
            this.dgvBacSi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // lblTitleThuoc
            this.lblTitleThuoc.Name = "lblTitleThuoc";
            this.lblTitleThuoc.Location = new System.Drawing.Point(20, 310);
            this.lblTitleThuoc.TabIndex = 16;
            this.lblTitleThuoc.AutoSize = true;
            this.lblTitleThuoc.Text = "THUỐC";
            this.lblTitleThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitleThuoc.ForeColor = System.Drawing.Color.Navy;

            // lblMaThuoc
            this.lblMaThuoc.Name = "lblMaThuoc";
            this.lblMaThuoc.Location = new System.Drawing.Point(20, 340);
            this.lblMaThuoc.TabIndex = 17;
            this.lblMaThuoc.AutoSize = true;
            this.lblMaThuoc.Text = "Mã thuốc:";

            // txtMaThuoc
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.Location = new System.Drawing.Point(90, 337);
            this.txtMaThuoc.Size = new System.Drawing.Size(80, 22);
            this.txtMaThuoc.TabIndex = 18;

            // lblTenThuoc
            this.lblTenThuoc.Name = "lblTenThuoc";
            this.lblTenThuoc.Location = new System.Drawing.Point(190, 340);
            this.lblTenThuoc.TabIndex = 19;
            this.lblTenThuoc.AutoSize = true;
            this.lblTenThuoc.Text = "Tên thuốc:";

            // txtTenThuoc
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Location = new System.Drawing.Point(260, 337);
            this.txtTenThuoc.Size = new System.Drawing.Size(210, 22);
            this.txtTenThuoc.TabIndex = 20;

            // lblDVT
            this.lblDVT.Name = "lblDVT";
            this.lblDVT.Location = new System.Drawing.Point(20, 368);
            this.lblDVT.TabIndex = 21;
            this.lblDVT.AutoSize = true;
            this.lblDVT.Text = "ĐVT:";

            // txtDVT
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Location = new System.Drawing.Point(90, 365);
            this.txtDVT.Size = new System.Drawing.Size(80, 22);
            this.txtDVT.TabIndex = 22;

            // btnThemThuoc
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Location = new System.Drawing.Point(380, 363);
            this.btnThemThuoc.Size = new System.Drawing.Size(90, 28);
            this.btnThemThuoc.TabIndex = 23;
            this.btnThemThuoc.Text = "Thêm";
            this.btnThemThuoc.UseVisualStyleBackColor = true;
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);

            // dgvThuoc
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.Location = new System.Drawing.Point(20, 400);
            this.dgvThuoc.Size = new System.Drawing.Size(450, 190);
            this.dgvThuoc.TabIndex = 24;
            this.dgvThuoc.AllowUserToAddRows = false;
            this.dgvThuoc.AllowUserToDeleteRows = false;
            this.dgvThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.ReadOnly = true;
            this.dgvThuoc.RowHeadersWidth = 51;
            this.dgvThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // lblTitleXN
            this.lblTitleXN.Name = "lblTitleXN";
            this.lblTitleXN.Location = new System.Drawing.Point(510, 310);
            this.lblTitleXN.TabIndex = 25;
            this.lblTitleXN.AutoSize = true;
            this.lblTitleXN.Text = "XÉT NGHIỆM";
            this.lblTitleXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitleXN.ForeColor = System.Drawing.Color.Navy;

            // lblMaXN
            this.lblMaXN.Name = "lblMaXN";
            this.lblMaXN.Location = new System.Drawing.Point(510, 340);
            this.lblMaXN.TabIndex = 26;
            this.lblMaXN.AutoSize = true;
            this.lblMaXN.Text = "Mã XN:";

            // txtMaXN
            this.txtMaXN.Name = "txtMaXN";
            this.txtMaXN.Location = new System.Drawing.Point(580, 337);
            this.txtMaXN.Size = new System.Drawing.Size(80, 22);
            this.txtMaXN.TabIndex = 27;

            // lblTenXN
            this.lblTenXN.Name = "lblTenXN";
            this.lblTenXN.Location = new System.Drawing.Point(680, 340);
            this.lblTenXN.TabIndex = 28;
            this.lblTenXN.AutoSize = true;
            this.lblTenXN.Text = "Tên XN:";

            // txtTenXN
            this.txtTenXN.Name = "txtTenXN";
            this.txtTenXN.Location = new System.Drawing.Point(740, 337);
            this.txtTenXN.Size = new System.Drawing.Size(230, 22);
            this.txtTenXN.TabIndex = 29;

            // btnThemXN
            this.btnThemXN.Name = "btnThemXN";
            this.btnThemXN.Location = new System.Drawing.Point(880, 363);
            this.btnThemXN.Size = new System.Drawing.Size(90, 28);
            this.btnThemXN.TabIndex = 30;
            this.btnThemXN.Text = "Thêm";
            this.btnThemXN.UseVisualStyleBackColor = true;
            this.btnThemXN.Click += new System.EventHandler(this.btnThemXN_Click);

            // dgvXetNghiem
            this.dgvXetNghiem.Name = "dgvXetNghiem";
            this.dgvXetNghiem.Location = new System.Drawing.Point(510, 400);
            this.dgvXetNghiem.Size = new System.Drawing.Size(460, 190);
            this.dgvXetNghiem.TabIndex = 31;
            this.dgvXetNghiem.AllowUserToAddRows = false;
            this.dgvXetNghiem.AllowUserToDeleteRows = false;
            this.dgvXetNghiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXetNghiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXetNghiem.ReadOnly = true;
            this.dgvXetNghiem.RowHeadersWidth = 51;
            this.dgvXetNghiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // FrmDanhMuc
            this.ClientSize = new System.Drawing.Size(995, 610);
            this.Controls.Add(this.lblTitleKhoa);
            this.Controls.Add(this.lblMaKhoa);
            this.Controls.Add(this.txtMaKhoa);
            this.Controls.Add(this.lblTenKhoa);
            this.Controls.Add(this.txtTenKhoa);
            this.Controls.Add(this.btnThemKhoa);
            this.Controls.Add(this.dgvKhoa);
            this.Controls.Add(this.lblTitleBS);
            this.Controls.Add(this.lblMaBS);
            this.Controls.Add(this.txtMaBS);
            this.Controls.Add(this.lblTenBS);
            this.Controls.Add(this.txtTenBS);
            this.Controls.Add(this.lblKhoaBS);
            this.Controls.Add(this.cboKhoaBS);
            this.Controls.Add(this.btnThemBS);
            this.Controls.Add(this.dgvBacSi);
            this.Controls.Add(this.lblTitleThuoc);
            this.Controls.Add(this.lblMaThuoc);
            this.Controls.Add(this.txtMaThuoc);
            this.Controls.Add(this.lblTenThuoc);
            this.Controls.Add(this.txtTenThuoc);
            this.Controls.Add(this.lblDVT);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.btnThemThuoc);
            this.Controls.Add(this.dgvThuoc);
            this.Controls.Add(this.lblTitleXN);
            this.Controls.Add(this.lblMaXN);
            this.Controls.Add(this.txtMaXN);
            this.Controls.Add(this.lblTenXN);
            this.Controls.Add(this.txtTenXN);
            this.Controls.Add(this.btnThemXN);
            this.Controls.Add(this.dgvXetNghiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục - Khoa, Bác sĩ, Thuốc, Xét nghiệm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBacSi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXetNghiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitleKhoa;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.Button btnThemKhoa;
        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.Label lblTitleBS;
        private System.Windows.Forms.Label lblMaBS;
        private System.Windows.Forms.TextBox txtMaBS;
        private System.Windows.Forms.Label lblTenBS;
        private System.Windows.Forms.TextBox txtTenBS;
        private System.Windows.Forms.Label lblKhoaBS;
        private System.Windows.Forms.ComboBox cboKhoaBS;
        private System.Windows.Forms.Button btnThemBS;
        private System.Windows.Forms.DataGridView dgvBacSi;
        private System.Windows.Forms.Label lblTitleThuoc;
        private System.Windows.Forms.Label lblMaThuoc;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.Label lblTenThuoc;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.Label lblDVT;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Button btnThemThuoc;
        private System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.Label lblTitleXN;
        private System.Windows.Forms.Label lblMaXN;
        private System.Windows.Forms.TextBox txtMaXN;
        private System.Windows.Forms.Label lblTenXN;
        private System.Windows.Forms.TextBox txtTenXN;
        private System.Windows.Forms.Button btnThemXN;
        private System.Windows.Forms.DataGridView dgvXetNghiem;
    }
}
