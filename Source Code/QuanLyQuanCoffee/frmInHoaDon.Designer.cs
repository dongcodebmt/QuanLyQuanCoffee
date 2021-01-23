
namespace QuanLyQuanCaffe
{
    partial class frmInHoaDon
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CTHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.CTHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CTHDBindingSource
            // 
            this.CTHDBindingSource.DataSource = typeof(QuanLyQuanCaffe.Reporting.rptCTHD);
            // 
            // reportHoaDon
            // 
            reportDataSource1.Name = "rptCTHD";
            reportDataSource1.Value = this.CTHDBindingSource;
            reportDataSource2.Name = "rptHoaDon";
            reportDataSource2.Value = this.HoaDonBindingSource;
            this.reportHoaDon.LocalReport.DataSources.Add(reportDataSource1);
            this.reportHoaDon.LocalReport.DataSources.Add(reportDataSource2);
            this.reportHoaDon.LocalReport.ReportEmbeddedResource = "QuanLyQuanCaffe.Reporting.HoaDon.rdlc";
            this.reportHoaDon.Location = new System.Drawing.Point(0, 0);
            this.reportHoaDon.Name = "reportHoaDon";
            this.reportHoaDon.ServerReport.BearerToken = null;
            this.reportHoaDon.Size = new System.Drawing.Size(478, 482);
            this.reportHoaDon.TabIndex = 0;
            // 
            // frmInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 482);
            this.Controls.Add(this.reportHoaDon);
            this.Name = "frmInHoaDon";
            this.Text = "In Hóa Đơn";
            this.Load += new System.EventHandler(this.frmInHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CTHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportHoaDon;
        private System.Windows.Forms.BindingSource CTHDBindingSource;
        private System.Windows.Forms.BindingSource HoaDonBindingSource;
    }
}