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
    public partial class frmMain : Form
    {
        public static int maTaiKhoan { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            IsLockAction(false);
            DisplayFormLogin();
        }

        private void IsLockAction(bool isLock)
        {
            miDangNhap.Enabled = !isLock;
            miThongTinTaiKhoan.Enabled = isLock;
            miDoiMatKhau.Enabled = isLock;
            miDangXuat.Enabled = isLock;
            miQuanLyCuaHang.Enabled = isLock;
            miXuatNhapKho.Enabled = isLock;
        }

        private void DisplayFormLogin()
        {
            if (!CheckForm("frmDangNhap"))
            {
                frmDangNhap frm = new frmDangNhap();
                frm.MdiParent = this;
                frm.XacThucTaiKhoan += frmDangNhap_XacThucTaiKhoan;
                frm.Show();
            }
        }
        private void frmDangNhap_XacThucTaiKhoan(object sender)
        {
            TaiKhoan taiKhoan = (TaiKhoan)sender;
            maTaiKhoan = taiKhoan.ma;
            IsLockAction(true);
        }
        private bool CheckForm(string frmName)
        {
            Form frm = this.MdiChildren.Where(x => x.Name == frmName).FirstOrDefault();
            if (frm != null)
            {
                frm.Activate();
                return true;
            }

            return false;
        }

        private void miThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void miDangNhap_Click(object sender, EventArgs e)
        {
            DisplayFormLogin();
        }

        private void miDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
            IsLockAction(false);
            DisplayFormLogin();
        }

        private void miThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            if (!CheckForm("frmThongTinTaiKhoan"))
            {
                frmThongTinTaiKhoan frm = new frmThongTinTaiKhoan();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void miDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (!CheckForm("frmDoiMatKhau"))
            {
                frmDoiMatKhau frm = new frmDoiMatKhau();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void miQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            if (!CheckForm("frmQuanLyTaiKhoan"))
            {
                frmQuanLyTaiKhoan frm = new frmQuanLyTaiKhoan();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void miNhapKho_Click(object sender, EventArgs e)
        {
            if (!CheckForm("frmNhapKho"))
            {
                frmNhapKho frm = new frmNhapKho();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void miNhapNguyenLieu_Click(object sender, EventArgs e)
        {
            if (!CheckForm("frmNhapNguyenLieu"))
            {
                frmNhapNguyenLieu frm = new frmNhapNguyenLieu();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void miNhapCongThuc_Click(object sender, EventArgs e)
        {
            if (!CheckForm("frmNhapCongThuc"))
            {
                frmNhapCongThuc frm = new frmNhapCongThuc();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void miQuanLyMonAn_Click(object sender, EventArgs e)
        {
            if (!CheckForm("frmQuanLyMonAn"))
            {
                frmQuanLyMonAn frm = new frmQuanLyMonAn();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void miQuanLyBanHang_Click(object sender, EventArgs e)
        {
            if (!CheckForm("frmQuanLyCuaHang"))
            {
                frmQuanLyCuaHang frm = new frmQuanLyCuaHang();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
