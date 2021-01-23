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
    public partial class frmQuanLyBan : Form
    {
        QLCFContext model;
        public frmQuanLyBan()
        {
            model = new QLCFContext();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void frmQuanLyBan_Load(object sender, EventArgs e)
        {
            List<Ban> listBan = model.Ban.ToList();
            BildingToDataGirdView(listBan);
            ButtonLock(false);
            TB_CBLock(false);
        }

        private void BildingToDataGirdView(List<Ban> listBan)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Mã Bàn");
            dt.Columns.Add("Tên Bàn");
            dt.Columns.Add("Trạng thái");
            int STT = 1;
            for (int i = 0; i <listBan.Count;i++,STT++)
            {
                Ban b = listBan[i];
                string s;
                if(b.trangThai == true)
                {
                     s = "Còn hoạt động";
                }
                else {
                     s = "Không còn hoạt động";
                }
                dt.Rows.Add(new string[] { STT.ToString(), b.ma.ToString(), b.ten, s.ToString() });
            }
            dataGVBan.DataSource = dt;
        }

        private void SCBan_CLick(object sender, EventArgs e)
        {
            if(dataGVBan.SelectedRows.Count>0 && dataGVBan.SelectedRows[0].Cells[0] != null)
            {
                txtMaBan.Text = dataGVBan.SelectedRows[0].Cells[1].Value.ToString();
                txtTenBan.Text = dataGVBan.SelectedRows[0].Cells[2].Value.ToString();
                txtTrangThai.Text = dataGVBan.SelectedRows[0].Cells[3].Value.ToString();
            } 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaBan.Text = "";
            ButtonLock(true);
            TB_CBNull();
            TB_CBLock(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ButtonLock(true);
            TB_CBLock(true);
            if (txtMaBan.Text == "")
            {
                MessageBox.Show("Vui lòng chọn bàn để sửa");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaBan.Text == "")
            {
                MessageBox.Show("Không tim thấy bàn cần xóa");
            }
            else
            {
                int s = Int32.Parse(txtMaBan.Text);
                Ban b = model.Ban.FirstOrDefault(c => c.ma == s);
                model.Ban.Remove(b);
                model.SaveChanges();
            }
            TB_CBNull();
            BildingToDataGirdView(model.Ban.ToList());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenBan.Text == "")
            {
                if (txtMaBan.Text == "")
                {
                    Ban bnew = new Ban();
                    bnew.ten = txtTenBan.Text;
                    bnew.trangThai = true;
                    model.Ban.Add(bnew);

                }
                else
                {
                    int s = Int32.Parse(txtMaBan.Text);
                    Ban b = model.Ban.FirstOrDefault(c => c.ma == s);
                    b.ten = txtTenBan.Text;

                }
                model.SaveChanges();
                BildingToDataGirdView(model.Ban.ToList());
                ButtonLock(false);
                TB_CBLock(false);
                TB_CBNull();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên bàn!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TB_CBLock(false);
            ButtonLock(false);
            TB_CBNull();
        }
        private void TB_CBLock(bool isLock)
        {
            txtMaBan.ReadOnly = true;
            txtTenBan.Enabled = isLock;
            txtTrangThai.ReadOnly = true;
        }
        private void ButtonLock(bool isLock)
        {
            btnHuy.Visible = isLock;
            btnLuu.Visible = isLock;
            btnThem.Visible = !isLock;
            btnSua.Visible = !isLock;
            btnXoa.Visible = !isLock;
        }
        private void TB_CBNull()
        {
            txtMaBan.Text = null;
            txtTenBan.Text = null;
            txtTrangThai.Text = null;
        }
    }
}
