using Microsoft.Reporting.WinForms;
using QuanLyQuanCaffe.Database;
using QuanLyQuanCaffe.Reporting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaffe
{
    public partial class frmInHoaDon : Form
    {
        QLCFContext model;
        public static int maHDHT;
        public frmInHoaDon()
        {
            InitializeComponent();
            model = new QLCFContext();
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            HoaDon hoaDon = model.HoaDon.FirstOrDefault(x => x.ma == maHDHT);
            List<CTHD> cTHDs = model.CTHD.Where(x => x.maHoaDon == maHDHT).ToList();
            double tamTinh = 0;
            double tyLe = 0;
            double tongTien = 0;
            List<rptCTHD> listCTHD = new List<rptCTHD>();
            foreach (CTHD item in cTHDs)
            {
                rptCTHD temp = new rptCTHD();
                temp.tenMon = item.MonAn.ten;
                temp.soLuong = item.soLuong;
                temp.soTien = (double)(item.soLuong * item.MonAn.gia);
                tamTinh += temp.soTien;
                listCTHD.Add(temp);
            }

            if (hoaDon.maKhuyenMai != null)
            {
                tyLe = hoaDon.KhuyenMai.tyLe;
            }
            tongTien = tamTinh - (tamTinh * tyLe) / 100;

            ReportParameter[] HD = new ReportParameter[]
            {
                new ReportParameter("maHD", hoaDon.ma.ToString()),
                new ReportParameter("ban", hoaDon.Ban.ten),
                new ReportParameter("nguoiPV", hoaDon.TaiKhoan.hoTen),
                new ReportParameter("gioVao", hoaDon.ngayVao.ToString()),
                new ReportParameter("gioIn", DateTime.Now.ToString()),
                new ReportParameter("tamTinh", tamTinh.ToString() + " VND"),
                new ReportParameter("tyLe", tyLe.ToString() + "%"),
                new ReportParameter("tongTien", tongTien.ToString() + " VND"),
            };

            this.reportHoaDon.LocalReport.ReportPath = "D:/Cloud/C#/QuanLyQuanCoffee/Source Code/QuanLyQuanCoffee/Reporting/HoaDon.rdlc";
            var reportDataSource = new ReportDataSource("rptCTHD", listCTHD);
            this.reportHoaDon.LocalReport.DataSources.Clear();
            this.reportHoaDon.LocalReport.DataSources.Add(reportDataSource);
            this.reportHoaDon.LocalReport.SetParameters(HD);
            this.reportHoaDon.RefreshReport();
        }
    }
}
