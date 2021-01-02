using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.EntityClient;
using System.Data.SqlClient;
using BUS;

namespace CuaHangDienTu
{
    public partial class UC_ThongKe : UserControl
    {
        public UC_ThongKe()
        {
            InitializeComponent();
        }
        
        private void UC_ThongKe_Load(object sender, EventArgs e)
        {
            
            comboBox1.DataSource = HoaDonBUS.GetNamHD();
            comboBox1.ValueMember = "YEAR";
            try
            {
                chart1.DataSource = HoaDonBUS.GetThangHD(int.Parse(comboBox1.SelectedValue.ToString()));


                chart1.Series["chartthu"].XValueMember = "thang";
                chart1.Series["chartthu"].YValueMembers = "tien";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                chart2.DataSource = PhieuNhapBUS.GetThangPN(int.Parse(comboBox1.SelectedValue.ToString()));


                chart2.Series["chartchi"].XValueMember = "thangPN";
                chart2.Series["chartchi"].YValueMembers = "tienPN";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            lbdoanhthu.Text = HoaDonBUS.TongDoanhThu(int.Parse(comboBox1.SelectedValue.ToString())).ToString();
            lbChiPhi.Text = PhieuNhapBUS.TongChiPhi(int.Parse(comboBox1.SelectedValue.ToString())).ToString();


        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

            UC_BieuDo uc = new UC_BieuDo(int.Parse(comboBox1.SelectedValue.ToString()));
            pnBieuDo.Controls.Clear();
            pnBieuDo.Controls.Add(uc);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }
    }
}
