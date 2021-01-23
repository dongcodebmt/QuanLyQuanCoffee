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
    public partial class frmQuanLyNguyenLieu : Form
    {
        QLCFContext model;

        public frmQuanLyNguyenLieu()
        {
            model = new QLCFContext();
            InitializeComponent();
        }

        private void frmQuanLyNguyenLieu_Load(object sender, EventArgs e)
        {
            model = new QLCFContext();
            List<NguyenLieu> listNguyenLieu = model.NguyenLieu.ToList();
            Setting();
            BildingToDataGirdViewNguyenLieu(listNguyenLieu);
            InitializeComponent();
             ReadOnlyAll();
            //btnLuu.Visible = false;
            //txtTenNL.Enabled = false;
            
        }
        private void BildingToDataGirdViewNguyenLieu(List<NguyenLieu> listNguyenLieu)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Mã nguyên liệu");
            dt.Columns.Add("Tên nguyên liệu");

            int STT = 1;
            for (int i = 0; i < listNguyenLieu.Count; i++, STT++)
            {
                NguyenLieu temp = listNguyenLieu[i];
                dt.Rows.Add(new string[] { STT.ToString(), temp.ma.ToString(), temp.ten });
            }
            dataGridView1.DataSource = dt;
        }
        private void Setting()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void ReadOnlyAll()
        {
            txtMaNL.ReadOnly = true;
            txtTenNL.ReadOnly = true;
        }
        private void UnReadOnlyAll()
        {
            btnLuu.Visible = false;
            btnHuy.Visible = false;

        }
        private void SetTextBoXNull()
        {
            txtMaNL.Text = "";
            txtTenNL.Text = "";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NguyenLieu n = new NguyenLieu();
            n.ten = txtTenNL.Text;
            n.trongLuong = 0;
            model.NguyenLieu.Add(n);
            model.SaveChanges();
        }
    }
}



