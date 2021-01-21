
namespace QuanLyQuanCaffe
{
    partial class frmNhapCongThuc
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
            this.lbMon = new System.Windows.Forms.Label();
            this.lbNguyenLieu = new System.Windows.Forms.Label();
            this.lbChiPhi = new System.Windows.Forms.Label();
            this.txtChiPhi = new System.Windows.Forms.TextBox();
            this.cbMonAn = new System.Windows.Forms.ComboBox();
            this.cbNguyenLieu = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dataCongThuc = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCongThuc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMon
            // 
            this.lbMon.AutoSize = true;
            this.lbMon.Location = new System.Drawing.Point(12, 72);
            this.lbMon.Name = "lbMon";
            this.lbMon.Size = new System.Drawing.Size(43, 13);
            this.lbMon.TabIndex = 1;
            this.lbMon.Text = "Món ăn";
            // 
            // lbNguyenLieu
            // 
            this.lbNguyenLieu.AutoSize = true;
            this.lbNguyenLieu.Location = new System.Drawing.Point(12, 99);
            this.lbNguyenLieu.Name = "lbNguyenLieu";
            this.lbNguyenLieu.Size = new System.Drawing.Size(63, 13);
            this.lbNguyenLieu.TabIndex = 2;
            this.lbNguyenLieu.Text = "Nguyên liệu";
            // 
            // lbChiPhi
            // 
            this.lbChiPhi.AutoSize = true;
            this.lbChiPhi.Location = new System.Drawing.Point(12, 126);
            this.lbChiPhi.Name = "lbChiPhi";
            this.lbChiPhi.Size = new System.Drawing.Size(26, 13);
            this.lbChiPhi.TabIndex = 3;
            this.lbChiPhi.Text = "Tốn";
            // 
            // txtChiPhi
            // 
            this.txtChiPhi.Location = new System.Drawing.Point(101, 123);
            this.txtChiPhi.Name = "txtChiPhi";
            this.txtChiPhi.Size = new System.Drawing.Size(194, 20);
            this.txtChiPhi.TabIndex = 3;
            // 
            // cbMonAn
            // 
            this.cbMonAn.FormattingEnabled = true;
            this.cbMonAn.Location = new System.Drawing.Point(101, 69);
            this.cbMonAn.Name = "cbMonAn";
            this.cbMonAn.Size = new System.Drawing.Size(194, 21);
            this.cbMonAn.TabIndex = 1;
            // 
            // cbNguyenLieu
            // 
            this.cbNguyenLieu.FormattingEnabled = true;
            this.cbNguyenLieu.Location = new System.Drawing.Point(101, 96);
            this.cbNguyenLieu.Name = "cbNguyenLieu";
            this.cbNguyenLieu.Size = new System.Drawing.Size(194, 21);
            this.cbNguyenLieu.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(20, 159);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(220, 159);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(123, 159);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dataCongThuc
            // 
            this.dataCongThuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCongThuc.Location = new System.Drawing.Point(301, 12);
            this.dataCongThuc.Name = "dataCongThuc";
            this.dataCongThuc.Size = new System.Drawing.Size(439, 244);
            this.dataCongThuc.TabIndex = 11;
            this.dataCongThuc.SelectionChanged += new System.EventHandler(this.dataCongThuc_SelectionChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(20, 159);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(123, 159);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmNhapCongThuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 268);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dataCongThuc);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbNguyenLieu);
            this.Controls.Add(this.cbMonAn);
            this.Controls.Add(this.txtChiPhi);
            this.Controls.Add(this.lbChiPhi);
            this.Controls.Add(this.lbNguyenLieu);
            this.Controls.Add(this.lbMon);
            this.Name = "frmNhapCongThuc";
            this.Text = "Nhập công thức";
            this.Load += new System.EventHandler(this.frmNhapCongThuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCongThuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMon;
        private System.Windows.Forms.Label lbNguyenLieu;
        private System.Windows.Forms.Label lbChiPhi;
        private System.Windows.Forms.TextBox txtChiPhi;
        private System.Windows.Forms.ComboBox cbMonAn;
        private System.Windows.Forms.ComboBox cbNguyenLieu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dataCongThuc;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}