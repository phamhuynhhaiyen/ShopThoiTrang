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

namespace CuaHangDienTu
{
    public partial class UC_BieuDo : UserControl
    {
        int year;
        public UC_BieuDo(int nam)
        {
            InitializeComponent();
            this.year = nam;
        }

        private void UC_BieuDo_Load(object sender, EventArgs e)
        {
            
            try
            {
                chart1.DataSource = HoaDonBUS.GetThangHD(year);


                chart1.Series["chartthu"].XValueMember = "thang";
                chart1.Series["chartthu"].YValueMembers = "tien";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                chart2.DataSource = PhieuNhapBUS.GetThangPN(year);


                chart2.Series["chartchi"].XValueMember = "thangPN";
                chart2.Series["chartchi"].YValueMembers = "tienPN";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            lbdoanhthu.Text = HoaDonBUS.TongDoanhThu(year).ToString();
            lbChiPhi.Text = PhieuNhapBUS.TongChiPhi(year).ToString();
        }
    }
}
