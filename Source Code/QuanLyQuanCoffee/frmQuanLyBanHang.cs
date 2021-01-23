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
            FillComboxMonAn(model.MonAn.Where(x => x.trangThai == true).ToList());
            FillComboxKhuyenMai(model.KhuyenMai.ToList());
            FillDataToCBBan(model.Ban.ToList());
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
                HoaDon hoaDon = model.HoaDon.FirstOrDefault(c => c.maBan == item.ma && c.trangThai == false);
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
            ButtonLock(false);
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            int maBan = ((sender as Button).Tag as Ban).ma;
            lbTenBan.Text = ((sender as Button).Tag as Ban).ten;
            maBanHT = maBan;
            ButtonLock(true);
            ShowHoaDon(maBan);
        }
        private void ShowHoaDon(int id)
        {
            lsvCTHD.Items.Clear();
            HoaDon hoaDon = model.HoaDon.FirstOrDefault(c => c.maBan == id && c.trangThai == false);
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
                HoaDon hoaDon = model.HoaDon.FirstOrDefault(c => c.maBan == maBanHT && c.trangThai == false);
                if (hoaDon == null)
                {
                    HoaDon HD = new HoaDon();
                    HD.maNhanVien = frmMain.maTaiKhoan;
                    HD.ngayVao = DateTime.Now;
                    HD.ngayRa = null;
                    HD.maBan = maBanHT;
                    HD.maKhuyenMai = null;
                    HD.trangThai = false;
                    model.HoaDon.Add(HD);
                    model.SaveChanges();
                }

                hoaDon = model.HoaDon.FirstOrDefault(c => c.maBan == maBanHT && c.trangThai == false);
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
            ButtonLock(true);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = model.HoaDon.FirstOrDefault(c => c.maBan == maBanHT && c.trangThai == false);
            if (hoaDon != null)
            {
                var maKM = cbKhuyenMai.SelectedValue;

                if (maKM != null)
                {
                    hoaDon.ngayRa = DateTime.Now;
                    hoaDon.maKhuyenMai = (int)maKM;
                    hoaDon.trangThai = true;
                    InHD(hoaDon.ma);
                }
                else
                {
                    hoaDon.ngayRa = DateTime.Now;
                    hoaDon.trangThai = true;
                    InHD(hoaDon.ma);
                }

                model.SaveChanges();
            }
            LoadTableBtn(model.Ban.ToList());
            ShowHoaDon(maBanHT);
            txbTongTien.Text = null;
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
                if (kho.tonKho >= soLuong)
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
                else
                {
                    item.NguyenLieu.trongLuong = item.NguyenLieu.trongLuong - soLuong * item.chiPhi;
                }
            }
            model.SaveChanges();
            return true;
        }
        private void ButtonLock(bool isLock)
        {
            btnThanhToan.Enabled = isLock;
            btnThemMon.Enabled = isLock;
            btnKhuyenMai.Enabled = isLock;
            btnChuyenBan.Enabled = isLock;
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            int maBan = Int32.Parse(cbBan.SelectedValue.ToString());
            HoaDon hoaDon = model.HoaDon.FirstOrDefault(c => c.maBan == maBan && c.trangThai == false);
            HoaDon hoaDonHT = model.HoaDon.FirstOrDefault(c => c.maBan == maBanHT && c.trangThai == false);
            if (hoaDon == null)
            {
                hoaDonHT.maBan = maBan;
                model.SaveChanges();
            }
            else
            {
                List<CTHD> cTHDs = model.CTHD.Where(c => c.maHoaDon == hoaDonHT.ma).ToList();
                foreach (var item in cTHDs)
                {
                    item.maHoaDon = hoaDon.ma;
                }
                model.HoaDon.Remove(hoaDonHT);
                model.SaveChanges();
            }
            LoadTableBtn(model.Ban.ToList());
            ShowHoaDon(maBanHT);
        }

        private void FillDataToCBBan(List<Ban> bans)
        {
            cbBan.DataSource = bans;
            cbBan.DisplayMember = "ten";
            cbBan.ValueMember = "ma";
        }

        private void InHD(int maHD)
        {
            frmInHoaDon frm = new frmInHoaDon();
            frmInHoaDon.maHDHT = maHD;
            frm.Show();
        }
    }
}
