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
    public partial class UC_NhaCungCap : UserControl
    {
        public UC_NhaCungCap()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            txtmancc.Text = txttenncc.Text = txtdiachi.Text = "";         
        }

        public void LoadDuLieu()
        {
            CuaHangDienTuEntities db = new CuaHangDienTuEntities();
            var lstNCC = from c in db.NhaCungCaps select new { MaNCC = c.MaNCC, TenNCC = c.TenNCC, DiaChi = c.DiaChi};
            dgvNhanVien.DataSource = lstNCC.ToList();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (CuaHangDienTuEntities entities = new CuaHangDienTuEntities())
            {
                long input_Id = Convert.ToInt64(txtmancc.Text.Trim());
                NhaCungCap ncc = entities.NhaCungCaps.Where(p => p.MaNCC == input_Id).FirstOrDefault();
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn thực hiện thao tác?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (ncc == null)
                    {
                        entities.NhaCungCaps.Add(new NhaCungCap
                        {
                            MaNCC = input_Id,
                            TenNCC = txttenncc.Text,
                            DiaChi = txtdiachi.Text                     
                        });

                        entities.SaveChanges();

                        Reset();
                    }
                    else
                    {
                        ncc.TenNCC = txttenncc.Text;
                        ncc.DiaChi = txtdiachi.Text;
                        

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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (CuaHangDienTuEntities db = new CuaHangDienTuEntities())
                {
                    int input_Id = int.Parse(txtmancc.Text.Trim());
                    db.NhaCungCaps.Remove(db.NhaCungCaps.Where(p => p.MaNCC == input_Id).FirstOrDefault());
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

        private void UC_NhaCungCap_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtmancc.Text = row.Cells[0].Value.ToString();
                txttenncc.Text = row.Cells[1].Value.ToString();
                txtdiachi.Text = row.Cells[2].Value.ToString();
                
            }
        }
    }
}
