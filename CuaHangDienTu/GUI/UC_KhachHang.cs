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
    public partial class UC_KhachHang : UserControl
    {
        public UC_KhachHang()
        {
            InitializeComponent();
        }
        public void LoadDuLieu()
        {
            CuaHangDienTuEntities db = new CuaHangDienTuEntities();
            var lstkhachhang = from c in db.KhachHangs select new { SDT = c.SDT, TenKH = c.TenKH, GioiTinh = c.GioiTinh, NamSinh = c.NamSinh, CMND = c.CMND};
            dgvNhanVien.DataSource = lstkhachhang.ToList();
        }
        private void UC_KhachHang_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
