
namespace QuanLyQuanCaffe
{
    partial class frmQuanLyDoanhThu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tpBill = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.QuanLy = new System.Windows.Forms.TabControl();
            this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lbTuNgay = new System.Windows.Forms.Label();
            this.lbDenNgay = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.reportDoanhThu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tpBill.SuspendLayout();
            this.panel7.SuspendLayout();
            this.QuanLy.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.reportDoanhThu);
            this.tpBill.Controls.Add(this.panel7);
            this.tpBill.Controls.Add(this.panel6);
            this.tpBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpBill.Location = new System.Drawing.Point(4, 22);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(768, 400);
            this.tpBill.TabIndex = 1;
            this.tpBill.Text = "Doanh thu";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnThongKe);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(3, 358);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(762, 39);
            this.panel7.TabIndex = 2;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(342, 5);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 31);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // QuanLy
            // 
            this.QuanLy.Controls.Add(this.tpBill);
            this.QuanLy.Location = new System.Drawing.Point(12, 12);
            this.QuanLy.Name = "QuanLy";
            this.QuanLy.SelectedIndex = 0;
            this.QuanLy.Size = new System.Drawing.Size(776, 426);
            this.QuanLy.TabIndex = 4;
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.Location = new System.Drawing.Point(155, 6);
            this.dtTuNgay.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(200, 20);
            this.dtTuNgay.TabIndex = 1;
            this.dtTuNgay.Value = new System.DateTime(2021, 1, 23, 0, 0, 0, 0);
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.Location = new System.Drawing.Point(436, 7);
            this.dtDenNgay.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(200, 20);
            this.dtDenNgay.TabIndex = 2;
            // 
            // lbTuNgay
            // 
            this.lbTuNgay.AutoSize = true;
            this.lbTuNgay.Location = new System.Drawing.Point(103, 12);
            this.lbTuNgay.Name = "lbTuNgay";
            this.lbTuNgay.Size = new System.Drawing.Size(46, 13);
            this.lbTuNgay.TabIndex = 2;
            this.lbTuNgay.Text = "Từ ngày";
            // 
            // lbDenNgay
            // 
            this.lbDenNgay.AutoSize = true;
            this.lbDenNgay.Location = new System.Drawing.Point(377, 12);
            this.lbDenNgay.Name = "lbDenNgay";
            this.lbDenNgay.Size = new System.Drawing.Size(53, 13);
            this.lbDenNgay.TabIndex = 3;
            this.lbDenNgay.Text = "Đến ngày";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbDenNgay);
            this.panel6.Controls.Add(this.lbTuNgay);
            this.panel6.Controls.Add(this.dtDenNgay);
            this.panel6.Controls.Add(this.dtTuNgay);
            this.panel6.Location = new System.Drawing.Point(6, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(756, 35);
            this.panel6.TabIndex = 1;
            // 
            // reportDoanhThu
            // 
            this.reportDoanhThu.LocalReport.ReportEmbeddedResource = "QuanLyQuanCaffe.Reporting.DoanhThu.rdlc";
            this.reportDoanhThu.Location = new System.Drawing.Point(6, 47);
            this.reportDoanhThu.Name = "reportDoanhThu";
            this.reportDoanhThu.ServerReport.BearerToken = null;
            this.reportDoanhThu.Size = new System.Drawing.Size(756, 305);
            this.reportDoanhThu.TabIndex = 3;
            // 
            // frmQuanLyDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuanLy);
            this.Name = "frmQuanLyDoanhThu";
            this.Text = "Quản lý doanh thu";
            this.Load += new System.EventHandler(this.frmQuanLyDoanhThu_Load);
            this.tpBill.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.QuanLy.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.TabControl QuanLy;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbDenNgay;
        private System.Windows.Forms.Label lbTuNgay;
        private System.Windows.Forms.DateTimePicker dtDenNgay;
        private System.Windows.Forms.DateTimePicker dtTuNgay;
        private Microsoft.Reporting.WinForms.ReportViewer reportDoanhThu;
    }
}