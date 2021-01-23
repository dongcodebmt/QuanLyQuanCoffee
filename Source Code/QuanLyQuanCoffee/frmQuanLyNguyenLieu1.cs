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
    public partial class frmQuanLyNguyenLieu1 : Form
    {
        QLCFContext model;
        public frmQuanLyNguyenLieu1()
        {
            model = new QLCFContext();
            InitializeComponent();
        }

        private void frmQuanLyNguyenLieu1_Load(object sender, EventArgs e)
        {
            List<NguyenLieu> listNL = model.NguyenLieu.ToList();
            BildingToData(listNL);
            ReadOnlyAll();
        }
        private void BildingToData(List<NguyenLieu> listNguyenLieu)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Ma nguyên liệu");
            dt.Columns.Add("Tên nguyên liệu");
            dt.Columns.Add("Trọng lượng");
            int STT = 1;
            for (int i = 0; i < listNguyenLieu.Count; i++,STT++)        
            {
                NguyenLieu nl = listNguyenLieu[i];
                dt.Rows.Add(new string[] { STT.ToString(), nl.ma.ToString(), nl.ten, nl.trongLuong.ToString() });

            }
            dataGridView1.DataSource = dt;
        }

        private void SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells[0] != null)
            {
                txtMa.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtTen.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtTrongLuong.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
        private void ReadOnlyAll()
        {
            txtMa.ReadOnly = true;
            txtTen.ReadOnly = true;
            txtTrongLuong.ReadOnly = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTen.ReadOnly = false;
         
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Vui long nhập tên nguyên liệu cần thêm");
            }
            else
            {
                NguyenLieu nl = new NguyenLieu();
                nl.ten = txtTen.Text;
                nl.trongLuong = 0;
                model.NguyenLieu.Add(nl);
                model.SaveChanges();
            }
            BildingToData(model.NguyenLieu.ToList());
            SettingTBNull();
          
        }
        private void SettingTBNull()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtTrongLuong.Text = "";
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTen.ReadOnly = false;
            txtTrongLuong.ReadOnly = false;
            if (string.IsNullOrWhiteSpace(txtMa.Text))
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu cấn sửa");
            }
            else
            {
                int s = Int32.Parse(txtMa.Text);
                NguyenLieu nl = model.NguyenLieu.FirstOrDefault(c => c.ma == s);
                nl.ten = txtTen.Text;
                nl.trongLuong = float.Parse( txtTrongLuong.Text);
                model.SaveChanges();
            }
            BildingToData(model.NguyenLieu.ToList());
            SettingTBNull();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrWhiteSpace(txtMa.Text))
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu cấn xóa");
            }
            else
            {
                int s = Int32.Parse(txtMa.Text);
                NguyenLieu nl = model.NguyenLieu.FirstOrDefault(c => c.ma == s);
                model.NguyenLieu.Remove(nl);
                model.SaveChanges();
            }
            BildingToData(model.NguyenLieu.ToList());
            SettingTBNull();
        }
    }
}
