namespace QuanLyCuaHangBanMayTinh.FormGiaoDien
{
    partial class Form_HangHoa
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
            this.dtv_hanghoa = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_ncc = new System.Windows.Forms.ComboBox();
            this.txt_dongianhap = new System.Windows.Forms.TextBox();
            this.txt_dongiaban = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_tenhang = new System.Windows.Forms.TextBox();
            this.txt_mahang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.MAHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGIANHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGIABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_hanghoa)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(28, 350);
            this.btn_load.Margin = new System.Windows.Forms.Padding(4);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(176, 43);
            this.btn_load.TabIndex = 147;
            this.btn_load.Text = "Hiển thị toàn bộ hàng hóa";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtv_hanghoa);
            this.groupBox1.Location = new System.Drawing.Point(24, 401);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1216, 298);
            this.groupBox1.TabIndex = 148;
            this.groupBox1.TabStop = false;
            // 
            // dtv_hanghoa
            // 
            this.dtv_hanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_hanghoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHH,
            this.MaNCC,
            this.TenHANG,
            this.SoLUONG,
            this.DonGIANHAP,
            this.DonGIABAN});
            this.dtv_hanghoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtv_hanghoa.Location = new System.Drawing.Point(4, 19);
            this.dtv_hanghoa.Margin = new System.Windows.Forms.Padding(4);
            this.dtv_hanghoa.Name = "dtv_hanghoa";
            this.dtv_hanghoa.RowHeadersWidth = 51;
            this.dtv_hanghoa.Size = new System.Drawing.Size(1208, 275);
            this.dtv_hanghoa.TabIndex = 0;
            this.dtv_hanghoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_hanghoa_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(503, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(233, 46);
            this.label11.TabIndex = 146;
            this.label11.Text = "HÀNG HÓA";
            // 
            // cb_ncc
            // 
            this.cb_ncc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ncc.FormattingEnabled = true;
            this.cb_ncc.Location = new System.Drawing.Point(317, 201);
            this.cb_ncc.Margin = new System.Windows.Forms.Padding(5);
            this.cb_ncc.Name = "cb_ncc";
            this.cb_ncc.Size = new System.Drawing.Size(239, 30);
            this.cb_ncc.TabIndex = 140;
            // 
            // txt_dongianhap
            // 
            this.txt_dongianhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dongianhap.Location = new System.Drawing.Point(849, 144);
            this.txt_dongianhap.Margin = new System.Windows.Forms.Padding(5);
            this.txt_dongianhap.Name = "txt_dongianhap";
            this.txt_dongianhap.Size = new System.Drawing.Size(239, 30);
            this.txt_dongianhap.TabIndex = 139;
            // 
            // txt_dongiaban
            // 
            this.txt_dongiaban.Location = new System.Drawing.Point(849, 205);
            this.txt_dongiaban.Margin = new System.Windows.Forms.Padding(5);
            this.txt_dongiaban.Multiline = true;
            this.txt_dongiaban.Name = "txt_dongiaban";
            this.txt_dongiaban.Size = new System.Drawing.Size(239, 34);
            this.txt_dongiaban.TabIndex = 138;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluong.Location = new System.Drawing.Point(849, 87);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(5);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(239, 30);
            this.txt_soluong.TabIndex = 137;
            // 
            // txt_tenhang
            // 
            this.txt_tenhang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenhang.Location = new System.Drawing.Point(317, 144);
            this.txt_tenhang.Margin = new System.Windows.Forms.Padding(5);
            this.txt_tenhang.Name = "txt_tenhang";
            this.txt_tenhang.Size = new System.Drawing.Size(239, 30);
            this.txt_tenhang.TabIndex = 136;
            // 
            // txt_mahang
            // 
            this.txt_mahang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mahang.Location = new System.Drawing.Point(317, 87);
            this.txt_mahang.Margin = new System.Windows.Forms.Padding(5);
            this.txt_mahang.Name = "txt_mahang";
            this.txt_mahang.Size = new System.Drawing.Size(239, 30);
            this.txt_mahang.TabIndex = 135;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(653, 210);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 23);
            this.label8.TabIndex = 134;
            this.label8.Text = "Đơn giá bán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(652, 151);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 23);
            this.label7.TabIndex = 133;
            this.label7.Text = "Đơn giá nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(652, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 132;
            this.label6.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(118, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 131;
            this.label5.Text = "Tên hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(118, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 23);
            this.label4.TabIndex = 130;
            this.label4.Text = "Tên nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(124, 329);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 129;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(144, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(121, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 127;
            this.label1.Text = "Mã hàng";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Exit.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Black;
            this.btn_Exit.Image = global::QuanLyCuaHangBanMayTinh.Properties.Resources.close;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(955, 269);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(133, 55);
            this.btn_Exit.TabIndex = 145;
            this.btn_Exit.Text = "Đóng";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Find
            // 
            this.btn_Find.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Find.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Find.ForeColor = System.Drawing.Color.Black;
            this.btn_Find.Image = global::QuanLyCuaHangBanMayTinh.Properties.Resources.search;
            this.btn_Find.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Find.Location = new System.Drawing.Point(747, 269);
            this.btn_Find.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(145, 55);
            this.btn_Find.TabIndex = 144;
            this.btn_Find.Text = "Tìm kiếm";
            this.btn_Find.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Find.UseVisualStyleBackColor = false;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Black;
            this.btn_update.Image = global::QuanLyCuaHangBanMayTinh.Properties.Resources.update;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(317, 269);
            this.btn_update.Margin = new System.Windows.Forms.Padding(5);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(133, 55);
            this.btn_update.TabIndex = 143;
            this.btn_update.Text = "Sửa";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.Image = global::QuanLyCuaHangBanMayTinh.Properties.Resources.delete;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(529, 269);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(133, 55);
            this.btn_delete.TabIndex = 142;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Image = global::QuanLyCuaHangBanMayTinh.Properties.Resources.add;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(119, 269);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(133, 55);
            this.btn_add.TabIndex = 141;
            this.btn_add.Text = "Thêm ";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // MAHH
            // 
            this.MAHH.DataPropertyName = "MAHH";
            this.MAHH.HeaderText = "Mã Hàng";
            this.MAHH.MinimumWidth = 6;
            this.MAHH.Name = "MAHH";
            this.MAHH.Width = 115;
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Width = 115;
            // 
            // TenHANG
            // 
            this.TenHANG.DataPropertyName = "TenHANG";
            this.TenHANG.HeaderText = "Tên Hàng";
            this.TenHANG.MinimumWidth = 6;
            this.TenHANG.Name = "TenHANG";
            this.TenHANG.Width = 250;
            // 
            // SoLUONG
            // 
            this.SoLUONG.DataPropertyName = "SoLUONG";
            this.SoLUONG.HeaderText = "Số lượng";
            this.SoLUONG.MinimumWidth = 6;
            this.SoLUONG.Name = "SoLUONG";
            // 
            // DonGIANHAP
            // 
            this.DonGIANHAP.DataPropertyName = "DonGIANHAP";
            this.DonGIANHAP.HeaderText = "Đơn giá nhập";
            this.DonGIANHAP.MinimumWidth = 6;
            this.DonGIANHAP.Name = "DonGIANHAP";
            this.DonGIANHAP.Width = 135;
            // 
            // DonGIABAN
            // 
            this.DonGIABAN.DataPropertyName = "DonGIABAN";
            this.DonGIABAN.HeaderText = "Đơn giá bán";
            this.DonGIABAN.MinimumWidth = 6;
            this.DonGIABAN.Name = "DonGIABAN";
            this.DonGIABAN.Width = 145;
            // 
            // Form_HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 741);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cb_ncc);
            this.Controls.Add(this.txt_dongianhap);
            this.Controls.Add(this.txt_dongiaban);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.txt_tenhang);
            this.Controls.Add(this.txt_mahang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_HangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_HangHoa";
            this.Load += new System.EventHandler(this.Form_HangHoa_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_hanghoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dtv_hanghoa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.ComboBox cb_ncc;
        public System.Windows.Forms.TextBox txt_dongianhap;
        public System.Windows.Forms.TextBox txt_dongiaban;
        public System.Windows.Forms.TextBox txt_soluong;
        public System.Windows.Forms.TextBox txt_tenhang;
        public System.Windows.Forms.TextBox txt_mahang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGIANHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGIABAN;

    }
}