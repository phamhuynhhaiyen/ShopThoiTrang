using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace CuaHangDienTu
{
    public partial class UC_XemPhieuNhap : UserControl
    {
        public UC_XemPhieuNhap()
        {
            InitializeComponent();
        }
        
        

        private void UC_XemPhieuNhap_Load(object sender, EventArgs e)
        {
            dgvHD.DataSource = PhieuNhapBUS.GetAllPhieuNhap();
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DateTime NgayLap = dateTimePicker1.Value;
            dgvHD.DataSource = PhieuNhapBUS.GetPhieuTheoNgay(NgayLap);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BUS.Bus_Thonke.XuatExcel(dgvHD, 1);
        }
    }
}
