
namespace NguyenHoangKy_1150080023_CNPM1_Bt5
{
    partial class Form6
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.RadioButton rbWindowsAuth;
        private System.Windows.Forms.RadioButton rbSqlAuth;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Button btnOpenConnect;
        private System.Windows.Forms.Button btnCloseConnect;

        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblAuth;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;

        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtMaLop;

        private System.Windows.Forms.Button btnCountSV;
        private System.Windows.Forms.Button btnXemThongTin;
        private System.Windows.Forms.Button btnXemDanhSach;
        private System.Windows.Forms.Button btnXemTheoLop;

        private System.Windows.Forms.ListView lsvDanhSach;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.Label lblMaLop;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lblAuth = new System.Windows.Forms.Label();
            this.rbWindowsAuth = new System.Windows.Forms.RadioButton();
            this.rbSqlAuth = new System.Windows.Forms.RadioButton();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.btnOpenConnect = new System.Windows.Forms.Button();
            this.btnCloseConnect = new System.Windows.Forms.Button();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.btnCountSV = new System.Windows.Forms.Button();
            this.btnXemThongTin = new System.Windows.Forms.Button();
            this.btnXemDanhSach = new System.Windows.Forms.Button();
            this.btnXemTheoLop = new System.Windows.Forms.Button();
            this.lsvDanhSach = new System.Windows.Forms.ListView();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(12, 15);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(46, 13);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "Server:";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(15, 31);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(200, 20);
            this.txtServer.TabIndex = 1;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(230, 15);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(57, 13);
            this.lblDatabase.TabIndex = 2;
            this.lblDatabase.Text = "Database:";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(233, 31);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(200, 20);
            this.txtDatabase.TabIndex = 3;
            // 
            // lblAuth
            // 
            this.lblAuth.AutoSize = true;
            this.lblAuth.Location = new System.Drawing.Point(12, 60);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(81, 13);
            this.lblAuth.TabIndex = 4;
            this.lblAuth.Text = "Authentication:";
            // 
            // rbWindowsAuth
            // 
            this.rbWindowsAuth.AutoSize = true;
            this.rbWindowsAuth.Location = new System.Drawing.Point(15, 76);
            this.rbWindowsAuth.Name = "rbWindowsAuth";
            this.rbWindowsAuth.Size = new System.Drawing.Size(141, 17);
            this.rbWindowsAuth.TabIndex = 5;
            this.rbWindowsAuth.TabStop = true;
            this.rbWindowsAuth.Text = "Windows Authentication";
            this.rbWindowsAuth.UseVisualStyleBackColor = true;
            this.rbWindowsAuth.CheckedChanged += new System.EventHandler(this.rbSqlAuth_CheckedChanged);
            // 
            // rbSqlAuth
            // 
            this.rbSqlAuth.AutoSize = true;
            this.rbSqlAuth.Location = new System.Drawing.Point(162, 76);
            this.rbSqlAuth.Name = "rbSqlAuth";
            this.rbSqlAuth.Size = new System.Drawing.Size(151, 17);
            this.rbSqlAuth.TabIndex = 6;
            this.rbSqlAuth.TabStop = true;
            this.rbSqlAuth.Text = "SQL Server Authentication";
            this.rbSqlAuth.UseVisualStyleBackColor = true;
            this.rbSqlAuth.CheckedChanged += new System.EventHandler(this.rbSqlAuth_CheckedChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 106);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 13);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "User ID:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(64, 103);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(130, 20);
            this.txtUser.TabIndex = 8;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(210, 106);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 13);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(273, 103);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(130, 20);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(450, 28);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(120, 23);
            this.btnTestConnection.TabIndex = 11;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnOpenConnect
            // 
            this.btnOpenConnect.Location = new System.Drawing.Point(450, 60);
            this.btnOpenConnect.Name = "btnOpenConnect";
            this.btnOpenConnect.Size = new System.Drawing.Size(120, 23);
            this.btnOpenConnect.TabIndex = 12;
            this.btnOpenConnect.Text = "Open Connection";
            this.btnOpenConnect.UseVisualStyleBackColor = true;
            this.btnOpenConnect.Click += new System.EventHandler(this.btnOpenConnect_Click);
            // 
            // btnCloseConnect
            // 
            this.btnCloseConnect.Location = new System.Drawing.Point(450, 92);
            this.btnCloseConnect.Name = "btnCloseConnect";
            this.btnCloseConnect.Size = new System.Drawing.Size(120, 23);
            this.btnCloseConnect.TabIndex = 13;
            this.btnCloseConnect.Text = "Close Connection";
            this.btnCloseConnect.UseVisualStyleBackColor = true;
            this.btnCloseConnect.Click += new System.EventHandler(this.btnCloseConnect_Click);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(80, 150);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(150, 20);
            this.txtMaSV.TabIndex = 15;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(80, 176);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.ReadOnly = true;
            this.txtTenSV.Size = new System.Drawing.Size(220, 20);
            this.txtTenSV.TabIndex = 17;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(80, 202);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.ReadOnly = true;
            this.txtGioiTinh.Size = new System.Drawing.Size(100, 20);
            this.txtGioiTinh.TabIndex = 19;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(268, 202);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.ReadOnly = true;
            this.txtNgaySinh.Size = new System.Drawing.Size(120, 20);
            this.txtNgaySinh.TabIndex = 21;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(80, 228);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.ReadOnly = true;
            this.txtQueQuan.Size = new System.Drawing.Size(220, 20);
            this.txtQueQuan.TabIndex = 23;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(80, 254);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(150, 20);
            this.txtMaLop.TabIndex = 25;
            // 
            // btnCountSV
            // 
            this.btnCountSV.Location = new System.Drawing.Point(450, 210);
            this.btnCountSV.Name = "btnCountSV";
            this.btnCountSV.Size = new System.Drawing.Size(120, 23);
            this.btnCountSV.TabIndex = 26;
            this.btnCountSV.Text = "Đếm Sinh Viên";
            this.btnCountSV.UseVisualStyleBackColor = true;
            this.btnCountSV.Click += new System.EventHandler(this.btnCountSV_Click);
            // 
            // btnXemThongTin
            // 
            this.btnXemThongTin.Location = new System.Drawing.Point(240, 148);
            this.btnXemThongTin.Name = "btnXemThongTin";
            this.btnXemThongTin.Size = new System.Drawing.Size(100, 23);
            this.btnXemThongTin.TabIndex = 27;
            this.btnXemThongTin.Text = "Xem Thông Tin";
            this.btnXemThongTin.UseVisualStyleBackColor = true;
            this.btnXemThongTin.Click += new System.EventHandler(this.btnXemThongTin_Click);
            // 
            // btnXemDanhSach
            // 
            this.btnXemDanhSach.Location = new System.Drawing.Point(450, 150);
            this.btnXemDanhSach.Name = "btnXemDanhSach";
            this.btnXemDanhSach.Size = new System.Drawing.Size(120, 23);
            this.btnXemDanhSach.TabIndex = 28;
            this.btnXemDanhSach.Text = "Xem Toàn Bộ DS";
            this.btnXemDanhSach.UseVisualStyleBackColor = true;
            this.btnXemDanhSach.Click += new System.EventHandler(this.btnXemDanhSach_Click);
            // 
            // btnXemTheoLop
            // 
            this.btnXemTheoLop.Location = new System.Drawing.Point(450, 180);
            this.btnXemTheoLop.Name = "btnXemTheoLop";
            this.btnXemTheoLop.Size = new System.Drawing.Size(120, 23);
            this.btnXemTheoLop.TabIndex = 29;
            this.btnXemTheoLop.Text = "Xem Theo Lớp";
            this.btnXemTheoLop.UseVisualStyleBackColor = true;
            this.btnXemTheoLop.Click += new System.EventHandler(this.btnXemTheoLop_Click);
            // 
            // lsvDanhSach
            // 
            this.lsvDanhSach.FullRowSelect = true;
            this.lsvDanhSach.GridLines = true;
            this.lsvDanhSach.HideSelection = false;
            this.lsvDanhSach.Location = new System.Drawing.Point(15, 290);
            this.lsvDanhSach.Name = "lsvDanhSach";
            this.lsvDanhSach.Size = new System.Drawing.Size(555, 200);
            this.lsvDanhSach.TabIndex = 30;
            this.lsvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(12, 153);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(42, 13);
            this.lblMaSV.TabIndex = 14;
            this.lblMaSV.Text = "Mã SV:";
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Location = new System.Drawing.Point(12, 179);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(46, 13);
            this.lblTenSV.TabIndex = 16;
            this.lblTenSV.Text = "Tên SV:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(12, 205);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(54, 13);
            this.lblGioiTinh.TabIndex = 18;
            this.lblGioiTinh.Text = "Giới Tính:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(200, 205);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(59, 13);
            this.lblNgaySinh.TabIndex = 20;
            this.lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Location = new System.Drawing.Point(12, 231);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(59, 13);
            this.lblQueQuan.TabIndex = 22;
            this.lblQueQuan.Text = "Quê Quán:";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(12, 257);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(46, 13);
            this.lblMaLop.TabIndex = 24;
            this.lblMaLop.Text = "Mã Lớp:";
            // 
            // Form6
            // 
            this.ClientSize = new System.Drawing.Size(584, 501);
            this.Controls.Add(this.lsvDanhSach);
            this.Controls.Add(this.btnXemTheoLop);
            this.Controls.Add(this.btnXemDanhSach);
            this.Controls.Add(this.btnXemThongTin);
            this.Controls.Add(this.btnCountSV);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.lblQueQuan);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.lblTenSV);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.btnCloseConnect);
            this.Controls.Add(this.btnOpenConnect);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.rbSqlAuth);
            this.Controls.Add(this.rbWindowsAuth);
            this.Controls.Add(this.lblAuth);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblServer);
            this.Name = "Form6";
            this.Text = "Quản lý Sinh viên - ADO.NET";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
