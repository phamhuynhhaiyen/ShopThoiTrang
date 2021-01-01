
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
            Boolean check = false;
            //if(txtPassword.Text == "" || txtUsername.Text == "")
            //{
            //    MessageBox.Show("Vui lòng nhập mã nhân viên và mật khẩu!!");
            //}
            try
            {
                foreach (var u in UserBUS.GetAllUser())
                {
                    if (u.TaiKhoan == long.Parse(txtUsername.Text) && u.MatKhau == txtPassword.Text)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        check = true;
                        string tennv = UserBUS.GetTenUser(u.TaiKhoan);
                        Form1 frm = new Form1(u.TaiKhoan,tennv);
                        
                        frm.Show();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên và mật khẩu!!");
            }
            if (check == false)
            {
                //MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }
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


        //MessageBox.Show(UserBUS.GetAllUser() + "");

    }


        
}

