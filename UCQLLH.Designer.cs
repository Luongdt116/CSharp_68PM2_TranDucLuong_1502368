namespace QLSinhVien
{
    partial class UCQLLH
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
            this.pm_qllh = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnXemdssv = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvQLLH = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnDau = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTrang = new System.Windows.Forms.Label();
            this.btnSuasv = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pm_qllh.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLLH)).BeginInit();
            this.SuspendLayout();
            // 
            // pm_qllh
            // 
            this.pm_qllh.Controls.Add(this.groupBox1);
            this.pm_qllh.Controls.Add(this.btnXemdssv);
            this.pm_qllh.Controls.Add(this.btnSau);
            this.pm_qllh.Controls.Add(this.panel1);
            this.pm_qllh.Controls.Add(this.btnLamMoi);
            this.pm_qllh.Controls.Add(this.btnXoa);
            this.pm_qllh.Controls.Add(this.btnCuoi);
            this.pm_qllh.Controls.Add(this.btnTruoc);
            this.pm_qllh.Controls.Add(this.btnDau);
            this.pm_qllh.Controls.Add(this.txtTimKiem);
            this.pm_qllh.Controls.Add(this.btnTimKiem);
            this.pm_qllh.Controls.Add(this.label7);
            this.pm_qllh.Controls.Add(this.lblTrang);
            this.pm_qllh.Controls.Add(this.btnSuasv);
            this.pm_qllh.Controls.Add(this.btnThem);
            this.pm_qllh.Location = new System.Drawing.Point(15, 31);
            this.pm_qllh.Name = "pm_qllh";
            this.pm_qllh.Size = new System.Drawing.Size(1182, 686);
            this.pm_qllh.TabIndex = 63;
            this.pm_qllh.Paint += new System.Windows.Forms.PaintEventHandler(this.pm_qllh_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaLop);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTenLop);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Location = new System.Drawing.Point(20, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 409);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý lớp học";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(10, 45);
            this.lblId.Margin = new System.Windows.Forms.Padding(8);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(45, 16);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "Mã ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(10, 77);
            this.txtID.Margin = new System.Windows.Forms.Padding(8, 8, 8, 14);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(350, 22);
            this.txtID.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mã lớp:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(10, 153);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(8, 8, 8, 14);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(350, 22);
            this.txtMaLop.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tên lớp:";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(10, 229);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(8, 8, 8, 14);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(350, 22);
            this.txtTenLop.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 273);
            this.label6.Margin = new System.Windows.Forms.Padding(8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(10, 305);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(8, 8, 8, 14);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(350, 22);
            this.txtGhiChu.TabIndex = 21;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnXemdssv
            // 
            this.btnXemdssv.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXemdssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemdssv.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnXemdssv.Location = new System.Drawing.Point(20, 572);
            this.btnXemdssv.Name = "btnXemdssv";
            this.btnXemdssv.Size = new System.Drawing.Size(370, 49);
            this.btnXemdssv.TabIndex = 76;
            this.btnXemdssv.Text = "Xem danh sách sinh viên";
            this.btnXemdssv.UseVisualStyleBackColor = false;
            this.btnXemdssv.Click += new System.EventHandler(this.btnXemdssv_Click);
            // 
            // btnSau
            // 
            this.btnSau.Location = new System.Drawing.Point(796, 574);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(60, 47);
            this.btnSau.TabIndex = 73;
            this.btnSau.Text = ">";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvQLLH);
            this.panel1.Location = new System.Drawing.Point(407, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 483);
            this.panel1.TabIndex = 67;
            // 
            // dgvQLLH
            // 
            this.dgvQLLH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLLH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvQLLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLLH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MaLop,
            this.TenLop,
            this.GhiChu});
            this.dgvQLLH.Location = new System.Drawing.Point(3, 3);
            this.dgvQLLH.Name = "dgvQLLH";
            this.dgvQLLH.RowHeadersWidth = 51;
            this.dgvQLLH.RowTemplate.Height = 24;
            this.dgvQLLH.Size = new System.Drawing.Size(691, 477);
            this.dgvQLLH.TabIndex = 0;
            this.dgvQLLH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLLH_CellContentClick);
            this.dgvQLLH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLLH_CellContentClick_1);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã lớp ";
            this.MaLop.MinimumWidth = 6;
            this.MaLop.Name = "MaLop";
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "Tên lớp ";
            this.TenLop.MinimumWidth = 6;
            this.TenLop.Name = "TenLop";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Silver;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnLamMoi.Location = new System.Drawing.Point(213, 498);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(177, 49);
            this.btnLamMoi.TabIndex = 66;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnXoa.Location = new System.Drawing.Point(20, 498);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(177, 49);
            this.btnXoa.TabIndex = 65;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCuoi
            // 
            this.btnCuoi.Location = new System.Drawing.Point(853, 574);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(60, 47);
            this.btnCuoi.TabIndex = 74;
            this.btnCuoi.Text = ">>";
            this.btnCuoi.UseVisualStyleBackColor = true;
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Location = new System.Drawing.Point(467, 574);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(60, 47);
            this.btnTruoc.TabIndex = 72;
            this.btnTruoc.Text = "<";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnDau
            // 
            this.btnDau.Location = new System.Drawing.Point(410, 574);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(60, 47);
            this.btnDau.TabIndex = 71;
            this.btnDau.Text = "<<";
            this.btnDau.UseVisualStyleBackColor = true;
            this.btnDau.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(407, 53);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(289, 22);
            this.txtTimKiem.TabIndex = 70;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(702, 32);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(88, 47);
            this.btnTimKiem.TabIndex = 69;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(404, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 16);
            this.label7.TabIndex = 68;
            this.label7.Text = "Tìm kiếm (Tên/Mã lớp/Lớp)";
            // 
            // lblTrang
            // 
            this.lblTrang.AutoSize = true;
            this.lblTrang.Location = new System.Drawing.Point(600, 589);
            this.lblTrang.Name = "lblTrang";
            this.lblTrang.Size = new System.Drawing.Size(127, 16);
            this.lblTrang.TabIndex = 75;
            this.lblTrang.Text = "Trang 1/1 | 3 bản ghi";
            // 
            // btnSuasv
            // 
            this.btnSuasv.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSuasv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuasv.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSuasv.Location = new System.Drawing.Point(213, 443);
            this.btnSuasv.Name = "btnSuasv";
            this.btnSuasv.Size = new System.Drawing.Size(177, 49);
            this.btnSuasv.TabIndex = 64;
            this.btnSuasv.Text = "Sửa";
            this.btnSuasv.UseVisualStyleBackColor = false;
            this.btnSuasv.Click += new System.EventHandler(this.btnSuasv_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnThem.Location = new System.Drawing.Point(20, 443);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(177, 49);
            this.btnThem.TabIndex = 63;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // UCQLLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pm_qllh);
            this.Name = "UCQLLH";
            this.Size = new System.Drawing.Size(1200, 720);
            this.Load += new System.EventHandler(this.UCQLLH_Load);
            this.pm_qllh.ResumeLayout(false);
            this.pm_qllh.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLLH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pm_qllh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnXemdssv;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvQLLH;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCuoi;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnDau;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTrang;
        private System.Windows.Forms.Button btnSuasv;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}
