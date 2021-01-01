using BUS;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangDienTu.Report
{
    public partial class frmHoaDon : Form
    {
        long MaHD;
        public frmHoaDon(long mahd)
        {
            InitializeComponent();
            this.MaHD = mahd;
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            DataTable cthd = HoaDonBUS.GetCTHD(MaHD);
            DataTable pn = HoaDonBUS.GetHoaDon(MaHD);

            ReportParameter[] param = new ReportParameter[5];
            param[0] = new ReportParameter("MaHD", "" + MaHD);
            param[1] = new ReportParameter("KhachHang", pn.Rows[0][1].ToString());
            param[2] = new ReportParameter("NguoiLap", pn.Rows[0][2].ToString());
            param[3] = new ReportParameter("NgayLap", pn.Rows[0][3].ToString());
            param[4] = new ReportParameter("TongTien", pn.Rows[0][4].ToString());
            this.reportViewer1.LocalReport.SetParameters(param);
            ReportDataSource rds = new ReportDataSource("DataSet2", cthd);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();

        }
    }
}
