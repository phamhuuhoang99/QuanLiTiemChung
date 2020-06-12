using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Mot_Chut
{
    public partial class FormChangePassWord : Form
    {
        ConnectionStringSettings conSet = ConfigurationManager.ConnectionStrings["MyDBConnectionString"];
        string email = FormVerifyCode.to;
        public FormChangePassWord()
        {
            InitializeComponent();
        }

        #region nhấp,rời chuột các textbox
        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if(txtMatKhau.Text == "")
            {
                txtMatKhau.Text = "Mật khẩu mới";
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật khẩu mới")
            {
                txtMatKhau.Text = "";
            }
        }

        private void txtNhapLai_Leave(object sender, EventArgs e)
        {
            if (txtNhapLai.Text == "")
            {
                txtNhapLai.Text = "Nhập lại mật khẩu mới";
            }
        }

        private void txtNhapLai_Enter(object sender, EventArgs e)
        {
            if (txtNhapLai.Text == "Nhập lại mật khẩu mới")
            {
                txtNhapLai.Text = "";
            }
        }
        #endregion

        private void btnOK_Click(object sender, EventArgs e)
        {
            string source = conSet.ConnectionString;
            SqlConnection cn = new SqlConnection(source);
            while (true)
            {
                if (txtMatKhau.Text != txtNhapLai.Text)
                {
                    errorNhapSai.SetError(txtNhapLai, "Mật khẩu nhập lại không trùng khớp");
                    break;
                }
                cn.Open();
                string qry = "UPDATE dbo.DangNhap SET matKhau = '" + txtNhapLai.Text + "' WHERE email = '" + email + "'";
                SqlCommand cmd = new SqlCommand(qry, cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đổi mật khẩu thành công");
                cn.Close();
                this.Close();
                FormLogIn fli = new FormLogIn();
                fli.ShowDialog();
                break;
            }


            
  

        }
    }
}
