namespace QuanLyCuaHangBanMayTinh.FormGiaoDien
{
    partial class Form_KhachHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtv_khachhang = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaCHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_gioitinh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.dt_namsinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_khachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtv_khachhang);
            this.groupBox1.Location = new System.Drawing.Point(23, 372);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(926, 263);
            this.groupBox1.TabIndex = 142;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng";
            // 
            // dtv_khachhang
            // 
            this.dtv_khachhang.AllowUserToOrderColumns = true;
            this.dtv_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_khachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.NgaySINH,
            this.GioiTINH,
            this.DiaCHI,
            this.SDT});
            this.dtv_khachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtv_khachhang.Location = new System.Drawing.Point(4, 19);
            this.dtv_khachhang.Margin = new System.Windows.Forms.Padding(4);
            this.dtv_khachhang.Name = "dtv_khachhang";
            this.dtv_khachhang.RowHeadersWidth = 51;
            this.dtv_khachhang.Size = new System.Drawing.Size(918, 240);
            this.dtv_khachhang.TabIndex = 0;
            this.dtv_khachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_khachhang_CellContentClick);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 125;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 200;
            // 
            // NgaySINH
            // 
            this.NgaySINH.DataPropertyName = "NgaySINH";
            this.NgaySINH.HeaderText = "Ngày sinh";
            this.NgaySINH.MinimumWidth = 6;
            this.NgaySINH.Name = "NgaySINH";
            this.NgaySINH.Width = 125;
            // 
            // GioiTINH
            // 
            this.GioiTINH.DataPropertyName = "GioiTINH";
            this.GioiTINH.HeaderText = "Giới tính";
            this.GioiTINH.MinimumWidth = 6;
            this.GioiTINH.Name = "GioiTINH";
            this.GioiTINH.Width = 125;
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
            this.SDT.Width = 120;
            // 
            // cb_gioitinh
            // 
            this.cb_gioitinh.FormattingEnabled = true;
            this.cb_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cb_gioitinh.Location = new System.Drawing.Point(190, 149);
            this.cb_gioitinh.Margin = new System.Windows.Forms.Padding(4);
            this.cb_gioitinh.Name = "cb_gioitinh";
            this.cb_gioitinh.Size = new System.Drawing.Size(169, 24);
            this.cb_gioitinh.TabIndex = 141;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(357, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 45);
            this.label5.TabIndex = 140;
            this.label5.Text = " Khách Hàng";
            // 
            // txt_sdt
            // 
            this.txt_sdt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_sdt.Location = new System.Drawing.Point(771, 218);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_sdt.Multiline = true;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(178, 26);
            this.txt_sdt.TabIndex = 139;
            // 
            // dt_namsinh
            // 
            this.dt_namsinh.CustomFormat = "dd/MM/yyyy";
            this.dt_namsinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_namsinh.Location = new System.Drawing.Point(768, 147);
            this.dt_namsinh.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dt_namsinh.Name = "dt_namsinh";
            this.dt_namsinh.Size = new System.Drawing.Size(178, 22);
            this.dt_namsinh.TabIndex = 138;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(581, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 137;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(581, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 136;
            this.label4.Text = "Số điện thoại";
            // 
            // txt_diachi
            // 
            this.txt_diachi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_diachi.Location = new System.Drawing.Point(190, 218);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_diachi.Multiline = true;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(169, 26);
            this.txt_diachi.TabIndex = 135;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(23, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 23);
            this.label6.TabIndex = 134;
            this.label6.Text = "Địa Chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(23, 151);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 23);
            this.label7.TabIndex = 133;
            this.label7.Text = "Giới Tính";
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_tenkh.Location = new System.Drawing.Point(767, 86);
            this.txt_tenkh.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_tenkh.Multiline = true;
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(178, 26);
            this.txt_tenkh.TabIndex = 132;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(581, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 131;
            this.label2.Text = "Tên khách hàng";
            // 
            // txt_makh
            // 
            this.txt_makh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_makh.Location = new System.Drawing.Point(190, 86);
            this.txt_makh.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_makh.Multiline = true;
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(169, 26);
            this.txt_makh.TabIndex = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 129;
            this.label1.Text = "Mã khách hàng";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.White;
            this.btnDong.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnDong.Image = global::QuanLyCuaHangBanMayTinh.Properties.Resources.close;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(758, 283);
            this.btnDong.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(126, 51);
            this.btnDong.TabIndex = 128;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnSua.Image = global::QuanLyCuaHangBanMayTinh.Properties.Resources.update;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(549, 283);
            this.btnSua.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 51);
            this.btnSua.TabIndex = 127;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnXoa.Image = global::QuanLyCuaHangBanMayTinh.Properties.Resources.delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(282, 283);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(122, 51);
            this.btnXoa.TabIndex = 126;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnThem.Image = global::QuanLyCuaHangBanMayTinh.Properties.Resources.add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(62, 283);
            this.btnThem.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 51);
            this.btnThem.TabIndex = 125;
            this.btnThem.Text = "Thêm ";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Form_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 669);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cb_gioitinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.dt_namsinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_tenkh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_makh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "Form_KhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKhachHang";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_khachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dtv_khachhang;
        public System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaCHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        public System.Windows.Forms.ComboBox cb_gioitinh;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_sdt;
        public System.Windows.Forms.DateTimePicker dt_namsinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}