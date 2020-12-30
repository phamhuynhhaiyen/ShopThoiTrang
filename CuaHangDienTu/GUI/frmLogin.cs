using CuaHangDienTu.Database;
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
            bool check = false;
            CuaHangDienTuEntities entities = new CuaHangDienTuEntities();
            List<User> lst = entities.Users.ToList();
            foreach(var u in lst)
            {
                if(Convert.ToString(u.TaiKhoan) == txtUsername.Text && u.MatKhau == txtPassword.Text)
                {
                    Form1 frm = new Form1(Convert.ToInt64(txtUsername.Text), u.NhanVien.TenNV, u.NhanVien.ChucVu);
                    frm.Show();
                    check = true;
                    UC_LapHoaDon lhd = new UC_LapHoaDon(Convert.ToInt64(txtUsername.Text));
                }
            }
            if(check == false)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "5951071125";
            txtPassword.Text = "1";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
