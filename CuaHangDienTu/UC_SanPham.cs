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
    public partial class UC_SanPham : UserControl
    {
        public UC_SanPham()
        {
            InitializeComponent();
        }
        long masp;
        private void btnthemloai_Click(object sender, EventArgs e)
        {
            frmLoaiSP frm = new frmLoaiSP();
            frm.Show();
        }
        private void UC_SanPham_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = SanPhamBUS.GetAllSanPham();
            cbbNCC.DataSource = NhaCungCapBUS.GetAllNCC();
            cbbNCC.ValueMember = "MaNCC";
            cbbNCC.DisplayMember = "TenNCC";
            cbbLoai.DataSource = SanPhamBUS.GetAllLoai();
            cbbLoai.ValueMember = "MaLoai";
            cbbLoai.DisplayMember = "TenLoai";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SanPhamBUS.InsertSP(txtTenSP.Text, long.Parse(cbbLoai.SelectedValue.ToString()), long.Parse(cbbNCC.SelectedValue.ToString()));
            dgvNhanVien.DataSource = SanPhamBUS.GetAllSanPham();
        }
        
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                masp = long.Parse(row.Cells[0].Value.ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SanPhamBUS.DeleteSP(masp);
            dgvNhanVien.DataSource = SanPhamBUS.GetAllSanPham();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            BUS.Bus_Thonke.XuatExcel(dgvNhanVien, 4);
        }
    }
}
