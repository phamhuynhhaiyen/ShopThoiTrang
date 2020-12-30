using CuaHangDienTu.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangDienTu
{
    public partial class frmThemKH : Form
    {
        public frmThemKH()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (CuaHangDienTuEntities entities = new CuaHangDienTuEntities())
            {
                entities.KhachHangs.Add(new KhachHang
                {
                    SDT = long.Parse(txtSDT.Text),
                    TenKH = txtTen.Text,
                    GioiTinh = cbbGioiTinh.Text,
                    NamSinh = int.Parse(txtNS.Text),
                    CMND = txtcmnd.Text
                });
                entities.SaveChanges();
                

            }
        }
    }
}
