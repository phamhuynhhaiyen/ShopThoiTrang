using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuaHangDienTu.Database;
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
            CuaHangDienTuEntities db = new CuaHangDienTuEntities();
            var lstCTPN = from c in db.CTPNs where c.MaPhieuNhap == maphieu select new { MaSP = c.MaSP, TenSP = c.SanPham.TenSP, SoLuong = c.SoLuong, GiaNhap = c.GiaNhap, ThanhTien = c.ThanhTien };
            dgvNhapHang.DataSource = lstCTPN.ToList();
            dgvNhapHang.Show();
        }

        public void LoadSP()
        {
            CuaHangDienTuEntities entities = new CuaHangDienTuEntities();
            List<SanPham> lstloai = entities.SanPhams.ToList();
            cbbMaSP.DataSource = lstloai;
            cbbMaSP.ValueMember = "MaSP";
            cbbMaSP.DisplayMember = "MaSP";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            CuaHangDienTuEntities entities = new CuaHangDienTuEntities();
            entities.CTPNs.Add(new CTPN
            {
                MaPhieuNhap = this.maphieu,
                MaSP = long.Parse(cbbMaSP.SelectedValue.ToString()),
                SoLuong = int.Parse(txtSL.Text),
                GiaNhap = long.Parse(txtGiaNhap.Text),
                ThanhTien = (long)(int.Parse(txtSL.Text) * long.Parse(txtGiaNhap.Text))
            });
            entities.SaveChanges();
            LoadDuLieu();
        }

        private void cbbMaSP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CuaHangDienTuEntities entities = new CuaHangDienTuEntities();
            var lstSP = entities.SanPhams.ToList();
            foreach (var c in lstSP)
            {

                if (c.MaSP == long.Parse(cbbMaSP.SelectedValue.ToString()))
                {
                    cbbTen.Text = c.TenSP;
                }
            }
        }

        private void UC_NhapHang_Load(object sender, EventArgs e)
        {
            LoadSP();
            CuaHangDienTuEntities entities = new CuaHangDienTuEntities();
            var lstSP = entities.SanPhams.ToList();
            foreach (var c in lstSP)
            {

                if (c.MaSP == long.Parse(cbbMaSP.SelectedValue.ToString()))
                {
                    cbbTen.Text = c.TenSP;
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            frmPhieuNhap frm = new frmPhieuNhap(maphieu);
            frm.Show();
        }
    }
}
