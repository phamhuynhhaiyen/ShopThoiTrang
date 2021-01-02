namespace CuaHangDienTu
{
    partial class UC_ThongKe
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnBieuDo = new System.Windows.Forms.Panel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbChiPhi = new System.Windows.Forms.Label();
            this.lbdoanhthu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnBieuDo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 58);
            this.panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(693, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 24);
            this.comboBox1.TabIndex = 52;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(642, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "Năm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 50;
            this.label1.Text = "Thống kê";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this.panel1;
            // 
            // pnBieuDo
            // 
            this.pnBieuDo.BackColor = System.Drawing.Color.White;
            this.pnBieuDo.Controls.Add(this.lbChiPhi);
            this.pnBieuDo.Controls.Add(this.lbdoanhthu);
            this.pnBieuDo.Controls.Add(this.label3);
            this.pnBieuDo.Controls.Add(this.label4);
            this.pnBieuDo.Controls.Add(this.chart2);
            this.pnBieuDo.Controls.Add(this.chart1);
            this.pnBieuDo.Location = new System.Drawing.Point(0, 81);
            this.pnBieuDo.Name = "pnBieuDo";
            this.pnBieuDo.Size = new System.Drawing.Size(898, 522);
            this.pnBieuDo.TabIndex = 2;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 35;
            this.bunifuElipse2.TargetControl = this.pnBieuDo;
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(441, 20);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "chartchi";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(457, 483);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "chart2";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title3.Name = "Title1";
            title3.Text = "BIỂU ĐỒ THỐNG KÊ CHI PHÍ";
            this.chart2.Titles.Add(title3);
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(0, 20);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.LegendText = "Thu nhập";
            series4.Name = "chartthu";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(435, 483);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            title4.Name = "Title1";
            title4.Text = "BIỂU ĐỒ THỐNG KÊ DOANH THU";
            this.chart1.Titles.Add(title4);
            // 
            // lbChiPhi
            // 
            this.lbChiPhi.AutoSize = true;
            this.lbChiPhi.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiPhi.Location = new System.Drawing.Point(657, 494);
            this.lbChiPhi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbChiPhi.Name = "lbChiPhi";
            this.lbChiPhi.Size = new System.Drawing.Size(94, 18);
            this.lbChiPhi.TabIndex = 148;
            this.lbChiPhi.Text = "Tổng chi phí";
            // 
            // lbdoanhthu
            // 
            this.lbdoanhthu.AutoSize = true;
            this.lbdoanhthu.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdoanhthu.Location = new System.Drawing.Point(195, 494);
            this.lbdoanhthu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbdoanhthu.Name = "lbdoanhthu";
            this.lbdoanhthu.Size = new System.Drawing.Size(128, 18);
            this.lbdoanhthu.TabIndex = 147;
            this.lbdoanhthu.Text = "Tổng doanh thu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(531, 494);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 146;
            this.label3.Text = "Tổng chi phí:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 494);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 145;
            this.label4.Text = "Tổng doanh thu:";
            // 
            // UC_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnBieuDo);
            this.Controls.Add(this.panel1);
            this.Name = "UC_ThongKe";
            this.Size = new System.Drawing.Size(898, 606);
            this.Load += new System.EventHandler(this.UC_ThongKe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnBieuDo.ResumeLayout(false);
            this.pnBieuDo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnBieuDo;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbChiPhi;
        private System.Windows.Forms.Label lbdoanhthu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
