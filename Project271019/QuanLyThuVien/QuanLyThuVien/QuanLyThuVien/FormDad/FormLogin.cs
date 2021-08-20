using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FormDangNhap : Form
    {
        private int mouseStas;
        private int mouseX;
        private int mouseY;
        private string urlDB;
        private string userName;
        private string userPass;

        public FormDangNhap()
        {
            InitializeComponent();
            this.checkBoxNhanVien.Checked = true;
            VisibleLable();
            pictureBoxShow.Visible = true;
        }
        
        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            string userNameIn = textBoxUserName.Text;
            string userPassIn = EncodeString(textBoxUserPass.Text);

            if (TextBoxEmpty(textBoxUserName.Text, textBoxUserPass.Text))
            {
                ClassConnectDB.ConnectLink connect = new ClassConnectDB.ConnectLink();
                this.urlDB = connect.GetConnectLink();

                if (checkBoxNhanVien.Checked == true)
                {
                    String query = "SELECT * FROM dbo.TaiKhoanNV WHERE maNV = " + "'" + userNameIn + "'";
                    ConnectTableReader(userNameIn, query);
                    if (AccountReliable(userNameIn, userPassIn))
                    {
                        this.Hide();
                        new FormDad.FormPerson().ShowDialog();
                    }
                }
                if (checkBoxDocGia.Checked == true)
                {
                    String query = "SELECT * FROM dbo.TaiKhoanDG WHERE maDG = " + "'" + userNameIn + "'";
                    ConnectTableReader(userNameIn, query);
                    if (AccountReliable(userNameIn, userPassIn))
                    {
                        this.Hide();
                        new FormDad.FormGuest().ShowDialog();
                    }
                }
                ReFreshProperty();
                this.Show();
            }
            else
            {
                MessageBox.Show("Hãy Điền Thông Tin Đăng Nhập.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ReFreshProperty()
        {
            this.userName = null;
            this.userPass = null;
            this.urlDB = null;
        }

        private bool TextBoxEmpty(string txtUser,string txtPass)
        {
            if(txtUser == "")
            {
                return false;
            }
            if(txtPass == "")
            {
                return false;
            }
            return true;
        }

        private bool AccountReliable(string userNameIn, string userPassIn)
        {
            if(this.userName == null)
            {
                MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Đúng!\n Hãy Kiểm Tra Lại.","Chú Ý!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }

            if (String.Compare(this.userPass, userPassIn) != 0)
            {
                MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Đúng!\n Hãy Kiểm Tra Lại.", "Chú Ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ConnectTableReader(string maDangNhap, string queryData)
        {
            using (System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(this.urlDB))
            {
                sqlConnection.Open();
                //MessageBox.Show("connecting to opening");
                System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(queryData, sqlConnection);
                System.Data.SqlClient.SqlDataReader dataReader = command.ExecuteReader();
                                
                try
                {
                    dataReader.Read();
                    this.userName = dataReader.GetValue(0) + "";
                    this.userPass = dataReader.GetValue(1) + "";
                }
                catch (Exception e)
                {

                }
                
                sqlConnection.Close();
            }
        }

        private string EncodeString(string strPasswork)
        {
            System.Security.Cryptography.MD5 mh = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(strPasswork);
            byte[] hash = mh.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            
            return sb.ToString();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxNhanVien_MouseCaptureChanged(object sender, EventArgs e)
        {
            checkBoxNhanVien.Checked = true;
            checkBoxDocGia.Checked = false;
        }

        private void checkBoxDocGia_MouseCaptureChanged(object sender, EventArgs e)
        {
            checkBoxNhanVien.Checked = false;
            checkBoxDocGia.Checked = true;
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

        private void VisibleLable()
        {
            pictureBoxShow.Visible = false;
            pictureBoxHide.Visible = false;
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            VisibleLable();
            pictureBoxHide.Visible = true;
            textBoxUserPass.PasswordChar = '\0';
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            VisibleLable();
            pictureBoxShow.Visible = true;
            textBoxUserPass.PasswordChar = '•';
        }
    }
}
