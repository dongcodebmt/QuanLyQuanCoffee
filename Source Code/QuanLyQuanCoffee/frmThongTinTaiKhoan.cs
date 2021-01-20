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
    public partial class frmThongTinTaiKhoan : Form
    {
        QLCFContext model;
        public int maTaiKhoan;
        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
            model = new QLCFContext();
            maTaiKhoan = frmMain.maTaiKhoan;
        }

        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = model.TaiKhoan.FirstOrDefault(x => x.ma == maTaiKhoan);
            lbXinChao.Text = "Xin chào " + taiKhoan.hoTen + "!";
            txtTenTaiKhoan.Enabled = false;
            txtTenTaiKhoan.Text = taiKhoan.tenDangNhap;
            txtHoTen.Text = taiKhoan.hoTen;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;

            if (hoTen == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                TaiKhoan taiKhoan = model.TaiKhoan.FirstOrDefault(x => x.ma == maTaiKhoan);
                taiKhoan.hoTen = hoTen;
                model.SaveChanges();
                lbXinChao.Text = "Xin chào " + taiKhoan.hoTen + "!";
                MessageBox.Show("Cập nhật thông tin thành công");
            }
        }
    }
}
