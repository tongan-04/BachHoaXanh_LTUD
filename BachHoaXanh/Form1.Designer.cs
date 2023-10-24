namespace BachHoaXanh
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCuaHang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDatHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCuaHang,
            this.toolStripMenuItemNhanVien,
            this.toolStripMenuItemSanPham,
            this.toolStripMenuItemKhachHang,
            this.toolStripMenuItemChucVu,
            this.toolStripMenuItemDatHang});
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.quanLyToolStripMenuItem.Text = "Quan Ly";
            // 
            // toolStripMenuItemCuaHang
            // 
            this.toolStripMenuItemCuaHang.Name = "toolStripMenuItemCuaHang";
            this.toolStripMenuItemCuaHang.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemCuaHang.Text = "Cửa Hàng";
            this.toolStripMenuItemCuaHang.Click += new System.EventHandler(this.toolStripMenuItemCuaHang_Click);
            // 
            // toolStripMenuItemNhanVien
            // 
            this.toolStripMenuItemNhanVien.Name = "toolStripMenuItemNhanVien";
            this.toolStripMenuItemNhanVien.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemNhanVien.Text = "Nhân Viên";
            this.toolStripMenuItemNhanVien.Click += new System.EventHandler(this.toolStripMenuItemNhanVien_Click);
            // 
            // toolStripMenuItemSanPham
            // 
            this.toolStripMenuItemSanPham.Name = "toolStripMenuItemSanPham";
            this.toolStripMenuItemSanPham.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemSanPham.Text = "Sản Phẩm";
            this.toolStripMenuItemSanPham.Click += new System.EventHandler(this.toolStripMenuItemSanPham_Click);
            // 
            // toolStripMenuItemKhachHang
            // 
            this.toolStripMenuItemKhachHang.Name = "toolStripMenuItemKhachHang";
            this.toolStripMenuItemKhachHang.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemKhachHang.Text = "Khách Hàng";
            // 
            // toolStripMenuItemChucVu
            // 
            this.toolStripMenuItemChucVu.Name = "toolStripMenuItemChucVu";
            this.toolStripMenuItemChucVu.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemChucVu.Text = "Chức Vụ";
            // 
            // toolStripMenuItemDatHang
            // 
            this.toolStripMenuItemDatHang.Name = "toolStripMenuItemDatHang";
            this.toolStripMenuItemDatHang.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemDatHang.Text = "Đặt Hàng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCuaHang;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNhanVien;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSanPham;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemKhachHang;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemChucVu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDatHang;
    }
}

