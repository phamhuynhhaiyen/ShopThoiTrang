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
    public partial class UC_NhaCungCap : UserControl
    {
        public UC_NhaCungCap()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            txtmancc.Text = txttenncc.Text = txtdiachi.Text = "";         
        }

        public void LoadDuLieu()
        {
            
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void UC_NhaCungCap_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtmancc.Text = row.Cells[0].Value.ToString();
                txttenncc.Text = row.Cells[1].Value.ToString();
                txtdiachi.Text = row.Cells[2].Value.ToString();
                
            }
        }
    }
}
