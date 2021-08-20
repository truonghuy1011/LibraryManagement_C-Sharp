using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.FormChildren
{
    public partial class FormDoiMatKhau : Form
    {
        private int mouseStas;
        private int mouseX;
        private int mouseY;

        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void panelToppic_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseStas == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }
    }
}
