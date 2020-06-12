using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Test_Mot_Chut
{
    public partial class FormLogIn : Form
    {
        ConnectionStringSettings conSet = ConfigurationManager.ConnectionStrings["MyDBConnectionString"];
        public static string[] arrchucVu;
        public static string maNV;
        public FormLogIn()
        {
            InitializeComponent();
        }
        #region Khi nhap, tha chuot vao cac o Text: Enter la nhan vao, Leave la tha chuot ra
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtDangNhap.Text = "";
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtMatKhau.Text = "";
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if(txtMatKhau.Text == "")
            {
                txtMatKhau.Text = "Password";
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtDangNhap.Text == "")
            {
                txtDangNhap.Text = "Username";
            }
        }

        #endregion 

       
        
         
        // Nhan vao link dang ki (New Register) hien bang dang ki (Sign Up)
        private void linkLBNewRegis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            FormSignUp form3 = new FormSignUp();
            form3.ShowDialog();
            this.Visible = true;
        }

        // Kiem tra thong tin dang nhap co trong csdl khong
        private void btnLogin_Click(object sender, EventArgs e)
        {
            while (true)
            {
                #region Kiểm tra nhập đủ email và pass chưa
                if (txtDangNhap.Text == "Email")
                {
                    MessageBox.Show("Chưa nhập email");
                    break;
                }

                if (txtMatKhau.Text == "Mật Khẩu")
                {
                    MessageBox.Show("Chưa nhập mật khẩu");
                    break;
                }
                #endregion

                string source = conSet.ConnectionString;
                SqlConnection cn = new SqlConnection(source);
                cn.Open();

                SqlCommand cmd_Check = new SqlCommand("select * from DangNhap where email = '" + txtDangNhap.Text + "' and matKhau = '" + txtMatKhau.Text + "'", cn);
                SqlDataReader dr_Check;
                dr_Check = cmd_Check.ExecuteReader();
                int dem = 0;
                while (dr_Check.Read())
                {
                    dem += 1;
                }
                dr_Check.Close();

                if (dem == 1)
                {
                    string query_chucVu = "SELECT MaChucVu FROM dbo.NhanVien WHERE Email = '" + txtDangNhap.Text + "'";
                    string query_maNV = "SELECT MaNV FROM dbo.NhanVien WHERE Email = '" + txtDangNhap.Text + "'";
                    SqlCommand cmd_ChucVu = new SqlCommand(query_chucVu, cn);
                    SqlCommand cmd_maNV = new SqlCommand(query_maNV, cn);

                    string chucVu = (string)cmd_ChucVu.ExecuteScalar();
                    arrchucVu = chucVu.Split(' ');
                    maNV = (string)cmd_maNV.ExecuteScalar();
                    this.Hide();
                    FormMain fMain = new FormMain();
                    fMain.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai !");
                }

                cn.Close();
                break;
            }   
        }

        private void btnTurnOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLBForgotPassw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            FormVerifyCode fvc = new FormVerifyCode();
            fvc.ShowDialog();
            this.Visible = true;
        }
    }
}
