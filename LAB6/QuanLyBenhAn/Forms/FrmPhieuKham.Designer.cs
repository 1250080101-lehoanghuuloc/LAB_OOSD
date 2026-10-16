namespace QuanLyBenhAn.Forms
{
    partial class FrmPhieuKham
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
            this.lblLoai = new System.Windows.Forms.Label();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.lblBS = new System.Windows.Forms.Label();
            this.cboBS = new System.Windows.Forms.ComboBox();
            this.lblTrieuChung = new System.Windows.Forms.Label();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.lblNhiet = new System.Windows.Forms.Label();
            this.txtNhiet = new System.Windows.Forms.TextBox();
            this.lblHuyetAp = new System.Windows.Forms.Label();
            this.txtHuyetAp = new System.Windows.Forms.TextBox();
            this.lblChanDoan = new System.Windows.Forms.Label();
            this.txtChanDoan = new System.Windows.Forms.TextBox();
            this.lblPhanUng = new System.Windows.Forms.Label();
            this.txtPhanUng = new System.Windows.Forms.TextBox();
            this.lblTitleToa = new System.Windows.Forms.Label();
            this.lblThuoc = new System.Windows.Forms.Label();
            this.cboThuoc = new System.Windows.Forms.ComboBox();
            this.lblSL = new System.Windows.Forms.Label();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.lblCachDung = new System.Windows.Forms.Label();
            this.txtCachDung = new System.Windows.Forms.TextBox();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.dgvToa = new System.Windows.Forms.DataGridView();
            this.lblTitleXN = new System.Windows.Forms.Label();
            this.cboXN = new System.Windows.Forms.ComboBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.txtKetQuaXN = new System.Windows.Forms.TextBox();
            this.btnThemXN = new System.Windows.Forms.Button();
            this.dgvXN = new System.Windows.Forms.DataGridView();
            this.lblVienPhi = new System.Windows.Forms.Label();
            this.txtVienPhi = new System.Windows.Forms.TextBox();
            this.lblXuatVien = new System.Windows.Forms.Label();
            this.dtpXuatVien = new System.Windows.Forms.DateTimePicker();
            this.lblGhiChuLoai = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblTitleLS = new System.Windows.Forms.Label();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.SuspendLayout();

            // lblNav
            this.lblNav.Name = "lblNav";
            this.lblNav.Location = new System.Drawing.Point(25, 15);
            this.lblNav.TabIndex = 0;
            this.lblNav.AutoSize = true;
            this.lblNav.Text = "[Bệnh nhân]  [Phiếu khám bệnh]  [Toa thuốc - Xét nghiệm]";
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
            this.lblNgayGio.Text = "Ngày giờ khám:";

            // dtpNgayGio
            this.dtpNgayGio.Name = "dtpNgayGio";
            this.dtpNgayGio.Location = new System.Drawing.Point(130, 91);
            this.dtpNgayGio.Size = new System.Drawing.Size(170, 22);
            this.dtpNgayGio.TabIndex = 6;
            this.dtpNgayGio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayGio.CustomFormat = "dd/MM/yyyy HH:mm";

            // lblLoai
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Location = new System.Drawing.Point(320, 94);
            this.lblLoai.TabIndex = 7;
            this.lblLoai.AutoSize = true;
            this.lblLoai.Text = "Loại khám:";

            // cboLoai
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Location = new System.Drawing.Point(395, 91);
            this.cboLoai.Size = new System.Drawing.Size(130, 24);
            this.cboLoai.TabIndex = 8;
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.SelectedIndexChanged += new System.EventHandler(this.cboLoai_SelectedIndexChanged);

            // lblKhoa
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Location = new System.Drawing.Point(545, 94);
            this.lblKhoa.TabIndex = 9;
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Text = "Khoa:";

            // cboKhoa
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Location = new System.Drawing.Point(590, 91);
            this.cboKhoa.Size = new System.Drawing.Size(150, 24);
            this.cboKhoa.TabIndex = 10;
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.SelectedIndexChanged += new System.EventHandler(this.cboKhoa_SelectedIndexChanged);

            // lblBS
            this.lblBS.Name = "lblBS";
            this.lblBS.Location = new System.Drawing.Point(760, 94);
            this.lblBS.TabIndex = 11;
            this.lblBS.AutoSize = true;
            this.lblBS.Text = "Bác sĩ:";

            // cboBS
            this.cboBS.Name = "cboBS";
            this.cboBS.Location = new System.Drawing.Point(815, 91);
            this.cboBS.Size = new System.Drawing.Size(160, 24);
            this.cboBS.TabIndex = 12;
            this.cboBS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBS.FormattingEnabled = true;

            // lblTrieuChung
            this.lblTrieuChung.Name = "lblTrieuChung";
            this.lblTrieuChung.Location = new System.Drawing.Point(25, 130);
            this.lblTrieuChung.TabIndex = 13;
            this.lblTrieuChung.AutoSize = true;
            this.lblTrieuChung.Text = "Triệu chứng:";

            // txtTrieuChung
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Location = new System.Drawing.Point(130, 127);
            this.txtTrieuChung.Size = new System.Drawing.Size(845, 50);
            this.txtTrieuChung.TabIndex = 14;
            this.txtTrieuChung.Multiline = true;
            this.txtTrieuChung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            // lblNhiet
            this.lblNhiet.Name = "lblNhiet";
            this.lblNhiet.Location = new System.Drawing.Point(25, 191);
            this.lblNhiet.TabIndex = 15;
            this.lblNhiet.AutoSize = true;
            this.lblNhiet.Text = "Thân nhiệt (°C):";

            // txtNhiet
            this.txtNhiet.Name = "txtNhiet";
            this.txtNhiet.Location = new System.Drawing.Point(130, 188);
            this.txtNhiet.Size = new System.Drawing.Size(60, 22);
            this.txtNhiet.TabIndex = 16;

            // lblHuyetAp
            this.lblHuyetAp.Name = "lblHuyetAp";
            this.lblHuyetAp.Location = new System.Drawing.Point(215, 191);
            this.lblHuyetAp.TabIndex = 17;
            this.lblHuyetAp.AutoSize = true;
            this.lblHuyetAp.Text = "Huyết áp:";

            // txtHuyetAp
            this.txtHuyetAp.Name = "txtHuyetAp";
            this.txtHuyetAp.Location = new System.Drawing.Point(285, 188);
            this.txtHuyetAp.Size = new System.Drawing.Size(80, 22);
            this.txtHuyetAp.TabIndex = 18;

            // lblChanDoan
            this.lblChanDoan.Name = "lblChanDoan";
            this.lblChanDoan.Location = new System.Drawing.Point(390, 191);
            this.lblChanDoan.TabIndex = 19;
            this.lblChanDoan.AutoSize = true;
            this.lblChanDoan.Text = "Chẩn đoán:";

            // txtChanDoan
            this.txtChanDoan.Name = "txtChanDoan";
            this.txtChanDoan.Location = new System.Drawing.Point(465, 188);
            this.txtChanDoan.Size = new System.Drawing.Size(510, 22);
            this.txtChanDoan.TabIndex = 20;

            // lblPhanUng
            this.lblPhanUng.Name = "lblPhanUng";
            this.lblPhanUng.Location = new System.Drawing.Point(25, 225);
            this.lblPhanUng.TabIndex = 21;
            this.lblPhanUng.AutoSize = true;
            this.lblPhanUng.Text = "Phản ứng phụ:";

            // txtPhanUng
            this.txtPhanUng.Name = "txtPhanUng";
            this.txtPhanUng.Location = new System.Drawing.Point(130, 222);
            this.txtPhanUng.Size = new System.Drawing.Size(845, 22);
            this.txtPhanUng.TabIndex = 22;

            // lblTitleToa
            this.lblTitleToa.Name = "lblTitleToa";
            this.lblTitleToa.Location = new System.Drawing.Point(25, 262);
            this.lblTitleToa.TabIndex = 23;
            this.lblTitleToa.AutoSize = true;
            this.lblTitleToa.Text = "TOA THUỐC (nhấp đúp vào dòng để xóa):";
            this.lblTitleToa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitleToa.ForeColor = System.Drawing.Color.Navy;

            // lblThuoc
            this.lblThuoc.Name = "lblThuoc";
            this.lblThuoc.Location = new System.Drawing.Point(25, 291);
            this.lblThuoc.TabIndex = 24;
            this.lblThuoc.AutoSize = true;
            this.lblThuoc.Text = "Thuốc:";

            // cboThuoc
            this.cboThuoc.Name = "cboThuoc";
            this.cboThuoc.Location = new System.Drawing.Point(80, 288);
            this.cboThuoc.Size = new System.Drawing.Size(200, 24);
            this.cboThuoc.TabIndex = 25;
            this.cboThuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThuoc.FormattingEnabled = true;

            // lblSL
            this.lblSL.Name = "lblSL";
            this.lblSL.Location = new System.Drawing.Point(295, 291);
            this.lblSL.TabIndex = 26;
            this.lblSL.AutoSize = true;
            this.lblSL.Text = "SL:";

            // numSL
            this.numSL.Name = "numSL";
            this.numSL.Location = new System.Drawing.Point(325, 288);
            this.numSL.Size = new System.Drawing.Size(55, 22);
            this.numSL.TabIndex = 27;
            this.numSL.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSL.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            this.numSL.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // lblCachDung
            this.lblCachDung.Name = "lblCachDung";
            this.lblCachDung.Location = new System.Drawing.Point(395, 291);
            this.lblCachDung.TabIndex = 28;
            this.lblCachDung.AutoSize = true;
            this.lblCachDung.Text = "Cách dùng:";

            // txtCachDung
            this.txtCachDung.Name = "txtCachDung";
            this.txtCachDung.Location = new System.Drawing.Point(470, 288);
            this.txtCachDung.Size = new System.Drawing.Size(210, 22);
            this.txtCachDung.TabIndex = 29;

            // btnThemThuoc
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Location = new System.Drawing.Point(690, 286);
            this.btnThemThuoc.Size = new System.Drawing.Size(60, 26);
            this.btnThemThuoc.TabIndex = 30;
            this.btnThemThuoc.Text = "Thêm";
            this.btnThemThuoc.UseVisualStyleBackColor = true;
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);

            // dgvToa
            this.dgvToa.Name = "dgvToa";
            this.dgvToa.Location = new System.Drawing.Point(25, 320);
            this.dgvToa.Size = new System.Drawing.Size(725, 125);
            this.dgvToa.TabIndex = 31;
            this.dgvToa.AllowUserToAddRows = false;
            this.dgvToa.AllowUserToDeleteRows = false;
            this.dgvToa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvToa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToa.ReadOnly = true;
            this.dgvToa.RowHeadersWidth = 51;
            this.dgvToa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvToa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvToa_CellDoubleClick);

            // lblTitleXN
            this.lblTitleXN.Name = "lblTitleXN";
            this.lblTitleXN.Location = new System.Drawing.Point(770, 262);
            this.lblTitleXN.TabIndex = 32;
            this.lblTitleXN.AutoSize = true;
            this.lblTitleXN.Text = "XÉT NGHIỆM (nhấp đúp để xóa):";
            this.lblTitleXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitleXN.ForeColor = System.Drawing.Color.Navy;

            // cboXN
            this.cboXN.Name = "cboXN";
            this.cboXN.Location = new System.Drawing.Point(770, 288);
            this.cboXN.Size = new System.Drawing.Size(205, 24);
            this.cboXN.TabIndex = 33;
            this.cboXN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboXN.FormattingEnabled = true;

            // lblKQ
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Location = new System.Drawing.Point(770, 322);
            this.lblKQ.TabIndex = 34;
            this.lblKQ.AutoSize = true;
            this.lblKQ.Text = "Kết quả:";

            // txtKetQuaXN
            this.txtKetQuaXN.Name = "txtKetQuaXN";
            this.txtKetQuaXN.Location = new System.Drawing.Point(825, 319);
            this.txtKetQuaXN.Size = new System.Drawing.Size(90, 22);
            this.txtKetQuaXN.TabIndex = 35;

            // btnThemXN
            this.btnThemXN.Name = "btnThemXN";
            this.btnThemXN.Location = new System.Drawing.Point(920, 317);
            this.btnThemXN.Size = new System.Drawing.Size(55, 26);
            this.btnThemXN.TabIndex = 36;
            this.btnThemXN.Text = "Thêm";
            this.btnThemXN.UseVisualStyleBackColor = true;
            this.btnThemXN.Click += new System.EventHandler(this.btnThemXN_Click);

            // dgvXN
            this.dgvXN.Name = "dgvXN";
            this.dgvXN.Location = new System.Drawing.Point(770, 350);
            this.dgvXN.Size = new System.Drawing.Size(205, 95);
            this.dgvXN.TabIndex = 37;
            this.dgvXN.AllowUserToAddRows = false;
            this.dgvXN.AllowUserToDeleteRows = false;
            this.dgvXN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXN.ReadOnly = true;
            this.dgvXN.RowHeadersWidth = 51;
            this.dgvXN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXN.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXN_CellDoubleClick);

            // lblVienPhi
            this.lblVienPhi.Name = "lblVienPhi";
            this.lblVienPhi.Location = new System.Drawing.Point(25, 465);
            this.lblVienPhi.TabIndex = 38;
            this.lblVienPhi.AutoSize = true;
            this.lblVienPhi.Text = "Viện phí:";

            // txtVienPhi
            this.txtVienPhi.Name = "txtVienPhi";
            this.txtVienPhi.Location = new System.Drawing.Point(90, 462);
            this.txtVienPhi.Size = new System.Drawing.Size(100, 22);
            this.txtVienPhi.TabIndex = 39;
            this.txtVienPhi.Text = "0";

            // lblXuatVien
            this.lblXuatVien.Name = "lblXuatVien";
            this.lblXuatVien.Location = new System.Drawing.Point(215, 465);
            this.lblXuatVien.TabIndex = 40;
            this.lblXuatVien.AutoSize = true;
            this.lblXuatVien.Text = "Ngày xuất viện:";

            // dtpXuatVien
            this.dtpXuatVien.Name = "dtpXuatVien";
            this.dtpXuatVien.Location = new System.Drawing.Point(320, 462);
            this.dtpXuatVien.Size = new System.Drawing.Size(120, 22);
            this.dtpXuatVien.TabIndex = 41;
            this.dtpXuatVien.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // lblGhiChuLoai
            this.lblGhiChuLoai.Name = "lblGhiChuLoai";
            this.lblGhiChuLoai.Location = new System.Drawing.Point(460, 465);
            this.lblGhiChuLoai.TabIndex = 42;
            this.lblGhiChuLoai.AutoSize = true;
            this.lblGhiChuLoai.Text = "";
            this.lblGhiChuLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.lblGhiChuLoai.ForeColor = System.Drawing.Color.DarkGreen;

            // btnLamMoi
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Location = new System.Drawing.Point(690, 458);
            this.btnLamMoi.Size = new System.Drawing.Size(100, 32);
            this.btnLamMoi.TabIndex = 43;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // btnLuu
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Location = new System.Drawing.Point(800, 458);
            this.btnLuu.Size = new System.Drawing.Size(175, 32);
            this.btnLuu.TabIndex = 44;
            this.btnLuu.Text = "Lưu phiếu khám";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

            // lblTitleLS
            this.lblTitleLS.Name = "lblTitleLS";
            this.lblTitleLS.Location = new System.Drawing.Point(25, 505);
            this.lblTitleLS.TabIndex = 45;
            this.lblTitleLS.AutoSize = true;
            this.lblTitleLS.Text = "Lịch sử khám bệnh của bệnh nhân:";

            // dgvLichSu
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.Location = new System.Drawing.Point(28, 530);
            this.dgvLichSu.Size = new System.Drawing.Size(947, 140);
            this.dgvLichSu.TabIndex = 46;
            this.dgvLichSu.AllowUserToAddRows = false;
            this.dgvLichSu.AllowUserToDeleteRows = false;
            this.dgvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSu.ReadOnly = true;
            this.dgvLichSu.RowHeadersWidth = 51;
            this.dgvLichSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // FrmPhieuKham
            this.ClientSize = new System.Drawing.Size(1000, 685);
            this.Controls.Add(this.lblNav);
            this.Controls.Add(this.lblMaHoSo);
            this.Controls.Add(this.txtMaHoSo);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.lblNgayGio);
            this.Controls.Add(this.dtpNgayGio);
            this.Controls.Add(this.lblLoai);
            this.Controls.Add(this.cboLoai);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.lblBS);
            this.Controls.Add(this.cboBS);
            this.Controls.Add(this.lblTrieuChung);
            this.Controls.Add(this.txtTrieuChung);
            this.Controls.Add(this.lblNhiet);
            this.Controls.Add(this.txtNhiet);
            this.Controls.Add(this.lblHuyetAp);
            this.Controls.Add(this.txtHuyetAp);
            this.Controls.Add(this.lblChanDoan);
            this.Controls.Add(this.txtChanDoan);
            this.Controls.Add(this.lblPhanUng);
            this.Controls.Add(this.txtPhanUng);
            this.Controls.Add(this.lblTitleToa);
            this.Controls.Add(this.lblThuoc);
            this.Controls.Add(this.cboThuoc);
            this.Controls.Add(this.lblSL);
            this.Controls.Add(this.numSL);
            this.Controls.Add(this.lblCachDung);
            this.Controls.Add(this.txtCachDung);
            this.Controls.Add(this.btnThemThuoc);
            this.Controls.Add(this.dgvToa);
            this.Controls.Add(this.lblTitleXN);
            this.Controls.Add(this.cboXN);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.txtKetQuaXN);
            this.Controls.Add(this.btnThemXN);
            this.Controls.Add(this.dgvXN);
            this.Controls.Add(this.lblVienPhi);
            this.Controls.Add(this.txtVienPhi);
            this.Controls.Add(this.lblXuatVien);
            this.Controls.Add(this.dtpXuatVien);
            this.Controls.Add(this.lblGhiChuLoai);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lblTitleLS);
            this.Controls.Add(this.dgvLichSu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPhieuKham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu khám bệnh - Toa thuốc - Xét nghiệm";
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
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
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label lblBS;
        private System.Windows.Forms.ComboBox cboBS;
        private System.Windows.Forms.Label lblTrieuChung;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.Label lblNhiet;
        private System.Windows.Forms.TextBox txtNhiet;
        private System.Windows.Forms.Label lblHuyetAp;
        private System.Windows.Forms.TextBox txtHuyetAp;
        private System.Windows.Forms.Label lblChanDoan;
        private System.Windows.Forms.TextBox txtChanDoan;
        private System.Windows.Forms.Label lblPhanUng;
        private System.Windows.Forms.TextBox txtPhanUng;
        private System.Windows.Forms.Label lblTitleToa;
        private System.Windows.Forms.Label lblThuoc;
        private System.Windows.Forms.ComboBox cboThuoc;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.Label lblCachDung;
        private System.Windows.Forms.TextBox txtCachDung;
        private System.Windows.Forms.Button btnThemThuoc;
        private System.Windows.Forms.DataGridView dgvToa;
        private System.Windows.Forms.Label lblTitleXN;
        private System.Windows.Forms.ComboBox cboXN;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.TextBox txtKetQuaXN;
        private System.Windows.Forms.Button btnThemXN;
        private System.Windows.Forms.DataGridView dgvXN;
        private System.Windows.Forms.Label lblVienPhi;
        private System.Windows.Forms.TextBox txtVienPhi;
        private System.Windows.Forms.Label lblXuatVien;
        private System.Windows.Forms.DateTimePicker dtpXuatVien;
        private System.Windows.Forms.Label lblGhiChuLoai;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblTitleLS;
        private System.Windows.Forms.DataGridView dgvLichSu;
    }
}
