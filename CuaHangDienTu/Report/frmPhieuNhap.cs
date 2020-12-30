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
            
        }
    }
}
