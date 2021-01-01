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
            //PhieuNhap pn = PhieuNhapBUS.GetPhieuNhap(maphieunhap);
            //QLshopthoitrangDataSet dataSet = new QLshopthoitrangDataSet();
            ReportParameter[] param = new ReportParameter[4];
            param[0] = new ReportParameter("MaPN",""+ maphieunhap);
            param[1] = new ReportParameter("NguoiLap", pn.Rows[0][1].ToString());
            param[2] = new ReportParameter("NgayLap", pn.Rows[0][2].ToString());
            param[3] = new ReportParameter("TongTien", pn.Rows[0][3].ToString());
            this.reportViewer1.LocalReport.SetParameters(param);
            ReportDataSource rds = new ReportDataSource("DataSetPhieuNhap", ctpn);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
