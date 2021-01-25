using Microsoft.Reporting.WinForms;
using QuanLyQuanCaffe.Database;
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
    public partial class frmQuanLyDoanhThu : Form
    {
        QLCFContext model;
        public frmQuanLyDoanhThu()
        {
            InitializeComponent();
            model = new QLCFContext();
        }

        private void frmQuanLyDoanhThu_Load(object sender, EventArgs e)
        {
            SetDay(1);
        }
        private void XuatBaoCao()
        {
            DateTime ngayVao = dtTuNgay.Value;
            DateTime ngayRa = dtDenNgay.Value;
            double doanhThu = 0;
            int tongMon = 0;
            List<CTHD> cTHDs = model.CTHD.Where(x => x.HoaDon.ngayVao >= ngayVao && x.HoaDon.ngayRa <= ngayRa).ToList();
            foreach (var item in cTHDs)
            {
                double temp = (double)(item.soLuong * item.MonAn.gia);
                double giamGia = 0;
                if (item.HoaDon.maKhuyenMai != null)
                {
                    giamGia = giamGia + (temp * (item.HoaDon.KhuyenMai.tyLe) / 100);
                }
                doanhThu += temp - giamGia;
                tongMon = tongMon + item.soLuong;
            }

            ReportParameter[] HD = new ReportParameter[]
            {
                new ReportParameter("tuNgay", "Từ ngày: " + ngayVao.ToString()),
                new ReportParameter("denNgay", "Đến ngày: " + ngayRa.ToString()),
                new ReportParameter("doanhThu", doanhThu.ToString() + " VND"),
                new ReportParameter("tongMon", tongMon + " mặt hàng"),
            };

            this.reportDoanhThu.LocalReport.ReportPath = "DoanhThu.rdlc";
            this.reportDoanhThu.LocalReport.DataSources.Clear();
            this.reportDoanhThu.LocalReport.SetParameters(HD);
            this.reportDoanhThu.RefreshReport();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            XuatBaoCao();
        }
        private void SetDay(int month)
        {
            dtDenNgay.Value = DateTime.Now;
            dtTuNgay.Value = dtDenNgay.Value.AddMonths(-month);
        }
    }
}
