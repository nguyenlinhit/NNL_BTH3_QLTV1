namespace BTH3
{
    partial class frm_NhapSach
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
            this.cbbNhaXuatBan = new System.Windows.Forms.ComboBox();
            this.txtNhapTenSach = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtNhapMaSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbTheLoai = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNhapSach = new System.Windows.Forms.Button();
            this.btnHuySach = new System.Windows.Forms.Button();
            this.btnSuaSach = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnKhongGhi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvChiTietNhapSach = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietNhapSach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKhongGhi);
            this.groupBox1.Controls.Add(this.btnGhi);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.dateNgayNhap);
            this.groupBox1.Controls.Add(this.cbbTheLoai);
            this.groupBox1.Controls.Add(this.cbbNhaXuatBan);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtNhapTenSach);
            this.groupBox1.Controls.Add(this.txtTacGia);
            this.groupBox1.Controls.Add(this.txtNhapMaSach);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách";
            // 
            // cbbNhaXuatBan
            // 
            this.cbbNhaXuatBan.FormattingEnabled = true;
            this.cbbNhaXuatBan.Location = new System.Drawing.Point(310, 63);
            this.cbbNhaXuatBan.Name = "cbbNhaXuatBan";
            this.cbbNhaXuatBan.Size = new System.Drawing.Size(173, 21);
            this.cbbNhaXuatBan.TabIndex = 2;
            // 
            // txtNhapTenSach
            // 
            this.txtNhapTenSach.Location = new System.Drawing.Point(309, 24);
            this.txtNhapTenSach.Name = "txtNhapTenSach";
            this.txtNhapTenSach.Size = new System.Drawing.Size(174, 20);
            this.txtNhapTenSach.TabIndex = 1;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(79, 63);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(142, 20);
            this.txtTacGia.TabIndex = 1;
            // 
            // txtNhapMaSach
            // 
            this.txtNhapMaSach.Location = new System.Drawing.Point(79, 24);
            this.txtNhapMaSach.Name = "txtNhapMaSach";
            this.txtNhapMaSach.Size = new System.Drawing.Size(100, 20);
            this.txtNhapMaSach.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sách:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nhà xuất bản :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tác giả :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sách :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "NHẬP SÁCH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thể loại :";
            // 
            // cbbTheLoai
            // 
            this.cbbTheLoai.FormattingEnabled = true;
            this.cbbTheLoai.Location = new System.Drawing.Point(230, 101);
            this.cbbTheLoai.Name = "cbbTheLoai";
            this.cbbTheLoai.Size = new System.Drawing.Size(84, 21);
            this.cbbTheLoai.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(79, 101);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(76, 20);
            this.txtSoLuong.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày nhập :";
            // 
            // dateNgayNhap
            // 
            this.dateNgayNhap.Location = new System.Drawing.Point(404, 102);
            this.dateNgayNhap.Name = "dateNgayNhap";
            this.dateNgayNhap.Size = new System.Drawing.Size(201, 20);
            this.dateNgayNhap.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSuaSach);
            this.panel1.Controls.Add(this.btnHuySach);
            this.panel1.Controls.Add(this.btnNhapSach);
            this.panel1.Location = new System.Drawing.Point(628, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(87, 98);
            this.panel1.TabIndex = 4;
            // 
            // btnNhapSach
            // 
            this.btnNhapSach.Location = new System.Drawing.Point(6, 9);
            this.btnNhapSach.Name = "btnNhapSach";
            this.btnNhapSach.Size = new System.Drawing.Size(75, 23);
            this.btnNhapSach.TabIndex = 0;
            this.btnNhapSach.Text = "Nhập sách";
            this.btnNhapSach.UseVisualStyleBackColor = true;
            // 
            // btnHuySach
            // 
            this.btnHuySach.Location = new System.Drawing.Point(6, 38);
            this.btnHuySach.Name = "btnHuySach";
            this.btnHuySach.Size = new System.Drawing.Size(75, 23);
            this.btnHuySach.TabIndex = 0;
            this.btnHuySach.Text = "Hủy Sách";
            this.btnHuySach.UseVisualStyleBackColor = true;
            // 
            // btnSuaSach
            // 
            this.btnSuaSach.Location = new System.Drawing.Point(6, 67);
            this.btnSuaSach.Name = "btnSuaSach";
            this.btnSuaSach.Size = new System.Drawing.Size(75, 23);
            this.btnSuaSach.TabIndex = 0;
            this.btnSuaSach.Text = "Sửa Sách";
            this.btnSuaSach.UseVisualStyleBackColor = true;
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(756, 43);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(80, 23);
            this.btnGhi.TabIndex = 5;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            // 
            // btnKhongGhi
            // 
            this.btnKhongGhi.Location = new System.Drawing.Point(756, 76);
            this.btnKhongGhi.Name = "btnKhongGhi";
            this.btnKhongGhi.Size = new System.Drawing.Size(80, 23);
            this.btnKhongGhi.TabIndex = 5;
            this.btnKhongGhi.Text = "Không Ghi";
            this.btnKhongGhi.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvChiTietNhapSach);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(912, 277);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết nhập sách";
            // 
            // dtgvChiTietNhapSach
            // 
            this.dtgvChiTietNhapSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietNhapSach.Location = new System.Drawing.Point(6, 19);
            this.dtgvChiTietNhapSach.Name = "dtgvChiTietNhapSach";
            this.dtgvChiTietNhapSach.Size = new System.Drawing.Size(900, 252);
            this.dtgvChiTietNhapSach.TabIndex = 0;
            // 
            // frm_NhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 488);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_NhapSach";
            this.Text = "frm_NhapSach";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietNhapSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbNhaXuatBan;
        private System.Windows.Forms.TextBox txtNhapTenSach;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtNhapMaSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKhongGhi;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSuaSach;
        private System.Windows.Forms.Button btnHuySach;
        private System.Windows.Forms.Button btnNhapSach;
        private System.Windows.Forms.DateTimePicker dateNgayNhap;
        private System.Windows.Forms.ComboBox cbbTheLoai;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvChiTietNhapSach;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}