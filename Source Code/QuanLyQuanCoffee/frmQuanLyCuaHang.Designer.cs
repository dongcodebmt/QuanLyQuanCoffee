
namespace QuanLyQuanCaffe
{
    partial class frmQuanLyCuaHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyCuaHang));
            this.lsvCTHD = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvBan = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbMonAn = new System.Windows.Forms.Label();
            this.cbMonAn = new System.Windows.Forms.ComboBox();
            this.nmSLMonAn = new System.Windows.Forms.NumericUpDown();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbKhuyenMai = new System.Windows.Forms.ComboBox();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btTongCong = new System.Windows.Forms.Label();
            this.txbTongTien = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lbKhuyenMai = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSLMonAn)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvCTHD
            // 
            this.lsvCTHD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvCTHD.GridLines = true;
            this.lsvCTHD.HideSelection = false;
            this.lsvCTHD.Location = new System.Drawing.Point(12, 12);
            this.lsvCTHD.Name = "lsvCTHD";
            this.lsvCTHD.Size = new System.Drawing.Size(398, 313);
            this.lsvCTHD.TabIndex = 17;
            this.lsvCTHD.UseCompatibleStateImageBehavior = false;
            this.lsvCTHD.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món ăn";
            this.columnHeader1.Width = 196;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 56;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.Width = 63;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tổng tiền";
            this.columnHeader4.Width = 78;
            // 
            // lsvBan
            // 
            this.lsvBan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lsvBan.Location = new System.Drawing.Point(438, 14);
            this.lsvBan.Name = "lsvBan";
            this.lsvBan.Size = new System.Drawing.Size(433, 311);
            this.lsvBan.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbSoLuong);
            this.panel2.Controls.Add(this.lbMonAn);
            this.panel2.Controls.Add(this.cbMonAn);
            this.panel2.Controls.Add(this.nmSLMonAn);
            this.panel2.Controls.Add(this.btnThemMon);
            this.panel2.Controls.Add(this.btnChuyenBan);
            this.panel2.Location = new System.Drawing.Point(12, 348);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 97);
            this.panel2.TabIndex = 14;
            // 
            // lbMonAn
            // 
            this.lbMonAn.AutoSize = true;
            this.lbMonAn.Location = new System.Drawing.Point(31, 18);
            this.lbMonAn.Name = "lbMonAn";
            this.lbMonAn.Size = new System.Drawing.Size(43, 13);
            this.lbMonAn.TabIndex = 11;
            this.lbMonAn.Text = "Món ăn";
            // 
            // cbMonAn
            // 
            this.cbMonAn.FormattingEnabled = true;
            this.cbMonAn.Location = new System.Drawing.Point(86, 15);
            this.cbMonAn.Name = "cbMonAn";
            this.cbMonAn.Size = new System.Drawing.Size(204, 21);
            this.cbMonAn.TabIndex = 7;
            // 
            // nmSLMonAn
            // 
            this.nmSLMonAn.Location = new System.Drawing.Point(86, 61);
            this.nmSLMonAn.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmSLMonAn.Name = "nmSLMonAn";
            this.nmSLMonAn.Size = new System.Drawing.Size(48, 20);
            this.nmSLMonAn.TabIndex = 3;
            this.nmSLMonAn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmSLMonAn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThemMon
            // 
            this.btnThemMon.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMon.Image")));
            this.btnThemMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMon.Location = new System.Drawing.Point(296, 52);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(98, 42);
            this.btnThemMon.TabIndex = 2;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.Location = new System.Drawing.Point(296, 3);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(99, 42);
            this.btnChuyenBan.TabIndex = 6;
            this.btnChuyenBan.Text = "Chuyển bàn";
            this.btnChuyenBan.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbKhuyenMai);
            this.panel4.Controls.Add(this.cbKhuyenMai);
            this.panel4.Controls.Add(this.btnInHD);
            this.panel4.Controls.Add(this.btTongCong);
            this.panel4.Controls.Add(this.txbTongTien);
            this.panel4.Controls.Add(this.btnThanhToan);
            this.panel4.Location = new System.Drawing.Point(438, 348);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(436, 97);
            this.panel4.TabIndex = 15;
            // 
            // cbKhuyenMai
            // 
            this.cbKhuyenMai.FormattingEnabled = true;
            this.cbKhuyenMai.Location = new System.Drawing.Point(108, 15);
            this.cbKhuyenMai.Name = "cbKhuyenMai";
            this.cbKhuyenMai.Size = new System.Drawing.Size(174, 21);
            this.cbKhuyenMai.TabIndex = 10;
            // 
            // btnInHD
            // 
            this.btnInHD.Image = ((System.Drawing.Image)(resources.GetObject("btnInHD.Image")));
            this.btnInHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHD.Location = new System.Drawing.Point(326, 51);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(98, 42);
            this.btnInHD.TabIndex = 4;
            this.btnInHD.Text = "In Hóa Đơn";
            this.btnInHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInHD.UseVisualStyleBackColor = true;
            // 
            // btTongCong
            // 
            this.btTongCong.AutoSize = true;
            this.btTongCong.Location = new System.Drawing.Point(12, 67);
            this.btTongCong.Name = "btTongCong";
            this.btTongCong.Size = new System.Drawing.Size(59, 13);
            this.btTongCong.TabIndex = 9;
            this.btTongCong.Text = "Tổng cộng";
            // 
            // txbTongTien
            // 
            this.txbTongTien.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTongTien.ForeColor = System.Drawing.Color.OrangeRed;
            this.txbTongTien.Location = new System.Drawing.Point(108, 61);
            this.txbTongTien.Name = "txbTongTien";
            this.txbTongTien.ReadOnly = true;
            this.txbTongTien.Size = new System.Drawing.Size(174, 25);
            this.txbTongTien.TabIndex = 8;
            this.txbTongTien.Text = "0";
            this.txbTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(326, 3);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(98, 42);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lbKhuyenMai
            // 
            this.lbKhuyenMai.AutoSize = true;
            this.lbKhuyenMai.Location = new System.Drawing.Point(12, 18);
            this.lbKhuyenMai.Name = "lbKhuyenMai";
            this.lbKhuyenMai.Size = new System.Drawing.Size(62, 13);
            this.lbKhuyenMai.TabIndex = 11;
            this.lbKhuyenMai.Text = "Khuyến mãi";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Location = new System.Drawing.Point(31, 66);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(49, 13);
            this.lbSoLuong.TabIndex = 12;
            this.lbSoLuong.Text = "Số lượng";
            // 
            // frmQuanLyCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 462);
            this.Controls.Add(this.lsvCTHD);
            this.Controls.Add(this.lsvBan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Name = "frmQuanLyCuaHang";
            this.Text = "Quản lý cửa hàng";
            this.Load += new System.EventHandler(this.frmQuanLyCuaHang_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSLMonAn)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvCTHD;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.FlowLayoutPanel lsvBan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbMonAn;
        private System.Windows.Forms.ComboBox cbMonAn;
        private System.Windows.Forms.NumericUpDown nmSLMonAn;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbKhuyenMai;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Label btTongCong;
        private System.Windows.Forms.TextBox txbTongTien;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbKhuyenMai;
    }
}