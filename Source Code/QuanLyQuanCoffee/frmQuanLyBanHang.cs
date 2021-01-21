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
    public partial class frmQuanLyBanHang : Form
    {
        QLCFContext model;
        public frmQuanLyBanHang()
        {
            model = new QLCFContext();
            InitializeComponent();
        }

        private void QuanLyBanHang_Load(object sender, EventArgs e)
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
                    flpBan.Controls.Add(btn);
                   }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int maBan = ((sender as Button).Tag as Ban).ma;
            ShowHoaDon(maBan);
        }

      
        private void ShowHoaDon(int id)
        {
            lsvCTHD.Items.Clear();
            HoaDon h = model.HoaDon.FirstOrDefault(c => c.maBan == id && c.ngayRa == null);
            //if (h == null)
            //{
            //    MessageBox.Show("Bàn trống");
            //}
            //else
            //{
                int maHD = h.ma;
                List<CTHD> listCT = model.CTHD.Where(c => c.maHoaDon == maHD).ToList();
                decimal tongtien = 0;
                foreach(CTHD item in listCT)
                {
                ListViewItem lsvItem = new ListViewItem(item.MonAn.ten);
                lsvItem.SubItems.Add(item.soLuong.ToString());
                decimal giatien = Decimal.Round(item.MonAn.gia, 2);
                lsvItem.SubItems.Add(giatien.ToString());
                
                decimal tong  = (item.soLuong * item.MonAn.gia);
                tongtien += tong;
                decimal rounded = Decimal.Round(tong, 2);
                lsvItem.SubItems.Add(rounded.ToString());

                lsvCTHD.Items.Add(lsvItem);
               }
                decimal tongTienRound = Decimal.Round(tongtien, 2);
                 txbTongTien.Text = tongTienRound.ToString();
                //DataTable dt = new DataTable();
                //dt.Columns.Add("STT");
                //dt.Columns.Add("Tên món");
                //dt.Columns.Add("Số lượng");
                //dt.Columns.Add("Giá");
                //int STT = 1;
                //for (int i = 0; i < listCT.Count; i++, STT++)
                //{
                //    CTHD c = listCT[i];
                //    dt.Rows.Add(new string[] { STT.ToString(), c.MonAn.ten, c.soLuong.ToString(), c.MonAn.gia.ToString() });

                //}
                //dataGridView1.DataSource = dt;
            //}
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
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            
        }
    }
}
