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
    public partial class FormCustomer : Form
    {
        ConnectionStringSettings conSet = ConfigurationManager.ConnectionStrings["MyDBConnectionString"];
        string maKH;
        public FormCustomer()
        {
            InitializeComponent();
        }

        #region Nhấp, bỏ chuột ra khỏi textbox
        private void txtTenKH_Leave(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "")
            {
                txtTenKH.Text = "Họ và Tên";
            }
        }

        private void txtTenKH_Enter(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "Họ và Tên")
            {
                txtTenKH.Text = "";
            }
        }

        private void txtCMND_Leave(object sender, EventArgs e)
        {
            if (txtCMND.Text == "")
            {
                txtCMND.Text = "Số CMND";
            }
        }

        private void txtCMND_Enter(object sender, EventArgs e)
        {
            if (txtCMND.Text == "Số CMND")
            {
                txtCMND.Text = "";
            }
        }

        private void txtTenBM_Leave(object sender, EventArgs e)
        {
            if (txtTenBM.Text == "")
            {
                txtTenBM.Text = "Tên Bố Mẹ ( < 8 tuổi )";
            }
        }

        private void txtTenBM_Enter(object sender, EventArgs e)
        {
            if (txtTenBM.Text == "Tên Bố Mẹ ( < 8 tuổi )")
            {
                txtTenBM.Text = "";
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text == "")
            {
                txtSDT.Text = "Số Điện Thoại";
            }
        }

        private void txtSDT_Enter(object sender, EventArgs e)
        {
            if (txtSDT.Text == "Số Điện Thoại")
            {
                txtSDT.Text = "";
            }
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "")
            {
                txtDiaChi.Text = "Địa Chỉ";
            }
        }

        private void txtDiaChi_Enter(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "Địa Chỉ")
            {
                txtDiaChi.Text = "";
            }
        }

        private void txtTuoi_Leave(object sender, EventArgs e)
        {
            if (txtTuoi.Text == "")
            {
                txtTuoi.Text = "Tuổi";
            }
        }

        private void txtTuoi_Enter(object sender, EventArgs e)
        {
            if (txtTuoi.Text == "Tuổi")
            {
                txtTuoi.Text = "";
            }
        }

        #endregion

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            string source = conSet.ConnectionString;
            SqlConnection sqlCon = new SqlConnection(source);
            sqlCon.Open();

            SqlCommand cmd_KH = new SqlCommand("select count(*) from KhachHang", sqlCon);

            #region Tự động nhập mã khách hàng
            string soKHdangco;
            if ((int)(cmd_KH.ExecuteScalar()) + 1 < 10)
            {
                soKHdangco = string.Concat("0", ((int)(cmd_KH.ExecuteScalar()) + 1).ToString());
            }
            else soKHdangco = ((int)(cmd_KH.ExecuteScalar()) + 1).ToString();
            maKH = string.Concat("KH", soKHdangco);
            txtMaKH.Text = maKH;
            #endregion
            sqlCon.Close();
        }

        private void btnNhapPT_Click(object sender, EventArgs e)
        {
            string tenBM;
            string source = conSet.ConnectionString;
            SqlConnection sqlCon = new SqlConnection(source);
            sqlCon.Open();
            while (true)
            {
                if(txtCMND.Text == "Số CMND" || txtTenKH.Text == "Họ và Tên" || txtSDT.Text == "Số Điện Thoại" || txtTuoi.Text == "Tuổi")
                {
                    MessageBox.Show("Điền đầy đủ những mục có dấu *");
                    break;
                }

                
                int dem_CMND = 0;
                int dem_SDT = 0;

                #region Check trùng CMND
                SqlCommand cmd_CheckCMND = new SqlCommand("select * from KhachHang where soCMND = '" + txtCMND.Text + "'", sqlCon);
                SqlDataReader dr_CheckCMND;
                dr_CheckCMND = cmd_CheckCMND.ExecuteReader();
                while (dr_CheckCMND.Read())
                {
                    dem_CMND += 1;
                }
                if (dem_CMND >= 1) MessageBox.Show("Số CMND đã được sử dụng");

                dr_CheckCMND.Close();
                #endregion

                #region Check trùng số điện thoại
                SqlCommand cmd_CheckSDT = new SqlCommand("select * from KhachHang where SDT = '" + txtSDT.Text + "'", sqlCon);
                SqlDataReader dr_CheckSDT;
                dr_CheckSDT = cmd_CheckSDT.ExecuteReader();
                while (dr_CheckSDT.Read())
                {
                    dem_SDT += 1;
                }
                if (dem_SDT >= 1) MessageBox.Show("SĐT đã được sử dụng");

                dr_CheckSDT.Close();
                #endregion

                while (dem_CMND < 1 && dem_SDT < 1)
                {
                    #region check ô tên bố mẹ
                    // Check trẻ dưới 8 tuổi
                    if (Convert.ToInt32(txtTuoi.Text) < 8 && txtTenBM.Text == "Tên Bố Mẹ ( < 8 tuổi )")
                    {
                        MessageBox.Show("Trẻ dưới 8 tuổi hãy nhập tên bố mẹ");
                        break;
                    }

                    // nếu trên 8 tuổi 
                    if (txtTenBM.Text == "Tên Bố Mẹ ( < 8 tuổi )")
                    {
                        tenBM = "";
                    }
                    else tenBM = txtTenBM.Text;
                    #endregion

                    // Insert khách hàng vào CSDL
                    string query = "INSERT INTO dbo.KhachHang( MaKH ,TenKhachHang ,SoCMND ,TenBoMe ,SDT ,DiaChi ,Tuoi)" +
                                   "VALUES  ( '" + maKH + "' ,N'" + txtTenKH.Text + "' ,'" + txtCMND.Text + "' ,N'" + tenBM + "' ,'" + txtSDT.Text + "' ,N'" + txtDiaChi.Text + "' ," + Convert.ToInt32(txtTuoi.Text) + " )";
                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.ExecuteNonQuery();
                    FormInsertPT_LeTan fIPT_LT = new FormInsertPT_LeTan();


                    fIPT_LT.maKH = maKH; // Lưu lại mã KH để nhập tự động vào phiếu tiêm ( maKH ở formInsertPT để public nên có thể gọi đc ở đây )
                    fIPT_LT.ShowDialog();
                    this.Close();
                    break;
                }
                break;
            }
            sqlCon.Close();
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
