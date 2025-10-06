namespace NguyenHoangKy_1150080023_CNPM1_Bt5
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Nhapa = new System.Windows.Forms.Label();
            this.Nhapb = new System.Windows.Forms.Label();
            this.kq = new System.Windows.Forms.Label();
            this.inputa = new System.Windows.Forms.TextBox();
            this.inputb = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.buttoncong = new System.Windows.Forms.Button();
            this.buttontru = new System.Windows.Forms.Button();
            this.buttonnhan = new System.Windows.Forms.Button();
            this.buttonchia = new System.Windows.Forms.Button();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.buttonthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỰC HIỆN CÁC PHÉP TÍNH SỐ HỌC ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nhapa
            // 
            this.Nhapa.AutoSize = true;
            this.Nhapa.Location = new System.Drawing.Point(254, 153);
            this.Nhapa.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Nhapa.Name = "Nhapa";
            this.Nhapa.Size = new System.Drawing.Size(128, 29);
            this.Nhapa.TabIndex = 1;
            this.Nhapa.Text = "Nhập số a:";
            this.Nhapa.Click += new System.EventHandler(this.Nhapa_Click);
            // 
            // Nhapb
            // 
            this.Nhapb.AutoSize = true;
            this.Nhapb.Location = new System.Drawing.Point(253, 243);
            this.Nhapb.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Nhapb.Name = "Nhapb";
            this.Nhapb.Size = new System.Drawing.Size(129, 29);
            this.Nhapb.TabIndex = 2;
            this.Nhapb.Text = "Nhập số b:";
            // 
            // kq
            // 
            this.kq.AutoSize = true;
            this.kq.Location = new System.Drawing.Point(268, 378);
            this.kq.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.kq.Name = "kq";
            this.kq.Size = new System.Drawing.Size(95, 29);
            this.kq.TabIndex = 3;
            this.kq.Text = "Kết quả";
            // 
            // inputa
            // 
            this.inputa.Location = new System.Drawing.Point(478, 147);
            this.inputa.Name = "inputa";
            this.inputa.Size = new System.Drawing.Size(269, 35);
            this.inputa.TabIndex = 4;
            this.inputa.TextChanged += new System.EventHandler(this.inputa_TextChanged);
            // 
            // inputb
            // 
            this.inputb.Location = new System.Drawing.Point(478, 237);
            this.inputb.Name = "inputb";
            this.inputb.Size = new System.Drawing.Size(269, 35);
            this.inputb.TabIndex = 5;
            this.inputb.TextChanged += new System.EventHandler(this.inputb_TextChanged);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(478, 372);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(269, 35);
            this.txtKetQua.TabIndex = 6;
            this.txtKetQua.TextChanged += new System.EventHandler(this.inputkq_TextChanged);
            // 
            // buttoncong
            // 
            this.buttoncong.Location = new System.Drawing.Point(82, 308);
            this.buttoncong.Name = "buttoncong";
            this.buttoncong.Size = new System.Drawing.Size(92, 37);
            this.buttoncong.TabIndex = 7;
            this.buttoncong.Text = "Cộng";
            this.buttoncong.UseVisualStyleBackColor = true;
            this.buttoncong.Click += new System.EventHandler(this.buttoncong_Click);
            // 
            // buttontru
            // 
            this.buttontru.Location = new System.Drawing.Point(325, 308);
            this.buttontru.Name = "buttontru";
            this.buttontru.Size = new System.Drawing.Size(92, 37);
            this.buttontru.TabIndex = 8;
            this.buttontru.Text = "Trừ";
            this.buttontru.UseVisualStyleBackColor = true;
            this.buttontru.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonnhan
            // 
            this.buttonnhan.Location = new System.Drawing.Point(560, 308);
            this.buttonnhan.Name = "buttonnhan";
            this.buttonnhan.Size = new System.Drawing.Size(92, 37);
            this.buttonnhan.TabIndex = 9;
            this.buttonnhan.Text = "Nhân";
            this.buttonnhan.UseVisualStyleBackColor = true;
            this.buttonnhan.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonchia
            // 
            this.buttonchia.Location = new System.Drawing.Point(803, 308);
            this.buttonchia.Name = "buttonchia";
            this.buttonchia.Size = new System.Drawing.Size(92, 37);
            this.buttonchia.TabIndex = 10;
            this.buttonchia.Text = "Chia";
            this.buttonchia.UseVisualStyleBackColor = true;
            this.buttonchia.Click += new System.EventHandler(this.buttonchia_Click);
            // 
            // buttonxoa
            // 
            this.buttonxoa.Location = new System.Drawing.Point(392, 466);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(92, 37);
            this.buttonxoa.TabIndex = 11;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = true;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click);
            // 
            // buttonthoat
            // 
            this.buttonthoat.Location = new System.Drawing.Point(638, 466);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(92, 37);
            this.buttonthoat.TabIndex = 12;
            this.buttonthoat.Text = "Thoát";
            this.buttonthoat.UseVisualStyleBackColor = true;
            this.buttonthoat.Click += new System.EventHandler(this.buttonthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 652);
            this.Controls.Add(this.buttonthoat);
            this.Controls.Add(this.buttonxoa);
            this.Controls.Add(this.buttonchia);
            this.Controls.Add(this.buttonnhan);
            this.Controls.Add(this.buttontru);
            this.Controls.Add(this.buttoncong);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.inputb);
            this.Controls.Add(this.inputa);
            this.Controls.Add(this.kq);
            this.Controls.Add(this.Nhapb);
            this.Controls.Add(this.Nhapa);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nhapa;
        private System.Windows.Forms.Label Nhapb;
        private System.Windows.Forms.Label kq;
        private System.Windows.Forms.TextBox inputa;
        private System.Windows.Forms.TextBox inputb;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button buttoncong;
        private System.Windows.Forms.Button buttontru;
        private System.Windows.Forms.Button buttonnhan;
        private System.Windows.Forms.Button buttonchia;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.Button buttonthoat;
    }
}

