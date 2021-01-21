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
    public partial class frmQuanLyKhuyenMai : Form
    {
        QLCFContext model;
        public frmQuanLyKhuyenMai()
        {
            InitializeComponent();
            model = new QLCFContext();
        }
        private void DataSetting()
        {
            dataKhuyenMai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void frmQuanLyKhuyenMai_Load(object sender, EventArgs e)
        {
            ButtonLock(false);
            TB_CBLock(false);
            BilingListToDataGridView(model.KhuyenMai.Where(x => x.trangThai == true).ToList());
            DataSetting();
        }
        private void BilingListToDataGridView(List<KhuyenMai> khuyenMais)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Mã");
            dt.Columns.Add("Tên khuyến mãi");
            dt.Columns.Add("Mã khuyến mãi");
            dt.Columns.Add("Tỷ lệ");
            int STT = 1;
            for (int i = 0; i < khuyenMais.Count; i++, STT++)
            {
                KhuyenMai KM = khuyenMais[i];
                dt.Rows.Add(new string[] { STT.ToString(), KM.ma.ToString(), KM.ten, KM.maKhyenMai, KM.tyLe.ToString() });
            }
            dataKhuyenMai.DataSource = dt;
        }

        private void dataKhuyenMai_SelectionChanged(object sender, EventArgs e)
        {
            if (dataKhuyenMai.SelectedRows.Count == 1)
            {
                txtMa.Text = dataKhuyenMai.SelectedRows[0].Cells[1].Value.ToString();
                txtTen.Text = dataKhuyenMai.SelectedRows[0].Cells[2].Value.ToString();
                txtMaKM.Text = dataKhuyenMai.SelectedRows[0].Cells[3].Value.ToString();
                txtTyLe.Text = dataKhuyenMai.SelectedRows[0].Cells[4].Value.ToString();
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
            TB_CBLock(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ButtonLock(false);
            TB_CBLock(false);
            TB_CBNull();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            KhuyenMai KM = model.KhuyenMai.FirstOrDefault(x => x.maKhyenMai.ToUpper() == txtMaKM.Text.ToUpper());
            if (KM == null)
            {
                KhuyenMai khuyenMai = new KhuyenMai();
                khuyenMai.ten = txtTen.Text;
                khuyenMai.maKhyenMai = txtMaKM.Text.ToUpper();
                khuyenMai.tyLe = Int32.Parse(txtTyLe.Text);
                khuyenMai.trangThai = true;
                model.KhuyenMai.Add(khuyenMai);
            }
            else
            {
                KM.ten = txtTen.Text;
                KM.maKhyenMai = txtMaKM.Text.ToUpper();
                KM.tyLe = Int32.Parse(txtTyLe.Text);
                KM.trangThai = true;
            }

            model.SaveChanges();
            BilingListToDataGridView(model.KhuyenMai.Where(x => x.trangThai == true).ToList());
            ButtonLock(false);
            TB_CBLock(false);
            TB_CBNull();
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
            txtMa.Enabled = false;
            txtTen.Enabled = isLock;
            txtMaKM.Enabled = isLock;
            txtTyLe.Enabled = isLock;
        }
        private void TB_CBNull()
        {
            txtMa.Text = null;
            txtTen.Text = null;
            txtMaKM.Text = null;
            txtTyLe.Text = null;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            KhuyenMai khuyenMai = model.KhuyenMai.FirstOrDefault(x => x.maKhyenMai.ToUpper() == txtMaKM.Text.ToUpper());
            if (khuyenMai != null)
            {
                khuyenMai.trangThai = false;
                model.SaveChanges();
            }
            else
            {
                MessageBox.Show("Khuyến mãi không tồn tại");
            }
            TB_CBNull();
            BilingListToDataGridView(model.KhuyenMai.Where(x => x.trangThai == true).ToList());
        }
    }
}
