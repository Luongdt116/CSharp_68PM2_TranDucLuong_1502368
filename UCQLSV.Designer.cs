namespace QLSinhVien
{
    partial class UCQLSV
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pn_qlsv = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_DSSV = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSuasv = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.qLSinhVienDataSet = new QLSinhVien.QLSinhVienDataSet();
            this.qLSinhVienDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pn_qlsv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSV)).BeginInit();
            this.grb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_qlsv
            // 
            this.pn_qlsv.Controls.Add(this.textBox3);
            this.pn_qlsv.Controls.Add(this.btnTimKiem);
            this.pn_qlsv.Controls.Add(this.label5);
            this.pn_qlsv.Controls.Add(this.button8);
            this.pn_qlsv.Controls.Add(this.button9);
            this.pn_qlsv.Controls.Add(this.button7);
            this.pn_qlsv.Controls.Add(this.button6);
            this.pn_qlsv.Controls.Add(this.label6);
            this.pn_qlsv.Controls.Add(this.dgv_DSSV);
            this.pn_qlsv.Controls.Add(this.btnLamMoi);
            this.pn_qlsv.Controls.Add(this.btnXoa);
            this.pn_qlsv.Controls.Add(this.btnSuasv);
            this.pn_qlsv.Controls.Add(this.btnThem);
            this.pn_qlsv.Controls.Add(this.grb1);
            this.pn_qlsv.Location = new System.Drawing.Point(10, 16);
            this.pn_qlsv.Name = "pn_qlsv";
            this.pn_qlsv.Size = new System.Drawing.Size(1177, 683);
            this.pn_qlsv.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(420, 43);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(289, 22);
            this.textBox3.TabIndex = 73;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(715, 22);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(88, 47);
            this.btnTimKiem.TabIndex = 72;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(417, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 16);
            this.label5.TabIndex = 71;
            this.label5.Text = "Tìm kiếm (Tên/Mã lớp/Lớp)";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(889, 625);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(53, 51);
            this.button8.TabIndex = 35;
            this.button8.Text = ">";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(940, 625);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(53, 51);
            this.button9.TabIndex = 34;
            this.button9.Text = ">>";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(500, 626);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(53, 51);
            this.button7.TabIndex = 33;
            this.button7.Text = "<<";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(551, 626);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(53, 51);
            this.button6.TabIndex = 32;
            this.button6.Text = "<";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(710, 643);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Trang 1/1 | 3 bản ghi";
            // 
            // dgv_DSSV
            // 
            this.dgv_DSSV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_DSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.HoTen,
            this.GioiTinh,
            this.NgaySinh,
            this.MaLop});
            this.dgv_DSSV.Location = new System.Drawing.Point(420, 75);
            this.dgv_DSSV.Name = "dgv_DSSV";
            this.dgv_DSSV.RowHeadersWidth = 51;
            this.dgv_DSSV.RowTemplate.Height = 24;
            this.dgv_DSSV.Size = new System.Drawing.Size(704, 544);
            this.dgv_DSSV.TabIndex = 30;
            this.dgv_DSSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_DSSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã SV";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.ReadOnly = true;
            this.MaSV.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ và Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 125;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            this.NgaySinh.Width = 125;
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã Lớp";
            this.MaLop.MinimumWidth = 6;
            this.MaLop.Name = "MaLop";
            this.MaLop.Width = 125;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLamMoi.Location = new System.Drawing.Point(222, 592);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(163, 51);
            this.btnLamMoi.TabIndex = 29;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(21, 592);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(163, 51);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSuasv
            // 
            this.btnSuasv.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSuasv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSuasv.Location = new System.Drawing.Point(222, 522);
            this.btnSuasv.Name = "btnSuasv";
            this.btnSuasv.Size = new System.Drawing.Size(163, 51);
            this.btnSuasv.TabIndex = 27;
            this.btnSuasv.Text = "Sửa";
            this.btnSuasv.UseVisualStyleBackColor = false;
            this.btnSuasv.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(21, 522);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(163, 51);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.cboLop);
            this.grb1.Controls.Add(this.cboGioiTinh);
            this.grb1.Controls.Add(this.dtpNgaySinh);
            this.grb1.Controls.Add(this.label7);
            this.grb1.Controls.Add(this.label4);
            this.grb1.Controls.Add(this.label3);
            this.grb1.Controls.Add(this.txtHoTen);
            this.grb1.Controls.Add(this.label2);
            this.grb1.Controls.Add(this.txtMaSV);
            this.grb1.Controls.Add(this.label1);
            this.grb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb1.Location = new System.Drawing.Point(19, 3);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(366, 497);
            this.grb1.TabIndex = 25;
            this.grb1.TabStop = false;
            this.grb1.Text = "Thông tin Sinh Viên";
            // 
            // cboLop
            // 
            this.cboLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Items.AddRange(new object[] {
            "68PM1 - Lớp 68PM1",
            "68PM2 - Lớp 68PM2"});
            this.cboLop.Location = new System.Drawing.Point(20, 448);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(314, 24);
            this.cboLop.TabIndex = 11;
            this.cboLop.Text = "68PM1 - Lớp 68PM1";
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cboGioiTinh.Location = new System.Drawing.Point(20, 356);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(314, 24);
            this.cboGioiTinh.TabIndex = 10;
            this.cboGioiTinh.Text = "Nam";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(20, 265);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(314, 22);
            this.dtpNgaySinh.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(17, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Lớp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(17, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(17, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(20, 163);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(314, 22);
            this.txtHoTen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(17, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(20, 72);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(314, 22);
            this.txtMaSV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên:";
            // 
            // qLSinhVienDataSet
            // 
            this.qLSinhVienDataSet.DataSetName = "QLSinhVienDataSet";
            this.qLSinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLSinhVienDataSetBindingSource
            // 
            this.qLSinhVienDataSetBindingSource.DataSource = this.qLSinhVienDataSet;
            this.qLSinhVienDataSetBindingSource.Position = 0;
            // 
            // UCQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_qlsv);
            this.Name = "UCQLSV";
            this.Size = new System.Drawing.Size(1200, 716);
            this.Load += new System.EventHandler(this.UCQLSV_Load);
            this.pn_qlsv.ResumeLayout(false);
            this.pn_qlsv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSV)).EndInit();
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_qlsv;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_DSSV;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSuasv;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label5;
        private QLSinhVienDataSet qLSinhVienDataSet;
        private System.Windows.Forms.BindingSource qLSinhVienDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
    }
}
