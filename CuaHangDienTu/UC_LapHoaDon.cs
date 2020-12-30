using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace CuaHangDienTu
{
    public partial class UC_LapHoaDon : UserControl
    {
        
        public UC_LapHoaDon()
        {
            InitializeComponent();
            //this.manhanvien = MaNV;
           // LoadData();
        }
        long MaHD = 0;
        
        public void LoadcbbSP()
        {
            
        }
        private void UC_LapHoaDon_Load(object sender, EventArgs e)
        {
            pnCTHD.Visible = false;
            LoadcbbSP();
        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            
            
        }

        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            
            
            
         
        }
        
        private void LoadData()
        {
            
            
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            Report.Form1 f = new Report.Form1();
            f.Show();
            pnCTHD.Visible = false;
            btnThemKH.Enabled = true;
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            frmThemKH frm = new frmThemKH();
            frm.Show();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        
            
        }
    }
}
