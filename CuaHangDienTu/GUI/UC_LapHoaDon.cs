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
using System.Data.SqlClient;

namespace CuaHangDienTu
{
    public partial class UC_LapHoaDon : UserControl
    {
        private long manhanvien;
        public UC_LapHoaDon(long MaNV)
        {
            InitializeComponent();
            this.manhanvien = MaNV;
           // LoadData();
        }
        long MaHD = 0;
        
        public void LoadcbbSP()
        {
            CuaHangDienTuEntities entities = new CuaHangDienTuEntities();
            List<SanPham> lstloai = entities.SanPhams.ToList();
            cbbMaSP.DataSource = lstloai;
            cbbMaSP.ValueMember = "MaSP";
            cbbMaSP.DisplayMember = "TenSP";
        }
        private void UC_LapHoaDon_Load(object sender, EventArgs e)
        {
            pnCTHD.Visible = false;
            LoadcbbSP();
        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            bool dem = false;
            CuaHangDienTuEntities entities = new CuaHangDienTuEntities();
            List<KhachHang> lstKhachHang = entities.KhachHangs.ToList();
            if(e.KeyCode == Keys.Enter)
            {
                foreach(var kh in lstKhachHang)
                {
                    if(kh.SDT == Convert.ToInt64(txtSDT.Text))
                    {
                        txtTenKH.Text = kh.TenKH;
                        dem = true;
                        pnCTHD.Visible = true;                       
                        entities.HoaDons.Add(new HoaDon
                        {
                            SDT = long.Parse(txtSDT.Text),
                            MaNV = manhanvien,
                            NgayLap = DateTime.Now,
                        });

                        entities.SaveChanges();
                        MaHD = entities.HoaDons.ToList().Last().MaHD;
                        LoadData();
                        //btnThemHD.Enabled = false;
                    }
                }
                if(dem == false)
                {
                    MessageBox.Show("Không tìm thấy khách hàng!");
                }
            }
            
        }

        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            
            string strCn = @"Data Source=LAPTOP-OCUUTDBF\SQLEXPRESS;Initial Catalog=CuaHangDienTu;Integrated Security=True";// đây là chuổi kết nối
          
            SqlConnection Cn = new SqlConnection(strCn);
            CuaHangDienTuEntities entities = new CuaHangDienTuEntities();
            List<SanPham> lstsp = entities.SanPhams.ToList();
            foreach(var sp in lstsp)
            {
                if(sp.MaSP == long.Parse(cbbMaSP.SelectedValue.ToString())){
                    if (sp.SoLuongTon >= int.Parse(txtSoLuong.Text))
                    {
                        long sl = long.Parse(txtSoLuong.Text);
                        long DONGIA = long.Parse(txtDonGia.Text);
                        CTHD cTHD = new CTHD
                        {
                            MaHD = this.MaHD,
                            MaSP = long.Parse(cbbMaSP.SelectedValue.ToString()),
                            DonGia = long.Parse(txtDonGia.Text),
                            SoLuong = int.Parse(txtSoLuong.Text),
                            ThanhTien = sl * DONGIA
                        };

                        SqlConnection sqlConnection1 = Cn;
                        try
                        {
                            string SQL = string.Format("INSERT INTO CTHD  VALUES" +
                        " ('{0}','{1}','{2}','{3}','{4}') ", +cTHD.MaHD, cTHD.MaSP, cTHD.DonGia, cTHD.SoLuong,
                        cTHD.ThanhTien);

                            sqlConnection1.Open();
                            SqlCommand command = new SqlCommand(SQL, sqlConnection1);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            sqlConnection1.Close();

                            LoadData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không đủ số lượng hàng!");
                    }
                }
                    
            }
            
         
        }
        
        private void LoadData()
        {
            try
            {
                CuaHangDienTuEntities entities = new CuaHangDienTuEntities();
                 
                var cthd = from X in entities.CTHDs
                           where X.MaHD == MaHD
                           select new
                           {
                              // MaHD = X.MaHD,
                               TenSP = X.SanPham.TenSP,
                               MaSP = X.MaSP,
                               DonGia = X.DonGia,
                               SoLuong = X.SoLuong,
                               ThanhTien = X.ThanhTien
                           }
                           ;


                dgvNhanVien.DataSource = cthd.ToList();
                dgvNhanVien.Show();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            Report.Form1 f = new Report.Form1(MaHD);
            f.Show();
            pnCTHD.Visible = false;
            btnThemKH.Enabled = true;
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            frmThemKH frm = new frmThemKH();
            frm.Show();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
            //if (e.RowIndex >= 0)
            //{
            //    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        using (CuaHangDienTuEntities db = new CuaHangDienTuEntities())
            //        {
            //            //long id_maHD = long.Parse(row.Cells[0].Value.ToString());
            //            long id_maSP = long.Parse(row.Cells[0].Value.ToString());
            //            db.CTHDs.Remove(db.CTHDs.Where(p => p.MaSP == id_maSP && p.MaHD == this.MaHD).FirstOrDefault());
            //            db.SaveChanges();

            //        }
            //    }

            //}
            //LoadData();
        
            
        }
    }
}
