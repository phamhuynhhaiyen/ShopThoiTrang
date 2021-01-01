using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangDienTu
{
    public partial class frmThemSP : Form
    {
        public frmThemSP()
        {
            InitializeComponent();
        }

        

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void frmThemSP_Load(object sender, EventArgs e)
        {
            cbbLoai.DataSource = SanPhamBUS.GetAllLoai();
            cbbLoai.ValueMember = "MaLoai";
            cbbLoai.DisplayMember = "TenLoai";
            cbbNCC.DataSource = NhaCungCapBUS.GetAllNCC();
            cbbNCC.ValueMember = "MaNCC";
            cbbNCC.DisplayMember = "TenNCC";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SanPhamBUS.InsertSP(txtTenSP.Text, long.Parse(cbbLoai.SelectedValue.ToString()), long.Parse(cbbNCC.SelectedValue.ToString()));
            MessageBox.Show("Thêm thành công!");
        }
    }
}
