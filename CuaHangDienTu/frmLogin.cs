
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {           
            if(NhanVienBUS.GetNhanVien(long.Parse(txtUsername.Text)) != 0)
            {
                if(txtPassword.Text == NhanVienBUS.GetMKNhanVien(long.Parse(txtUsername.Text)))
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    string TenNV = NhanVienBUS.GetTenNhanVien(long.Parse(txtUsername.Text));
                    Form1 frm = new Form1(long.Parse(txtUsername.Text), TenNV);
                    frm.Show();
                }
            }
            else { MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ!"); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "5951071125";
            txtPassword.Text = "123";
        }


        

    }


        
}

