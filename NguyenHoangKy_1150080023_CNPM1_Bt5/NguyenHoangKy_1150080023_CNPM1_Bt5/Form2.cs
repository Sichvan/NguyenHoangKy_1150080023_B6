using System;
using System.Windows.Forms;

namespace NguyenHoangKy_1150080023_CNPM1_Bt5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Hàm tìm USCLN (Ước số chung lớn nhất)
        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        // Hàm tìm BSCNN (Bội số chung nhỏ nhất)
        private int BSCNN(int a, int b)
        {
            return (a * b) / UCLN(a, b);
        }

        private void Tim_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBoxA.Text);
                int b = int.Parse(textBoxB.Text);

                if (USCLN.Checked)
                {
                    kq.Text = UCLN(a, b).ToString();
                }
                else if (BSCLN.Checked)
                {
                    kq.Text = BSCNN(a, b).ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn USCLN hoặc BSCNN!");
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ!");
            }
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kq_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
