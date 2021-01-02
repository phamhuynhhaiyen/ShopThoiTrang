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
using Microsoft.Office.Interop.Excel;

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
            if(e.KeyCode == Keys.Enter)
            {
                dgvHD.DataSource = BUS.HoaDonBUS.GetHoaDonTheoSDT(txttimkiem.Text);
            }
            

        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHD.Rows[e.RowIndex];
                long mahd = long.Parse(row.Cells[0].Value.ToString());
                frmHoaDon frm = new frmHoaDon(mahd);
                frm.Show();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
        DateTime t2 = DateTime.Now;
        DateTime t1 = DateTime.Now.AddMonths(-1) ; 
       
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            BUS.Bus_Thonke.XuatExcel(dgvHD,3);



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
