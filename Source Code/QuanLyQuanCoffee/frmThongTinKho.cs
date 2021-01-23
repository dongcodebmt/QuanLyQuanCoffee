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
    public partial class frmThongTinKho : Form
    {
        QLCFContext model;
        public frmThongTinKho()
        {
            InitializeComponent();
            model = new QLCFContext();
        }

        private void frmThongTinKho_Load(object sender, EventArgs e)
        {
            BilingListToDataKho(model.Kho.ToList());
            BilingListToDataNguyenLieu(model.NguyenLieu.ToList());
        }
        private void BilingListToDataKho(List<Kho> khos)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Tên");
            dt.Columns.Add("Số lượng");
            int STT = 1;
            for (int i = 0; i < khos.Count; i++, STT++)
            {
                Kho kho = khos[i];
                dt.Rows.Add(new string[] { STT.ToString(), kho.MonAn.ten, kho.tonKho.ToString() });
            }
            dataKho.DataSource = dt;
        }
        private void BilingListToDataNguyenLieu(List<NguyenLieu> nguyenLieus)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Tên");
            dt.Columns.Add("Số lượng");
            int STT = 1;
            for (int i = 0; i < nguyenLieus.Count; i++, STT++)
            {
                NguyenLieu nguyenLieu = nguyenLieus[i];
                dt.Rows.Add(new string[] { STT.ToString(), nguyenLieu.ten, nguyenLieu.trongLuong.ToString() });
            }
            dataNguyenLieu.DataSource = dt;
        }
    }
}
