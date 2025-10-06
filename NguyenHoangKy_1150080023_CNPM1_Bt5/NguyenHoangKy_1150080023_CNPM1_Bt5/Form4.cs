using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenHoangKy_1150080023_CNPM1_Bt5
{
    public partial class Form4 : Form
    {
        // Danh sách lưu món ăn và số lượng
        private Dictionary<string, int> danhSachMon = new Dictionary<string, int>();

        public Form4()
        {
            InitializeComponent();
            // Gán sự kiện Load để tải ảnh dynamic
            this.Load += new EventHandler(this.Form4_Load);
            TaoSuKienChoCacButtonMonAn();
            // Gán sự kiện cho btnXoa và btnOrder
            btnXoa.Click += btnXoa_Click;
            btnOrder.Click += btnOrder_Click;
        }

        // Sự kiện Load form để tải ảnh
        private async void Form4_Load(object sender, EventArgs e)
        {
            await TaiAnhTuURL();
        }

        // Tải ảnh từ URL dynamic
        private async Task TaiAnhTuURL()
        {
            string urlAnh = "https://images.unsplash.com/photo-1571091718767-18b5b1457add?w=300&fit=crop";  // URL direct cheeseburger free
            try
            {
                using (WebClient client = new WebClient())
                {
                    byte[] imageBytes = await client.DownloadDataTaskAsync(urlAnh);
                    using (var ms = new System.IO.MemoryStream(imageBytes))
                    {
                        pictureBox1.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải ảnh: " + ex.Message + "\nKiểm tra kết nối mạng!");
                // Fallback: Có thể gán ảnh default từ Resources nếu có
            }
        }

        private void TaoSuKienChoCacButtonMonAn()
        {
            // Duyệt qua tất cả Button trong groupBox1
            foreach (Control c in groupBox1.Controls)
            {
                if (c is Button btn)
                {
                    btn.Click += BtnMonAn_Click;
                }
            }
        }

        // Khi nhấn vào món ăn
        private void BtnMonAn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string tenMon = btn.Text;

            // Nếu món ăn đã có thì tăng số lượng, ngược lại thêm mới
            if (danhSachMon.ContainsKey(tenMon))
                danhSachMon[tenMon]++;
            else
                danhSachMon[tenMon] = 1;

            CapNhatDataGridView();
        }

        // Cập nhật hiển thị DataGridView
        private void CapNhatDataGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên món");
            dt.Columns.Add("Số lượng");

            foreach (var mon in danhSachMon)
            {
                dt.Rows.Add(mon.Key, mon.Value);
            }

            dataGridView1.DataSource = dt;
        }

        // Xóa danh sách
        private void btnXoa_Click(object sender, EventArgs e)
        {
            danhSachMon.Clear();
            CapNhatDataGridView();
        }

        // Ghi tệp Order
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (cboChonBan.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi order!");
                return;
            }

            string tenBan = cboChonBan.SelectedItem.ToString();
            string fileName = $"Order_{tenBan}_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine($"Bàn: {tenBan}");
                sw.WriteLine($"Thời gian: {DateTime.Now}");
                sw.WriteLine("-------------------------");

                foreach (var mon in danhSachMon)
                {
                    sw.WriteLine($"{mon.Key}: {mon.Value}");
                }

                sw.WriteLine("-------------------------");
                sw.WriteLine("Trạng thái: Đã gửi xuống bếp");
            }

            MessageBox.Show($"Đã ghi order của {tenBan} vào file:\n{fileName}");
            // Clear danh sách sau khi order
            danhSachMon.Clear();
            CapNhatDataGridView();
        }
    }
}