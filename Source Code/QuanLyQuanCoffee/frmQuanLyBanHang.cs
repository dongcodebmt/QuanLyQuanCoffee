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
            maBanHT = 0;
        }

        private void frmQuanLyCuaHang_Load(object sender, EventArgs e)
        {
            LoadTableBtn(model.Ban.ToList());
            FillComboxMonAn(model.MonAn.ToList());
            FillComboxKhuyenMai(model.KhuyenMai.ToList());
            cbKhuyenMai.SelectedItem = null;
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
            btnThanhToan.Enabled = false;
            btnThemMon.Enabled = false;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            int maBan = ((sender as Button).Tag as Ban).ma;
            maBanHT = maBan;
            btnThanhToan.Enabled = true;
            btnThemMon.Enabled = true;
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

            if (maBanHT == 0)
            {
                MessageBox.Show("Vui lòng chọn bàn!");
            }
            else if (!LayMonAn(maMon, SLMon))
            {
                MessageBox.Show("Đã hết món!");
            }
            else
            {
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
            btnThanhToan.Enabled = true;
            btnThemMon.Enabled = true;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            
                HoaDon hoaDon = model.HoaDon.FirstOrDefault(c => c.maBan == maBanHT && c.ngayRa == null);
                if (hoaDon != null)
                {
                    var maKM = cbKhuyenMai.SelectedValue;

                    if (maKM != null)
                    {
                        hoaDon.ngayRa = DateTime.Now;
                        hoaDon.maKhuyenMai = (int)maKM;
                        hoaDon.trangThai = true;
                    }
                    else
                    {
                        hoaDon.ngayRa = DateTime.Now;
                        hoaDon.trangThai = true;
                    }

                    model.SaveChanges();
                }
                LoadTableBtn(model.Ban.ToList());
            
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            decimal tongTien = decimal.Parse(txbTongTien.Text);
            var maKM = cbKhuyenMai.SelectedValue;
            if (maKM == null)
            {
                maKM = 0;
            }
            KhuyenMai khuyenMai = model.KhuyenMai.FirstOrDefault(x => x.ma == (int)maKM);
            if (khuyenMai != null)
            {
                tongTien = tongTien - (tongTien * (decimal)khuyenMai.tyLe) / 100;
            }
            txbTongTien.Text = tongTien.ToString();

        }
        private bool LayMonAn(int maMon, int soLuong)
        {
            MonAn monAn = model.MonAn.FirstOrDefault(x => x.DonVi.ma == 1 && x.ma == maMon);
            if (monAn != null)
            {
                if (LayNguyenLieu(maMon, soLuong))
                {
                    return true;
                }
            }
            else
            {
                if (LayKho(maMon, soLuong))
                {
                    return true;
                }
            }
            return false;
        }
        private bool LayKho(int maMon, int soLuong)
        {
            Kho kho = model.Kho.FirstOrDefault(x => x.ma == maMon);
            if (kho != null)
            {
                if (kho.tonKho < soLuong)
                {
                    return false;
                }
                else
                {
                    kho.tonKho = kho.tonKho - soLuong;
                    model.SaveChanges();
                    return true;
                }
            }
            return false;
        }
        private bool LayNguyenLieu(int maMon,int soLuong)
        {
            List<CongThuc> listCongThuc = model.CongThuc.Where(c => c.maMon == maMon).ToList();
            foreach (var item in listCongThuc)
            {
                if (item.NguyenLieu.trongLuong < soLuong * item.chiPhi)
                {
                    return false;
                }

            }
            string query = "UPDATE NguyenLieu SET NguyenLieu.trongLuong = NguyenLieu.trongLuong - CongThuc.chiPhi*" + soLuong + " FROM MonAn, CongThuc, NguyenLieu WHERE MonAn.ma = maMon AND NguyenLieu.ma = maNguyenLieu AND MonAn.ma = " + maMon;
            _ = model.Database.ExecuteSqlCommand(query);
            return true;
        }
    }
}
