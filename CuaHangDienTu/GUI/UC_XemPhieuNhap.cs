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
    public partial class UC_XemPhieuNhap : UserControl
    {
        public UC_XemPhieuNhap()
        {
            InitializeComponent();
        }
        public void LoadDuLieu()
        {
            CuaHangDienTuEntities entities = new CuaHangDienTuEntities();
            var lstpn = from c in entities.PhieuNhaps select new { MaPN = c.MaPhieuNhap, TenNV = c.NhanVien.TenNV, NgayLap = c.NgayLap, TongTien = c.TongTien };
            dgvHD.DataSource = lstpn.ToList();
        }
        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            CuaHangDienTuEntities entities = new CuaHangDienTuEntities();
            if (e.KeyCode == Keys.Enter)
            {
                foreach (var u in entities.PhieuNhaps.ToList())
                {
                    if (u.MaPhieuNhap == long.Parse(txttimkiem.Text))
                    {
                        var hd = from c in entities.PhieuNhaps where c.MaPhieuNhap == u.MaPhieuNhap select new { MaPN = c.MaPhieuNhap, TenNV = c.NhanVien.TenNV, NgayLap = c.NgayLap, TongTien = c.TongTien };
                        dgvHD.DataSource = hd.ToList();
                    }
                    
                }
            }
        }

        private void UC_XemPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHD.Rows[e.RowIndex];
                long maphieu = long.Parse(row.Cells[0].Value.ToString());
                Report.frmPhieuNhap frm = new Report.frmPhieuNhap(maphieu);
                frm.Show();
            }
        }
    }
}
