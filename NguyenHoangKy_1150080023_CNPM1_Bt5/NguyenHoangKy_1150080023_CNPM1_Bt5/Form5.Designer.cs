namespace NguyenHoangKy_1150080023_CNPM1_Bt5
{
    partial class Form5
    {
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxThongTin;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.GroupBox groupBoxChucNang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colLop;
        private System.Windows.Forms.ColumnHeader colDiaChi;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxThongTin = new System.Windows.Forms.GroupBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.groupBoxChucNang = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxThongTin.SuspendLayout();
            this.groupBoxChucNang.SuspendLayout();
            this.groupBoxDanhSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DANH MỤC SINH VIÊN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxThongTin
            // 
            this.groupBoxThongTin.Controls.Add(this.txtHoTen);
            this.groupBoxThongTin.Controls.Add(this.txtLop);
            this.groupBoxThongTin.Controls.Add(this.dtpNgaySinh);
            this.groupBoxThongTin.Controls.Add(this.txtDiaChi);
            this.groupBoxThongTin.Controls.Add(this.lblHoTen);
            this.groupBoxThongTin.Controls.Add(this.lblLop);
            this.groupBoxThongTin.Controls.Add(this.lblNgaySinh);
            this.groupBoxThongTin.Controls.Add(this.lblDiaChi);
            this.groupBoxThongTin.Location = new System.Drawing.Point(20, 60);
            this.groupBoxThongTin.Name = "groupBoxThongTin";
            this.groupBoxThongTin.Size = new System.Drawing.Size(760, 100);
            this.groupBoxThongTin.TabIndex = 1;
            this.groupBoxThongTin.TabStop = false;
            this.groupBoxThongTin.Text = "Thông tin sinh viên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(90, 27);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(250, 26);
            this.txtHoTen.TabIndex = 0;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(430, 27);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(300, 26);
            this.txtLop.TabIndex = 1;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(90, 61);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(250, 26);
            this.dtpNgaySinh.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(430, 61);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(300, 26);
            this.txtDiaChi.TabIndex = 3;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(15, 30);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(61, 20);
            this.lblHoTen.TabIndex = 4;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(380, 30);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(40, 20);
            this.lblLop.TabIndex = 5;
            this.lblLop.Text = "Lớp:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(15, 65);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(82, 20);
            this.lblNgaySinh.TabIndex = 6;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(363, 66);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(61, 20);
            this.lblDiaChi.TabIndex = 7;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // groupBoxChucNang
            // 
            this.groupBoxChucNang.Controls.Add(this.btnThem);
            this.groupBoxChucNang.Controls.Add(this.btnSua);
            this.groupBoxChucNang.Controls.Add(this.btnXoa);
            this.groupBoxChucNang.Controls.Add(this.btnThoat);
            this.groupBoxChucNang.Location = new System.Drawing.Point(20, 170);
            this.groupBoxChucNang.Name = "groupBoxChucNang";
            this.groupBoxChucNang.Size = new System.Drawing.Size(760, 60);
            this.groupBoxChucNang.TabIndex = 2;
            this.groupBoxChucNang.TabStop = false;
            this.groupBoxChucNang.Text = "Chức năng";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(90, 22);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(240, 22);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 30);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(390, 22);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(540, 22);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 30);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Controls.Add(this.lvSinhVien);
            this.groupBoxDanhSach.Location = new System.Drawing.Point(20, 240);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Size = new System.Drawing.Size(760, 180);
            this.groupBoxDanhSach.TabIndex = 3;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Thông tin chung sinh viên";
            // 
            // lvSinhVien
            // 
            this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHoTen,
            this.colNgaySinh,
            this.colLop,
            this.colDiaChi});
            this.lvSinhVien.FullRowSelect = true;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.Location = new System.Drawing.Point(15, 25);
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(730, 140);
            this.lvSinhVien.TabIndex = 0;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ tên";
            this.colHoTen.Width = 180;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày sinh";
            this.colNgaySinh.Width = 120;
            // 
            // colLop
            // 
            this.colLop.Text = "Lớp";
            this.colLop.Width = 120;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa chỉ";
            this.colDiaChi.Width = 280;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBoxThongTin);
            this.Controls.Add(this.groupBoxChucNang);
            this.Controls.Add(this.groupBoxDanhSach);
            this.Name = "Form5";
            this.Text = "Danh sách sinh viên";
            this.groupBoxThongTin.ResumeLayout(false);
            this.groupBoxThongTin.PerformLayout();
            this.groupBoxChucNang.ResumeLayout(false);
            this.groupBoxDanhSach.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
