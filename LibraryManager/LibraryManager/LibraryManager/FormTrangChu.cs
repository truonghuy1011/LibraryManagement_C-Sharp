using System;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class FormTrangChu : Form
    {
        private Form activeform = null;

        public FormTrangChu()
        {
            InitializeComponent();
            OpenChildrenForm(new FormDangNhap());
        }

        private void buttonTaiKhoan_Click(object sender, EventArgs e)
        {
            
            
        }

        private void buttonQuanlyMuonTra_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonThongKe_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonThongTin_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonQuanLySach_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonQuanLyDocGia_Click(object sender, EventArgs e)
        {
            
        }

        private void OpenChildrenForm(Form childrenForm)
        {
            if (this.activeform != null)
            {
                activeform.Close();
            }
            activeform = childrenForm;
            childrenForm.TopLevel = false;
            childrenForm.FormBorderStyle = FormBorderStyle.None;
            childrenForm.Dock = DockStyle.Fill;
            panel4.Controls.Add(childrenForm);
            panel4.Tag = childrenForm;
            childrenForm.BringToFront();
            childrenForm.Show();
        }

        private void buttonTKThongTin_Click(object sender, EventArgs e)
        {
            OpenChildrenForm(new FormThongTin());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label3.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
