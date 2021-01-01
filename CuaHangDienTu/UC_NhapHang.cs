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
using BUS;
using DTO;

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

        public void LoadSP()
        {
            cbbMaSP.DataSource = SanPhamBUS.GetAllSanPham();
            cbbMaSP.ValueMember = "MaSP";
            cbbMaSP.DisplayMember = "TenSP";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(txtSL.Text);
            long gia = long.Parse(txtGiaNhap.Text);
            long thanhtien = (long)sl * gia;
            long masp = long.Parse(cbbMaSP.SelectedValue.ToString());
            CTPNDTO ctpn = new CTPNDTO(maphieu,masp, sl,gia,thanhtien);
            PhieuNhapBUS.InsertCTPN(ctpn);
            dgvNhapHang.DataSource = PhieuNhapBUS.GetCTPN(maphieu);
        }

        private void cbbMaSP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            long masp = long.Parse(cbbMaSP.SelectedValue.ToString());
            //cbbTen.Text = SanPhamBUS.GetTenSP(masp);
        }

        private void UC_NhapHang_Load(object sender, EventArgs e)
        {
            LoadSP();
            long masp = long.Parse(cbbMaSP.SelectedValue.ToString());
            //cbbTen.Text = SanPhamBUS.GetTenSP(masp);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            frmPhieuNhap frm = new frmPhieuNhap(maphieu);
            frm.Show();
        }
    }
}
