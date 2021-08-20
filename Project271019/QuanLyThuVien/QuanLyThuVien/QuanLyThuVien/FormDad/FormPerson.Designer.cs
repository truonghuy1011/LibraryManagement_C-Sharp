namespace QuanLyThuVien.FormDad
{
    partial class FormPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerson));
            this.panelToppic = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelOption = new System.Windows.Forms.Panel();
            this.labelLinkInfor = new System.Windows.Forms.Label();
            this.buttonQuanTriVien = new System.Windows.Forms.Button();
            this.buttonThongKe = new System.Windows.Forms.Button();
            this.buttonQuanLyPhieu = new System.Windows.Forms.Button();
            this.buttonDocGia = new System.Windows.Forms.Button();
            this.buttonQuanLySach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFormChildren = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelInforUser = new System.Windows.Forms.Panel();
            this.pictureBoxThongTin = new System.Windows.Forms.PictureBox();
            this.labelClaim = new System.Windows.Forms.Label();
            this.labelNameUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxDoiMatKhau = new System.Windows.Forms.PictureBox();
            this.pictureBoxDangXuat = new System.Windows.Forms.PictureBox();
            this.panelToppic.SuspendLayout();
            this.panelOption.SuspendLayout();
            this.panelInforUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThongTin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoiMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDangXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToppic
            // 
            this.panelToppic.BackColor = System.Drawing.SystemColors.Control;
            this.panelToppic.Controls.Add(this.buttonMinimize);
            this.panelToppic.Controls.Add(this.buttonClose);
            this.panelToppic.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToppic.Location = new System.Drawing.Point(0, 0);
            this.panelToppic.Name = "panelToppic";
            this.panelToppic.Size = new System.Drawing.Size(1152, 26);
            this.panelToppic.TabIndex = 0;
            this.panelToppic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelToppic_MouseDown);
            this.panelToppic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelToppic_MouseMove);
            this.panelToppic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelToppic_MouseUp);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.Image")));
            this.buttonMinimize.Location = new System.Drawing.Point(1047, 1);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(52, 24);
            this.buttonMinimize.TabIndex = 3;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(1099, 1);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(52, 24);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelOption
            // 
            this.panelOption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOption.Controls.Add(this.labelLinkInfor);
            this.panelOption.Controls.Add(this.buttonQuanTriVien);
            this.panelOption.Controls.Add(this.buttonThongKe);
            this.panelOption.Controls.Add(this.buttonQuanLyPhieu);
            this.panelOption.Controls.Add(this.buttonDocGia);
            this.panelOption.Controls.Add(this.buttonQuanLySach);
            this.panelOption.Controls.Add(this.label1);
            this.panelOption.Location = new System.Drawing.Point(12, 96);
            this.panelOption.Name = "panelOption";
            this.panelOption.Size = new System.Drawing.Size(198, 479);
            this.panelOption.TabIndex = 1;
            // 
            // labelLinkInfor
            // 
            this.labelLinkInfor.AutoSize = true;
            this.labelLinkInfor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLinkInfor.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLinkInfor.ForeColor = System.Drawing.Color.Blue;
            this.labelLinkInfor.Location = new System.Drawing.Point(59, 430);
            this.labelLinkInfor.Name = "labelLinkInfor";
            this.labelLinkInfor.Size = new System.Drawing.Size(74, 13);
            this.labelLinkInfor.TabIndex = 0;
            this.labelLinkInfor.Text = "Infomations!";
            this.labelLinkInfor.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.labelLinkInfor.MouseLeave += new System.EventHandler(this.labelLinkInfor_MouseLeave);
            // 
            // buttonQuanTriVien
            // 
            this.buttonQuanTriVien.BackColor = System.Drawing.Color.LightGreen;
            this.buttonQuanTriVien.FlatAppearance.BorderSize = 0;
            this.buttonQuanTriVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuanTriVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuanTriVien.Image = ((System.Drawing.Image)(resources.GetObject("buttonQuanTriVien.Image")));
            this.buttonQuanTriVien.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonQuanTriVien.Location = new System.Drawing.Point(21, 346);
            this.buttonQuanTriVien.Name = "buttonQuanTriVien";
            this.buttonQuanTriVien.Size = new System.Drawing.Size(153, 74);
            this.buttonQuanTriVien.TabIndex = 6;
            this.buttonQuanTriVien.Text = "Quản Trị Viên";
            this.buttonQuanTriVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonQuanTriVien.UseVisualStyleBackColor = false;
            this.buttonQuanTriVien.Click += new System.EventHandler(this.buttonQuanTriVien_Click);
            // 
            // buttonThongKe
            // 
            this.buttonThongKe.BackColor = System.Drawing.Color.LightGreen;
            this.buttonThongKe.FlatAppearance.BorderSize = 0;
            this.buttonThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThongKe.Image = ((System.Drawing.Image)(resources.GetObject("buttonThongKe.Image")));
            this.buttonThongKe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonThongKe.Location = new System.Drawing.Point(21, 271);
            this.buttonThongKe.Name = "buttonThongKe";
            this.buttonThongKe.Size = new System.Drawing.Size(153, 74);
            this.buttonThongKe.TabIndex = 5;
            this.buttonThongKe.Text = "Thống Kê";
            this.buttonThongKe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonThongKe.UseVisualStyleBackColor = false;
            this.buttonThongKe.Click += new System.EventHandler(this.buttonThongKe_Click);
            // 
            // buttonQuanLyPhieu
            // 
            this.buttonQuanLyPhieu.BackColor = System.Drawing.Color.LightGreen;
            this.buttonQuanLyPhieu.FlatAppearance.BorderSize = 0;
            this.buttonQuanLyPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuanLyPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuanLyPhieu.Image = ((System.Drawing.Image)(resources.GetObject("buttonQuanLyPhieu.Image")));
            this.buttonQuanLyPhieu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonQuanLyPhieu.Location = new System.Drawing.Point(21, 196);
            this.buttonQuanLyPhieu.Name = "buttonQuanLyPhieu";
            this.buttonQuanLyPhieu.Size = new System.Drawing.Size(153, 74);
            this.buttonQuanLyPhieu.TabIndex = 4;
            this.buttonQuanLyPhieu.Text = "Quản Lý Phiếu";
            this.buttonQuanLyPhieu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonQuanLyPhieu.UseVisualStyleBackColor = false;
            this.buttonQuanLyPhieu.Click += new System.EventHandler(this.buttonQuanLyPhieu_Click);
            // 
            // buttonDocGia
            // 
            this.buttonDocGia.BackColor = System.Drawing.Color.LightGreen;
            this.buttonDocGia.FlatAppearance.BorderSize = 0;
            this.buttonDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDocGia.Image = ((System.Drawing.Image)(resources.GetObject("buttonDocGia.Image")));
            this.buttonDocGia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDocGia.Location = new System.Drawing.Point(21, 121);
            this.buttonDocGia.Name = "buttonDocGia";
            this.buttonDocGia.Size = new System.Drawing.Size(153, 74);
            this.buttonDocGia.TabIndex = 3;
            this.buttonDocGia.Text = "Đọc Giả";
            this.buttonDocGia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDocGia.UseVisualStyleBackColor = false;
            this.buttonDocGia.Click += new System.EventHandler(this.buttonDocGia_Click);
            // 
            // buttonQuanLySach
            // 
            this.buttonQuanLySach.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonQuanLySach.FlatAppearance.BorderSize = 0;
            this.buttonQuanLySach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuanLySach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuanLySach.Image = ((System.Drawing.Image)(resources.GetObject("buttonQuanLySach.Image")));
            this.buttonQuanLySach.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonQuanLySach.Location = new System.Drawing.Point(21, 46);
            this.buttonQuanLySach.Name = "buttonQuanLySach";
            this.buttonQuanLySach.Size = new System.Drawing.Size(153, 74);
            this.buttonQuanLySach.TabIndex = 2;
            this.buttonQuanLySach.Text = "Quản Lý Sách";
            this.buttonQuanLySach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonQuanLySach.UseVisualStyleBackColor = false;
            this.buttonQuanLySach.Click += new System.EventHandler(this.buttonQuanLySach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh Mục";
            // 
            // panelFormChildren
            // 
            this.panelFormChildren.Location = new System.Drawing.Point(212, 96);
            this.panelFormChildren.Name = "panelFormChildren";
            this.panelFormChildren.Size = new System.Drawing.Size(928, 479);
            this.panelFormChildren.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(293, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "PHẦN MỀM QUẢN LÝ THƯ VIỆN";
            // 
            // panelInforUser
            // 
            this.panelInforUser.Controls.Add(this.pictureBoxDangXuat);
            this.panelInforUser.Controls.Add(this.pictureBoxDoiMatKhau);
            this.panelInforUser.Controls.Add(this.pictureBoxThongTin);
            this.panelInforUser.Controls.Add(this.labelClaim);
            this.panelInforUser.Controls.Add(this.labelNameUser);
            this.panelInforUser.Controls.Add(this.pictureBox1);
            this.panelInforUser.Location = new System.Drawing.Point(883, 28);
            this.panelInforUser.Name = "panelInforUser";
            this.panelInforUser.Size = new System.Drawing.Size(257, 64);
            this.panelInforUser.TabIndex = 4;
            // 
            // pictureBoxThongTin
            // 
            this.pictureBoxThongTin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxThongTin.Image")));
            this.pictureBoxThongTin.Location = new System.Drawing.Point(229, 37);
            this.pictureBoxThongTin.Name = "pictureBoxThongTin";
            this.pictureBoxThongTin.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxThongTin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxThongTin.TabIndex = 6;
            this.pictureBoxThongTin.TabStop = false;
            this.pictureBoxThongTin.Click += new System.EventHandler(this.pictureBoxThongTin_Click);
            // 
            // labelClaim
            // 
            this.labelClaim.AutoSize = true;
            this.labelClaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClaim.Location = new System.Drawing.Point(73, 37);
            this.labelClaim.Name = "labelClaim";
            this.labelClaim.Size = new System.Drawing.Size(46, 16);
            this.labelClaim.TabIndex = 2;
            this.labelClaim.Text = "Admin";
            // 
            // labelNameUser
            // 
            this.labelNameUser.AutoSize = true;
            this.labelNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameUser.Location = new System.Drawing.Point(73, 13);
            this.labelNameUser.Name = "labelNameUser";
            this.labelNameUser.Size = new System.Drawing.Size(158, 16);
            this.labelNameUser.TabIndex = 1;
            this.labelNameUser.Text = "Nguyễn Hoàng Khánh An";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(44, 26);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLogo.TabIndex = 5;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxDoiMatKhau
            // 
            this.pictureBoxDoiMatKhau.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDoiMatKhau.Image")));
            this.pictureBoxDoiMatKhau.Location = new System.Drawing.Point(207, 37);
            this.pictureBoxDoiMatKhau.Name = "pictureBoxDoiMatKhau";
            this.pictureBoxDoiMatKhau.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxDoiMatKhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxDoiMatKhau.TabIndex = 7;
            this.pictureBoxDoiMatKhau.TabStop = false;
            this.pictureBoxDoiMatKhau.Click += new System.EventHandler(this.pictureBoxDoiMatKhau_Click);
            // 
            // pictureBoxDangXuat
            // 
            this.pictureBoxDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDangXuat.Image")));
            this.pictureBoxDangXuat.Location = new System.Drawing.Point(185, 37);
            this.pictureBoxDangXuat.Name = "pictureBoxDangXuat";
            this.pictureBoxDangXuat.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxDangXuat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxDangXuat.TabIndex = 7;
            this.pictureBoxDangXuat.TabStop = false;
            this.pictureBoxDangXuat.Click += new System.EventHandler(this.pictureBoxDangXuat_Click);
            // 
            // FormPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 587);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.panelInforUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelFormChildren);
            this.Controls.Add(this.panelOption);
            this.Controls.Add(this.panelToppic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.panelToppic.ResumeLayout(false);
            this.panelOption.ResumeLayout(false);
            this.panelOption.PerformLayout();
            this.panelInforUser.ResumeLayout(false);
            this.panelInforUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThongTin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoiMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDangXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelToppic;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Panel panelOption;
        private System.Windows.Forms.Button buttonQuanLySach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonQuanTriVien;
        private System.Windows.Forms.Button buttonThongKe;
        private System.Windows.Forms.Button buttonQuanLyPhieu;
        private System.Windows.Forms.Button buttonDocGia;
        private System.Windows.Forms.Panel panelFormChildren;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelInforUser;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelClaim;
        private System.Windows.Forms.Label labelNameUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLinkInfor;
        private System.Windows.Forms.PictureBox pictureBoxThongTin;
        private System.Windows.Forms.PictureBox pictureBoxDoiMatKhau;
        private System.Windows.Forms.PictureBox pictureBoxDangXuat;
    }
}