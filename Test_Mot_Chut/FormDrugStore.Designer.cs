namespace Test_Mot_Chut
{
    partial class FormDrugStore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
               this.btnClose = new System.Windows.Forms.Label();
               this.splitContainer1 = new System.Windows.Forms.SplitContainer();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.nhomThuoc = new System.Windows.Forms.TreeView();
               this.splitContainer2 = new System.Windows.Forms.SplitContainer();
               this.groupBox2 = new System.Windows.Forms.GroupBox();
               this.lvThuoc = new System.Windows.Forms.ListView();
               this.maVacxin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
               this.tenVacxin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
               this.xuatXu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
               this.donGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
               this.tenDichVu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
               this.TenLoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
               this.groupBox3 = new System.Windows.Forms.GroupBox();
               this.button1 = new System.Windows.Forms.Button();
               this.btnThoat = new System.Windows.Forms.Button();
               this.btnXoa = new System.Windows.Forms.Button();
               this.btnLuu = new System.Windows.Forms.Button();
               this.cboNhomThuoc = new System.Windows.Forms.ComboBox();
               this.txtXuatXu = new System.Windows.Forms.TextBox();
               this.txtTenThuoc = new System.Windows.Forms.TextBox();
               this.txtMaThuoc = new System.Windows.Forms.TextBox();
               this.label5 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
               this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
               this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
               this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
               this.metroButton1 = new MetroFramework.Controls.MetroButton();
               this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
               this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
               this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
               ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
               this.splitContainer1.Panel1.SuspendLayout();
               this.splitContainer1.Panel2.SuspendLayout();
               this.splitContainer1.SuspendLayout();
               this.groupBox1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
               this.splitContainer2.Panel1.SuspendLayout();
               this.splitContainer2.Panel2.SuspendLayout();
               this.splitContainer2.SuspendLayout();
               this.groupBox2.SuspendLayout();
               this.groupBox3.SuspendLayout();
               this.metroTabControl1.SuspendLayout();
               this.metroTabPage1.SuspendLayout();
               this.metroTabPage2.SuspendLayout();
               this.metroPanel2.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               this.metroPanel1.SuspendLayout();
               this.SuspendLayout();
               // 
               // btnClose
               // 
               this.btnClose.AutoSize = true;
               this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
               this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
               this.btnClose.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnClose.Location = new System.Drawing.Point(1118, 0);
               this.btnClose.Name = "btnClose";
               this.btnClose.Size = new System.Drawing.Size(18, 18);
               this.btnClose.TabIndex = 1;
               this.btnClose.Text = "X";
               this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
               // 
               // splitContainer1
               // 
               this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.splitContainer1.Location = new System.Drawing.Point(0, 0);
               this.splitContainer1.Name = "splitContainer1";
               // 
               // splitContainer1.Panel1
               // 
               this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
               // 
               // splitContainer1.Panel2
               // 
               this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
               this.splitContainer1.Size = new System.Drawing.Size(1110, 484);
               this.splitContainer1.SplitterDistance = 431;
               this.splitContainer1.TabIndex = 5;
               // 
               // groupBox1
               // 
               this.groupBox1.Controls.Add(this.nhomThuoc);
               this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
               this.groupBox1.Location = new System.Drawing.Point(0, 0);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Size = new System.Drawing.Size(431, 484);
               this.groupBox1.TabIndex = 0;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "Nhóm Thuốc";
               // 
               // nhomThuoc
               // 
               this.nhomThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
               this.nhomThuoc.Location = new System.Drawing.Point(3, 18);
               this.nhomThuoc.Name = "nhomThuoc";
               this.nhomThuoc.Size = new System.Drawing.Size(425, 463);
               this.nhomThuoc.TabIndex = 0;
               // 
               // splitContainer2
               // 
               this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
               this.splitContainer2.Location = new System.Drawing.Point(0, 0);
               this.splitContainer2.Name = "splitContainer2";
               this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
               // 
               // splitContainer2.Panel1
               // 
               this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
               // 
               // splitContainer2.Panel2
               // 
               this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
               this.splitContainer2.Size = new System.Drawing.Size(675, 484);
               this.splitContainer2.SplitterDistance = 210;
               this.splitContainer2.TabIndex = 0;
               // 
               // groupBox2
               // 
               this.groupBox2.Controls.Add(this.lvThuoc);
               this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
               this.groupBox2.Location = new System.Drawing.Point(0, 0);
               this.groupBox2.Name = "groupBox2";
               this.groupBox2.Size = new System.Drawing.Size(675, 210);
               this.groupBox2.TabIndex = 0;
               this.groupBox2.TabStop = false;
               this.groupBox2.Text = "Danh Sách Thuốc";
               // 
               // lvThuoc
               // 
               this.lvThuoc.BackColor = System.Drawing.SystemColors.Window;
               this.lvThuoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maVacxin,
            this.tenVacxin,
            this.xuatXu,
            this.donGia,
            this.tenDichVu,
            this.TenLoai});
               this.lvThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
               this.lvThuoc.FullRowSelect = true;
               this.lvThuoc.GridLines = true;
               this.lvThuoc.HideSelection = false;
               this.lvThuoc.Location = new System.Drawing.Point(3, 16);
               this.lvThuoc.Name = "lvThuoc";
               this.lvThuoc.Size = new System.Drawing.Size(669, 191);
               this.lvThuoc.TabIndex = 0;
               this.lvThuoc.UseCompatibleStateImageBehavior = false;
               this.lvThuoc.View = System.Windows.Forms.View.Details;
               // 
               // maVacxin
               // 
               this.maVacxin.Text = "Mã";
               // 
               // tenVacxin
               // 
               this.tenVacxin.Text = "Tên Vacxin";
               this.tenVacxin.Width = 90;
               // 
               // xuatXu
               // 
               this.xuatXu.Text = "Xuất xứ";
               // 
               // donGia
               // 
               this.donGia.Text = "Đơn giá";
               // 
               // tenDichVu
               // 
               this.tenDichVu.Text = "Tên Dịch Vụ";
               this.tenDichVu.Width = 90;
               // 
               // TenLoai
               // 
               this.TenLoai.Text = "Tên Loại";
               this.TenLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               this.TenLoai.Width = 90;
               // 
               // groupBox3
               // 
               this.groupBox3.Controls.Add(this.button1);
               this.groupBox3.Controls.Add(this.btnThoat);
               this.groupBox3.Controls.Add(this.btnXoa);
               this.groupBox3.Controls.Add(this.btnLuu);
               this.groupBox3.Controls.Add(this.cboNhomThuoc);
               this.groupBox3.Controls.Add(this.txtXuatXu);
               this.groupBox3.Controls.Add(this.txtTenThuoc);
               this.groupBox3.Controls.Add(this.txtMaThuoc);
               this.groupBox3.Controls.Add(this.label5);
               this.groupBox3.Controls.Add(this.label4);
               this.groupBox3.Controls.Add(this.label3);
               this.groupBox3.Controls.Add(this.label2);
               this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
               this.groupBox3.Location = new System.Drawing.Point(0, 0);
               this.groupBox3.Name = "groupBox3";
               this.groupBox3.Size = new System.Drawing.Size(675, 270);
               this.groupBox3.TabIndex = 0;
               this.groupBox3.TabStop = false;
               this.groupBox3.Text = "Thông tin chi tiết Thuốc";
               // 
               // button1
               // 
               this.button1.Location = new System.Drawing.Point(329, 201);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(90, 23);
               this.button1.TabIndex = 11;
               this.button1.Text = "Xem";
               this.button1.UseVisualStyleBackColor = true;
               // 
               // btnThoat
               // 
               this.btnThoat.Location = new System.Drawing.Point(219, 201);
               this.btnThoat.Name = "btnThoat";
               this.btnThoat.Size = new System.Drawing.Size(95, 23);
               this.btnThoat.TabIndex = 10;
               this.btnThoat.Text = "Sửa";
               this.btnThoat.UseVisualStyleBackColor = true;
               // 
               // btnXoa
               // 
               this.btnXoa.Location = new System.Drawing.Point(116, 201);
               this.btnXoa.Name = "btnXoa";
               this.btnXoa.Size = new System.Drawing.Size(88, 23);
               this.btnXoa.TabIndex = 9;
               this.btnXoa.Text = "Xuất thuốc";
               this.btnXoa.UseVisualStyleBackColor = true;
               // 
               // btnLuu
               // 
               this.btnLuu.Location = new System.Drawing.Point(18, 201);
               this.btnLuu.Name = "btnLuu";
               this.btnLuu.Size = new System.Drawing.Size(83, 23);
               this.btnLuu.TabIndex = 8;
               this.btnLuu.Text = "Nhập Thuốc";
               this.btnLuu.UseVisualStyleBackColor = true;
               // 
               // cboNhomThuoc
               // 
               this.cboNhomThuoc.FormattingEnabled = true;
               this.cboNhomThuoc.Location = new System.Drawing.Point(100, 160);
               this.cboNhomThuoc.Name = "cboNhomThuoc";
               this.cboNhomThuoc.Size = new System.Drawing.Size(143, 22);
               this.cboNhomThuoc.TabIndex = 7;
               // 
               // txtXuatXu
               // 
               this.txtXuatXu.Location = new System.Drawing.Point(100, 110);
               this.txtXuatXu.Name = "txtXuatXu";
               this.txtXuatXu.Size = new System.Drawing.Size(143, 20);
               this.txtXuatXu.TabIndex = 6;
               // 
               // txtTenThuoc
               // 
               this.txtTenThuoc.Location = new System.Drawing.Point(100, 73);
               this.txtTenThuoc.Name = "txtTenThuoc";
               this.txtTenThuoc.Size = new System.Drawing.Size(143, 20);
               this.txtTenThuoc.TabIndex = 5;
               // 
               // txtMaThuoc
               // 
               this.txtMaThuoc.Location = new System.Drawing.Point(100, 28);
               this.txtMaThuoc.Name = "txtMaThuoc";
               this.txtMaThuoc.Size = new System.Drawing.Size(143, 20);
               this.txtMaThuoc.TabIndex = 4;
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Location = new System.Drawing.Point(15, 168);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(67, 14);
               this.label5.TabIndex = 3;
               this.label5.Text = "Nhóm Thuốc";
               this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(15, 116);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(46, 14);
               this.label4.TabIndex = 2;
               this.label4.Text = "Xuất Xứ";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(15, 79);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(58, 14);
               this.label3.TabIndex = 1;
               this.label3.Text = "Tên Thuốc";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(15, 35);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(54, 14);
               this.label2.TabIndex = 0;
               this.label2.Text = "Mã Thuốc";
               // 
               // metroTabControl1
               // 
               this.metroTabControl1.Controls.Add(this.metroTabPage1);
               this.metroTabControl1.Controls.Add(this.metroTabPage2);
               this.metroTabControl1.Controls.Add(this.metroTabPage3);
               this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
               this.metroTabControl1.Name = "metroTabControl1";
               this.metroTabControl1.SelectedIndex = 0;
               this.metroTabControl1.Size = new System.Drawing.Size(1118, 526);
               this.metroTabControl1.TabIndex = 6;
               this.metroTabControl1.UseSelectable = true;
               // 
               // metroTabPage1
               // 
               this.metroTabPage1.Controls.Add(this.splitContainer1);
               this.metroTabPage1.HorizontalScrollbarBarColor = true;
               this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
               this.metroTabPage1.HorizontalScrollbarSize = 10;
               this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
               this.metroTabPage1.Name = "metroTabPage1";
               this.metroTabPage1.Size = new System.Drawing.Size(1110, 484);
               this.metroTabPage1.TabIndex = 0;
               this.metroTabPage1.Text = "Kho thuốc";
               this.metroTabPage1.VerticalScrollbarBarColor = true;
               this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
               this.metroTabPage1.VerticalScrollbarSize = 10;
               // 
               // metroTabPage2
               // 
               this.metroTabPage2.Controls.Add(this.metroPanel2);
               this.metroTabPage2.Controls.Add(this.metroPanel1);
               this.metroTabPage2.HorizontalScrollbarBarColor = true;
               this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
               this.metroTabPage2.HorizontalScrollbarSize = 10;
               this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
               this.metroTabPage2.Name = "metroTabPage2";
               this.metroTabPage2.Size = new System.Drawing.Size(1110, 484);
               this.metroTabPage2.TabIndex = 1;
               this.metroTabPage2.Text = "Doanh Thu";
               this.metroTabPage2.VerticalScrollbarBarColor = true;
               this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
               this.metroTabPage2.VerticalScrollbarSize = 10;
               // 
               // metroPanel2
               // 
               this.metroPanel2.Controls.Add(this.dataGridView1);
               this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
               this.metroPanel2.HorizontalScrollbarBarColor = true;
               this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
               this.metroPanel2.HorizontalScrollbarSize = 10;
               this.metroPanel2.Location = new System.Drawing.Point(0, 100);
               this.metroPanel2.Name = "metroPanel2";
               this.metroPanel2.Size = new System.Drawing.Size(1110, 384);
               this.metroPanel2.TabIndex = 3;
               this.metroPanel2.VerticalScrollbarBarColor = true;
               this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
               this.metroPanel2.VerticalScrollbarSize = 10;
               // 
               // dataGridView1
               // 
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.dataGridView1.Location = new System.Drawing.Point(0, 0);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.Size = new System.Drawing.Size(1110, 384);
               this.dataGridView1.TabIndex = 2;
               // 
               // metroPanel1
               // 
               this.metroPanel1.Controls.Add(this.metroButton1);
               this.metroPanel1.Controls.Add(this.metroDateTime2);
               this.metroPanel1.Controls.Add(this.metroDateTime1);
               this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
               this.metroPanel1.HorizontalScrollbarBarColor = true;
               this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
               this.metroPanel1.HorizontalScrollbarSize = 10;
               this.metroPanel1.Location = new System.Drawing.Point(0, 0);
               this.metroPanel1.Name = "metroPanel1";
               this.metroPanel1.Size = new System.Drawing.Size(1110, 100);
               this.metroPanel1.TabIndex = 2;
               this.metroPanel1.VerticalScrollbarBarColor = true;
               this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
               this.metroPanel1.VerticalScrollbarSize = 10;
               // 
               // metroButton1
               // 
               this.metroButton1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.metroButton1.Location = new System.Drawing.Point(200, 0);
               this.metroButton1.Name = "metroButton1";
               this.metroButton1.Size = new System.Drawing.Size(710, 100);
               this.metroButton1.TabIndex = 4;
               this.metroButton1.Text = "Thống kê";
               this.metroButton1.UseSelectable = true;
               // 
               // metroDateTime2
               // 
               this.metroDateTime2.Dock = System.Windows.Forms.DockStyle.Right;
               this.metroDateTime2.FontSize = MetroFramework.MetroDateTimeSize.Tall;
               this.metroDateTime2.Location = new System.Drawing.Point(910, 0);
               this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 35);
               this.metroDateTime2.Name = "metroDateTime2";
               this.metroDateTime2.Size = new System.Drawing.Size(200, 35);
               this.metroDateTime2.Style = MetroFramework.MetroColorStyle.Black;
               this.metroDateTime2.TabIndex = 3;
               // 
               // metroDateTime1
               // 
               this.metroDateTime1.Dock = System.Windows.Forms.DockStyle.Left;
               this.metroDateTime1.FontSize = MetroFramework.MetroDateTimeSize.Tall;
               this.metroDateTime1.Location = new System.Drawing.Point(0, 0);
               this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 35);
               this.metroDateTime1.Name = "metroDateTime1";
               this.metroDateTime1.Size = new System.Drawing.Size(200, 35);
               this.metroDateTime1.Style = MetroFramework.MetroColorStyle.Black;
               this.metroDateTime1.TabIndex = 2;
               // 
               // metroTabPage3
               // 
               this.metroTabPage3.HorizontalScrollbarBarColor = true;
               this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
               this.metroTabPage3.HorizontalScrollbarSize = 10;
               this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
               this.metroTabPage3.Name = "metroTabPage3";
               this.metroTabPage3.Size = new System.Drawing.Size(1110, 484);
               this.metroTabPage3.TabIndex = 2;
               this.metroTabPage3.Text = "Tài Khoản";
               this.metroTabPage3.VerticalScrollbarBarColor = true;
               this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
               this.metroTabPage3.VerticalScrollbarSize = 10;
               // 
               // FormDrugStore
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.ActiveCaption;
               this.ClientSize = new System.Drawing.Size(1136, 526);
               this.Controls.Add(this.metroTabControl1);
               this.Controls.Add(this.btnClose);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "FormDrugStore";
               this.Text = "FormDrugStore";
               this.Load += new System.EventHandler(this.FormDrugStore_Load);
               this.splitContainer1.Panel1.ResumeLayout(false);
               this.splitContainer1.Panel2.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
               this.splitContainer1.ResumeLayout(false);
               this.groupBox1.ResumeLayout(false);
               this.splitContainer2.Panel1.ResumeLayout(false);
               this.splitContainer2.Panel2.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
               this.splitContainer2.ResumeLayout(false);
               this.groupBox2.ResumeLayout(false);
               this.groupBox3.ResumeLayout(false);
               this.groupBox3.PerformLayout();
               this.metroTabControl1.ResumeLayout(false);
               this.metroTabPage1.ResumeLayout(false);
               this.metroTabPage2.ResumeLayout(false);
               this.metroPanel2.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               this.metroPanel1.ResumeLayout(false);
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView nhomThuoc;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvThuoc;
        private System.Windows.Forms.ColumnHeader maVacxin;
        private System.Windows.Forms.ColumnHeader tenVacxin;
        private System.Windows.Forms.ColumnHeader xuatXu;
        private System.Windows.Forms.ColumnHeader donGia;
        private System.Windows.Forms.ColumnHeader tenDichVu;
        private System.Windows.Forms.ColumnHeader TenLoai;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cboNhomThuoc;
        private System.Windows.Forms.TextBox txtXuatXu;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
    }
}