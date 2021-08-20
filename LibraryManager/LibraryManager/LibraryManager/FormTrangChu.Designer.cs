namespace LibraryManager
{
    partial class FormTrangChu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrangChu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonThongTin = new System.Windows.Forms.Button();
            this.buttonThongKe = new System.Windows.Forms.Button();
            this.buttonQuanLySach = new System.Windows.Forms.Button();
            this.buttonQuanLyDocGia = new System.Windows.Forms.Button();
            this.buttonQuanlyMuonTra = new System.Windows.Forms.Button();
            this.buttonTaiKhoan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(0)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.buttonThongTin);
            this.panel1.Controls.Add(this.buttonThongKe);
            this.panel1.Controls.Add(this.buttonQuanLySach);
            this.panel1.Controls.Add(this.buttonQuanLyDocGia);
            this.panel1.Controls.Add(this.buttonQuanlyMuonTra);
            this.panel1.Controls.Add(this.buttonTaiKhoan);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 436);
            this.panel1.TabIndex = 0;
            // 
            // buttonThongTin
            // 
            this.buttonThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonThongTin.FlatAppearance.BorderSize = 0;
            this.buttonThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonThongTin.Image = ((System.Drawing.Image)(resources.GetObject("buttonThongTin.Image")));
            this.buttonThongTin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThongTin.Location = new System.Drawing.Point(0, 358);
            this.buttonThongTin.Name = "buttonThongTin";
            this.buttonThongTin.Size = new System.Drawing.Size(238, 50);
            this.buttonThongTin.TabIndex = 9;
            this.buttonThongTin.Text = "Thông tin";
            this.buttonThongTin.UseVisualStyleBackColor = true;
            this.buttonThongTin.Click += new System.EventHandler(this.buttonThongTin_Click);
            // 
            // buttonThongKe
            // 
            this.buttonThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(0)))), ((int)(((byte)(31)))));
            this.buttonThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonThongKe.FlatAppearance.BorderSize = 0;
            this.buttonThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThongKe.ForeColor = System.Drawing.Color.White;
            this.buttonThongKe.Image = ((System.Drawing.Image)(resources.GetObject("buttonThongKe.Image")));
            this.buttonThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThongKe.Location = new System.Drawing.Point(0, 308);
            this.buttonThongKe.Name = "buttonThongKe";
            this.buttonThongKe.Size = new System.Drawing.Size(238, 50);
            this.buttonThongKe.TabIndex = 7;
            this.buttonThongKe.Text = "Thống kê";
            this.buttonThongKe.UseVisualStyleBackColor = false;
            this.buttonThongKe.Click += new System.EventHandler(this.buttonThongKe_Click);
            // 
            // buttonQuanLySach
            // 
            this.buttonQuanLySach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(0)))), ((int)(((byte)(31)))));
            this.buttonQuanLySach.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonQuanLySach.FlatAppearance.BorderSize = 0;
            this.buttonQuanLySach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuanLySach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuanLySach.ForeColor = System.Drawing.Color.White;
            this.buttonQuanLySach.Image = ((System.Drawing.Image)(resources.GetObject("buttonQuanLySach.Image")));
            this.buttonQuanLySach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuanLySach.Location = new System.Drawing.Point(0, 258);
            this.buttonQuanLySach.Name = "buttonQuanLySach";
            this.buttonQuanLySach.Size = new System.Drawing.Size(238, 50);
            this.buttonQuanLySach.TabIndex = 5;
            this.buttonQuanLySach.Text = "Quản lý sách";
            this.buttonQuanLySach.UseVisualStyleBackColor = false;
            this.buttonQuanLySach.Click += new System.EventHandler(this.buttonQuanLySach_Click);
            // 
            // buttonQuanLyDocGia
            // 
            this.buttonQuanLyDocGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(0)))), ((int)(((byte)(31)))));
            this.buttonQuanLyDocGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonQuanLyDocGia.FlatAppearance.BorderSize = 0;
            this.buttonQuanLyDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuanLyDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuanLyDocGia.ForeColor = System.Drawing.Color.White;
            this.buttonQuanLyDocGia.Image = ((System.Drawing.Image)(resources.GetObject("buttonQuanLyDocGia.Image")));
            this.buttonQuanLyDocGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuanLyDocGia.Location = new System.Drawing.Point(0, 208);
            this.buttonQuanLyDocGia.Name = "buttonQuanLyDocGia";
            this.buttonQuanLyDocGia.Size = new System.Drawing.Size(238, 50);
            this.buttonQuanLyDocGia.TabIndex = 4;
            this.buttonQuanLyDocGia.Text = "Quản lý đọc giả";
            this.buttonQuanLyDocGia.UseVisualStyleBackColor = false;
            this.buttonQuanLyDocGia.Click += new System.EventHandler(this.buttonQuanLyDocGia_Click);
            // 
            // buttonQuanlyMuonTra
            // 
            this.buttonQuanlyMuonTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(0)))), ((int)(((byte)(31)))));
            this.buttonQuanlyMuonTra.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonQuanlyMuonTra.FlatAppearance.BorderSize = 0;
            this.buttonQuanlyMuonTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuanlyMuonTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuanlyMuonTra.ForeColor = System.Drawing.Color.White;
            this.buttonQuanlyMuonTra.Image = ((System.Drawing.Image)(resources.GetObject("buttonQuanlyMuonTra.Image")));
            this.buttonQuanlyMuonTra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuanlyMuonTra.Location = new System.Drawing.Point(0, 158);
            this.buttonQuanlyMuonTra.Name = "buttonQuanlyMuonTra";
            this.buttonQuanlyMuonTra.Size = new System.Drawing.Size(238, 50);
            this.buttonQuanlyMuonTra.TabIndex = 3;
            this.buttonQuanlyMuonTra.Text = "Quản lý mượn trả";
            this.buttonQuanlyMuonTra.UseVisualStyleBackColor = false;
            this.buttonQuanlyMuonTra.Click += new System.EventHandler(this.buttonQuanlyMuonTra_Click);
            // 
            // buttonTaiKhoan
            // 
            this.buttonTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(0)))), ((int)(((byte)(31)))));
            this.buttonTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTaiKhoan.FlatAppearance.BorderSize = 0;
            this.buttonTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.buttonTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("buttonTaiKhoan.Image")));
            this.buttonTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTaiKhoan.Location = new System.Drawing.Point(0, 108);
            this.buttonTaiKhoan.Name = "buttonTaiKhoan";
            this.buttonTaiKhoan.Size = new System.Drawing.Size(238, 50);
            this.buttonTaiKhoan.TabIndex = 1;
            this.buttonTaiKhoan.Text = "Tài khoản";
            this.buttonTaiKhoan.UseVisualStyleBackColor = false;
            this.buttonTaiKhoan.Click += new System.EventHandler(this.buttonTaiKhoan_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 108);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(98, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "UTC2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(82, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Library";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(4, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 1);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(239, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(723, 413);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(244, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(827, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hãy đăng nhập";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(3, 0);
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1006, 315);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý thư viện";
            this.Load += new System.EventHandler(this.FormTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonTaiKhoan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonQuanlyMuonTra;
        private System.Windows.Forms.Button buttonQuanLyDocGia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonQuanLySach;
        private System.Windows.Forms.Button buttonThongKe;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonThongTin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

