
using BUS;
using CuaHangDienTu.Properties;
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
    public partial class Form1 : Form
    {
        bool isCollapsed;
        long MaNhanvien;
        string TenNV;
        public Form1(long manv, string tenNV)
        {
            InitializeComponent();
            this.MaNhanvien = manv;
            this.TenNV = tenNV;
        }
        public void AddControl(Control c)
        {
            
            c.Dock = DockStyle.Fill;
            pnCenter.Controls.Clear();
            pnCenter.Controls.Add(c);

        }
        private void btnBanHang_Click(object sender, EventArgs e)
        {
            UC_BanHang bh = new UC_BanHang(MaNhanvien);          
            AddControl(bh);
            UC_LapHoaDon lapHoaDon = new UC_LapHoaDon(MaNhanvien);
            
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                btnDanhMuc.Image = Resources.sort_up_10px;
                pnDanhMuc.Height += 10;
                if (pnDanhMuc.Size == pnDanhMuc.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                
                btnDanhMuc.Image = Resources.sort_down_10px;
                pnDanhMuc.Height -= 10;
                if (pnDanhMuc.Size == pnDanhMuc.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            UC_NhanVien nv = new UC_NhanVien();
            AddControl(nv);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            UC_KhachHang kh = new UC_KhachHang();
            AddControl(kh);

        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            UC_SanPham sp = new UC_SanPham();
            AddControl(sp);
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            UC_NhaCungCap ncc = new UC_NhaCungCap();
            AddControl(ncc);
        }

        private void btnXemHoaDon_Click(object sender, EventArgs e)
        {
            UC_XemHoaDon hd = new UC_XemHoaDon();
            AddControl(hd);
        }

        
        

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                btnNhapHang.Image = Resources.sort_up_10px;
                pnNhapHang.Height += 10;
                if (pnNhapHang.Size == pnNhapHang.MaximumSize)
                {
                    timer3.Stop();
                    isCollapsed = false;
                }
            }
            else
            {

                btnNhapHang.Image = Resources.sort_down_10px;
                pnNhapHang.Height -= 10;
                if (pnNhapHang.Size == pnNhapHang.MinimumSize)
                {
                    timer3.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void btnXemPN_Click(object sender, EventArgs e)
        {
            UC_XemPhieuNhap uc = new UC_XemPhieuNhap();
            AddControl(uc);
        }
        long MaPhieu;
        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thêm phiếu nhập mới", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                PhieuNhapBUS.InsertPhieuNhap(MaNhanvien, DateTime.Now);
                MaPhieu = PhieuNhapBUS.GetMaPN();
                UC_NhapHang frm = new UC_NhapHang(MaPhieu);
                AddControl(frm);
                MessageBox.Show("Thêm phiếu nhập thành công");
            }
                
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                Dispose();
            }
            
        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            UC_ThongKe tk = new UC_ThongKe();
            AddControl(tk);
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            lbTen.Text = TenNV;
            if(NhanVienBUS.GetQuyenNhanVien(MaNhanvien) == 1)
            {

            }
            if (NhanVienBUS.GetQuyenNhanVien(MaNhanvien) == 2)
            {

            }
            if (NhanVienBUS.GetQuyenNhanVien(MaNhanvien) == 3)
            {
                pnDanhMuc.Visible = false;
                pnNhapHang.Visible = false;
                btnThongKe.Visible = false;
            }
            if (NhanVienBUS.GetQuyenNhanVien(MaNhanvien) == 4)
            {
                btnNhanVien.Enabled = false;
                btnKhachHang.Enabled = false;
                btnThongKe.Visible = false;
                btnBanHang.Visible = false;
                btnXemHoaDon.Enabled = false;
            }
            if(NhanVienBUS.GetQuyenNhanVien(MaNhanvien) == 5)
            {                
                btnBanHang.Visible = false;
                btnNhanVien.Enabled = false;
                btnKhachHang.Enabled = false;
                btnPhieuNhap.Enabled = false;
                btnNCC.Enabled = false;
                
            }

        }

        private void label21_Click(object sender, EventArgs e)
        {
            UC_DoiMK mk = new UC_DoiMK(MaNhanvien);
            AddControl(mk);
        }
    }
}
