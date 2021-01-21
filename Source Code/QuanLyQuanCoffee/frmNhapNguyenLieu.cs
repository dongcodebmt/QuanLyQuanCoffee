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
    public partial class frmNhapNguyenLieu : Form
    {
        QLCFContext model;
        public frmNhapNguyenLieu()
        {
            InitializeComponent();
            model = new QLCFContext();
        }

        private void frmNhapNguyenLieu_Load(object sender, EventArgs e)
        {
            List<PhieuNhapNN> phieuNhapNNs = model.PhieuNhapNN.ToList();
            BilingListToDataGridView(phieuNhapNNs);
            List<NguyenLieu> nguyenLieus = model.NguyenLieu.ToList();
            FillDataToComboBox(nguyenLieus);
            cbNguyenLieu.SelectedItem = null;
        }

        private void BilingListToDataGridView(List<PhieuNhapNN> phieuNhapNNs)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Ngày nhập");
            dt.Columns.Add("Nguyên liệu");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Giá");
            int STT = 1;
            for (int i = 0; i < phieuNhapNNs.Count; i++, STT++)
            {
                PhieuNhapNN PN = phieuNhapNNs[i];
                dt.Rows.Add(new string[] { STT.ToString(), PN.ngayNhap.ToString(), PN.NguyenLieu.ten, PN.soLuong.ToString(), PN.giaDauVao.ToString() });
            }
            dataNhapNN.DataSource = dt;
        }
        private void FillDataToComboBox(List<NguyenLieu> nguyenLieus)
        {
            cbNguyenLieu.DataSource = nguyenLieus;
            cbNguyenLieu.DisplayMember = "ten";
            cbNguyenLieu.ValueMember = "ma";
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (txtGiaMua.Text == "" || txtTrongLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                PhieuNhapNN phieuNhapNN = new PhieuNhapNN();
                phieuNhapNN.ngayNhap = DateTime.Now;
                phieuNhapNN.maNguyenLieu = Int32.Parse(cbNguyenLieu.SelectedValue.ToString());
                phieuNhapNN.soLuong = float.Parse(txtTrongLuong.Text);
                phieuNhapNN.giaDauVao = decimal.Parse(txtGiaMua.Text);
                model.PhieuNhapNN.Add(phieuNhapNN);
                model.SaveChanges();

                NguyenLieu nguyenLieu = model.NguyenLieu.FirstOrDefault(x => x.ma == phieuNhapNN.maNguyenLieu);
                nguyenLieu.trongLuong = nguyenLieu.trongLuong + phieuNhapNN.soLuong;
                model.SaveChanges();
            }
            BilingListToDataGridView(model.PhieuNhapNN.ToList());
        }
    }
}
