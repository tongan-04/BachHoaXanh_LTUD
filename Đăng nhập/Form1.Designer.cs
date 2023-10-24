namespace Đăng_nhập
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbDangNhap = new System.Windows.Forms.Label();
            this.lbsdt = new System.Windows.Forms.Label();
            this.lbmk = new System.Windows.Forms.Label();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.cbLuu = new System.Windows.Forms.CheckBox();
            this.cbHienThi = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 235);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(267, 22);
            this.textBox2.TabIndex = 1;
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.AutoSize = true;
            this.lbDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbDangNhap.Location = new System.Drawing.Point(164, 30);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(214, 46);
            this.lbDangNhap.TabIndex = 2;
            this.lbDangNhap.Text = "Đăng nhập";
            // 
            // lbsdt
            // 
            this.lbsdt.AutoSize = true;
            this.lbsdt.Location = new System.Drawing.Point(147, 108);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(85, 16);
            this.lbsdt.TabIndex = 3;
            this.lbsdt.Text = "Số điện thoại";
            // 
            // lbmk
            // 
            this.lbmk.AutoSize = true;
            this.lbmk.Location = new System.Drawing.Point(150, 193);
            this.lbmk.Name = "lbmk";
            this.lbmk.Size = new System.Drawing.Size(61, 16);
            this.lbmk.TabIndex = 4;
            this.lbmk.Text = "Mật khẩu";
            // 
            // btnDangKi
            // 
            this.btnDangKi.Location = new System.Drawing.Point(121, 332);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(120, 40);
            this.btnDangKi.TabIndex = 5;
            this.btnDangKi.Text = "Đăng kí";
            this.btnDangKi.UseVisualStyleBackColor = true;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(330, 332);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(120, 40);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Text = "Đăng  nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // cbLuu
            // 
            this.cbLuu.AutoSize = true;
            this.cbLuu.Location = new System.Drawing.Point(310, 280);
            this.cbLuu.Name = "cbLuu";
            this.cbLuu.Size = new System.Drawing.Size(107, 20);
            this.cbLuu.TabIndex = 7;
            this.cbLuu.Text = "Lưu tài khoản";
            this.cbLuu.UseVisualStyleBackColor = true;
            // 
            // cbHienThi
            // 
            this.cbHienThi.AutoSize = true;
            this.cbHienThi.Location = new System.Drawing.Point(147, 280);
            this.cbHienThi.Name = "cbHienThi";
            this.cbHienThi.Size = new System.Drawing.Size(130, 20);
            this.cbHienThi.TabIndex = 8;
            this.cbHienThi.Text = "Hiển thị mật khẩu";
            this.cbHienThi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.cbHienThi);
            this.Controls.Add(this.cbLuu);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.lbmk);
            this.Controls.Add(this.lbsdt);
            this.Controls.Add(this.lbDangNhap);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbDangNhap;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.Label lbmk;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.CheckBox cbLuu;
        private System.Windows.Forms.CheckBox cbHienThi;
    }
}

