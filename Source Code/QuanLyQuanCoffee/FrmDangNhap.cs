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
    public partial class frmDangNhap : Form
    {
        QLCFContext model;
        public delegate void xacThucTaiKhoan(object sender);
        public event xacThucTaiKhoan XacThucTaiKhoan;
        public frmDangNhap()
        {
            InitializeComponent();
            model = new QLCFContext();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = txtTenTaiKhoan.Text.ToLower();
            string matKhau = txtMatKhau.Text;

            TaiKhoan taiKhoan = model.TaiKhoan.FirstOrDefault(x => x.tenDangNhap == tenTaiKhoan);

            if (taiKhoan == null)
            {
                MessageBox.Show("Tài khoản không tồn tại!");
                txtTenTaiKhoan.Text = null;
                txtMatKhau.Text = null;
            }
            else if (!BCrypt.Net.BCrypt.Verify(matKhau, taiKhoan.matKhau))
            {
                MessageBox.Show("Đăng nhập thất bại!");
                txtMatKhau.Text = null;
            }
            else
            {
                XacThucTaiKhoan(taiKhoan);
                MessageBox.Show("Đăng nhập thành công!");
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
