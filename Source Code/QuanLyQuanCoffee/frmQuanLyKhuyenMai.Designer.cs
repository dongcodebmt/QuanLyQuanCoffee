
namespace QuanLyQuanCaffe
{
    partial class frmQuanLyKhuyenMai
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
            this.dataKhuyenMai = new System.Windows.Forms.DataGridView();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbTyLe = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.lbMa = new System.Windows.Forms.Label();
            this.lbMaKM = new System.Windows.Forms.Label();
            this.txtMaKM = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtTyLe = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataKhuyenMai)).BeginInit();
            this.SuspendLayout();
            // 
            // dataKhuyenMai
            // 
            this.dataKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKhuyenMai.Location = new System.Drawing.Point(301, 12);
            this.dataKhuyenMai.Name = "dataKhuyenMai";
            this.dataKhuyenMai.Size = new System.Drawing.Size(547, 274);
            this.dataKhuyenMai.TabIndex = 0;
            this.dataKhuyenMai.SelectionChanged += new System.EventHandler(this.dataKhuyenMai_SelectionChanged);
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(12, 142);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(26, 13);
            this.lbTen.TabIndex = 1;
            this.lbTen.Text = "Tên";
            // 
            // lbTyLe
            // 
            this.lbTyLe.AutoSize = true;
            this.lbTyLe.Location = new System.Drawing.Point(12, 168);
            this.lbTyLe.Name = "lbTyLe";
            this.lbTyLe.Size = new System.Drawing.Size(30, 13);
            this.lbTyLe.TabIndex = 2;
            this.lbTyLe.Text = "Tỷ lệ";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(115, 87);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(180, 20);
            this.txtMa.TabIndex = 1;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Location = new System.Drawing.Point(12, 87);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(22, 13);
            this.lbMa.TabIndex = 4;
            this.lbMa.Text = "Mã";
            // 
            // lbMaKM
            // 
            this.lbMaKM.AutoSize = true;
            this.lbMaKM.Location = new System.Drawing.Point(12, 116);
            this.lbMaKM.Name = "lbMaKM";
            this.lbMaKM.Size = new System.Drawing.Size(79, 13);
            this.lbMaKM.TabIndex = 5;
            this.lbMaKM.Text = "Mã khuyến mãi";
            // 
            // txtMaKM
            // 
            this.txtMaKM.Location = new System.Drawing.Point(115, 113);
            this.txtMaKM.Name = "txtMaKM";
            this.txtMaKM.Size = new System.Drawing.Size(180, 20);
            this.txtMaKM.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(115, 139);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(180, 20);
            this.txtTen.TabIndex = 3;
            // 
            // txtTyLe
            // 
            this.txtTyLe.Location = new System.Drawing.Point(115, 165);
            this.txtTyLe.Name = "txtTyLe";
            this.txtTyLe.Size = new System.Drawing.Size(180, 20);
            this.txtTyLe.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(29, 203);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(128, 203);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(29, 203);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(128, 203);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(220, 203);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmQuanLyKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 300);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTyLe);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMaKM);
            this.Controls.Add(this.lbMaKM);
            this.Controls.Add(this.lbMa);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.lbTyLe);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.dataKhuyenMai);
            this.Name = "frmQuanLyKhuyenMai";
            this.Text = "Quản lý khuyến mãi";
            this.Load += new System.EventHandler(this.frmQuanLyKhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataKhuyenMai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataKhuyenMai;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbTyLe;
        private System.Windows.Forms.TextBox txtMa;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Label lbMaKM;
        private System.Windows.Forms.TextBox txtMaKM;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtTyLe;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
    }
}