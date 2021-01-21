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
        private static int maBanHT;
        public frmQuanLyBanHang()
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
            lsvBan.Controls.Clear();
            foreach (Ban item in listBan)
            {
                Button btn = new Button() { Width = 80, Height = 80 };
                string i;
                btn.Click += Btn_Click;
                btn.Tag = item;
                HoaDon hoaDon = model.HoaDon.FirstOrDefault(c => c.maBan == item.ma && c.ngayRa == null);
                //if (item.trangThai == true)
                if (hoaDon != null)
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
                lsvBan.Controls.Add(btn);
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            int maBan = ((sender as Button).Tag as Ban).ma;
            maBanHT = maBan;
            ShowHoaDon(maBan);
        }
        private void ShowHoaDon(int id)
        {
            lsvCTHD.Items.Clear();
            HoaDon hoaDon = model.HoaDon.FirstOrDefault(c => c.maBan == id && c.ngayRa == null);
            if (hoaDon != null)
            {
                int maHD = hoaDon.ma;
                List<CTHD> listCT = model.CTHD.Where(c => c.maHoaDon == maHD).ToList();
                decimal tongTien = 0;
                int maKM = Int32.Parse(cbKhuyenMai.SelectedValue.ToString());
                KhuyenMai khuyenMai = model.KhuyenMai.FirstOrDefault(x => x.ma == maKM);
                foreach (CTHD item in listCT)
                {
                    ListViewItem lsvItem = new ListViewItem(item.MonAn.ten);
                    lsvItem.SubItems.Add(item.soLuong.ToString());
                    decimal giaTien = Decimal.Round(item.MonAn.gia, 2);
                    lsvItem.SubItems.Add(giaTien.ToString());

                    decimal tong = (item.soLuong * item.MonAn.gia);
                    tongTien += tong;
                    decimal rounded = Decimal.Round(tong, 2);
                    lsvItem.SubItems.Add(rounded.ToString());

                    lsvCTHD.Items.Add(lsvItem);
                }
                decimal tongTienRound = Decimal.Round(tongTien, 2);
                tongTienRound = tongTienRound - (tongTienRound * (decimal)khuyenMai.tyLe) / 100;
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

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            int maMon = Int32.Parse(cbMonAn.SelectedValue.ToString());
            int SLMon = (int)nmSLMonAn.Value;
            HoaDon hoaDon = model.HoaDon.FirstOrDefault(c => c.maBan == maBanHT && c.ngayRa == null);
            if (hoaDon == null)
            {
                HoaDon HD = new HoaDon();
                HD.ngayVao = DateTime.Now;
                HD.ngayRa = null;
                HD.maBan = maBanHT;
                HD.maKhuyenMai = null;
                HD.trangThai = false;
                model.HoaDon.Add(HD);
                model.SaveChanges();
            }

            hoaDon = model.HoaDon.FirstOrDefault(c => c.maBan == maBanHT && c.ngayRa == null);
            CTHD cTHD = model.CTHD.FirstOrDefault(c => c.maHoaDon == hoaDon.ma && c.maMonAn == maMon);
            if (cTHD != null)
            {
                cTHD.soLuong = cTHD.soLuong + SLMon;
                model.SaveChanges();
            }
            else
            {
                CTHD x = new CTHD();
                x.maHoaDon = hoaDon.ma;
                x.maMonAn = maMon;
                x.soLuong = SLMon;
                model.CTHD.Add(x);
                model.SaveChanges();
            }
            ShowHoaDon(maBanHT);
            LoadTableBtn(model.Ban.ToList());
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = model.HoaDon.FirstOrDefault(c => c.maBan == maBanHT && c.ngayRa == null);
            if (hoaDon != null)
            {
                hoaDon.ngayRa = DateTime.Now;
                hoaDon.maKhuyenMai = Int32.Parse(cbKhuyenMai.SelectedValue.ToString());
                model.SaveChanges();
            }
            LoadTableBtn(model.Ban.ToList());
        }
    }
}
