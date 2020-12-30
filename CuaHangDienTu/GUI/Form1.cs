using CuaHangDienTu.Database;
using CuaHangDienTu.Properties;
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
        private bool isCollapsed;
        public long manhanvien;
        public string ten, chucvu;
        public Form1(long MaNV, string TenNV, string ChucVu)
        {
            InitializeComponent();
            this.manhanvien = MaNV;
            this.ten = TenNV;
            this.chucvu = ChucVu;
        }
        public void AddControl(Control c)
        {
            
            c.Dock = DockStyle.Fill;
            pnCenter.Controls.Clear();
            pnCenter.Controls.Add(c);

        }
        private void btnBanHang_Click(object sender, EventArgs e)
        {
            UC_BanHang bh = new UC_BanHang(manhanvien);          
            AddControl(bh);
            //UC_LapHoaDon lapHoaDon = new UC_LapHoaDon(manhanvien);
            
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                btnHeThong.Image = Resources.sort_up_10px;
                
                panelHeThong.Height += 10;
                if (panelHeThong.Size == panelHeThong.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                btnHeThong.Image = Resources.sort_down_10px;
                panelHeThong.Height -= 10;
                if (panelHeThong.Size == panelHeThong.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
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
            UC_DoiMK mk = new UC_DoiMK();
            AddControl(mk);
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

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Thêm phiếu nhập mới", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CuaHangDienTuEntities entities = new CuaHangDienTuEntities();
                entities.PhieuNhaps.Add(new PhieuNhap
                {
                    MaNV = manhanvien,
                    NgayLap = DateTime.Now
                });
                entities.SaveChanges();
                UC_NhapHang nh = new UC_NhapHang(entities.PhieuNhaps.ToList().Last().MaPhieuNhap);
                AddControl(nh);
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
            //bool check = false;
            lbTen.Text = ten;
            if(chucvu == "Nhân viên bán hàng")
            {
                pnDanhMuc.Visible = false;
                pnNhapHang.Visible = false;
                btnThongKe.Visible = false;
                
            }
            if (chucvu == "Nhân viên kho")
            {
                pnDanhMuc.Visible = false;
                btnBanHang.Visible = false;
                btnThongKe.Visible = false;

            }
            //label10.Text = DateTime.Now.ToString("hh:mm");


        }
    }
}
