using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BachHoaXanh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemCuaHang_Click(object sender, EventArgs e)
        {
            CuaHang_Form f=new CuaHang_Form();

            f.Show();
        }

        private void toolStripMenuItemNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien_Form f=new NhanVien_Form();
            f.Show();
        }

        private void toolStripMenuItemSanPham_Click(object sender, EventArgs e)
        {
            SanPham_Form f=new SanPham_Form();
            f.Show();
        }
    }
}
