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
            List<MonAn> listMonAn = model.MonAn.ToList();
            List<LoaiMonAn> listLoaiMonAn = model.LoaiMonAn.ToList();
            List<DonVi> listDonVi = model.DonVi.ToList();
            FillComboBoxLoaiMonAn(listLoaiMonAn);
            FillComboBoxDonVi(listDonVi);
            BildingToDataGirdView(listMonAn);
            txtMaMonAn.ReadOnly = true;
            btnLuu.Visible = false;
            btnHuy.Visible = false;
            Setting();
            ReadOnlyAll();

        }
        private void Setting()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void BildingToDataGirdView(List<MonAn> listMonAn)
        {
            int STT = 1;
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Mã Món Ăn");
            dt.Columns.Add("Tên Món ăn");
            dt.Columns.Add("Loai Món ăn");
            dt.Columns.Add("Đơn vị");
            for (int i = 0; i < listMonAn.Count; i++,STT++)
            {
                MonAn m = listMonAn[i];
                dt.Rows.Add(new string[] { STT.ToString(), m.ma.ToString(), m.ten, m.LoaiMonAn.ten, m.DonVi.ten });
            }
            dataGridView1.DataSource = dt;
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

        private void ReadOnlyAll()
        {
            
            txtTenMonAn.ReadOnly = true;
            cbLoaiMonAn.Enabled = false;
            cbDonVi.Enabled = false;
        }

        private void UnReadOnlyAll()
        {
            
            txtTenMonAn.ReadOnly = false;
            cbLoaiMonAn.Enabled = true;
            cbDonVi.Enabled = true;
        }

        private void SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count >0 && dataGridView1.SelectedRows[0].Cells[0] != null)
            {
                txtMaMonAn.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtTenMonAn.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                cbLoaiMonAn.SelectedIndex = cbLoaiMonAn.FindStringExact(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                cbDonVi.SelectedIndex = cbDonVi.FindStringExact(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UnReadOnlyAll();
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnLuu.Visible = true;
            btnHuy.Visible = true;
            SettingAllNull();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UnReadOnlyAll();
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnLuu.Visible = true;
            btnHuy.Visible = true;
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            
            MonAn m1 = model.MonAn.FirstOrDefault(c => c.ma.ToString() == txtMaMonAn.Text);
            if(m1 == null)
            {
                MonAn m = new MonAn();
                m.ten = txtTenMonAn.Text;
                m.maLoaiMonAn = Convert.ToInt32(cbLoaiMonAn.SelectedValue);
                m.maDonVi = Convert.ToInt32(cbDonVi.SelectedValue);
                model.MonAn.Add(m);
                
            }
            else
            {
               
                m1.ten = txtTenMonAn.Text;
                m1.maLoaiMonAn = Convert.ToInt32(cbLoaiMonAn.SelectedValue);
                m1.maDonVi = Convert.ToInt32(cbDonVi.SelectedValue);
                
                
            }
            model.SaveChanges();
            BildingToDataGirdView(model.MonAn.ToList());
            SettingAllNull();
            btnThem.Visible = true;
            btnSua.Visible = true;
            btnLuu.Visible = false;
            btnHuy.Visible = false;
        }

        private void btnHuy_Cick(object sender, EventArgs e)
        {
            ReadOnlyAll();
            SettingAllNull();
            btnThem.Visible = true;
            btnSua.Visible = true;
            btnLuu.Visible = false;
            btnHuy.Visible = false;
        }
        private void SettingAllNull()
        {
            txtMaMonAn.Text = "";
            txtTenMonAn.Text = "";
            cbLoaiMonAn.SelectedIndex = 1;
            cbDonVi.SelectedIndex = 1;
        }
    }
}
