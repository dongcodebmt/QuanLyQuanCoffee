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
    public partial class frmThongTin : Form
    {
        public frmThongTin()
        {
            InitializeComponent();
        }

        private void frmThongTin_Load(object sender, EventArgs e)
        {
            lbName1.Text = "Trịnh Văn Đông - 1811062417";
            lbName2.Text = "Trần Phước Anh - 1811063315";
            lbName3.Text = "Nguyễn Huỳnh Đại Lâm - 1811062171";
        }
    }
}
