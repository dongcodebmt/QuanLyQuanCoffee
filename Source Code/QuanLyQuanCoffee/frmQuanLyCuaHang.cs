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
    public partial class frmQuanLyCuaHang : Form
    {
        QLCFContext model;
        public frmQuanLyCuaHang()
        {
            InitializeComponent();
            model = new QLCFContext();
        }

        private void frmQuanLyCuaHang_Load(object sender, EventArgs e)
        {
            LoadTableBtn(model.Ban.ToList());
            FillComboxMonAn(model.MonAn.ToList());
            FillComboxKhuyenMai(model.KhuyenMai.ToList());
        }

        private void LoadTableBtn(List<Ban> listBan)
        {

            foreach (Ban item in listBan)
            {
                Button btn = new Button() { Width = 80, Height = 80 };
                string i;
                btn.Click += Btn_Click;
                btn.Tag = item;
                if (item.trangThai == true)
                {
                    i = "Có người";
                    btn.BackColor = Color.HotPink;
                }
                else
                {
                    i = "Trống";
                    btn.BackColor = Color.Blue;
                }
                btn.Text = item.ten + Environment.NewLine + i;
                dataBan.Controls.Add(btn);
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            int maBan = ((sender as Button).Tag as Ban).ma;
            ShowHoaDon(maBan);
        }
        private void ShowHoaDon(int id)
        {
            dataCTHD.Items.Clear();
            HoaDon hoaDon = model.HoaDon.FirstOrDefault(c => c.maBan == id && c.ngayRa == null);
            if (hoaDon != null)
            {
                int maHD = hoaDon.ma;
                List<CTHD> listCT = model.CTHD.Where(c => c.maHoaDon == maHD).ToList();
                decimal tongtien = 0;
                foreach (CTHD item in listCT)
                {
                    ListViewItem lsvItem = new ListViewItem(item.MonAn.ten);
                    lsvItem.SubItems.Add(item.soLuong.ToString());
                    decimal giatien = Decimal.Round(item.MonAn.gia, 2);
                    lsvItem.SubItems.Add(giatien.ToString());

                    decimal tong = (item.soLuong * item.MonAn.gia);
                    tongtien += tong;
                    decimal rounded = Decimal.Round(tong, 2);
                    lsvItem.SubItems.Add(rounded.ToString());

                    dataCTHD.Items.Add(lsvItem);
                }
                decimal tongTienRound = Decimal.Round(tongtien, 2);
                txbTongTien.Text = tongTienRound.ToString();
            }
        }
        private void FillComboxMonAn(List<MonAn> listMonAn)
        {
            cbMonAn.DataSource = listMonAn;
            cbMonAn.DisplayMember = "ten";
            cbMonAn.ValueMember = "ma";
        }
        private void FillComboxKhuyenMai(List<KhuyenMai> listKhuyenMai)
        {
            cbKhuyenMai.DataSource = listKhuyenMai;
            cbKhuyenMai.DisplayMember = "ten";
            cbKhuyenMai.ValueMember = "ma";
        }
    }
}
