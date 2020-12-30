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
    public partial class frmLoaiSP : Form
    {
        public frmLoaiSP()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        public void LoadDuLieu()
        {
            CuaHangDienTuEntities db = new CuaHangDienTuEntities();
            var lstLoai = from c in db.LoaiSanPhams select new { MaLoai = c.MaLoai, TenLoai = c.TenLoai};
            dgvNhanVien.DataSource = lstLoai.ToList();
        }
        private void frmLoaiSP_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        
    }
}
