using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.FormDad
{
    public partial class FormPerson : Form
    {
        private int mouseStas;
        private int mouseX;
        private int mouseY;
        private string userName;
        private Form activeForm = null;

        public FormPerson()
        {
            InitializeComponent();
            OpenChildrenForm(new FormChildren.FormQuanLySach());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonQuanLySach_Click(object sender, EventArgs e)
        {
            ReFreshForm();
            OpenChildrenForm(new FormChildren.FormQuanLySach());
            this.buttonQuanLySach.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void buttonDocGia_Click(object sender, EventArgs e)
        {
            ReFreshForm();
            OpenChildrenForm(new FormChildren.FormDocGia());
            this.buttonDocGia.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void buttonQuanLyPhieu_Click(object sender, EventArgs e)
        {
            ReFreshForm();
            OpenChildrenForm(new FormChildren.FormQuanLyPhieu());
            this.buttonQuanLyPhieu.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void buttonThongKe_Click(object sender, EventArgs e)
        {
            ReFreshForm();
            OpenChildrenForm(new FormChildren.FormThongKe());
            this.buttonThongKe.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void buttonQuanTriVien_Click(object sender, EventArgs e)
        {
            ReFreshForm();
            OpenChildrenForm(new FormChildren.FormQuanTri());
            this.buttonQuanTriVien.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void pictureBoxThongTin_Click(object sender, EventArgs e)
        {
            ReFreshForm();
            OpenChildrenForm(new FormChildren.FormThongTin());
        }

        private void ReFreshForm()
        {
            this.buttonDocGia.BackColor = System.Drawing.Color.LightGreen;
            this.buttonQuanLyPhieu.BackColor = System.Drawing.Color.LightGreen;
            this.buttonQuanLySach.BackColor = System.Drawing.Color.LightGreen;
            this.buttonThongKe.BackColor = System.Drawing.Color.LightGreen;
            this.buttonQuanTriVien.BackColor = System.Drawing.Color.LightGreen;
        }

        private void OpenChildrenForm(Form childrenForm)
        {
            if (this.activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childrenForm;
            childrenForm.TopLevel = false;
            childrenForm.FormBorderStyle = FormBorderStyle.None;
            childrenForm.Dock = DockStyle.Fill;
            panelFormChildren.Controls.Add(childrenForm);
            panelFormChildren.Tag = childrenForm;
            childrenForm.BringToFront();
            childrenForm.Show();
        }

        private void panelToppic_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseStas == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }

        private void panelToppic_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseStas = 1;
            this.mouseX = e.X;
            this.mouseY = e.Y;
        }

        private void panelToppic_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseStas = 0;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            this.labelLinkInfor.ForeColor = System.Drawing.Color.Red;
        }
        
        private void labelLinkInfor_MouseLeave(object sender, EventArgs e)
        {
            this.labelLinkInfor.ForeColor = System.Drawing.Color.Blue;
        }

        private void pictureBoxDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxDoiMatKhau_Click(object sender, EventArgs e)
        {
            new FormChildren.FormDoiMatKhau().ShowDialog();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
