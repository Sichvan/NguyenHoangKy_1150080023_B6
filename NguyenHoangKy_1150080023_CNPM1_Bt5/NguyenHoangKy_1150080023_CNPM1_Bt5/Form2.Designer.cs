namespace NguyenHoangKy_1150080023_CNPM1_Bt5
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelA = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.USCLN = new System.Windows.Forms.RadioButton();
            this.BSCLN = new System.Windows.Forms.RadioButton();
            this.labelKQ = new System.Windows.Forms.Label();
            this.kq = new System.Windows.Forms.TextBox();
            this.Tim = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelA);
            this.groupBox1.Controls.Add(this.textBoxA);
            this.groupBox1.Controls.Add(this.labelB);
            this.groupBox1.Controls.Add(this.textBoxB);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập dữ liệu";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(10, 30);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(102, 20);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "Số nguyên a:";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(100, 27);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(120, 26);
            this.textBoxA.TabIndex = 1;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(10, 65);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(102, 20);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "Số nguyên b:";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(100, 62);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(120, 26);
            this.textBoxB.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.USCLN);
            this.groupBox2.Controls.Add(this.BSCLN);
            this.groupBox2.Location = new System.Drawing.Point(300, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tùy chọn";
            // 
            // USCLN
            // 
            this.USCLN.AutoSize = true;
            this.USCLN.Location = new System.Drawing.Point(20, 30);
            this.USCLN.Name = "USCLN";
            this.USCLN.Size = new System.Drawing.Size(88, 24);
            this.USCLN.TabIndex = 0;
            this.USCLN.TabStop = true;
            this.USCLN.Text = "USCLN";
            // 
            // BSCLN
            // 
            this.BSCLN.AutoSize = true;
            this.BSCLN.Location = new System.Drawing.Point(20, 65);
            this.BSCLN.Name = "BSCLN";
            this.BSCLN.Size = new System.Drawing.Size(89, 24);
            this.BSCLN.TabIndex = 1;
            this.BSCLN.TabStop = true;
            this.BSCLN.Text = "BSCNN";
            // 
            // labelKQ
            // 
            this.labelKQ.AutoSize = true;
            this.labelKQ.Location = new System.Drawing.Point(20, 150);
            this.labelKQ.Name = "labelKQ";
            this.labelKQ.Size = new System.Drawing.Size(68, 20);
            this.labelKQ.TabIndex = 2;
            this.labelKQ.Text = "Kết quả:";
            // 
            // kq
            // 
            this.kq.Location = new System.Drawing.Point(100, 147);
            this.kq.Name = "kq";
            this.kq.Size = new System.Drawing.Size(200, 26);
            this.kq.TabIndex = 3;
            this.kq.TextChanged += new System.EventHandler(this.kq_TextChanged);
            // 
            // Tim
            // 
            this.Tim.Location = new System.Drawing.Point(100, 200);
            this.Tim.Name = "Tim";
            this.Tim.Size = new System.Drawing.Size(75, 25);
            this.Tim.TabIndex = 4;
            this.Tim.Text = "Tìm";
            this.Tim.UseVisualStyleBackColor = true;
            this.Tim.Click += new System.EventHandler(this.Tim_Click);
            // 
            // Thoat
            // 
            this.Thoat.Location = new System.Drawing.Point(200, 200);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(75, 25);
            this.Thoat.TabIndex = 5;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(480, 260);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelKQ);
            this.Controls.Add(this.kq);
            this.Controls.Add(this.Tim);
            this.Controls.Add(this.Thoat);
            this.Name = "Form2";
            this.Text = "Tìm USCLN và BSCNN của số nguyên a và b";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton USCLN;
        private System.Windows.Forms.RadioButton BSCLN;
        private System.Windows.Forms.Label labelKQ;
        private System.Windows.Forms.TextBox kq;
        private System.Windows.Forms.Button Tim;
        private System.Windows.Forms.Button Thoat;
    }
}
