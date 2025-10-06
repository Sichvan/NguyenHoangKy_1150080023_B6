using System;
using System.Windows.Forms;

namespace NguyenHoangKy_1150080023_CNPM1_Bt5
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // Có thể khởi tạo dữ liệu mẫu nếu muốn
        }

        // 🟢 Nút THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string lop = txtLop.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string ngaySinh = dtpNgaySinh.Value.ToShortDateString();

            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Họ tên sinh viên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            ListViewItem item = new ListViewItem(hoTen);
            item.SubItems.Add(ngaySinh);
            item.SubItems.Add(lop);
            item.SubItems.Add(diaChi);

            lvSinhVien.Items.Add(item);
            ClearTextBoxes();
        }

        // 🟠 Nút SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ListViewItem item = lvSinhVien.SelectedItems[0];
            item.Text = txtHoTen.Text.Trim();
            item.SubItems[1].Text = dtpNgaySinh.Value.ToShortDateString();
            item.SubItems[2].Text = txtLop.Text.Trim();
            item.SubItems[3].Text = txtDiaChi.Text.Trim();

            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();
        }

        // 🔴 Nút XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lvSinhVien.Items.Remove(lvSinhVien.SelectedItems[0]);
                ClearTextBoxes();
            }
        }

        // ⚫ Nút THOÁT
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // 🟣 Khi chọn 1 dòng trong ListView
        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lvSinhVien.SelectedItems[0];
                txtHoTen.Text = item.SubItems[0].Text;
                dtpNgaySinh.Value = DateTime.Parse(item.SubItems[1].Text);
                txtLop.Text = item.SubItems[2].Text;
                txtDiaChi.Text = item.SubItems[3].Text;
            }
        }

        // 🧹 Hàm xóa nội dung sau khi thêm/sửa/xóa
        private void ClearTextBoxes()
        {
            txtHoTen.Clear();
            txtLop.Clear();
            txtDiaChi.Clear();
            dtpNgaySinh.Value = DateTime.Now;
        }
    }
}
