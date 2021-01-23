
namespace QuanLyQuanCaffe
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.miTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.miDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.miThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.miDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.miDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.miQuanLyCuaHang = new System.Windows.Forms.ToolStripMenuItem();
            this.miQuanLyMonAn = new System.Windows.Forms.ToolStripMenuItem();
            this.miQuanLyBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.miQuanLyKhuyenMai = new System.Windows.Forms.ToolStripMenuItem();
            this.miQuanLyCongThuc = new System.Windows.Forms.ToolStripMenuItem();
            this.miQuanLyBan = new System.Windows.Forms.ToolStripMenuItem();
            this.miQuanLyTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.miQuanLyDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.miXuatNhapKho = new System.Windows.Forms.ToolStripMenuItem();
            this.miNhapKho = new System.Windows.Forms.ToolStripMenuItem();
            this.miNhapNguyenLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.miThongTInKho = new System.Windows.Forms.ToolStripMenuItem();
            this.miThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.miSinhVienThucHien = new System.Windows.Forms.ToolStripMenuItem();
            this.miThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTaiKhoan,
            this.miQuanLyCuaHang,
            this.miXuatNhapKho,
            this.miThongTin,
            this.miThoat});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(800, 24);
            this.menuMain.TabIndex = 2;
            this.menuMain.Text = "menuStrip2";
            // 
            // miTaiKhoan
            // 
            this.miTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDangNhap,
            this.miThongTinTaiKhoan,
            this.miDoiMatKhau,
            this.miDangXuat});
            this.miTaiKhoan.Name = "miTaiKhoan";
            this.miTaiKhoan.Size = new System.Drawing.Size(69, 20);
            this.miTaiKhoan.Text = "Tài khoản";
            // 
            // miDangNhap
            // 
            this.miDangNhap.Name = "miDangNhap";
            this.miDangNhap.Size = new System.Drawing.Size(177, 22);
            this.miDangNhap.Text = "Đăng nhập";
            this.miDangNhap.Click += new System.EventHandler(this.miDangNhap_Click);
            // 
            // miThongTinTaiKhoan
            // 
            this.miThongTinTaiKhoan.Name = "miThongTinTaiKhoan";
            this.miThongTinTaiKhoan.Size = new System.Drawing.Size(177, 22);
            this.miThongTinTaiKhoan.Text = "Thông tin tài khoản";
            this.miThongTinTaiKhoan.Click += new System.EventHandler(this.miThongTinTaiKhoan_Click);
            // 
            // miDoiMatKhau
            // 
            this.miDoiMatKhau.Name = "miDoiMatKhau";
            this.miDoiMatKhau.Size = new System.Drawing.Size(177, 22);
            this.miDoiMatKhau.Text = "Đổi mật khẩu";
            this.miDoiMatKhau.Click += new System.EventHandler(this.miDoiMatKhau_Click);
            // 
            // miDangXuat
            // 
            this.miDangXuat.Name = "miDangXuat";
            this.miDangXuat.Size = new System.Drawing.Size(177, 22);
            this.miDangXuat.Text = "Đăng xuất";
            this.miDangXuat.Click += new System.EventHandler(this.miDangXuat_Click);
            // 
            // miQuanLyCuaHang
            // 
            this.miQuanLyCuaHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miQuanLyMonAn,
            this.miQuanLyBanHang,
            this.miQuanLyKhuyenMai,
            this.miQuanLyCongThuc,
            this.miQuanLyBan,
            this.miQuanLyTaiKhoan,
            this.miQuanLyDoanhThu});
            this.miQuanLyCuaHang.Name = "miQuanLyCuaHang";
            this.miQuanLyCuaHang.Size = new System.Drawing.Size(112, 20);
            this.miQuanLyCuaHang.Text = "Quản lý cửa hàng";
            // 
            // miQuanLyMonAn
            // 
            this.miQuanLyMonAn.Name = "miQuanLyMonAn";
            this.miQuanLyMonAn.Size = new System.Drawing.Size(180, 22);
            this.miQuanLyMonAn.Text = "Quản lý món ăn";
            this.miQuanLyMonAn.Click += new System.EventHandler(this.miQuanLyMonAn_Click);
            // 
            // miQuanLyBanHang
            // 
            this.miQuanLyBanHang.Name = "miQuanLyBanHang";
            this.miQuanLyBanHang.Size = new System.Drawing.Size(180, 22);
            this.miQuanLyBanHang.Text = "Quản lý bán hàng";
            this.miQuanLyBanHang.Click += new System.EventHandler(this.miQuanLyBanHang_Click);
            // 
            // miQuanLyKhuyenMai
            // 
            this.miQuanLyKhuyenMai.Name = "miQuanLyKhuyenMai";
            this.miQuanLyKhuyenMai.Size = new System.Drawing.Size(180, 22);
            this.miQuanLyKhuyenMai.Text = "Quản lý khuyến mãi";
            this.miQuanLyKhuyenMai.Click += new System.EventHandler(this.miQuanLyKhuyenMai_Click);
            // 
            // miQuanLyCongThuc
            // 
            this.miQuanLyCongThuc.Name = "miQuanLyCongThuc";
            this.miQuanLyCongThuc.Size = new System.Drawing.Size(180, 22);
            this.miQuanLyCongThuc.Text = "Quản lý công thức";
            this.miQuanLyCongThuc.Click += new System.EventHandler(this.miQuanLyCongThuc_Click);
            // 
            // miQuanLyBan
            // 
            this.miQuanLyBan.Name = "miQuanLyBan";
            this.miQuanLyBan.Size = new System.Drawing.Size(180, 22);
            this.miQuanLyBan.Text = "Quản lý bàn";
            this.miQuanLyBan.Click += new System.EventHandler(this.miQuanLyBan_Click);
            // 
            // miQuanLyTaiKhoan
            // 
            this.miQuanLyTaiKhoan.Name = "miQuanLyTaiKhoan";
            this.miQuanLyTaiKhoan.Size = new System.Drawing.Size(180, 22);
            this.miQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.miQuanLyTaiKhoan.Click += new System.EventHandler(this.miQuanLyTaiKhoan_Click);
            // 
            // miQuanLyDoanhThu
            // 
            this.miQuanLyDoanhThu.Name = "miQuanLyDoanhThu";
            this.miQuanLyDoanhThu.Size = new System.Drawing.Size(180, 22);
            this.miQuanLyDoanhThu.Text = "Quản lý doanh thu";
            this.miQuanLyDoanhThu.Click += new System.EventHandler(this.miQuanLyDoanhThu_Click);
            // 
            // miXuatNhapKho
            // 
            this.miXuatNhapKho.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNhapKho,
            this.miNhapNguyenLieu,
            this.miThongTInKho});
            this.miXuatNhapKho.Name = "miXuatNhapKho";
            this.miXuatNhapKho.Size = new System.Drawing.Size(96, 20);
            this.miXuatNhapKho.Text = "Xuất nhập kho";
            // 
            // miNhapKho
            // 
            this.miNhapKho.Name = "miNhapKho";
            this.miNhapKho.Size = new System.Drawing.Size(228, 22);
            this.miNhapKho.Text = "Nhập kho";
            this.miNhapKho.Click += new System.EventHandler(this.miNhapKho_Click);
            // 
            // miNhapNguyenLieu
            // 
            this.miNhapNguyenLieu.Name = "miNhapNguyenLieu";
            this.miNhapNguyenLieu.Size = new System.Drawing.Size(228, 22);
            this.miNhapNguyenLieu.Text = "Nhập nguyên liệu";
            this.miNhapNguyenLieu.Click += new System.EventHandler(this.miNhapNguyenLieu_Click);
            // 
            // miThongTInKho
            // 
            this.miThongTInKho.Name = "miThongTInKho";
            this.miThongTInKho.Size = new System.Drawing.Size(228, 22);
            this.miThongTInKho.Text = "Thông tin kho và nguyên liệu";
            this.miThongTInKho.Click += new System.EventHandler(this.miThongTInKho_Click);
            // 
            // miThongTin
            // 
            this.miThongTin.Checked = true;
            this.miThongTin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miThongTin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSinhVienThucHien});
            this.miThongTin.Name = "miThongTin";
            this.miThongTin.Size = new System.Drawing.Size(70, 20);
            this.miThongTin.Text = "Thông tin";
            // 
            // miSinhVienThucHien
            // 
            this.miSinhVienThucHien.Name = "miSinhVienThucHien";
            this.miSinhVienThucHien.Size = new System.Drawing.Size(180, 22);
            this.miSinhVienThucHien.Text = "Sinh viên thực hiện";
            this.miSinhVienThucHien.Click += new System.EventHandler(this.miSinhVienThucHien_Click);
            // 
            // miThoat
            // 
            this.miThoat.Name = "miThoat";
            this.miThoat.Size = new System.Drawing.Size(110, 20);
            this.miThoat.Text = "Thoát phần mềm";
            this.miThoat.Click += new System.EventHandler(this.miThoat_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuMain);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Quản lý quán coffee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem miQuanLyCuaHang;
        private System.Windows.Forms.ToolStripMenuItem miTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem miXuatNhapKho;
        private System.Windows.Forms.ToolStripMenuItem miThoat;
        private System.Windows.Forms.ToolStripMenuItem miDangNhap;
        private System.Windows.Forms.ToolStripMenuItem miThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem miDangXuat;
        private System.Windows.Forms.ToolStripMenuItem miDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem miThongTin;
        private System.Windows.Forms.ToolStripMenuItem miSinhVienThucHien;
        private System.Windows.Forms.ToolStripMenuItem miQuanLyTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem miNhapKho;
        private System.Windows.Forms.ToolStripMenuItem miNhapNguyenLieu;
        private System.Windows.Forms.ToolStripMenuItem miQuanLyMonAn;
        private System.Windows.Forms.ToolStripMenuItem miQuanLyBanHang;
        private System.Windows.Forms.ToolStripMenuItem miQuanLyKhuyenMai;
        private System.Windows.Forms.ToolStripMenuItem miQuanLyCongThuc;
        private System.Windows.Forms.ToolStripMenuItem miQuanLyBan;
        private System.Windows.Forms.ToolStripMenuItem miQuanLyDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem miThongTInKho;
    }
}