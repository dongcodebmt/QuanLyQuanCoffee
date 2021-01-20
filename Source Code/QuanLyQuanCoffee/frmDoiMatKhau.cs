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
    public partial class frmDoiMatKhau : Form
    {
        QLCFContext model;
        public int maTaiKhoan;
        public frmDoiMatKhau()
        {
            InitializeComponent();
            model = new QLCFContext();
            maTaiKhoan = frmMain.maTaiKhoan;
        }

        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = model.TaiKhoan.FirstOrDefault(x => x.ma == maTaiKhoan);
            lbXinChao.Text = "Xin chào " + taiKhoan.hoTen + "!";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string matKhau = txtMatKhau.Text;
            string matKhauMoi = txtMatKhauMoi.Text;
            string nhapLaiMK = txtNhapLaiMatKhau.Text;

            TaiKhoan taiKhoan = model.TaiKhoan.FirstOrDefault(x => x.ma == maTaiKhoan);
            if (matKhau == "" || matKhauMoi == "" || nhapLaiMK == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                SetTextBoxNull();
            }
            else if (!BCrypt.Net.BCrypt.Verify(matKhau, taiKhoan.matKhau))
            {
                MessageBox.Show("Mật khẩu sai!");
                SetTextBoxNull();
            } 
            else if (matKhauMoi != nhapLaiMK)
            {
                MessageBox.Show("Hai mật khẩu mới không giống nhau!");
                SetTextBoxNull();
            }
            else
            {
                taiKhoan.matKhau = BCrypt.Net.BCrypt.HashPassword(matKhauMoi);
                model.SaveChanges();
                MessageBox.Show("Thay đổi mật khẩu thành công!");
                SetTextBoxNull();
            }
        }

        private void SetTextBoxNull()
        {
            txtMatKhau.Text = null;
            txtMatKhauMoi.Text = null;
            txtNhapLaiMatKhau.Text = null;
        }
    }
}
