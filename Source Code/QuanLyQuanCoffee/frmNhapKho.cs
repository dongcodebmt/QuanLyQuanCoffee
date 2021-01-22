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
    public partial class frmNhapKho : Form
    {
        QLCFContext model;
        public frmNhapKho()
        {
            InitializeComponent();
            model = new QLCFContext();
        }

        private void frmNhapKho_Load(object sender, EventArgs e)
        {
            rbtnThung.Checked = true;
            BilingListToDataGridView(model.PhieuNhap.ToList());
            FillDataToComboBox(model.MonAn.Where(x => x.DonVi.ma != 1).ToList());
            cbMonAn.SelectedItem = null;
        }

        private void BilingListToDataGridView(List<PhieuNhap> phieuNhaps)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Ngày nhập");
            dt.Columns.Add("Món nhập");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Giá");
            int STT = 1;
            for (int i = 0; i < phieuNhaps.Count; i++, STT++)
            {
                PhieuNhap PN = phieuNhaps[i];
                dt.Rows.Add(new string[] { STT.ToString(), PN.ngayNhap.ToString(), PN.Kho.MonAn.ten, PN.soLuong.ToString(), PN.giaDauVao.ToString() });
            }
            dataNhapKho.DataSource = dt;
        }

        private void FillDataToComboBox(List<MonAn> monAns)
        {
            cbMonAn.DataSource = monAns;
            cbMonAn.DisplayMember = "ten";
            cbMonAn.ValueMember = "ma";
        }

        private void rbtnThung_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnThung.Checked == true)
            {
                lbSLLe.Visible = true;
                txtSLLe.Visible = true;
            }
            else
            {
                lbSLLe.Visible = false;
                txtSLLe.Visible = false;
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (txtGiaMua.Text == "" || txtSoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                int maKho = Int32.Parse(cbMonAn.SelectedValue.ToString());
                int soLuong = Int32.Parse(txtSoLuong.Text);

                if (rbtnThung.Checked == true && txtSLLe.Text != "")
                {
                    soLuong = soLuong * Int32.Parse(txtSLLe.Text);
                }
                else if (rbtnLe.Checked != true)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }

                Kho kho = model.Kho.FirstOrDefault(x => x.ma == maKho);
                if (kho == null)
                {
                    Kho khoMoi = new Kho();
                    khoMoi.ma = maKho;
                    khoMoi.tonKho = soLuong;
                    model.Kho.Add(khoMoi);
                }
                else
                {
                    kho.tonKho = kho.tonKho + soLuong;
                }
                model.SaveChanges();

                PhieuNhap phieuNhap = new PhieuNhap();
                phieuNhap.ngayNhap = DateTime.Now;
                phieuNhap.maKho = maKho;
                phieuNhap.soLuong = soLuong;
                phieuNhap.giaDauVao = decimal.Parse(txtGiaMua.Text);
                model.PhieuNhap.Add(phieuNhap);
                model.SaveChanges();
            }

            BilingListToDataGridView(model.PhieuNhap.ToList());
        }
    }
}
