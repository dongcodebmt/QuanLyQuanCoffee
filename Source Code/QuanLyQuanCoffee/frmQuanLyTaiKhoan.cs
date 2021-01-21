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
    public partial class frmQuanLyTaiKhoan : Form
    {
        QLCFContext model;
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
            model = new QLCFContext();
        }

        private void DataSetting()
        {
            dataTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            BilingMacDinh();
            FillDataToComboBox(model.Quyen.ToList());
            DataSetting();
            ButtonLock(false);
            TB_CBLock(false);
            TB_CBNull();
        }

        private void BilingMacDinh()
        {
            List<PhanQuyen> listTaiKhoan = model.PhanQuyen.Where(x => x.TaiKhoan.trangThai == true).ToList();
            BilingListToDataGridView(listTaiKhoan);
        }
        private void BilingListToDataGridView(List<PhanQuyen> listTaiKhoan)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Tên đăng nhập");
            dt.Columns.Add("Họ tên");
            dt.Columns.Add("Năm sinh");
            dt.Columns.Add("SDT");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("Quyền");
            int STT = 1;
            for (int i = 0; i < listTaiKhoan.Count; i++, STT++)
            {
                PhanQuyen tk = listTaiKhoan[i];
                dt.Rows.Add(new string[] { STT.ToString(), tk.TaiKhoan.tenDangNhap, tk.TaiKhoan.hoTen, tk.TaiKhoan.namSinh, tk.TaiKhoan.SDT, tk.TaiKhoan.gioiTinh, tk.Quyen.ten });
            }
            dataTaiKhoan.DataSource = dt;
        }

        private void FillDataToComboBox(List<Quyen> quyens)
        {
            cbQuyen.DataSource = quyens;
            cbQuyen.DisplayMember = "ten";
            cbQuyen.ValueMember = "ma";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ButtonLock(true);
            TB_CBLock(true);
            TB_CBNull();
        }

        private bool KiemTraMK(string matKhau, string nhapLaiMK)
        {
            if (matKhau == nhapLaiMK)
            {
                return true;
            }
            return false;
        }
        private void dataTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dataTaiKhoan.SelectedRows.Count == 1)
            {
                txtTenTaiKhoan.Text = dataTaiKhoan.SelectedRows[0].Cells[1].Value.ToString();
                txtHoTen.Text = dataTaiKhoan.SelectedRows[0].Cells[2].Value.ToString();
                txtNamSinh.Text = dataTaiKhoan.SelectedRows[0].Cells[3].Value.ToString();
                txtSDT.Text = dataTaiKhoan.SelectedRows[0].Cells[4].Value.ToString();
                string sex = dataTaiKhoan.SelectedRows[0].Cells[5].Value.ToString();
                if (sex == "Nam")
                {
                    rbtnNam.Checked = true;
                } 
                else if (sex == "Nữ")
                {
                    rbtnNu.Checked = true;
                }
                else
                {
                    rbtnKhongXacDinh.Checked = true;
                }
                cbQuyen.SelectedIndex = cbQuyen.FindStringExact(dataTaiKhoan.SelectedRows[0].Cells[6].Value.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ButtonLock(true);
            TB_CBLock(true);
            txtTenTaiKhoan.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = model.TaiKhoan.FirstOrDefault(x => x.tenDangNhap == txtTenTaiKhoan.Text);
            if (taiKhoan != null)
            {
                taiKhoan.trangThai = false;
                model.SaveChanges();
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại");
            }
            TB_CBNull();
            BilingMacDinh();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<PhanQuyen> phanQuyens = model.PhanQuyen.Where(
                x => x.TaiKhoan.tenDangNhap.Contains(txtTimKiem.Text.ToLower()) 
                || x.TaiKhoan.hoTen.Contains(txtTimKiem.Text.ToLower()) 
                || x.TaiKhoan.SDT.Contains(txtTimKiem.Text.ToLower())
            ).ToList();
            BilingListToDataGridView(phanQuyens);
            if (txtTimKiem.Text == "")
            {
                BilingMacDinh();
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (KiemTraMK(txtMatKhau.Text, txtNhapLaiMK.Text))
            {
                TaiKhoan TK = model.TaiKhoan.FirstOrDefault(x => x.tenDangNhap == txtTenTaiKhoan.Text);
                if (TK == null)
                {
                    try
                    {
                        TaiKhoan taiKhoanMoi = new TaiKhoan();
                        taiKhoanMoi.tenDangNhap = txtTenTaiKhoan.Text.ToLower();
                        taiKhoanMoi.matKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text);
                        taiKhoanMoi.hoTen = txtHoTen.Text;
                        taiKhoanMoi.namSinh = txtNamSinh.Text;
                        taiKhoanMoi.SDT = txtSDT.Text;
                        taiKhoanMoi.gioiTinh = GetSex();
                        taiKhoanMoi.trangThai = true;
                        model.TaiKhoan.Add(taiKhoanMoi);
                        model.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    }

                    PhanQuyen(txtTenTaiKhoan.Text.ToLower(), Int32.Parse(cbQuyen.SelectedValue.ToString()));
                }
                else
                {
                    try
                    {
                        TK.matKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text);
                        TK.hoTen = txtHoTen.Text;
                        TK.namSinh = txtNamSinh.Text;
                        TK.SDT = txtSDT.Text;
                        TK.gioiTinh = GetSex();
                        TK.trangThai = true;
                        model.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    }

                    PhanQuyen(txtTenTaiKhoan.Text.ToLower(), Int32.Parse(cbQuyen.SelectedValue.ToString()));
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không khớp!");
            }
            BilingMacDinh();
            ButtonLock(false);
            TB_CBLock(false);
            TB_CBNull();
        }
        private void PhanQuyen(string tenTaiKhoan, int maPhanQuyen)
        {
            TaiKhoan taiKhoan = model.TaiKhoan.FirstOrDefault(x => x.tenDangNhap == tenTaiKhoan);
            PhanQuyen phanQuyen = model.PhanQuyen.FirstOrDefault(x => x.maTaiKhoan == taiKhoan.ma);
            if (phanQuyen == null)
            {
                PhanQuyen phanQuyenMoi = new PhanQuyen();
                phanQuyenMoi.maTaiKhoan = taiKhoan.ma;
                phanQuyenMoi.maPhanQuyen = maPhanQuyen;
                model.PhanQuyen.Add(phanQuyenMoi);
                model.SaveChanges();
            }
            else
            {
                phanQuyen.maPhanQuyen = maPhanQuyen;
                model.SaveChanges();
            }
        }
        private string GetSex()
        {
            string sex = "Không xác định";
            if (rbtnNam.Checked == true)
            {
                sex = "Nam";
            }
            else if (rbtnNu.Checked == true)
            {
                sex = "Nữ";
            }
            return sex;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {

            ButtonLock(false);
            TB_CBLock(false);
            TB_CBNull();
        }
        private void ButtonLock(bool isLock)
        {
            btnHuy.Visible = isLock;
            btnLuu.Visible = isLock;
            btnThem.Visible = !isLock;
            btnSua.Visible = !isLock;
            btnXoa.Visible = !isLock;
        }

        private void TB_CBLock(bool isLock)
        {
            txtTenTaiKhoan.Enabled = isLock;
            txtHoTen.Enabled = isLock;
            txtNamSinh.Enabled = isLock;
            txtSDT.Enabled = isLock;
            txtMatKhau.Enabled = isLock;
            txtNhapLaiMK.Enabled = isLock;
            cbQuyen.Enabled = isLock;
            rbtnNam.Enabled = isLock;
            rbtnNu.Enabled = isLock;
            rbtnKhongXacDinh.Enabled = isLock;
        }
        private void TB_CBNull()
        {
            txtTenTaiKhoan.Text = null;
            txtHoTen.Text = null;
            txtNamSinh.Text = null;
            txtSDT.Text = null;
            txtMatKhau.Text = null;
            txtNhapLaiMK.Text = null;
            cbQuyen.SelectedItem = null;
            rbtnNam.Checked = false;
            rbtnNu.Checked = false;
            rbtnKhongXacDinh.Checked = false;
        }
    }
}
