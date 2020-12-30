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
using System.Data.EntityClient;
using System.Data.SqlClient;

namespace CuaHangDienTu
{
    public partial class UC_ThongKe : UserControl
    {
        public UC_ThongKe()
        {
            InitializeComponent();
        }
        int year = 2020;
        private void UC_ThongKe_Load(object sender, EventArgs e)
        {
            try
            {
                string kn = @"Data Source=LAPTOP-OCUUTDBF\SQLEXPRESS;Initial Catalog=CuaHangDienTu;Integrated Security=True";
                string cl = @" SELECT MONTH(HoaDon.NgayLap) as Thang , sum(HoaDon.TongTien) as Tien  FROM  HoaDon  WHERE  " +
                             "  YEAR(HoaDon.NgayLap) = 2020 group by MONTH(HoaDon.NgayLap) ";
                SqlConnection con = new SqlConnection(kn);
                SqlCommand cmd = new SqlCommand(cl, con);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                con.Open();
                chart1.DataSource = ds;
                chart1.Series["chartthu"].XValueMember = "Thang";
                chart1.Series["chartthu"].YValueMembers = "Tien";
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                string kn = @"Data Source=LAPTOP-OCUUTDBF\SQLEXPRESS;Initial Catalog=CuaHangDienTu;Integrated Security=True";
                string cl = @" SELECT MONTH(NgayLap) as 'Thang', sum(TongTien) as Tien FROM PhieuNhap WHERE YEAR(NgayLap) = 2020 group by MONTH(NgayLap) ";
                SqlConnection con = new SqlConnection(kn);
                SqlCommand cmd = new SqlCommand(cl, con);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                con.Open();
                chart1.DataSource = ds;
                chart1.Series["chartchi"].XValueMember = "Thang";
                chart1.Series["chartchi"].YValueMembers = "Tien";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        
    }
}
