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
using DTO;

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

        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            long MaNCC = long.Parse(txtmancc.Text);
            string TenNCC = txttenncc.Text;
            string DiaChi = txtdiachi.Text;
            NhaCungCapDTO nhaCungCap = new NhaCungCapDTO(MaNCC, TenNCC, DiaChi);
            if (NhaCungCapBUS.GetNCC(MaNCC) == 0)
            {
                MessageBox.Show("Thêm nhà cung cấp " + TenNCC + " thành công");
                NhaCungCapBUS.InsertNCC(nhaCungCap);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thay đổi?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    NhaCungCapBUS.UpdateNCC(nhaCungCap);
                }
                
            }
            Reset();
            dgvNhanVien.DataSource = NhaCungCapBUS.GetAllNCC();
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
            dgvNhanVien.DataSource = NhaCungCapBUS.GetAllNCC();
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
