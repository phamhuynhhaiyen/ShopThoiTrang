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
    public partial class UC_DoiMK : UserControl
    {
        long manhanvien;
        public UC_DoiMK(long manv)
        {
            InitializeComponent();
            this.manhanvien = manv;
        }

        private void UC_DoiMK_Load(object sender, EventArgs e)
        {
            //label8.Text = HoaDonBUS.DoanhThuNgay(DateTime.Now).ToString();
            label4.Visible = false;
            label21.Visible = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
          if (NhanVienBUS.GetNhanVien(manhanvien, txtMKC.Text) == 0)
            {
                label4.Visible = true;
            }
            else
            {
                label4.Visible = false;
                if (txtMKM.Text == "" || txtXN.Text == "" || txtMKM.Text != txtXN.Text)
                {
                    label21.Visible = true;


                }
                else
                {
                    label21.Visible = false;
                    MessageBox.Show("Đã thay đổi mật khẩu!");
                    NhanVienBUS.UpdateTaiKhoan(manhanvien, txtMKM.Text);
                    txtMKM.Text = txtXN.Text = txtMKC.Text = "";



                }


            }

        }

        private void txtMKC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
