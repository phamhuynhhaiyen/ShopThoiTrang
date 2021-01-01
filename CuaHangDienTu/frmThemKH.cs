
using BUS;
using DTO;
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
    public partial class frmThemKH : Form
    {
        string SDT;
        
        public frmThemKH(string sdt)
        {
            InitializeComponent();
            this.SDT = sdt;
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtTen.Text != "")
            {
                KhachHangDTO kh = new KhachHangDTO(SDT, txtTen.Text);
                KhachHangBUS.InsertKhachHang(kh);               
                MessageBox.Show("Thêm thành công");
                Dispose();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên");
            }
            
        }

    }
}
