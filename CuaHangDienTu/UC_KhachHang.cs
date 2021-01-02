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
    public partial class UC_KhachHang : UserControl
    {
        public UC_KhachHang()
        {
            InitializeComponent();
        }
        
        private void UC_KhachHang_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = KhachHangBUS.GetAllKH();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO(txtSDT.Text, txtTen.Text);
            
            if (KhachHangBUS.GetMa(txtSDT.Text) == 0)
            {
                MessageBox.Show("Thêm thành công!");
                KhachHangBUS.InsertKhachHang(kh);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thay đổi?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    KhachHangBUS.UpdateKhachHang(kh);
                }

            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtSDT.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            KhachHangBUS.DeleteKhachHang(txtSDT.Text);
            dgvNhanVien.DataSource = KhachHangBUS.GetAllKH();
        }
    }
}
