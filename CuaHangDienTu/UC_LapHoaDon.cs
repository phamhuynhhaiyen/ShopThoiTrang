using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using DTO;
using BUS;

namespace CuaHangDienTu
{
    public partial class UC_LapHoaDon : UserControl
    {
        long manhanvien;
        public UC_LapHoaDon(long MaNV)
        {
            InitializeComponent();
            this.manhanvien = MaNV;
           
        }
        long MaHD = HoaDonBUS.GetMaHD();
        
        
        private void UC_LapHoaDon_Load(object sender, EventArgs e)
        {
            pnCTHD.Visible = false;
            cbbMaSP.DataSource = SanPhamBUS.GetAllSanPham();
            cbbMaSP.ValueMember = "MaSP";
            cbbMaSP.DisplayMember = "TenSP";
            //txtTenKH.Text = KhachHangBUS.GetTEnKH(txtSDT.Text);
        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Boolean check = false;
                List<KhachHangDTO> lst = KhachHangBUS.GetAllKH();
                foreach (var kh in lst)
                {
                    if (txtSDT.Text == kh.sdt)
                    {
                        txtTenKH.Text = KhachHangBUS.GetTEnKH(txtSDT.Text);
                        check = true;
                        
                    }
                }
                if (check == false)
                {
                    txtTenKH.Text = "";
                    frmThemKH frm = new frmThemKH(txtSDT.Text);
                    frm.Show();

                }
            }

            
            
        }

        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            int slton = SanPhamBUS.GetSoLuongTon(long.Parse(cbbMaSP.SelectedValue.ToString()));
            
            int sl = int.Parse(txtSoLuong.Text);
            if(slton > sl)
            {
                long gia = long.Parse(txtDonGia.Text);
                long thanhtien = sl * gia;
                DTO.CTHDDTO cthd = new CTHDDTO(MaHD, long.Parse(cbbMaSP.SelectedValue.ToString()), sl, thanhtien);
                HoaDonBUS.InsertCTHD(cthd);
                dgvNhanVien.DataSource = HoaDonBUS.GetCTHD(MaHD);
            }
            else
            {
                MessageBox.Show("Không đủ số lượng hàng!");
            }           

        }
        
       
        private void btThanhToan_Click(object sender, EventArgs e)
        {
            Report.frmHoaDon f = new Report.frmHoaDon();
            f.Show();
            pnCTHD.Visible = false;
        }

        

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        
            
        }

        private void cbbMaSP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            long masp = long.Parse(cbbMaSP.SelectedValue.ToString());
            txtDonGia.Text = (SanPhamBUS.GetGiaSanPham(masp)).ToString();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thêm phiếu nhập mới", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                HoaDonBUS.InsertHoaDon(txtSDT.Text, manhanvien, DateTime.Now, 0);
                pnCTHD.Visible = true;
            }
                

            
        }
    }
}
