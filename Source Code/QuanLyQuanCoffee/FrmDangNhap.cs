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
            if (tenTaiKhoan == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
            }
            else if (matKhau == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
            }
            else
            {
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
                    PhanQuyen phanQuyen = model.PhanQuyen.FirstOrDefault(x => x.maTaiKhoan == taiKhoan.ma);
                    XacThucTaiKhoan(phanQuyen);
                    this.Close();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
