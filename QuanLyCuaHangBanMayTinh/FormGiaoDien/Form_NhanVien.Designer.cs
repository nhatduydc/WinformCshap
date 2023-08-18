namespace QuanLyCuaHangBanMayTinh.FormGiaoDien
{
    partial class Form_NhanVien
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_load = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtv_nhanvien = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaCHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.cb_gioitinh = new System.Windows.Forms.ComboBox();
            this.dt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txt_sdt = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(466, 352);
            this.btn_load.Margin = new System.Windows.Forms.Padding(4);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(180, 43);
            this.btn_load.TabIndex = 130;
            this.btn_load.Text = "Danh sách nhân viên";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtv_nhanvien);
            this.groupBox1.Location = new System.Drawing.Point(13, 403);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1159, 315);
            this.groupBox1.TabIndex = 129;
            this.groupBox1.TabStop = false;
            // 
            // dtv_nhanvien
            // 
            this.dtv_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_nhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.GioiTINH,
            this.NgaySINH,
            this.DiaCHI,
            this.SDT});
            this.dtv_nhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtv_nhanvien.Location = new System.Drawing.Point(4, 19);
            this.dtv_nhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.dtv_nhanvien.Name = "dtv_nhanvien";
            this.dtv_nhanvien.RowHeadersWidth = 51;
            this.dtv_nhanvien.Size = new System.Drawing.Size(1151, 292);
            this.dtv_nhanvien.TabIndex = 0;
            this.dtv_nhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_nhanvien_CellContentClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 85;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên nhân viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 170;
            // 
            // GioiTINH
            // 
            this.GioiTINH.DataPropertyName = "GioiTINH";
            this.GioiTINH.HeaderText = "Giới tính";
            this.GioiTINH.MinimumWidth = 6;
            this.GioiTINH.Name = "GioiTINH";
            this.GioiTINH.Width = 125;
            // 
            // NgaySINH
            // 
            this.NgaySINH.DataPropertyName = "NgaySINH";
            this.NgaySINH.HeaderText = "Ngày sinh";
            this.NgaySINH.MinimumWidth = 6;
            this.NgaySINH.Name = "NgaySINH";
            this.NgaySINH.Width = 150;
            // 
            // DiaCHI
            // 
            this.DiaCHI.DataPropertyName = "DiaCHI";
            this.DiaCHI.HeaderText = "Địa chỉ";
            this.DiaCHI.MinimumWidth = 6;
            this.DiaCHI.Name = "DiaCHI";
            this.DiaCHI.Width = 200;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 150;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_timkiem.Image = global::QuanLyCuaHangBanMayTinh.Properties.Resources.search;
            this.btn_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiem.Location = new System.Drawing.Point(691, 269);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(174, 60);
            this.btn_timkiem.TabIndex = 128;
            this.btn_timkiem.Text = "Tìm kiếm theo tên";
            this.btn_timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // cb_gioitinh
            // 
            this.cb_gioitinh.FormattingEnabled = true;
            this.cb_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cb_gioitinh.Location = new System.Drawing.Point(273, 197);
            this.cb_gioitinh.Margin = new System.Windows.Forms.Padding(4);
            this.cb_gioitinh.Name = "cb_gioitinh";
            this.cb_gioitinh.Size = new System.Drawing.Size(125, 24);
            this.cb_gioitinh.TabIndex = 127;
            // 
            // dt_ngaysinh
            // 
            this.dt_ngaysinh.CustomFormat = "dd/MM/yyyy";
            this.dt_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngaysinh.Location = new System.Drawing.Point(815, 202);
            this.dt_ngaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.dt_ngaysinh.Name = "dt_ngaysinh";
            this.dt_ngaysinh.Size = new System.Drawing.Size(244, 22);
            this.dt_ngaysinh.TabIndex = 126;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label9.Location = new System.Drawing.Point(475, 2);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 45);
            this.label9.TabIndex = 125;
            this.label9.Text = "Nhân Viên";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.White;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.Black;
            this.btnDong.Image = global::QuanLyCuaHangBanMayTinh.Properties.Resources.close;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(932, 267);
            this.btnDong.Margin = new System.Windows.Forms.Padding(5);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(127, 60);
            this.btnDong.TabIndex = 124;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = global::QuanLyCuaHangBanMayTinh.Properties.Resources.update;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(483, 269);
            this.btnSua.Margin = new System.Windows.Forms.Padding(5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(128, 60);
            this.btnSua.TabIndex = 123;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = global::QuanLyCuaHangBanMayTinh.Properties.Resources.delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(273, 269);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(134, 60);
            this.btnXoa.TabIndex = 122;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = global::QuanLyCuaHangBanMayTinh.Properties.Resources.add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(52, 271);
            this.btnThem.Margin = new System.Windows.Forms.Padding(5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(133, 60);
            this.btnThem.TabIndex = 121;
            this.btnThem.Text = "Thêm ";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_sdt.Location = new System.Drawing.Point(815, 125);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(5);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(244, 32);
            this.txt_sdt.TabIndex = 120;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(607, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 119;
            this.label4.Text = "Số điện thoại";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_diachi.Location = new System.Drawing.Point(815, 70);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(5);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(244, 32);
            this.txt_diachi.TabIndex = 118;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(607, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 117;
            this.label6.Text = "Địa Chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(47, 195);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 25);
            this.label7.TabIndex = 116;
            this.label7.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(607, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 115;
            this.label3.Text = "Năm Sinh";
            // 
            // txt_tennv
            // 
            this.txt_tennv.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tennv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_tennv.Location = new System.Drawing.Point(273, 125);
            this.txt_tennv.Margin = new System.Windows.Forms.Padding(5);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(209, 32);
            this.txt_tennv.TabIndex = 114;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(47, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 113;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 309);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 112;
            // 
            // txt_manv
            // 
            this.txt_manv.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_manv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_manv.Location = new System.Drawing.Point(273, 70);
            this.txt_manv.Margin = new System.Windows.Forms.Padding(5);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(209, 32);
            this.txt_manv.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(47, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 110;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // Form_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 744);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.cb_gioitinh);
            this.Controls.Add(this.dt_ngaysinh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tennv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_manv);
            this.Controls.Add(this.label1);
            this.Name = "Form_NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_NhanVien";
            this.Load += new System.EventHandler(this.Form_NhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_nhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dtv_nhanvien;
        public System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaCHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.Button btn_timkiem;
        public System.Windows.Forms.ComboBox cb_gioitinh;
        public System.Windows.Forms.DateTimePicker dt_ngaysinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        public System.Windows.Forms.MaskedTextBox txt_sdt;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.Label label1;

    }
}