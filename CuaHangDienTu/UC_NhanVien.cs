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
    public partial class UC_NhanVien : UserControl
    {
        
        public UC_NhanVien()
        {
            InitializeComponent();
        }
        //List<NhanVien> listNhanVien;
        public void LoadDuLieu()
        {
            
        }
        private void UC_NhanVien_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }
        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            txtmanv.Text = txtsdt.Text = txttennv.Text = "";
            cbbgioitinh.SelectedIndex = cbbChucVu.SelectedIndex = 0;
            dtpngaysinh.Value = DateTime.Now;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtmanv.Text = row.Cells[0].Value.ToString();
                txttennv.Text = row.Cells[1].Value.ToString();
                cbbChucVu.Text = row.Cells[2].Value.ToString();
                dtpngaysinh.Text = row.Cells[3].Value.ToString();
                cbbgioitinh.Text = row.Cells[4].Value.ToString();
                txtsdt.Text = row.Cells[5].Value.ToString();
            }
        }

    }
}
