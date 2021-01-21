
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
            this.dataCTHD = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataBan = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMonAn = new System.Windows.Forms.ComboBox();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.cbKhuyenMai = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.txbTongTien = new System.Windows.Forms.TextBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataCTHD
            // 
            this.dataCTHD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.dataCTHD.GridLines = true;
            this.dataCTHD.HideSelection = false;
            this.dataCTHD.Location = new System.Drawing.Point(12, 12);
            this.dataCTHD.Name = "dataCTHD";
            this.dataCTHD.Size = new System.Drawing.Size(395, 358);
            this.dataCTHD.TabIndex = 17;
            this.dataCTHD.UseCompatibleStateImageBehavior = false;
            this.dataCTHD.View = System.Windows.Forms.View.Details;
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
            // dataBan
            // 
            this.dataBan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataBan.Location = new System.Drawing.Point(428, 14);
            this.dataBan.Name = "dataBan";
            this.dataBan.Size = new System.Drawing.Size(443, 356);
            this.dataBan.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbMonAn);
            this.panel2.Controls.Add(this.nmFoodCount);
            this.panel2.Controls.Add(this.btnAddFood);
            this.panel2.Controls.Add(this.btnSwitchTable);
            this.panel2.Location = new System.Drawing.Point(12, 384);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 70);
            this.panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Món ăn";
            // 
            // cbMonAn
            // 
            this.cbMonAn.FormattingEnabled = true;
            this.cbMonAn.Location = new System.Drawing.Point(169, 26);
            this.cbMonAn.Name = "cbMonAn";
            this.cbMonAn.Size = new System.Drawing.Size(121, 21);
            this.cbMonAn.TabIndex = 7;
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Location = new System.Drawing.Point(108, 30);
            this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(48, 20);
            this.nmFoodCount.TabIndex = 3;
            this.nmFoodCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddFood
            // 
            this.btnAddFood.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFood.Image")));
            this.btnAddFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFood.Location = new System.Drawing.Point(3, 3);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(99, 64);
            this.btnAddFood.TabIndex = 2;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFood.UseVisualStyleBackColor = true;
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.Location = new System.Drawing.Point(296, 22);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(99, 32);
            this.btnSwitchTable.TabIndex = 6;
            this.btnSwitchTable.Text = "Chuyển bàn";
            this.btnSwitchTable.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.cbKhuyenMai);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.lbTotalPrice);
            this.panel4.Controls.Add(this.txbTongTien);
            this.panel4.Controls.Add(this.btnCheckout);
            this.panel4.Location = new System.Drawing.Point(416, 376);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(458, 78);
            this.panel4.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Khuyến mãi";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cbKhuyenMai
            // 
            this.cbKhuyenMai.FormattingEnabled = true;
            this.cbKhuyenMai.Location = new System.Drawing.Point(3, 34);
            this.cbKhuyenMai.Name = "cbKhuyenMai";
            this.cbKhuyenMai.Size = new System.Drawing.Size(121, 21);
            this.cbKhuyenMai.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(357, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "In Hóa Đơn";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Location = new System.Drawing.Point(153, 18);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(59, 13);
            this.lbTotalPrice.TabIndex = 9;
            this.lbTotalPrice.Text = "Tổng cộng";
            // 
            // txbTongTien
            // 
            this.txbTongTien.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTongTien.ForeColor = System.Drawing.Color.OrangeRed;
            this.txbTongTien.Location = new System.Drawing.Point(126, 30);
            this.txbTongTien.Name = "txbTongTien";
            this.txbTongTien.ReadOnly = true;
            this.txbTongTien.Size = new System.Drawing.Size(110, 25);
            this.txbTongTien.TabIndex = 8;
            this.txbTongTien.Text = "0";
            this.txbTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(255, 8);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(80, 61);
            this.btnCheckout.TabIndex = 3;
            this.btnCheckout.Text = "Thanh toán";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // frmQuanLyCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 463);
            this.Controls.Add(this.dataCTHD);
            this.Controls.Add(this.dataBan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Name = "frmQuanLyCuaHang";
            this.Text = "Quản lý cửa hàng";
            this.Load += new System.EventHandler(this.frmQuanLyCuaHang_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView dataCTHD;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.FlowLayoutPanel dataBan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMonAn;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbKhuyenMai;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.TextBox txbTongTien;
        private System.Windows.Forms.Button btnCheckout;
    }
}