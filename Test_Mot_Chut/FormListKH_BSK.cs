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
    public partial class FormListKH_BSK : Form
    {
        string maBSK = FormLogIn.maNV;
        ConnectionStringSettings conSet = ConfigurationManager.ConnectionStrings["MyDBConnectionString"];
        string maPhieu;
        string maVX;
        public FormListKH_BSK()
        {
            InitializeComponent();
        }

        private void FormListKH_BSK_Load(object sender, EventArgs e)
        {
            string source = conSet.ConnectionString;
            SqlConnection sqlCon = new SqlConnection(source);
            sqlCon.Open();

            SqlDataAdapter sqlData_KH = new SqlDataAdapter("SELECT MaPhieuTiem AS 'Mã Phiếu',TenKhachHang AS 'Tên Khách Hàng',Tuoi AS 'Tuổi' FROM dbo.KhachHang,dbo.PhieuTiem AS PT WHERE KhachHang.MaKH = PT.MaKH AND PT.MaBSKham = '" + maBSK + "' AND GhiChu is null" , sqlCon);
           
            DataTable dt_KH = new DataTable();

            sqlData_KH.Fill(dt_KH);
            dgvListKH.DataSource = dt_KH;

            #region Đổi màu dataGridView
            dgvListKH.Columns[0].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvListKH.Columns[0].DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvListKH.Columns[0].HeaderCell.Style.ForeColor = Color.DodgerBlue;
            dgvListKH.Columns[0].DefaultCellStyle.ForeColor = Color.DodgerBlue;
            dgvListKH.Columns[0].HeaderCell.Style.BackColor = Color.White;
            dgvListKH.Columns[0].DefaultCellStyle.BackColor = Color.White;

            dgvListKH.Columns[1].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvListKH.Columns[1].DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvListKH.Columns[1].HeaderCell.Style.ForeColor = Color.DodgerBlue;
            dgvListKH.Columns[1].DefaultCellStyle.ForeColor = Color.DodgerBlue;
            dgvListKH.Columns[1].HeaderCell.Style.BackColor = Color.White;
            dgvListKH.Columns[1].DefaultCellStyle.BackColor = Color.White;

            dgvListKH.Columns[2].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvListKH.Columns[2].DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvListKH.Columns[2].HeaderCell.Style.ForeColor = Color.DodgerBlue;
            dgvListKH.Columns[2].DefaultCellStyle.ForeColor = Color.DodgerBlue;
            dgvListKH.Columns[2].HeaderCell.Style.BackColor = Color.White;
            dgvListKH.Columns[2].DefaultCellStyle.BackColor = Color.White;

            dgvListKH.EnableHeadersVisualStyles = false;

            
            #endregion 

            sqlCon.Close();
        }

        private void dgvListKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string source = conSet.ConnectionString;
            SqlConnection sqlCon = new SqlConnection(source);
            sqlCon.Open();

            int selectedRowIndex = e.RowIndex;

            DataGridViewRow row = new DataGridViewRow();

            row = dgvListKH.Rows[selectedRowIndex];

            maPhieu = row.Cells[0].Value.ToString();
            string tenKH = row.Cells[1].Value.ToString();
            string tuoi = row.Cells[2].Value.ToString();

            string query_MaKH = "SELECT MaKH FROM dbo.PhieuTiem WHERE MaBSKham = '" + maBSK + "' AND MaPhieuTiem = '" + maPhieu + "'";
            SqlCommand cmd_MaKH = new SqlCommand(query_MaKH, sqlCon);

            string maKH = (string)cmd_MaKH.ExecuteScalar();

            lbMaKH.Text = maKH;
            lbMaPT.Text = maPhieu;
            lbTuoiKH.Text = tuoi;
            lbTenKH.Text = tenKH;

            SqlDataAdapter sqlData_VX = new SqlDataAdapter("SELECT VX.MaLoai AS 'Loại Vacxine',VX.MaVacxin AS 'Mã Vacxine',PTCT.LieuLuong AS 'Liều Lượng' FROM dbo.PT_ChiTiet AS PTCT,dbo.Vacxin AS VX WHERE MaPhieuTiem ='" + maPhieu + "' AND PTCT.MaVacXin = VX.MaVacxin", sqlCon);
            DataTable dt_VX = new DataTable();

            sqlData_VX.Fill(dt_VX);
            dgvDSVacxine.DataSource = dt_VX;

            dgvDSVacxine.Columns[0].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvDSVacxine.Columns[0].DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvDSVacxine.Columns[0].HeaderCell.Style.ForeColor = Color.DodgerBlue;
            dgvDSVacxine.Columns[0].DefaultCellStyle.ForeColor = Color.DodgerBlue;
            dgvDSVacxine.Columns[0].HeaderCell.Style.BackColor = Color.White;
            dgvDSVacxine.Columns[0].DefaultCellStyle.BackColor = Color.White;

            dgvDSVacxine.Columns[1].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvDSVacxine.Columns[1].DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvDSVacxine.Columns[1].HeaderCell.Style.ForeColor = Color.DodgerBlue;
            dgvDSVacxine.Columns[1].DefaultCellStyle.ForeColor = Color.DodgerBlue;
            dgvDSVacxine.Columns[1].HeaderCell.Style.BackColor = Color.White;
            dgvDSVacxine.Columns[1].DefaultCellStyle.BackColor = Color.White;

            dgvDSVacxine.Columns[2].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvDSVacxine.Columns[2].DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvDSVacxine.Columns[2].HeaderCell.Style.ForeColor = Color.DodgerBlue;
            dgvDSVacxine.Columns[2].DefaultCellStyle.ForeColor = Color.DodgerBlue;
            dgvDSVacxine.Columns[2].HeaderCell.Style.BackColor = Color.White;
            dgvDSVacxine.Columns[2].DefaultCellStyle.BackColor = Color.White;

            dgvDSVacxine.EnableHeadersVisualStyles = false;
            sqlCon.Close();
        }

        private void dgvDSVacxine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string source = conSet.ConnectionString;
            SqlConnection sqlCon = new SqlConnection(source);
            sqlCon.Open();

            int selectedRowIndex = e.RowIndex;

            DataGridViewRow row = new DataGridViewRow();

            row = dgvDSVacxine.Rows[selectedRowIndex];

            txtLoaiVX.Text = row.Cells[0].Value.ToString();
            txtLieuLuong.Text = row.Cells[2].Value.ToString();

            maVX = row.Cells[1].Value.ToString();

            string query_tenVX = "SELECT * FROM dbo.Vacxin WHERE MaVacxin ='" + maVX + "'";
            SqlCommand cmd_tenVX = new SqlCommand(query_tenVX, sqlCon);
            txtTenVX.Text = (string)cmd_tenVX.ExecuteScalar();

            sqlCon.Close();
        }

        private void btnUpdateLL_Click(object sender, EventArgs e)
        {
            string source = conSet.ConnectionString;
            SqlConnection sqlCon = new SqlConnection(source);
            sqlCon.Open();

            string query_UpdateLL = "UPDATE dbo.PT_ChiTiet SET LieuLuong = '" + txtLieuLuong.Text + "' WHERE MaPhieuTiem ='" + maPhieu + "' AND MaVacXin ='" + maVX + "'";
            SqlCommand cmd_UpdateLL = new SqlCommand(query_UpdateLL, sqlCon);
            cmd_UpdateLL.ExecuteNonQuery();

            SqlDataAdapter sqlData_VX = new SqlDataAdapter("SELECT VX.MaLoai AS 'Loại Vacxine',VX.MaVacxin AS 'Mã Vacxine',PTCT.LieuLuong AS 'Liều Lượng' FROM dbo.PT_ChiTiet AS PTCT,dbo.Vacxin AS VX WHERE MaPhieuTiem ='" + maPhieu + "' AND PTCT.MaVacXin = VX.MaVacxin", sqlCon);
            DataTable dt_VX = new DataTable();

            sqlData_VX.Fill(dt_VX);
            dgvDSVacxine.DataSource = dt_VX;

            sqlCon.Close();
        }

        private void btnKhamXong_Click(object sender, EventArgs e)
        {
            string source = conSet.ConnectionString;
            SqlConnection sqlCon = new SqlConnection(source);
            sqlCon.Open();

            string query_UpdatePT = "UPDATE dbo.PhieuTiem SET GhiChu = '" + txtGhiChu.Text + "' WHERE MaPhieuTiem = '" + maPhieu + "'";
            SqlCommand cmd_UpdatePT = new SqlCommand(query_UpdatePT, sqlCon);
            cmd_UpdatePT.ExecuteNonQuery();

            string query_TThientai = "SELECT soKH FROM dbo.ThanhTich WHERE maNV = '" + maBSK + "'";
            SqlCommand cmd_TThientai = new SqlCommand(query_TThientai, sqlCon);
            int ttMoi = (int)cmd_TThientai.ExecuteScalar() + 1;

            string query_TTmoi = "UPDATE dbo.ThanhTich SET soKH = '" + ttMoi + "' WHERE maNV = '" + maBSK + "'";
            SqlCommand cmd_TTmoi = new SqlCommand(query_TTmoi, sqlCon);
            cmd_TTmoi.ExecuteNonQuery();

            //this.Close();
            sqlCon.Close();
            FormListKH_BSK_Load(sender,e);
        }
    }
}
