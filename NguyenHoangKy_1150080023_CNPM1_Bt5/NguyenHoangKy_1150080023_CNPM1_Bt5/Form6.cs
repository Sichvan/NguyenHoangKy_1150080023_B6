using NguyenHoangKy_1150080023_CNPM1_Bt5;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NguyenHoangKy_1150080023_CNPM1_Bt5
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Xây dựng chuỗi kết nối dựa trên các điều khiển trên Form.
        /// </summary>
        /// <returns>Chuỗi kết nối đến SQL Server.</returns>
        private string BuildConnectionString()
        {
            string server = txtServer.Text.Trim();
            string database = txtDatabase.Text.Trim();
            if (string.IsNullOrEmpty(server) || string.IsNullOrEmpty(database))
            {
                throw new InvalidOperationException("Bạn phải nhập đầy đủ tên Server và Database.");
            }

            if (rbWindowsAuth.Checked)
            {
                // Sử dụng xác thực Windows
                return $"Data Source={server};Initial Catalog={database};Integrated Security=True;Trust Server Certificate=True;";
            }
            else
            {
                // Sử dụng xác thực SQL Server
                string user = txtUser.Text.Trim();
                string pass = txtPassword.Text;
                if (string.IsNullOrEmpty(user))
                {
                    throw new InvalidOperationException("Bạn phải nhập User ID cho SQL Server Authentication.");
                }
                return $"Data Source={server};Initial Catalog={database};User ID={user};Password={pass};Trust Server Certificate=True;";
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = BuildConnectionString();
                // Sử dụng 'using' để đảm bảo kết nối được đóng tự động
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    MessageBox.Show("✅ Test kết nối thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Test kết nối thất bại:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Các nút Open/Close Connection không còn cần thiết với phương pháp mới
        // vì mỗi thao tác sẽ tự quản lý kết nối của riêng nó.
        // Bạn có thể vô hiệu hóa hoặc xóa chúng.
        private void btnOpenConnect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Không cần thiết. Mỗi chức năng sẽ tự động quản lý kết nối.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCloseConnect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Không cần thiết. Kết nối được quản lý tự động.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ================= Truy vấn: Đếm sinh viên =================
        private void btnCountSV_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = BuildConnectionString();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM SinhVien", con))
                    {
                        // ExecuteScalar phù hợp để lấy về một giá trị duy nhất
                        object result = cmd.ExecuteScalar();
                        int count = (result == DBNull.Value || result == null) ? 0 : Convert.ToInt32(result);
                        MessageBox.Show("Tổng số lượng sinh viên: " + count, "Kết Quả Đếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi đếm sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= Truy vấn: 1 dòng (theo MaSV) =================
        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Vui lòng nhập Mã Sinh Viên.", "Yêu Cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = BuildConnectionString();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT TenSV, GioiTinh, NgaySinh, QueQuan, MaLop FROM SinhVien WHERE MaSV = @MaSV";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Đọc và hiển thị dữ liệu
                                txtTenSV.Text = reader.IsDBNull(0) ? "" : reader.GetString(0);
                                txtGioiTinh.Text = reader.IsDBNull(1) ? "" : reader.GetString(1);
                                txtNgaySinh.Text = reader.IsDBNull(2) ? "" : reader.GetDateTime(2).ToString("dd/MM/yyyy");
                                txtQueQuan.Text = reader.IsDBNull(3) ? "" : reader.GetString(3);
                                txtMaLop.Text = reader.IsDBNull(4) ? "" : reader.GetString(4);
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy sinh viên có mã: " + maSV, "Không Tìm Thấy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Xóa thông tin cũ
                                txtTenSV.Text = "";
                                txtGioiTinh.Text = "";
                                txtNgaySinh.Text = "";
                                txtQueQuan.Text = "";
                                txtMaLop.Text = "";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi xem thông tin sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= Truy vấn: nhiều dòng (Danh sách tất cả) =================
        private void btnXemDanhSach_Click(object sender, EventArgs e)
        {
            try
            {
                lsvDanhSach.Items.Clear(); // Xóa dữ liệu cũ
                string connectionString = BuildConnectionString();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT MaSV, TenSV, GioiTinh, NgaySinh, QueQuan, MaLop FROM SinhVien", con))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string maSV = reader.IsDBNull(0) ? "" : reader.GetString(0);
                            string tenSV = reader.IsDBNull(1) ? "" : reader.GetString(1);
                            string gioiTinh = reader.IsDBNull(2) ? "" : reader.GetString(2);
                            string ngaySinh = reader.IsDBNull(3) ? "" : reader.GetDateTime(3).ToString("dd/MM/yyyy");
                            string queQuan = reader.IsDBNull(4) ? "" : reader.GetString(4);
                            string maLop = reader.IsDBNull(5) ? "" : reader.GetString(5);

                            ListViewItem lvi = new ListViewItem(maSV);
                            lvi.SubItems.Add(tenSV);
                            lvi.SubItems.Add(gioiTinh);
                            lvi.SubItems.Add(ngaySinh);
                            lvi.SubItems.Add(queQuan);
                            lvi.SubItems.Add(maLop);
                            lsvDanhSach.Items.Add(lvi);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi tải danh sách sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= Truy vấn theo Parameter (theo MaLop) =================
        private void btnXemTheoLop_Click(object sender, EventArgs e)
        {
            string maLopParam = txtMaLop.Text.Trim();
            if (string.IsNullOrEmpty(maLopParam))
            {
                MessageBox.Show("Vui lòng nhập Mã Lớp để lọc danh sách.", "Yêu Cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                lsvDanhSach.Items.Clear();
                string connectionString = BuildConnectionString();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT MaSV, TenSV, GioiTinh, NgaySinh, QueQuan, MaLop FROM SinhVien WHERE MaLop = @MaLop";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MaLop", maLopParam);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem lvi = new ListViewItem(reader.IsDBNull(0) ? "" : reader.GetString(0));
                                lvi.SubItems.Add(reader.IsDBNull(1) ? "" : reader.GetString(1));
                                lvi.SubItems.Add(reader.IsDBNull(2) ? "" : reader.GetString(2));
                                lvi.SubItems.Add(reader.IsDBNull(3) ? "" : reader.GetDateTime(3).ToString("dd/MM/yyyy"));
                                lvi.SubItems.Add(reader.IsDBNull(4) ? "" : reader.GetString(4));
                                lvi.SubItems.Add(reader.IsDBNull(5) ? "" : reader.GetString(5));
                                lsvDanhSach.Items.Add(lvi);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi xem danh sách theo lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // Thiết lập các cột cho ListView
            lsvDanhSach.Columns.Clear();
            lsvDanhSach.Columns.Add("Mã SV", 100);
            lsvDanhSach.Columns.Add("Họ Tên", 150);
            lsvDanhSach.Columns.Add("Giới Tính", 80);
            lsvDanhSach.Columns.Add("Ngày Sinh", 100);
            lsvDanhSach.Columns.Add("Quê Quán", 120);
            lsvDanhSach.Columns.Add("Mã Lớp", 80);

            // Giá trị mặc định để dễ dàng kiểm thử
            // Sửa lại cho phù hợp với môi trường của bạn
            txtServer.Text = ".\\SQLEXPRESS"; // Các giá trị phổ biến: (localdb)\\MSSQLLocalDB, Tên-Máy-Tính
            txtDatabase.Text = "QuanLySinhVien"; // Thay bằng tên CSDL của bạn
            rbWindowsAuth.Checked = true;
            rbSqlAuth_CheckedChanged(sender, e); // Cập nhật trạng thái UI
        }

        // Bật/tắt các ô User/Password dựa trên lựa chọn Authentication
        private void rbSqlAuth_CheckedChanged(object sender, EventArgs e)
        {
            bool isSqlAuth = rbSqlAuth.Checked;
            lblUser.Enabled = isSqlAuth;
            txtUser.Enabled = isSqlAuth;
            lblPassword.Enabled = isSqlAuth;
            txtPassword.Enabled = isSqlAuth;
        }
    }
}

