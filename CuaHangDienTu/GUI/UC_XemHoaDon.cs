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
    public partial class UC_XemHoaDon : UserControl
    {
        public UC_XemHoaDon()
        {
            InitializeComponent();
        }
        public void LoadDuLieu()
        {
            CuaHangDienTuEntities entities = new CuaHangDienTuEntities();
            var lsthd = from c in entities.HoaDons select new { MaHD = c.MaHD, TenKH = c.KhachHang.TenKH, TenNV = c.NhanVien.TenNV, NgayLap = c.NgayLap, TongTien = c.TongTien };
            dgvHD.DataSource = lsthd.ToList();
        }
        private void UC_XemHoaDon_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }
        HoaDon hd;
        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {

            CuaHangDienTuEntities entities = new CuaHangDienTuEntities();
            if (e.KeyCode == Keys.Enter)
            {
                foreach (var u in entities.HoaDons.ToList())
                {
                    if (u.MaHD == long.Parse(txttimkiem.Text))
                    {
                        var hd = from c in entities.HoaDons where c.MaHD == u.MaHD select new { MaHD = c.MaHD, TenKH = c.KhachHang.TenKH, TenNV = c.NhanVien.TenNV, NgayLap = c.NgayLap, TongTien = c.TongTien };
                        dgvHD.DataSource = hd.ToList();
                    }
                    if (u.SDT == long.Parse(txttimkiem.Text))
                    {
                        var hd = from c in entities.HoaDons where c.SDT == u.SDT select new { MaHD = c.MaHD, TenKH = c.KhachHang.TenKH, TenNV = c.NhanVien.TenNV, NgayLap = c.NgayLap, TongTien = c.TongTien };
                        dgvHD.DataSource = hd.ToList();
                    }
                }
            }

        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHD.Rows[e.RowIndex];
                long maHD = long.Parse(row.Cells[0].Value.ToString());
                Report.Form1 frm = new Report.Form1(maHD);
                frm.Show();
            }
        }
    }
}
