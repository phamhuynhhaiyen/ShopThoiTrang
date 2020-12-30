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
            CuaHangDienTuEntities entities = new CuaHangDienTuEntities();
            List<LoaiSanPham> lstloai = entities.LoaiSanPhams.ToList();
            cbbLoai.DataSource = lstloai;
            cbbLoai.ValueMember = "MaLoai";
            cbbLoai.DisplayMember = "TenLoai";
        }
        public void LoadcbbNCC()
        {
            CuaHangDienTuEntities entities = new CuaHangDienTuEntities();
            List<NhaCungCap> lstNCC = entities.NhaCungCaps.ToList();
            cbbNCC.DataSource = lstNCC;
            cbbNCC.ValueMember = "MaNCC";
            cbbNCC.DisplayMember = "TenNCC";
        }
        public void LoadDuLieu()
        {
            CuaHangDienTuEntities db = new CuaHangDienTuEntities();
            var lstSanPham = from c in db.SanPhams select new { MaSP = c.MaSP, TenSP = c.TenSP, TenLoai = 
                             c.LoaiSanPham.TenLoai, TenNCC = c.NhaCungCap.TenNCC, SoLuongTon = c.SoLuongTon };
            dgvNhanVien.DataSource = lstSanPham.ToList();
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
