using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuaHangDienTu.Report;

namespace CuaHangDienTu
{
    public partial class UC_XemHoaDon : UserControl
    {
        public UC_XemHoaDon()
        {
            InitializeComponent();
        }
        
        private void UC_XemHoaDon_Load(object sender, EventArgs e)
        {
            dgvHD.DataSource = BUS.HoaDonBUS.GetAllHoaDon();
        }
        
        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {

            

        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
