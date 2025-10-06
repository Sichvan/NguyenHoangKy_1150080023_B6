using System.Windows.Forms;
using System.Drawing;

namespace NguyenHoangKy_1150080023_CNPM1_Bt5
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnComChienTrung = new System.Windows.Forms.Button();
            this.btnBanhMyOpLa = new System.Windows.Forms.Button();
            this.btnCoca = new System.Windows.Forms.Button();
            this.btnLipton = new System.Windows.Forms.Button();
            this.btnOcRangMuoi = new System.Windows.Forms.Button();
            this.btnKhoaiTayChien = new System.Windows.Forms.Button();
            this.btn7up = new System.Windows.Forms.Button();
            this.btnCam = new System.Windows.Forms.Button();
            this.btnMyXaoHaiSan = new System.Windows.Forms.Button();
            this.btnCaVienChien = new System.Windows.Forms.Button();
            this.btnPepsi = new System.Windows.Forms.Button();
            this.btnCafe = new System.Windows.Forms.Button();
            this.btnBugerBoNuong = new System.Windows.Forms.Button();
            this.btnDuiGaRan = new System.Windows.Forms.Button();
            this.btnBunBoHue = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cboChonBan = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // pictureBox1
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Size = new System.Drawing.Size(120, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // Không gán Image ở đây, sẽ load dynamic


            // thêm hình burger vào Resources
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Size = new System.Drawing.Size(120, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // labelTitle
            this.labelTitle.Text = "Quán ăn nhanh Hưng Thịnh";
            this.labelTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.BackColor = System.Drawing.Color.Green;
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Location = new System.Drawing.Point(130, 10);
            this.labelTitle.Size = new System.Drawing.Size(500, 80);

            // groupBox1
            this.groupBox1.Text = "Danh sách món ăn:";
            this.groupBox1.Location = new System.Drawing.Point(10, 100);
            this.groupBox1.Size = new System.Drawing.Size(620, 200);

            // Tạo các button món ăn
            int x = 10, y = 30;
            int width = 130, height = 35;
            int spacingX = 145, spacingY = 45;

            string[] tenMon = {
                "Cơm chiên trứng","Bánh mì ốp la","Coca","Lipton",
                "Ốc rang muối","Khoai tây chiên","7 up","Cam",
                "Mỳ xào hải sản","Cá viên chiên","Pepsi","Cafe",
                "Buger bò nướng","Đùi gà rán","Bún bò Huế"
            };

            for (int i = 0; i < tenMon.Length; i++)
            {
                Button btn = new Button();
                btn.Text = tenMon[i];
                btn.Size = new System.Drawing.Size(width, height);
                btn.Location = new System.Drawing.Point(x + (i % 4) * spacingX, y + (i / 4) * spacingY);
                this.groupBox1.Controls.Add(btn);
            }

            // btnXoa
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(10, 310);
            this.btnXoa.Size = new System.Drawing.Size(80, 30);

            // cboChonBan
            this.cboChonBan.Location = new System.Drawing.Point(110, 315);
            this.cboChonBan.Size = new System.Drawing.Size(120, 25);
            this.cboChonBan.Items.AddRange(new object[] { "Bàn 1", "Bàn 2", "Bàn 3", "Bàn 4" });

            // btnOrder
            this.btnOrder.Text = "Order";
            this.btnOrder.Location = new System.Drawing.Point(250, 310);
            this.btnOrder.Size = new System.Drawing.Size(80, 30);

            // dataGridView1
            this.dataGridView1.Location = new System.Drawing.Point(10, 350);
            this.dataGridView1.Size = new System.Drawing.Size(620, 150);

            // Form4
            this.ClientSize = new System.Drawing.Size(640, 520);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.cboChonBan);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.dataGridView1);
            this.Text = "Quán ăn nhanh Hưng Thịnh";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cboChonBan;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Button btnComChienTrung;
        private System.Windows.Forms.Button btnBanhMyOpLa;
        private System.Windows.Forms.Button btnCoca;
        private System.Windows.Forms.Button btnLipton;
        private System.Windows.Forms.Button btnOcRangMuoi;
        private System.Windows.Forms.Button btnKhoaiTayChien;
        private System.Windows.Forms.Button btn7up;
        private System.Windows.Forms.Button btnCam;
        private System.Windows.Forms.Button btnMyXaoHaiSan;
        private System.Windows.Forms.Button btnCaVienChien;
        private System.Windows.Forms.Button btnPepsi;
        private System.Windows.Forms.Button btnCafe;
        private System.Windows.Forms.Button btnBugerBoNuong;
        private System.Windows.Forms.Button btnDuiGaRan;
        private System.Windows.Forms.Button btnBunBoHue;
    }
}
