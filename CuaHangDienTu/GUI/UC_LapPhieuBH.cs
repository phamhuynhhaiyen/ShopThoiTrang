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
    public partial class UC_LapPhieuBH : UserControl
    {
        public UC_LapPhieuBH()
        {
            InitializeComponent();
        }
        public void LoadcbbSP()
        {
            CuaHangDienTuEntities entities = new CuaHangDienTuEntities();
            List<SanPham> lstloai = entities.SanPhams.ToList();
            cbbMaSP.DataSource = lstloai;
            cbbMaSP.ValueMember = "MaSP";
            cbbMaSP.DisplayMember = "MaSP";
        }
        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            bool dem = false;
            CuaHangDienTuEntities entities = new CuaHangDienTuEntities();
            List<KhachHang> lstKhachHang = entities.KhachHangs.ToList();
            if (e.KeyCode == Keys.Enter)
            {
                foreach (var kh in lstKhachHang)
                {
                    if (kh.SDT == Convert.ToInt64(txtSDT.Text))
                    {
                        txtTenKH.Text = kh.TenKH;
                        dem = true;
                                               
                    }
                }
                if (dem == false)
                {
                    MessageBox.Show("Không tìm thấy khách hàng!");
                }
            }
        }

        private void UC_LapPhieuBH_Load(object sender, EventArgs e)
        {
            LoadcbbSP();
            CuaHangDienTuEntities entities = new CuaHangDienTuEntities();
            var lstSP = entities.SanPhams.ToList();
            foreach (var c in lstSP)
            {

                if (c.MaSP == long.Parse(cbbMaSP.SelectedValue.ToString()))
                {
                    txtTenSP.Text = c.TenSP;
                }
            }
        }

        

        private void cbbMaSP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CuaHangDienTuEntities entities = new CuaHangDienTuEntities();
            var lstSP = entities.SanPhams.ToList();
            foreach (var c in lstSP)
            {
                
                if (c.MaSP == long.Parse(cbbMaSP.SelectedValue.ToString()))
                {
                    txtTenSP.Text = c.TenSP;
                }
            }
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            CuaHangDienTuEntities entities = new CuaHangDienTuEntities();
            entities.PhieuBaoHanhs.Add(new PhieuBaoHanh
            {
                SDT = long.Parse(txtSDT.Text),
                MaSP = long.Parse(cbbMaSP.SelectedValue.ToString()),
                NgayMua = DateTime.Now,
                NgayHetHan = dtpHetHan.Value
            }) ;
            entities.SaveChanges();
        }
    }
}
