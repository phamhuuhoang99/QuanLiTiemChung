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
    public partial class FormInsertPT_LeTan : Form
    {
        ConnectionStringSettings conSet = ConfigurationManager.ConnectionStrings["MyDBConnectionString"];
        string sqlSource;
        public string maKH; // Biến này để lưu lại mã khách hàng từ FormCustomer ( public để gọi đc ở bên formCustomer )
        public string maPT;
        string GioTiem;
        string ngayHenTiem;
        bool phieuTiem_Moi = true; // Biến kiểm soát khi ấn Thêm chỉ đưa Phiếu Tiêm vào database 1 lần
        public FormInsertPT_LeTan()
        {
            InitializeComponent();
        }

        private void FormInsertPT_LeTan_Load(object sender, EventArgs e)
        {
            sqlSource = conSet.ConnectionString;
            SqlConnection sqlCon = new SqlConnection(sqlSource);
            phieuTiem_Moi = true;

            #region Đẩy các mã nhân viên đang có trong CSDL vào combobox  
            SqlDataAdapter sqlData_BSK = new SqlDataAdapter("SELECT MaNV FROM dbo.NhanVien WHERE MaChucVu = 'BSK'", sqlCon);
            SqlDataAdapter sqlData_BST = new SqlDataAdapter("SELECT MaNV FROM dbo.NhanVien WHERE MaChucVu = 'BST'", sqlCon);

            DataTable dt_BSK = new DataTable();
            DataTable dt_BST = new DataTable();

            sqlData_BSK.Fill(dt_BSK);
            sqlData_BST.Fill(dt_BST);

            foreach (DataRow dr in dt_BSK.Rows)
            {
                cbxBSK.Items.Add(dr["MaNV"].ToString());
            }

            foreach (DataRow dr in dt_BST.Rows)
            {
                cbxBST.Items.Add(dr["MaNV"].ToString());
            }

            
            #endregion

            #region Đẩy Loại Vacxine vào từ database
            SqlDataAdapter sqlData_LoaiVX = new SqlDataAdapter("SELECT MaLoai FROM dbo.LoaiVacxin", sqlCon);

            DataTable dt_LoaiVX = new DataTable();
            sqlData_LoaiVX.Fill(dt_LoaiVX);

            foreach (DataRow dr in dt_LoaiVX.Rows)
            {
                cbxLoaiVacxine.Items.Add(dr["MaLoai"].ToString());
            }
            #endregion 

            #region Điền tự động mã Phiếu Tiêm và mã Khách Hàng
            txtLTPhieu.Text = FormLogIn.maNV;
            txtMaKhachHang.Text = maKH; // mã KH

            string query_maPT = "SELECT COUNT(*) FROM dbo.PhieuTiem";
            sqlCon.Open();
            SqlCommand cmd_maPT = new SqlCommand(query_maPT, sqlCon);
            int stt;
            stt = (int)cmd_maPT.ExecuteScalar() + 1;
            if (stt < 10)
            {
                maPT = string.Concat("PT0", stt.ToString());
            }
            else maPT = string.Concat("PT", stt.ToString());
            txtMaPhieuTiem.Text = maPT;
            #endregion

            #region Đổi màu chữ trên datagridview
            // fore: màu chữ
            // back: màu nền
            // header cell : hàng đầu
            // default cell : từ hàng t2 trở đi
            dgvDSVacxine.Columns[0].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvDSVacxine.Columns[0].DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvDSVacxine.Columns[0].HeaderCell.Style.ForeColor = Color.DodgerBlue;
            dgvDSVacxine.Columns[0].HeaderCell.Style.BackColor = Color.White;
            dgvDSVacxine.Columns[0].DefaultCellStyle.BackColor = Color.White;

            dgvDSVacxine.Columns[1].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvDSVacxine.Columns[1].DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvDSVacxine.Columns[1].HeaderCell.Style.ForeColor = Color.DodgerBlue;
            dgvDSVacxine.Columns[1].HeaderCell.Style.BackColor = Color.White;
            dgvDSVacxine.Columns[1].DefaultCellStyle.BackColor = Color.White;

            dgvDSVacxine.Columns[2].HeaderCell.Style.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvDSVacxine.Columns[2].DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvDSVacxine.Columns[2].HeaderCell.Style.ForeColor = Color.DodgerBlue;
            dgvDSVacxine.Columns[2].HeaderCell.Style.BackColor = Color.White;
            dgvDSVacxine.Columns[2].DefaultCellStyle.BackColor = Color.White;


            dgvDSVacxine.EnableHeadersVisualStyles = false;
            #endregion 

            sqlCon.Close();
        }

        // Kiểm tra xem liệu có hẹn tiêm mũi tiếp theo không
        private void chkMuiTiepTheo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMuiTiepTheo.Checked == true)
            {
                dtMuiTiepTheo.Enabled = true;
                nudHour.Enabled = true;
                nudMinute.Enabled = true;
            }
            else
            {
                dtMuiTiepTheo.Enabled = false;
                nudHour.Enabled = false;
                nudMinute.Enabled = false;
            }
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            string source = conSet.ConnectionString;
            SqlConnection sqlCon = new SqlConnection(source);
            sqlCon.Open();

            string query_TThientai = "SELECT soKH FROM dbo.ThanhTich WHERE maNV = '" + FormLogIn.maNV + "'";
            SqlCommand cmd_TThientai = new SqlCommand(query_TThientai, sqlCon);
            int ttMoi = (int)cmd_TThientai.ExecuteScalar() + 1;

            string query_TTmoi = "UPDATE dbo.ThanhTich SET soKH = '" + ttMoi + "' WHERE maNV = '" + FormLogIn.maNV + "'";
            SqlCommand cmd_TTmoi = new SqlCommand(query_TTmoi, sqlCon);
            cmd_TTmoi.ExecuteNonQuery();

            sqlCon.Close();
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            while (true)
            {
                #region Đã điền đủ thông tin chưa

                if (cbxBSK.Text == "")
                {
                    MessageBox.Show("Chưa chọn bác sĩ khám");
                    break;
                }

                if (cbxBST.Text == "")
                {
                    MessageBox.Show("Chưa chọn bác sĩ tiêm");
                    break;
                }

                if (cbxLoaiVacxine.Text == "")
                {
                    MessageBox.Show("Chưa chọn loại vacxine");
                    break;
                }

                if (cbxMaVX.Text == "")
                {
                    MessageBox.Show("Chưa chọn mã vacxine");
                    break;
                }

                if (txtLieuLuong.Text == "")
                {
                    MessageBox.Show("Chưa ghi liều lượng");
                    break;
                }

                if (chkMuiTiepTheo.Checked == true)
                {
                    if (dtMuiTiepTheo.Value <= dtNgayTiem.Value)
                    {
                        MessageBox.Show("Ngày hẹn phải sau ngày hôm nay");
                        break;
                    }
                }
                #endregion

                // Lưu giờ Tiêm
                GioTiem = string.Concat(nudHour.Value.ToString(), "h", nudMinute.Value.ToString());

                SqlConnection sqlCon = new SqlConnection(sqlSource);
                sqlCon.Open();
                // Đưa phiếu tiêm vào database
                if (phieuTiem_Moi == true)
                {
                    string ngayTiem_Temp = dtNgayTiem.Value.ToShortDateString();
                    string[] nTiem = ngayTiem_Temp.Split(new char[] { '/' });
                    string namTiem = string.Concat(nTiem[2], "-", nTiem[0]);
                    string ngayTiem = string.Concat(namTiem, "-", nTiem[1]);

                    string query_InsertPT = "INSERT INTO dbo.PhieuTiem(MaPhieuTiem,MaKH,NgayTiem,MaNVphieu,MaBSKham,GhiChu,maNVtiem,TongTien) " +
                        "VALUES('" + txtMaPhieuTiem.Text + "','" + txtMaKhachHang.Text + "','" + ngayTiem + "','" + txtLTPhieu.Text + "','" + cbxBSK.Text + "', NULL,'" + cbxBST.Text + "', " + Convert.ToInt32(lbTongTien.Text) + ")";

                    SqlCommand cmd_InsertPT = new SqlCommand(query_InsertPT, sqlCon);
                    cmd_InsertPT.ExecuteNonQuery();
                    phieuTiem_Moi = false;
                }


                // Lấy giá tiền vacxine vừa được chọn
                string query_giaVacxine = "SELECT DonGia FROM dbo.Vacxin WHERE MaVacxin = '" + cbxMaVX.Text + "'";
                SqlCommand cmd_giaVX = new SqlCommand(query_giaVacxine, sqlCon);
                int giaVacxine;
                giaVacxine = (int)cmd_giaVX.ExecuteScalar();

                // Cập nhật tổng tiền
                lbTongTien.Text = (Convert.ToInt32(lbTongTien.Text) + giaVacxine).ToString();
                
                string query_UpdatePT = "UPDATE dbo.PhieuTiem SET TongTien = " + Convert.ToInt32(lbTongTien.Text) + " WHERE MaPhieuTiem = '" + txtMaPhieuTiem.Text + "'";
                SqlCommand cmd_UpdatePT = new SqlCommand(query_UpdatePT, sqlCon);
                cmd_UpdatePT.ExecuteNonQuery();
                
                


                #region Lưu phiếu tiêm chi tiết

                string query_InsertPTCT;
                // Nếu có ngày hẹn tiêm mũi tiếp theo
                if (chkMuiTiepTheo.Checked == true)
                {
                    string ngayHenTiem_Temp = dtMuiTiepTheo.Value.ToShortDateString();
                    string[] nHenTiem = ngayHenTiem_Temp.Split(new char[] { '/' });
                    string namHenTiem = string.Concat(nHenTiem[2], "-", nHenTiem[0]);
                    ngayHenTiem = string.Concat(namHenTiem, "-", nHenTiem[1]);

                    query_InsertPTCT = "INSERT INTO dbo.PT_ChiTiet(MaPhieuTiem,MaVacXin,LieuLuong,GioTiem,ThanhTien,NgayHenTiem) " +
                    "VALUES('" + txtMaPhieuTiem.Text + "','" + cbxMaVX.Text + "'," + txtLieuLuong.Text + ",'" + GioTiem + "'," + giaVacxine + ",'" + ngayHenTiem + "')";
                }
                // Nếu k có
                else
                {
                    query_InsertPTCT = "INSERT INTO dbo.PT_ChiTiet(MaPhieuTiem,MaVacXin,LieuLuong,GioTiem,ThanhTien,NgayHenTiem) " +
                    "VALUES('" + txtMaPhieuTiem.Text + "','" + cbxMaVX.Text + "'," + txtLieuLuong.Text + ",'" + GioTiem + "'," + giaVacxine + ",NULL)";

                    ngayHenTiem = "";
                }
                // Thêm phiếu tiêm chi tiết vào database
                SqlCommand cmd_InsertPTCT = new SqlCommand(query_InsertPTCT, sqlCon);
                cmd_InsertPTCT.ExecuteNonQuery();

                // Đẩy danh sách vacxine đc chọn lên dataGridview
                dgvDSVacxine.Rows.Add(cbxLoaiVacxine.Text, cbxMaVX.Text, ngayHenTiem);

                #endregion 

                sqlCon.Close();
                break;
            }
        }

        private void cbxLoaiVacxine_TextChanged(object sender, EventArgs e)
        {
            // Xóa các item mã vacxin cũ
            cbxMaVX.Items.Clear();

            // Lấy mã vacxin theo mã loại
            SqlConnection sqlCon = new SqlConnection(sqlSource);
            SqlDataAdapter sqlData_maVX = new SqlDataAdapter("SELECT MaVacxin FROM dbo.Vacxin WHERE MaLoai = '" + cbxLoaiVacxine.Text + "'", sqlCon);

            sqlCon.Open();
            DataTable dt_maVX = new DataTable();
            sqlData_maVX.Fill(dt_maVX);

            foreach (DataRow dr in dt_maVX.Rows)
            {
                cbxMaVX.Items.Add(dr["MaVacxin"].ToString());
            }
            sqlCon.Close();
        }
    }
}
