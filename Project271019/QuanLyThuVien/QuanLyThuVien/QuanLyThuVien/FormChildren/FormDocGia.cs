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
    public partial class FormDocGia : Form
    {
        public FormDocGia()
        {
            InitializeComponent();
            ReFreshSelect();
            radioButtonTimKiem1.Checked = true;
            labelTimKiem1.Visible = true;           
        }

        private void ReFreshSelect()
        {
            radioButtonTimKiem1.Checked = false;
            labelTimKiem1.Visible = false;
            labelTimKiem3.Visible = false;
            labelTimKiem2.Visible = false;
            comboBoxTimKiem2.Visible = false;
        }
        
        private void radioButtonTimKiem1_MouseCaptureChanged(object sender, EventArgs e)
        {
            ReFreshSelect();
            labelTimKiem1.Visible = true;
        }

        private void radioButtonTimKiem2_MouseCaptureChanged(object sender, EventArgs e)
        {
            ReFreshSelect();
            comboBoxTimKiem2.Visible = true;
            comboBoxTimKiem2.SelectedIndex = 0;
            labelTimKiem2.Visible = true;
            labelTimKiem2.Text = comboBoxTimKiem2.SelectedItem.ToString();
        }

        private void radioButtonTimKiem3_MouseCaptureChanged(object sender, EventArgs e)
        {
            ReFreshSelect();
            labelTimKiem3.Visible = true;
        }

        private void comboBoxTimKiem2_MouseCaptureChanged(object sender, EventArgs e)
        {
            labelTimKiem2.Text = comboBoxTimKiem2.SelectedItem.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
