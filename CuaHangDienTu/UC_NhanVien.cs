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
    public partial class UC_NhanVien : UserControl
    {
        
        public UC_NhanVien()
        {
            InitializeComponent();
        }
        
        
        private void UC_NhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = NhanVienBUS.GetAllNhanVien();
            cbbChucVu.DataSource = NhanVienBUS.GetAllQuyen();
            cbbChucVu.ValueMember = "MaQuyen";
            cbbChucVu.DisplayMember = "TenQuyen";
        }
        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            long manv = long.Parse(txtmanv.Text);
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                NhanVienBUS.DeleteNhanVien(manv);
            }
            if (dialogResult == DialogResult.Yes)
            {
                Reset();
            }

            dgvNhanVien.DataSource = NhanVienBUS.GetAllNhanVien();
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
            long manv = long.Parse(txtmanv.Text);
            string tennv = txttennv.Text;
            long maquyen = long.Parse(cbbChucVu.SelectedValue.ToString());
            DateTime ns = dtpngaysinh.Value;
            string gt = cbbgioitinh.Text;
            string sdt = txtsdt.Text;
            NhanVienDTO nv = new NhanVienDTO(manv, tennv, maquyen, ns, gt, sdt);
            
            if (NhanVienBUS.GetNhanVien(manv) == 0)
            {
                MessageBox.Show("Thêm thành công!");
                NhanVienBUS.InsertNhanVien(nv);               
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thay đổi?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {                    
                    NhanVienBUS.UpdateNhanVien(nv);
                }
                    
            }
            Reset();
            dgvNhanVien.DataSource = NhanVienBUS.GetAllNhanVien();
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
