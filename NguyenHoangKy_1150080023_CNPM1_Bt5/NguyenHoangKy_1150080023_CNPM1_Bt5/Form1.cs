using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenHoangKy_1150080023_CNPM1_Bt5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(inputa.Text);
            double b = double.Parse(inputb.Text);
            txtKetQua.Text = (a - b).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(inputa.Text);
            double b = double.Parse(inputb.Text);
            txtKetQua.Text = (a * b).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Nhapa_Click(object sender, EventArgs e)
        {

        }

        private void inputa_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttoncong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(inputa.Text);
            double b = double.Parse(inputb.Text);
            txtKetQua.Text = (a + b).ToString();
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inputb_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonchia_Click(object sender, EventArgs e)
        {
            double a = double.Parse(inputa.Text);
            double b = double.Parse(inputb.Text);

            if (b != 0)
                txtKetQua.Text = (a / b).ToString();
            else
                MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            inputa.Clear();
            inputb.Clear();
            txtKetQua.Clear();
            inputa.Focus();
        }

        private void inputkq_TextChanged(object sender, EventArgs e)
        {
            txtKetQua.Text = kq.ToString();
        }
    }
}
