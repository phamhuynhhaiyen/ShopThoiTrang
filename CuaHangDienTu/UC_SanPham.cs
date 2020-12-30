using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CuaHangDienTu
{
    public partial class UC_SanPham : UserControl
    {
        public UC_SanPham()
        {
            InitializeComponent();
        }

        private void btnthemloai_Click(object sender, EventArgs e)
        {
            frmLoaiSP frm = new frmLoaiSP();
            frm.Show();
        }
        public void LoadcbbLoaiSP()
        {
            
        }
        public void LoadcbbNCC()
        {
            
        }
        public void LoadDuLieu()
        {

        }
        private void UC_SanPham_Load(object sender, EventArgs e)
        {
            LoadcbbLoaiSP();
            LoadcbbNCC();
            LoadDuLieu();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
