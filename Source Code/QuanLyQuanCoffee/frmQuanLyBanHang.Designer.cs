﻿
namespace QuanLyQuanCaffe
{
    partial class frmQuanLyBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyBanHang));
            this.lsvCTHD = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvBan = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbBan = new System.Windows.Forms.ComboBox();
            this.lbBan = new System.Windows.Forms.Label();
            this.lbMonAn = new System.Windows.Forms.Label();
            this.cbMonAn = new System.Windows.Forms.ComboBox();
            this.nmSLMonAn = new System.Windows.Forms.NumericUpDown();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnKhuyenMai = new System.Windows.Forms.Button();
            this.cbKhuyenMai = new System.Windows.Forms.ComboBox();
            this.btTongCong = new System.Windows.Forms.Label();
            this.txbTongTien = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lbTenBan = new System.Windows.Forms.Label();
            this.lbKhuyenMai = new System.Windows.Forms.Label();
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
            this.lsvCTHD.Location = new System.Drawing.Point(12, 42);
            this.lsvCTHD.Name = "lsvCTHD";
            this.lsvCTHD.Size = new System.Drawing.Size(398, 283);
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
            this.panel2.Controls.Add(this.cbBan);
            this.panel2.Controls.Add(this.lbBan);
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
            // cbBan
            // 
            this.cbBan.FormattingEnabled = true;
            this.cbBan.Location = new System.Drawing.Point(51, 15);
            this.cbBan.Name = "cbBan";
            this.cbBan.Size = new System.Drawing.Size(186, 21);
            this.cbBan.TabIndex = 13;
            // 
            // lbBan
            // 
            this.lbBan.AutoSize = true;
            this.lbBan.Location = new System.Drawing.Point(3, 20);
            this.lbBan.Name = "lbBan";
            this.lbBan.Size = new System.Drawing.Size(26, 13);
            this.lbBan.TabIndex = 12;
            this.lbBan.Text = "Bàn";
            // 
            // lbMonAn
            // 
            this.lbMonAn.AutoSize = true;
            this.lbMonAn.Location = new System.Drawing.Point(3, 67);
            this.lbMonAn.Name = "lbMonAn";
            this.lbMonAn.Size = new System.Drawing.Size(43, 13);
            this.lbMonAn.TabIndex = 11;
            this.lbMonAn.Text = "Món ăn";
            // 
            // cbMonAn
            // 
            this.cbMonAn.FormattingEnabled = true;
            this.cbMonAn.Location = new System.Drawing.Point(51, 63);
            this.cbMonAn.Name = "cbMonAn";
            this.cbMonAn.Size = new System.Drawing.Size(186, 21);
            this.cbMonAn.TabIndex = 7;
            // 
            // nmSLMonAn
            // 
            this.nmSLMonAn.Location = new System.Drawing.Point(243, 64);
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
            this.btnThemMon.Location = new System.Drawing.Point(297, 52);
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
            this.btnChuyenBan.Location = new System.Drawing.Point(297, 5);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(98, 42);
            this.btnChuyenBan.TabIndex = 6;
            this.btnChuyenBan.Text = "Chuyển bàn";
            this.btnChuyenBan.UseVisualStyleBackColor = true;
            this.btnChuyenBan.Click += new System.EventHandler(this.btnChuyenBan_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbKhuyenMai);
            this.panel4.Controls.Add(this.btnKhuyenMai);
            this.panel4.Controls.Add(this.cbKhuyenMai);
            this.panel4.Controls.Add(this.btTongCong);
            this.panel4.Controls.Add(this.txbTongTien);
            this.panel4.Controls.Add(this.btnThanhToan);
            this.panel4.Location = new System.Drawing.Point(438, 348);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(436, 97);
            this.panel4.TabIndex = 15;
            // 
            // btnKhuyenMai
            // 
            this.btnKhuyenMai.Location = new System.Drawing.Point(335, 5);
            this.btnKhuyenMai.Name = "btnKhuyenMai";
            this.btnKhuyenMai.Size = new System.Drawing.Size(98, 42);
            this.btnKhuyenMai.TabIndex = 11;
            this.btnKhuyenMai.Text = "Khuyến mãi";
            this.btnKhuyenMai.UseVisualStyleBackColor = true;
            this.btnKhuyenMai.Click += new System.EventHandler(this.btnKhuyenMai_Click);
            // 
            // cbKhuyenMai
            // 
            this.cbKhuyenMai.FormattingEnabled = true;
            this.cbKhuyenMai.Location = new System.Drawing.Point(108, 17);
            this.cbKhuyenMai.Name = "cbKhuyenMai";
            this.cbKhuyenMai.Size = new System.Drawing.Size(174, 21);
            this.cbKhuyenMai.TabIndex = 10;
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
            this.btnThanhToan.Location = new System.Drawing.Point(335, 51);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(98, 42);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lbTenBan
            // 
            this.lbTenBan.AutoSize = true;
            this.lbTenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenBan.Location = new System.Drawing.Point(12, 14);
            this.lbTenBan.Name = "lbTenBan";
            this.lbTenBan.Size = new System.Drawing.Size(209, 25);
            this.lbTenBan.TabIndex = 18;
            this.lbTenBan.Text = "Vui lòng chọn bàn!";
            // 
            // lbKhuyenMai
            // 
            this.lbKhuyenMai.AutoSize = true;
            this.lbKhuyenMai.Location = new System.Drawing.Point(12, 20);
            this.lbKhuyenMai.Name = "lbKhuyenMai";
            this.lbKhuyenMai.Size = new System.Drawing.Size(62, 13);
            this.lbKhuyenMai.TabIndex = 12;
            this.lbKhuyenMai.Text = "Khuyến mãi";
            // 
            // frmQuanLyBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 462);
            this.Controls.Add(this.lbTenBan);
            this.Controls.Add(this.lsvCTHD);
            this.Controls.Add(this.lsvBan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Name = "frmQuanLyBanHang";
            this.Text = "Quản lý bán hàng";
            this.Load += new System.EventHandler(this.frmQuanLyCuaHang_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSLMonAn)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label btTongCong;
        private System.Windows.Forms.TextBox txbTongTien;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lbBan;
        private System.Windows.Forms.Button btnKhuyenMai;
        private System.Windows.Forms.ComboBox cbBan;
        private System.Windows.Forms.Label lbTenBan;
        private System.Windows.Forms.Label lbKhuyenMai;
    }
}