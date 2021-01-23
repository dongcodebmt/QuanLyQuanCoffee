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
            txtMaBan.ReadOnly = true;
            btnLuu.Visible = false;
            btnHuy.Visible = false;
            ReadOnlyAll();
            
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
        private void ReadOnlyAll()
        {
           
            txtTenBan.ReadOnly = true;
            txtTrangThai.ReadOnly = true;
        }
        private void UnReadOnlyAll()
        {
            txtTenBan.ReadOnly = false;
            txtTrangThai.ReadOnly = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaBan.Text = "";
            txtTenBan.ReadOnly = false;
            btnLuu.Visible = true;
            btnHuy.Visible = true;
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UnReadOnlyAll();
            txtTrangThai.ReadOnly = true;
            btnLuu.Visible = true;
            btnHuy.Visible = true;
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
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
            BildingToDataGirdView(model.Ban.ToList());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            if(txtMaBan.Text == "")
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
            btnThem.Visible = true;
            btnSua.Visible = true;
            btnXoa.Visible = true;
            btnLuu.Visible = false;
            btnHuy.Visible = false;
        }
    }
}
