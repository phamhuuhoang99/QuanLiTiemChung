using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Mot_Chut
{
    public partial class FormDrugStore : Form
    {
        public FormDrugStore()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        String sqlCon = "Data Source=.;Initial Catalog=QLTiemChung;Integrated Security=True";
        SqlConnection sqlConnect = null;
         
        

        private void FormDrugStore_Load(object sender, EventArgs e)
        {
               SqlCommand sqlCommand   = new SqlCommand();
               if (sqlConnect == null)
            {
                sqlConnect = new SqlConnection(sqlCon);
            }
            if (sqlConnect.State == ConnectionState.Closed)
            {
                sqlConnect.Open();
            }


             sqlCommand.CommandType = CommandType.Text;
               sqlCommand.CommandText = "SELECT GiaThanh.MaVacxin,TenVacxin,XuatXu,DonGia,TenDichVu,TenLoai FROM dbo.Vacxin"
                                      +" LEFT JOIN dbo.GiaThanh ON GiaThanh.MaVacxin = Vacxin.MaVacxin"
                                      +" LEFT JOIN dbo.DichVu ON DichVu.MaDichVu = GiaThanh.MaDichVu"
                                      +" LEFT JOIN dbo.LoaiVacxin ON LoaiVacxin.MaLoai = Vacxin.MaLoai";
            sqlCommand.Connection = sqlConnect;

            SqlDataReader reader = sqlCommand.ExecuteReader();

            lvThuoc.Items.Clear();

               while (reader.Read())
               {
                    ListViewItem lv = new ListViewItem(reader.GetString(0));
                    lv.SubItems.Add(reader.GetString(1));
                    lv.SubItems.Add(reader.GetString(2));
                    lv.SubItems.Add(reader.GetInt32(3).ToString());
                    lv.SubItems.Add(reader.GetString(4));
                    lv.SubItems.Add(reader.GetString(5));

                    lvThuoc.Items.Add(lv);
                    
               }
               reader.Close();

               updataTreeView();
           
        }
        private void updataTreeView()
        {
               SqlCommand sqlCommand = new SqlCommand();
               sqlCommand.CommandType = CommandType.Text;
               sqlCommand.CommandText = "SELECT TenLoai FROM dbo.LoaiVacxin";
                                     
               sqlCommand.Connection = sqlConnect;

               SqlDataReader reader = sqlCommand.ExecuteReader();

               nhomThuoc.Nodes.Clear();

               while (reader.Read())
               {
                    TreeNode nodeNhom = new TreeNode(reader.GetString(0));

                    nhomThuoc.Nodes.Add(nodeNhom);
               }
               reader.Close();





               //foreach(NhomThuoc nhom in listNhomThuoc)
               // {

               //     TreeNode nodeNhom = new TreeNode(nhom.TenNhomThuoc);
               //     //Tag???
               //     //nodeNhom.Tag = reader;
               //     nhomThuoc.Nodes.Add(nodeNhom);

               // }
               //  reader.Close();
               //nhomThuoc.ExpandAll();

          }
          private void connectSQL(SqlDataReader reader, String query)
        {

        }

        private void lvThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

          private void label1_Click(object sender, EventArgs e)
          {

          }

          private void nhomThuoc_AfterSelect(object sender, TreeViewEventArgs e)
          {

               lvThuoc.Items.Clear();
               if (e.Node != null)
               {
                   
                    if (e.Node.Level == 0)
                    {
                         String x =e.Node.Text;

                         SqlCommand sqlCommand = new SqlCommand();

                         sqlCommand.CommandType = CommandType.Text;
                         sqlCommand.CommandText = "SELECT GiaThanh.MaVacxin,TenVacxin,XuatXu,DonGia,TenDichVu,TenLoai FROM dbo.Vacxin"
                                     + " LEFT JOIN dbo.GiaThanh ON GiaThanh.MaVacxin = Vacxin.MaVacxin"
                                     + " LEFT JOIN dbo.DichVu ON DichVu.MaDichVu = GiaThanh.MaDichVu"
                                     + " LEFT JOIN dbo.LoaiVacxin ON LoaiVacxin.MaLoai = Vacxin.MaLoai WHERE TenLoai=N'" + x + "'";



                         sqlCommand.Connection = sqlConnect;

                         SqlDataReader reader = sqlCommand.ExecuteReader();





                         while (reader.Read())
                         {
                              ListViewItem lv = new ListViewItem(reader.GetString(0));
                              lv.SubItems.Add(reader.GetString(1));
                              lv.SubItems.Add(reader.GetString(2));
                              lv.SubItems.Add(reader.GetInt32(3).ToString());
                              lv.SubItems.Add(reader.GetString(4));
                              lv.SubItems.Add(reader.GetString(5));

                              lvThuoc.Items.Add(lv);
                         }
                         reader.Close();


                    }
               }
          }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
