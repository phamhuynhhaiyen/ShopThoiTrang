using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuaHangDienTu.Database;

namespace CuaHangDienTu
{
    public partial class UC_NhanVien : UserControl
    {
        
        public UC_NhanVien()
        {
            InitializeComponent();
        }
        //List<NhanVien> listNhanVien;
        public void LoadDuLieu()
        {
            CuaHangDienTuEntities db = new CuaHangDienTuEntities();
            var listNhanVien = from c in db.NhanViens select new { MaNV = c.MaNV, TenNV = c.TenNV, ChucVu = c.ChucVu, NgaySinh = c.NgaySinh, GioiTinh = c.GioiTinh, SDT = c.SDT };
            dgvNhanVien.DataSource = listNhanVien.ToList();
        }
        private void UC_NhanVien_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }
        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                using (CuaHangDienTuEntities db = new CuaHangDienTuEntities())
                {
                    int input_Id = int.Parse(txtmanv.Text.Trim());
                    db.NhanViens.Remove(db.NhanViens.Where(p => p.MaNV == input_Id).FirstOrDefault());
                    db.SaveChanges();
                    Reset();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                Reset();
            }
            LoadDuLieu();
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
            using (CuaHangDienTuEntities entities = new CuaHangDienTuEntities())
            {
                long input_Id = Convert.ToInt64(txtmanv.Text.Trim());
                NhanVien nv = entities.NhanViens.Where(p => p.MaNV == input_Id).FirstOrDefault();
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chăn thực hiện thao tác?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (nv == null)
                    {
                        entities.NhanViens.Add(new NhanVien
                        {
                            MaNV = input_Id,
                            TenNV = txttennv.Text,
                            ChucVu = cbbChucVu.Text,
                            NgaySinh = dtpngaysinh.Value,
                            GioiTinh = cbbgioitinh.Text,
                            SDT = txtsdt.Text
                        }) ;

                        entities.SaveChanges();

                        Reset();
                    }
                    else
                    {
                        nv.TenNV = txttennv.Text;
                        nv.ChucVu = cbbChucVu.Text;
                        nv.NgaySinh = dtpngaysinh.Value;
                        nv.GioiTinh = cbbgioitinh.Text;

                        entities.SaveChanges();
                        Reset();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    Reset();
                }

            }
            LoadDuLieu();
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
