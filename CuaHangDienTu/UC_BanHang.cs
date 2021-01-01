using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangDienTu
{
    public partial class UC_BanHang : UserControl
    {
        long manhanvien;
        public UC_BanHang(long manv)
        {
            InitializeComponent();
            this.manhanvien = manv;
            
        }


        private void lbLapHoaDon_Click(object sender, EventArgs e)
        {
            UC_LapHoaDon lhd = new UC_LapHoaDon(manhanvien);
            pnCenter.Controls.Clear();
            pnCenter.Controls.Add(lhd);
        }

        private void lbLapPhieu_Click(object sender, EventArgs e)
        {
            
        }

        private void lbKiemtra_Click(object sender, EventArgs e)
        {
            
        }

        private void UC_BanHang_Load(object sender, EventArgs e)
        {
            pnCenter.Controls.Add(new UC_LapHoaDon(manhanvien));
        }

        
    }
}
