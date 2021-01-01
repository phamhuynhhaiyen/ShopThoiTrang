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
using BUS;
using DTO;

namespace CuaHangDienTu.Report
{
    public partial class frmPhieuNhap : Form
    {
        public long maphieunhap;
        public frmPhieuNhap(long maPN)
        {
            InitializeComponent();
            this.maphieunhap = maPN;
        }
        
        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            
            DataTable ctpn = PhieuNhapBUS.GetCTPN(maphieunhap);
            DataTable pn = PhieuNhapBUS.GetPhieuNhap(maphieunhap);

            //ReportParameter[] param = new ReportParameter[1];
            //param[0] = new ReportParameter("MaPN", Convert.ToString(maphieunhap));
            //param[1] = new ReportParameter("TenNV", pn.Columns[1].ToString());
            //param[2] = new ReportParameter("NgayLap", );
            //param[3] = new ReportParameter("TongTien", );
            //this.reportViewer1.LocalReport.SetParameters(param);
            ReportDataSource rds = new ReportDataSource("DataSetPhieuNhap", ctpn);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
