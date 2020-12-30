using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuaHangDienTu.Report;

namespace CuaHangDienTu
{
    public partial class UC_NhapHang : UserControl
    {
        public long maphieu;
        public UC_NhapHang(long MaPN)
        {
            InitializeComponent();
            this.maphieu = MaPN;
            
        }
        
        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            frmThemSP frm = new frmThemSP();
            frm.Show();
                 
        }

        private void LoadDuLieu()
        {
            
        }

        public void LoadSP()
        {
            
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void cbbMaSP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void UC_NhapHang_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            frmPhieuNhap frm = new frmPhieuNhap(maphieu);
            frm.Show();
        }
    }
}
