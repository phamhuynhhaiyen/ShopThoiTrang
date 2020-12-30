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
    public partial class UC_XemPhieuNhap : UserControl
    {
        public UC_XemPhieuNhap()
        {
            InitializeComponent();
        }
        public void LoadDuLieu()
        {
            
        }
        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            
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
