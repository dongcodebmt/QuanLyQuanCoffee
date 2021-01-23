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
    public partial class frmQuanLyMonAn : Form
    {
        QLCFContext model;
        public frmQuanLyMonAn()
        {
            model = new QLCFContext();
            InitializeComponent();
        }

        private void QuanLyMonAn_Load(object sender, EventArgs e)
        {
            FillComboBoxLoaiMonAn(model.LoaiMonAn.ToList());
            FillComboBoxDonVi(model.DonVi.ToList());
            BildingToDataGirdView(model.MonAn.Where(x => x.trangThai == true).ToList());
            DataSetting();
            txtMaMonAn.Enabled = false;
            ButtonLock(false);
            TB_CBLock(false);
            TB_CBNull();

        }
        private void DataSetting()
        {
            dataMonAn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void BildingToDataGirdView(List<MonAn> listMonAn)
        {
            int STT = 1;
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Mã món ăn");
            dt.Columns.Add("Tên món ăn");
            dt.Columns.Add("Giá");
            dt.Columns.Add("Loai Món ăn");
            dt.Columns.Add("Đơn vị");
            for (int i = 0; i < listMonAn.Count; i++,STT++)
            {
                MonAn m = listMonAn[i];
                dt.Rows.Add(new string[] { STT.ToString(), m.ma.ToString(), m.ten, m.gia.ToString(), m.LoaiMonAn.ten, m.DonVi.ten });
            }
            dataMonAn.DataSource = dt;
        }
        private void FillComboBoxLoaiMonAn(List<LoaiMonAn> listLoaiMonAn)
        {
            cbLoaiMonAn.DataSource = listLoaiMonAn;
            cbLoaiMonAn.DisplayMember = "ten";
            cbLoaiMonAn.ValueMember = "ma";
        }
        private void FillComboBoxDonVi(List<DonVi> listDonVi)
        {
            cbDonVi.DataSource = listDonVi;
            cbDonVi.DisplayMember = "ten";
            cbDonVi.ValueMember = "ma";
        }

        private void SelectionChanged(object sender, EventArgs e)
        {
            if(dataMonAn.SelectedRows.Count >0 && dataMonAn.SelectedRows[0].Cells[0] != null)
            {
                txtMaMonAn.Text = dataMonAn.SelectedRows[0].Cells[1].Value.ToString();
                txtTenMonAn.Text = dataMonAn.SelectedRows[0].Cells[2].Value.ToString();
                txtGia.Text = dataMonAn.SelectedRows[0].Cells[3].Value.ToString();
                cbLoaiMonAn.SelectedIndex = cbLoaiMonAn.FindStringExact(dataMonAn.SelectedRows[0].Cells[4].Value.ToString());
                cbDonVi.SelectedIndex = cbDonVi.FindStringExact(dataMonAn.SelectedRows[0].Cells[5].Value.ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ButtonLock(true);
            TB_CBLock(true);
            TB_CBNull();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ButtonLock(true);
            TB_CBLock(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cbDonVi.SelectedValue == null || cbLoaiMonAn.SelectedValue == null || txtTenMonAn.Text == "" || txtGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                MonAn m1 = model.MonAn.FirstOrDefault(c => c.ma.ToString() == txtMaMonAn.Text);
                if (m1 == null)
                {
                    MonAn m = new MonAn();
                    m.ten = txtTenMonAn.Text;
                    m.gia = decimal.Parse(txtGia.Text);
                    m.maLoaiMonAn = Convert.ToInt32(cbLoaiMonAn.SelectedValue);
                    m.maDonVi = Convert.ToInt32(cbDonVi.SelectedValue);
                    m.trangThai = true;
                    model.MonAn.Add(m);
                }
                else
                {
                    m1.gia = decimal.Parse(txtGia.Text);
                    m1.ten = txtTenMonAn.Text;
                    m1.maLoaiMonAn = Convert.ToInt32(cbLoaiMonAn.SelectedValue);
                    m1.maDonVi = Convert.ToInt32(cbDonVi.SelectedValue);
                    m1.trangThai = true;
                }
                model.SaveChanges();
            }
            BildingToDataGirdView(model.MonAn.Where(x => x.trangThai == true).ToList()); 
            ButtonLock(false);
            TB_CBLock(false);
            TB_CBNull();
        }

        private void btnHuy_Cick(object sender, EventArgs e)
        {
            ButtonLock(false);
            TB_CBLock(false);
            TB_CBNull();
        }

        private void TB_CBLock(bool isLock)
        {
            txtTenMonAn.Enabled = isLock;
            txtGia.Enabled = isLock;
            cbLoaiMonAn.Enabled = isLock;
            cbDonVi.Enabled = isLock;
        }
        private void ButtonLock(bool isLock)
        {
            btnHuy.Visible = isLock;
            btnLuu.Visible = isLock;
            btnThem.Visible = !isLock;
            btnSua.Visible = !isLock;
        }
        private void TB_CBNull()
        {
            txtMaMonAn.Text = null;
            txtTenMonAn.Text = null;
            txtGia.Text = null;
            cbLoaiMonAn.SelectedItem = null;
            cbDonVi.SelectedItem = null;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MonAn monAn = model.MonAn.FirstOrDefault(x => x.ma.ToString() == txtMaMonAn.Text);
            if (monAn != null)
            {
                monAn.trangThai = false;
                model.SaveChanges();
            }
            else
            {
                MessageBox.Show("Món ăn không tồn tại");
            }
            TB_CBNull();
            BildingToDataGirdView(model.MonAn.Where(x => x.trangThai == true).ToList());
        }
    }
}
