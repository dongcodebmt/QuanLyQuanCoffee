
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.miTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.miDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.miThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.miDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.miDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.miQuanLyCuaHang = new System.Windows.Forms.ToolStripMenuItem();
            this.miXuatNhapKho = new System.Windows.Forms.ToolStripMenuItem();
            this.miThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênThựcHiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miQuanLyTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTaiKhoan,
            this.miQuanLyCuaHang,
            this.miXuatNhapKho,
            this.thôngTinToolStripMenuItem,
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
            this.miTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("miTaiKhoan.Image")));
            this.miTaiKhoan.Name = "miTaiKhoan";
            this.miTaiKhoan.Size = new System.Drawing.Size(85, 20);
            this.miTaiKhoan.Text = "Tài khoản";
            // 
            // miDangNhap
            // 
            this.miDangNhap.Name = "miDangNhap";
            this.miDangNhap.Size = new System.Drawing.Size(180, 22);
            this.miDangNhap.Text = "Đăng nhập";
            this.miDangNhap.Click += new System.EventHandler(this.miDangNhap_Click);
            // 
            // miThongTinTaiKhoan
            // 
            this.miThongTinTaiKhoan.Name = "miThongTinTaiKhoan";
            this.miThongTinTaiKhoan.Size = new System.Drawing.Size(180, 22);
            this.miThongTinTaiKhoan.Text = "Thông tin tài khoản";
            this.miThongTinTaiKhoan.Click += new System.EventHandler(this.miThongTinTaiKhoan_Click);
            // 
            // miDoiMatKhau
            // 
            this.miDoiMatKhau.Name = "miDoiMatKhau";
            this.miDoiMatKhau.Size = new System.Drawing.Size(180, 22);
            this.miDoiMatKhau.Text = "Đổi mật khẩu";
            this.miDoiMatKhau.Click += new System.EventHandler(this.miDoiMatKhau_Click);
            // 
            // miDangXuat
            // 
            this.miDangXuat.Name = "miDangXuat";
            this.miDangXuat.Size = new System.Drawing.Size(180, 22);
            this.miDangXuat.Text = "Đăng xuất";
            this.miDangXuat.Click += new System.EventHandler(this.miDangXuat_Click);
            // 
            // miQuanLyCuaHang
            // 
            this.miQuanLyCuaHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miQuanLyTaiKhoan});
            this.miQuanLyCuaHang.Image = ((System.Drawing.Image)(resources.GetObject("miQuanLyCuaHang.Image")));
            this.miQuanLyCuaHang.Name = "miQuanLyCuaHang";
            this.miQuanLyCuaHang.Size = new System.Drawing.Size(128, 20);
            this.miQuanLyCuaHang.Text = "Quản lý cửa hàng";
            // 
            // miXuatNhapKho
            // 
            this.miXuatNhapKho.Image = ((System.Drawing.Image)(resources.GetObject("miXuatNhapKho.Image")));
            this.miXuatNhapKho.Name = "miXuatNhapKho";
            this.miXuatNhapKho.Size = new System.Drawing.Size(112, 20);
            this.miXuatNhapKho.Text = "Xuất nhập kho";
            // 
            // miThoat
            // 
            this.miThoat.Image = ((System.Drawing.Image)(resources.GetObject("miThoat.Image")));
            this.miThoat.Name = "miThoat";
            this.miThoat.Size = new System.Drawing.Size(126, 20);
            this.miThoat.Text = "Thoát phần mềm";
            this.miThoat.Click += new System.EventHandler(this.miThoat_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Checked = true;
            this.thôngTinToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhViênThựcHiệnToolStripMenuItem});
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // sinhViênThựcHiệnToolStripMenuItem
            // 
            this.sinhViênThựcHiệnToolStripMenuItem.Name = "sinhViênThựcHiệnToolStripMenuItem";
            this.sinhViênThựcHiệnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sinhViênThựcHiệnToolStripMenuItem.Text = "Sinh viên thực hiện";
            // 
            // miQuanLyTaiKhoan
            // 
            this.miQuanLyTaiKhoan.Name = "miQuanLyTaiKhoan";
            this.miQuanLyTaiKhoan.Size = new System.Drawing.Size(180, 22);
            this.miQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.miQuanLyTaiKhoan.Click += new System.EventHandler(this.miQuanLyTaiKhoan_Click);
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
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhViênThựcHiệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miQuanLyTaiKhoan;
    }
}