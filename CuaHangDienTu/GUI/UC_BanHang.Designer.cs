namespace CuaHangDienTu
{
    partial class UC_BanHang
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
            this.pnCenter = new System.Windows.Forms.Panel();
            this.lbKiemtra = new System.Windows.Forms.Label();
            this.lbLapPhieu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLapHoaDon = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCenter
            // 
            this.pnCenter.BackColor = System.Drawing.Color.White;
            this.pnCenter.Location = new System.Drawing.Point(0, 69);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(898, 537);
            this.pnCenter.TabIndex = 45;
            // 
            // lbKiemtra
            // 
            this.lbKiemtra.AutoSize = true;
            this.lbKiemtra.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKiemtra.ForeColor = System.Drawing.Color.Black;
            this.lbKiemtra.Location = new System.Drawing.Point(720, 23);
            this.lbKiemtra.Name = "lbKiemtra";
            this.lbKiemtra.Size = new System.Drawing.Size(146, 19);
            this.lbKiemtra.TabIndex = 49;
            this.lbKiemtra.Text = "Kiểm tra bảo hành";
            this.lbKiemtra.Click += new System.EventHandler(this.lbKiemtra_Click);
            // 
            // lbLapPhieu
            // 
            this.lbLapPhieu.AutoSize = true;
            this.lbLapPhieu.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLapPhieu.ForeColor = System.Drawing.Color.Black;
            this.lbLapPhieu.Location = new System.Drawing.Point(501, 23);
            this.lbLapPhieu.Name = "lbLapPhieu";
            this.lbLapPhieu.Size = new System.Drawing.Size(153, 19);
            this.lbLapPhieu.TabIndex = 48;
            this.lbLapPhieu.Text = "Lập phiếu bảo hành";
            this.lbLapPhieu.Click += new System.EventHandler(this.lbLapPhieu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbKiemtra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbLapPhieu);
            this.panel1.Controls.Add(this.lbLapHoaDon);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 58);
            this.panel1.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 41);
            this.label1.TabIndex = 46;
            this.label1.Text = "Order";
            // 
            // lbLapHoaDon
            // 
            this.lbLapHoaDon.AutoSize = true;
            this.lbLapHoaDon.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLapHoaDon.ForeColor = System.Drawing.Color.Black;
            this.lbLapHoaDon.Location = new System.Drawing.Point(310, 23);
            this.lbLapHoaDon.Name = "lbLapHoaDon";
            this.lbLapHoaDon.Size = new System.Drawing.Size(101, 19);
            this.lbLapHoaDon.TabIndex = 47;
            this.lbLapHoaDon.Text = "Lập hóa đơn";
            this.lbLapHoaDon.Click += new System.EventHandler(this.lbLapHoaDon_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this.panel1;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 35;
            this.bunifuElipse2.TargetControl = this.pnCenter;
            // 
            // UC_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnCenter);
            this.Name = "UC_BanHang";
            this.Size = new System.Drawing.Size(898, 606);
            this.Load += new System.EventHandler(this.UC_BanHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnCenter;
        private System.Windows.Forms.Label lbLapPhieu;
        private System.Windows.Forms.Label lbKiemtra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLapHoaDon;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}
