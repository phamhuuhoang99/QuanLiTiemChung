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
    public partial class FormSignUp : Form
    {
        ConnectionStringSettings conSet = ConfigurationManager.ConnectionStrings["MyDBConnectionString"];
        string maNV;
        public FormSignUp()
        {
            InitializeComponent();
        }

        #region Nhấp,rời chuột các textbox
        private void txtDangNhap_Enter(object sender, EventArgs e)
        {
            if (txtDangNhap.Text == "Tên Đăng Nhập")
            {
                txtDangNhap.Text = "";
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật Khẩu")
            {
                txtMatKhau.Text = "";
            }
        }

        private void txtDangNhap_Leave(object sender, EventArgs e)
        {
            if (txtDangNhap.Text == "")
            {
                txtDangNhap.Text = "Tên Đăng Nhập";
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.Text = "Mật Khẩu";
            }
        }

        private void txtHoVaTen_Enter(object sender, EventArgs e)
        {
            if (txtHoVaTen.Text == "Họ Và Tên")
            {
                txtHoVaTen.Text = "";
            }
        }

        private void txtHoVaTen_Leave(object sender, EventArgs e)
        {
            if (txtHoVaTen.Text == "")
            {
                txtHoVaTen.Text = "Họ Và Tên";
            }
        }

        

        private void txtQueQuan_Leave(object sender, EventArgs e)
        {
            if (txtQueQuan.Text == "")
            {
                txtQueQuan.Text = "Quê Quán";
            }
        }

        private void txtQueQuan_Enter(object sender, EventArgs e)
        {
            if (txtQueQuan.Text == "Quê Quán")
            {
                txtQueQuan.Text = "";
            }
        }      

        private void txtSDT_Enter(object sender, EventArgs e)
        {
            if (txtSDT.Text == "Số Điện Thoại")
            {
                txtSDT.Text = "";
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text == "")
            {
                txtSDT.Text = "Số Điện Thoại";
            }
        }

        private void txtMaNV_Enter(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "Mã Nhân Viên")
            {
                txtMaNV.Text = "";
            }
        }

        private void txtMaNV_Leave(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                txtMaNV.Text = "Mã Nhân Viên";
            }
        }
        #endregion





        // Them thong tin cac o Text vao bang SQL 
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string source = conSet.ConnectionString;
            SqlConnection cn = new SqlConnection(source);
            cn.Open();
            while (true)
            {
                if (txtDangNhap.Text == "Tên Đăng Nhập" || txtMatKhau.Text == "Mật Khẩu" || txtHoVaTen.Text == "Họ Và Tên" || cbxChucVu.Text == "Chức Vụ")
                {
                    MessageBox.Show("Điền đầy đủ những mục có dấu *");
                    break;
                }

                int dem_TenDangNhap = 0;

               

                #region Kiểm tra trùng email
                SqlCommand cmd_CheckTenDangNhap = new SqlCommand("select * from DangNhap where email = '" + txtDangNhap.Text + "'", cn);
                SqlDataReader dr_CheckTenDangNhap;
                dr_CheckTenDangNhap = cmd_CheckTenDangNhap.ExecuteReader();
                while (dr_CheckTenDangNhap.Read())
                {
                    dem_TenDangNhap += 1;
                }
                if (dem_TenDangNhap >= 1)
                {
                    MessageBox.Show("Email đã được đăng kí");
                    cn.Close();
                    break;
                }  
                dr_CheckTenDangNhap.Close();
                #endregion

                // Nếu k trùng email
                if(dem_TenDangNhap < 1)
                {
                    String qry_1 = "insert into DangNhap (email,matKhau) values ('" + txtDangNhap.Text + "','" + txtMatKhau.Text + "')";
                    SqlCommand cmd_1 = new SqlCommand(qry_1, cn);
                    cmd_1.ExecuteNonQuery();

                    string[] maCV = cbxChucVu.Text.Split(new char[] { ' ' });

                    string ngaySinh_Temp = dtNgaySinh.Value.ToShortDateString();
                    string[] nSinh = ngaySinh_Temp.Split(new char[] { '/' });
                    string namSinh = string.Concat(nSinh[2], "-", nSinh[0]);
                    string ngaySinh = string.Concat(namSinh, "-", nSinh[1]);

                    string ngayVaoLam_Temp = dtNgayVaoLam.Value.ToShortDateString();
                    string[] nVaoLam = ngayVaoLam_Temp.Split(new char[] { '/' });
                    string namVaoLam = string.Concat(nVaoLam[2], "-", nVaoLam[0]);
                    string ngayVaoLam = string.Concat(namVaoLam, "-", nVaoLam[1]);

                    String qry_2 = "insert into dbo.NhanVien( MaNV ,HoTen ,Email ,NgaySinh ,QueQuan ,NgayVaoLam ,GioiTinh ,SDT ,MaChucVu) " +
                        "VALUES  ('" + maNV + "',N'" + txtHoVaTen.Text + "','" + txtDangNhap.Text + "','" + ngaySinh + "', N'" + txtQueQuan.Text + "' ,'" + ngayVaoLam + "',N'" + cbxGioiTinh.Text + "','" + txtSDT.Text + "','" + maCV[0] + "')";
                    SqlCommand cmd_2 = new SqlCommand(qry_2, cn);
                    cmd_2.ExecuteNonQuery();

                    String qry_3 = "INSERT INTO dbo.ThanhTich( maNV, soKH ) VALUES  ( '" + maNV + "', 0  )";
                    SqlCommand cmd_3 = new SqlCommand(qry_3, cn);
                    cmd_3.ExecuteNonQuery();
                    MessageBox.Show("Đăng kí thành công");
                    cn.Close();
                    this.Close();
                    FormLogIn fli = new FormLogIn();
                    fli.ShowDialog();
                    break;
                }
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxChucVu_TextChanged(object sender, EventArgs e)
        {
            string source = conSet.ConnectionString;
            SqlConnection cn = new SqlConnection(source);
            cn.Open();

            string[] maCV = cbxChucVu.Text.Split(new char[] { ' ' });

            SqlCommand cmd_MaNV = new SqlCommand("select count(*) from NhanVien where MaChucVu = '" + maCV[0] + "'",cn);
            string soNVdangco;
            if((int)(cmd_MaNV.ExecuteScalar()) + 1 < 10)
            {
                soNVdangco = string.Concat("0", ((int)(cmd_MaNV.ExecuteScalar()) + 1).ToString());
            }
            else soNVdangco = ((int)(cmd_MaNV.ExecuteScalar()) + 1).ToString();
            maNV = string.Concat(maCV[0], soNVdangco);
            txtMaNV.Text = maNV;
            cn.Close();
        }
    }
}
