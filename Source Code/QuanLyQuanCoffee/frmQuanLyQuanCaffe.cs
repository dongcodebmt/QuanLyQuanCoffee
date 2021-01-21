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
    public partial class frmQuanLyQuanCaffe : Form
    {
        QLCFContext model;
        public frmQuanLyQuanCaffe()
        {
            model = new QLCFContext();
            List<Ban> listBan = model.Ban.ToList();
            InitializeComponent();
            LoadTable(listBan);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbSwitchTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void LoadTable(List<Ban> listBan)
        {
            foreach(Ban item in listBan)
            {
                Button btn = new Button() { Width = 80, Height = 80};
                string i;
                if (item.trangThai == 1)
                {
                    i = "Có người";
                }
                else
                    i = "Trống";
                btn.Text = item.ten + Environment.NewLine + i;
                flpBan.Controls.Add(btn);
                
            }    
        }
    }
}
