using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
   public static class Bus_Thonke 
    {

        public static void XuatExcel(DataGridView dataGridView  ,int check)
        {
            if (check < 5)
            {
                string CHU = "K";
                Microsoft.Office.Interop.Excel._Application _Application = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = _Application.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                string fontName = "Times New Roman";
              
                int hang = 3;
                int fontSizeTieuDe = 15;
                int fontSizeTenTruong = 14;
                int fontSizeNoiDung = 12;
                Range row1_TieuDe_ThongKeSanPham = worksheet.get_Range("G6", "M6");
                row1_TieuDe_ThongKeSanPham.Merge();
                row1_TieuDe_ThongKeSanPham.Font.Size = fontSizeTieuDe;
                row1_TieuDe_ThongKeSanPham.Font.Name = fontName;
                row1_TieuDe_ThongKeSanPham.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            //    row1_TieuDe_ThongKeSanPham.Value2 = " Bảng Thống Kê Từ Ngày  " + t1.ToString("dd / MM / yyyy") + "  Đến Ngày  " + t2.ToString("dd / MM / yyyy");
                row1_TieuDe_ThongKeSanPham.Font.Bold = true;
                hang += 2;
                Range row1_TieuDe1_ThongKeSanPham = worksheet.get_Range("H" + hang, "J" + hang);
                row1_TieuDe1_ThongKeSanPham.Merge();
                row1_TieuDe1_ThongKeSanPham.Font.Size = fontSizeTieuDe - 2;
                row1_TieuDe1_ThongKeSanPham.Font.Name = fontName;
                row1_TieuDe1_ThongKeSanPham.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                if (check == 2)
                { 
                    row1_TieuDe1_ThongKeSanPham.Value2 = " Bảng Thống Kê Hóa Đơn"; hang += 1;
                }

                else if (check == 3)
                {
                    row1_TieuDe1_ThongKeSanPham.Value2 = " Bảng Thống Kê Nhân Viên "; hang += 1;
                    CHU = "L";
                }
                else if (check == 1)
                {
                    row1_TieuDe1_ThongKeSanPham.Value2 = " Bảng Thống Kê Phiếu Nhập "; hang += 1;
                    CHU = "J";
                }
                else if (check == 4)
                {
                    row1_TieuDe1_ThongKeSanPham.Value2 = " Bảng Thống Kê Sản Phẩm"; hang += 1;
                    CHU = "L";

                }

                hang++;
                row1_TieuDe1_ThongKeSanPham.Font.Bold = true;
                Range row23_CotTieuDe = worksheet.get_Range(CHU + hang, "G" + hang);
              //  nền vàng
                row23_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Green);
               // in đậm
                row23_CotTieuDe.Font.Bold = true;

             //   worksheet.Cells[hang, 9] = "  STT";
                int Colum = 10;
                dynamic[] arr = new dynamic[dataGridView.Columns.Count];
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    arr[i] = "" + dataGridView.Columns[i].Name;
                    Colum += 1;
                }
                Range rowData1 = worksheet.get_Range(CHU + hang, "G" + hang);//Lấy dòng thứ row ra để đổ dữ liệu  `     
                rowData1.Font.Size = fontSizeNoiDung;
                rowData1.Font.Name = fontName;
                rowData1.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                rowData1.Value2 = arr;
                row23_CotTieuDe.ColumnWidth = 20;

                int stt = 1;
                int q = hang;
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    try
                    {
                        stt++;
                        hang++;
                        arr = new dynamic[dataGridView.Columns.Count];
                        for (int j = 0; j < dataGridView.Columns.Count; j++)
                        {
                            arr[j] = dataGridView.Rows[i].Cells[j].Value.ToString();
                        }
                        Range rowData = worksheet.get_Range(CHU + hang, "G" + hang);//Lấy dòng thứ row ra để đổ dữ liệu
                        
                        rowData.Font.Size = fontSizeNoiDung;
                        rowData.Font.Name = fontName;
                        rowData.Value2 = arr;

                    }
                    catch { }
                }

                BorderAround(worksheet.get_Range(CHU + (q + 1), "G" + hang));
              row23_CotTieuDe.Font.Bold = true;
                row23_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);
                _Application.Rows.AutoFit();
                _Application.Visible = true;

            }
        }
        private static void BorderAround(Range range)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = Color.Black;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }
        public static void XuatExcel()
        {
            throw new NotImplementedException();
        }
    }
}
