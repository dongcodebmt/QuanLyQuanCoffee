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
    public partial class frmQuanLyCongThuc : Form
    {
        QLCFContext model;
        public frmQuanLyCongThuc()
        {
            InitializeComponent();
            model = new QLCFContext();
        }
        private void DataSetting()
        {
            dataCongThuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void frmNhapCongThuc_Load(object sender, EventArgs e)
        {
            ButtonLock(false);
            TB_CBLock(false);
            BilingListToDataGridView(model.CongThuc.ToList());
            FillDataToComboBox();
            DataSetting();
            TB_CBNull();
        }

        private void BilingListToDataGridView(List<CongThuc> listCongThuc)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Món ăn");
            dt.Columns.Add("Nguyên liệu");
            dt.Columns.Add("Tốn");
            int STT = 1;
            for (int i = 0; i < listCongThuc.Count; i++, STT++)
            {
                CongThuc ct = listCongThuc[i];
                dt.Rows.Add(new string[] { STT.ToString(), ct.MonAn.ten, ct.NguyenLieu.ten, ct.chiPhi.ToString() });
            }
            dataCongThuc.DataSource = dt;
        }

        private void FillDataToComboBox()
        {
            cbMonAn.DataSource = model.MonAn.Where(x => x.DonVi.ma == 1).ToList();
            cbMonAn.DisplayMember = "ten";
            cbMonAn.ValueMember = "ma";
            cbNguyenLieu.DataSource = model.NguyenLieu.ToList();
            cbNguyenLieu.DisplayMember = "ten";
            cbNguyenLieu.ValueMember = "ma";
        }

        private void dataCongThuc_SelectionChanged(object sender, EventArgs e)
        {
            if (dataCongThuc.SelectedRows.Count == 1)
            {
                cbMonAn.SelectedIndex = cbMonAn.FindStringExact(dataCongThuc.SelectedRows[0].Cells[1].Value.ToString());
                cbNguyenLieu.SelectedIndex = cbNguyenLieu.FindStringExact(dataCongThuc.SelectedRows[0].Cells[2].Value.ToString());
                txtChiPhi.Text = dataCongThuc.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TB_CBNull();
            ButtonLock(true);
            TB_CBLock(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ButtonLock(true);
            TB_CBLock(false);
            txtChiPhi.Enabled = true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maMon = Int32.Parse(cbMonAn.SelectedValue.ToString());
            int maNguyenLieu = Int32.Parse(cbNguyenLieu.SelectedValue.ToString());
            CongThuc ct = model.CongThuc.FirstOrDefault(x => x.maMon == maMon && x.maNguyenLieu == maNguyenLieu);
            if (ct == null)
            {
                MessageBox.Show("Không tìm thấy công thức cần xóa!");
            }
            else
            {
                model.CongThuc.Remove(ct);
                model.SaveChanges();
            }
            TB_CBNull();
            BilingListToDataGridView(model.CongThuc.ToList());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int maMon = Int32.Parse(cbMonAn.SelectedValue.ToString());
            int maNguyenLieu = Int32.Parse(cbNguyenLieu.SelectedValue.ToString());

            if (txtChiPhi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập khối lượng nguyên liệu cần!");
            }
            else
            {
                CongThuc ct = model.CongThuc.FirstOrDefault(x => x.maMon == maMon && x.maNguyenLieu == maNguyenLieu);
                if (ct == null)
                {
                    CongThuc congThuc = new CongThuc();
                    congThuc.maMon = Int32.Parse(cbMonAn.SelectedValue.ToString());
                    congThuc.maNguyenLieu = Int32.Parse(cbNguyenLieu.SelectedValue.ToString());
                    congThuc.chiPhi = float.Parse(txtChiPhi.Text);
                    model.CongThuc.Add(congThuc);
                }
                else
                {
                    ct.chiPhi = float.Parse(txtChiPhi.Text);
                }

            }
            model.SaveChanges();
            BilingListToDataGridView(model.CongThuc.ToList());

            ButtonLock(false);
            TB_CBLock(false);
            TB_CBNull();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ButtonLock(false);
            TB_CBLock(false);
        }

        private void ButtonLock(bool isLock)
        {
            btnHuy.Visible = isLock;
            btnLuu.Visible = isLock;
            btnThem.Visible = !isLock;
            btnSua.Visible = !isLock;
            btnXoa.Visible = !isLock;
        }

        private void TB_CBLock(bool isLock)
        {
            cbMonAn.Enabled = isLock;
            cbNguyenLieu.Enabled = isLock;
            txtChiPhi.Enabled = isLock;
        }
        private void TB_CBNull()
        {
            cbMonAn.SelectedItem = null;
            cbNguyenLieu.SelectedItem = null;
            txtChiPhi.Text = null;
        }
    }
}
