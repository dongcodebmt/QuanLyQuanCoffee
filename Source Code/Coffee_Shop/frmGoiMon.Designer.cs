﻿namespace Coffee_Shop
{
    partial class frmGoiMon
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lsv_Bill = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox_Switch_Tables = new System.Windows.Forms.ComboBox();
            this.Number_updown_Discount = new System.Windows.Forms.NumericUpDown();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnGiamGia = new System.Windows.Forms.Button();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Numb_Food_Count = new System.Windows.Forms.NumericUpDown();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.cbox_Food = new System.Windows.Forms.ComboBox();
            this.cbCategogy = new System.Windows.Forms.ComboBox();
            this.flowLayoutPane_Tables = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Number_updown_Discount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numb_Food_Count)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Lsv_Bill);
            this.panel2.Location = new System.Drawing.Point(474, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 276);
            this.panel2.TabIndex = 2;
            // 
            // Lsv_Bill
            // 
            this.Lsv_Bill.HideSelection = false;
            this.Lsv_Bill.Location = new System.Drawing.Point(3, 3);
            this.Lsv_Bill.Name = "Lsv_Bill";
            this.Lsv_Bill.Size = new System.Drawing.Size(315, 273);
            this.Lsv_Bill.TabIndex = 0;
            this.Lsv_Bill.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox_Switch_Tables);
            this.panel3.Controls.Add(this.Number_updown_Discount);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Controls.Add(this.btnGiamGia);
            this.panel3.Controls.Add(this.btnChuyenBan);
            this.panel3.Location = new System.Drawing.Point(474, 365);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 64);
            this.panel3.TabIndex = 3;
            // 
            // comboBox_Switch_Tables
            // 
            this.comboBox_Switch_Tables.FormattingEnabled = true;
            this.comboBox_Switch_Tables.Location = new System.Drawing.Point(18, 36);
            this.comboBox_Switch_Tables.Name = "comboBox_Switch_Tables";
            this.comboBox_Switch_Tables.Size = new System.Drawing.Size(95, 21);
            this.comboBox_Switch_Tables.TabIndex = 4;
            // 
            // Number_updown_Discount
            // 
            this.Number_updown_Discount.Location = new System.Drawing.Point(119, 37);
            this.Number_updown_Discount.Name = "Number_updown_Discount";
            this.Number_updown_Discount.Size = new System.Drawing.Size(95, 20);
            this.Number_updown_Discount.TabIndex = 3;
            this.Number_updown_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(221, 3);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(94, 55);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnGiamGia
            // 
            this.btnGiamGia.Location = new System.Drawing.Point(119, 3);
            this.btnGiamGia.Name = "btnGiamGia";
            this.btnGiamGia.Size = new System.Drawing.Size(95, 28);
            this.btnGiamGia.TabIndex = 1;
            this.btnGiamGia.Text = "Giảm Giá";
            this.btnGiamGia.UseVisualStyleBackColor = true;
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.Location = new System.Drawing.Point(18, 3);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(95, 28);
            this.btnChuyenBan.TabIndex = 0;
            this.btnChuyenBan.Text = "Chuyển Bàn";
            this.btnChuyenBan.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Numb_Food_Count);
            this.panel4.Controls.Add(this.btnThemMon);
            this.panel4.Controls.Add(this.cbox_Food);
            this.panel4.Controls.Add(this.cbCategogy);
            this.panel4.Location = new System.Drawing.Point(474, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(318, 50);
            this.panel4.TabIndex = 0;
            // 
            // Numb_Food_Count
            // 
            this.Numb_Food_Count.Location = new System.Drawing.Point(234, 26);
            this.Numb_Food_Count.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Numb_Food_Count.Name = "Numb_Food_Count";
            this.Numb_Food_Count.Size = new System.Drawing.Size(53, 20);
            this.Numb_Food_Count.TabIndex = 3;
            this.Numb_Food_Count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(221, 3);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(75, 23);
            this.btnThemMon.TabIndex = 2;
            this.btnThemMon.Text = "Thêm Món";
            this.btnThemMon.UseVisualStyleBackColor = true;
            // 
            // cbox_Food
            // 
            this.cbox_Food.FormattingEnabled = true;
            this.cbox_Food.Location = new System.Drawing.Point(3, 26);
            this.cbox_Food.Name = "cbox_Food";
            this.cbox_Food.Size = new System.Drawing.Size(202, 21);
            this.cbox_Food.TabIndex = 1;
            // 
            // cbCategogy
            // 
            this.cbCategogy.FormattingEnabled = true;
            this.cbCategogy.Location = new System.Drawing.Point(3, 0);
            this.cbCategogy.Name = "cbCategogy";
            this.cbCategogy.Size = new System.Drawing.Size(202, 21);
            this.cbCategogy.TabIndex = 0;
            // 
            // flowLayoutPane_Tables
            // 
            this.flowLayoutPane_Tables.Location = new System.Drawing.Point(12, 30);
            this.flowLayoutPane_Tables.Name = "flowLayoutPane_Tables";
            this.flowLayoutPane_Tables.Size = new System.Drawing.Size(456, 329);
            this.flowLayoutPane_Tables.TabIndex = 4;
            // 
            // frmGoiMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(810, 441);
            this.Controls.Add(this.flowLayoutPane_Tables);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmGoiMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Number_updown_Discount)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Numb_Food_Count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView Lsv_Bill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbCategogy;
        private System.Windows.Forms.ComboBox cbox_Food;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.NumericUpDown Numb_Food_Count;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPane_Tables;
        private System.Windows.Forms.ComboBox comboBox_Switch_Tables;
        private System.Windows.Forms.NumericUpDown Number_updown_Discount;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnGiamGia;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}