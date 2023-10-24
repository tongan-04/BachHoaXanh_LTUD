namespace BachHoaXsnh
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
            this.lbsdt = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtMkhau = new System.Windows.Forms.TextBox();
            this.lbmk = new System.Windows.Forms.Label();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.lbtaikhoan = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng kí tài khoản";
            // 
            // lbsdt
            // 
            this.lbsdt.AutoSize = true;
            this.lbsdt.Location = new System.Drawing.Point(147, 97);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(85, 16);
            this.lbsdt.TabIndex = 1;
            this.lbsdt.Text = "Số điện thoại";
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(152, 135);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(231, 22);
            this.txtSdt.TabIndex = 2;
            this.txtSdt.TextChanged += new System.EventHandler(this.txtSdt_TextChanged);
            // 
            // txtMkhau
            // 
            this.txtMkhau.Location = new System.Drawing.Point(152, 210);
            this.txtMkhau.Name = "txtMkhau";
            this.txtMkhau.Size = new System.Drawing.Size(231, 22);
            this.txtMkhau.TabIndex = 3;
            // 
            // lbmk
            // 
            this.lbmk.AutoSize = true;
            this.lbmk.Location = new System.Drawing.Point(149, 177);
            this.lbmk.Name = "lbmk";
            this.lbmk.Size = new System.Drawing.Size(61, 16);
            this.lbmk.TabIndex = 4;
            this.lbmk.Text = "Mật khẩu";
            // 
            // btnDangKi
            // 
            this.btnDangKi.Location = new System.Drawing.Point(294, 312);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(120, 40);
            this.btnDangKi.TabIndex = 5;
            this.btnDangKi.Text = "Đăng kí";
            this.btnDangKi.UseVisualStyleBackColor = true;
            // 
            // lbtaikhoan
            // 
            this.lbtaikhoan.AutoSize = true;
            this.lbtaikhoan.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbtaikhoan.Location = new System.Drawing.Point(210, 258);
            this.lbtaikhoan.Name = "lbtaikhoan";
            this.lbtaikhoan.Size = new System.Drawing.Size(125, 16);
            this.lbtaikhoan.TabIndex = 6;
            this.lbtaikhoan.Text = "Bạn đã có tài khoản";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(136, 312);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(120, 40);
            this.btnDangNhap.TabIndex = 7;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.lbtaikhoan);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.lbmk);
            this.Controls.Add(this.txtMkhau);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.lbsdt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtMkhau;
        private System.Windows.Forms.Label lbmk;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.Label lbtaikhoan;
        private System.Windows.Forms.Button btnDangNhap;
    }
}

