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

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
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
                string sex;
                if (tk.TaiKhoan.gioiTinh == 0)
                {
                    sex = "Không xác định";
                } 
                else if (tk.TaiKhoan.gioiTinh == 1) 
                {
                    sex = "Nam";
                } 
                else
                {
                    sex = "Nữ";
                }
                dt.Rows.Add(new string[] { STT.ToString(), tk.TaiKhoan.tenDangNhap, tk.TaiKhoan.hoTen, tk.TaiKhoan.namSinh, tk.TaiKhoan.SDT, sex, tk.Quyen.ten });
            }
            dataTaiKhoan.DataSource = dt;
        }
    }
}
