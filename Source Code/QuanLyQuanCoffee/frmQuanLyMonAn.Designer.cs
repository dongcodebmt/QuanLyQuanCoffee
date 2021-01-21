
namespace QuanLyQuanCaffe
{
    partial class frmQuanLyMonAn
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
            this.dataMonAn = new System.Windows.Forms.DataGridView();
            this.lbName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lbGia = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbDonVi = new System.Windows.Forms.ComboBox();
            this.cbLoaiMonAn = new System.Windows.Forms.ComboBox();
            this.txtTenMonAn = new System.Windows.Forms.TextBox();
            this.txtMaMonAn = new System.Windows.Forms.TextBox();
            this.lbDonVi = new System.Windows.Forms.Label();
            this.lbLoai = new System.Windows.Forms.Label();
            this.lbTenMon = new System.Windows.Forms.Label();
            this.lbMaMon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataMonAn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataMonAn
            // 
            this.dataMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMonAn.Location = new System.Drawing.Point(291, 74);
            this.dataMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.dataMonAn.Name = "dataMonAn";
            this.dataMonAn.RowHeadersWidth = 51;
            this.dataMonAn.RowTemplate.Height = 24;
            this.dataMonAn.Size = new System.Drawing.Size(504, 301);
            this.dataMonAn.TabIndex = 0;
            this.dataMonAn.SelectionChanged += new System.EventHandler(this.SelectionChanged);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(268, 9);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(256, 40);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Quản lý món ăn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.lbGia);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.cbDonVi);
            this.groupBox1.Controls.Add(this.cbLoaiMonAn);
            this.groupBox1.Controls.Add(this.txtTenMonAn);
            this.groupBox1.Controls.Add(this.txtMaMonAn);
            this.groupBox1.Controls.Add(this.lbDonVi);
            this.groupBox1.Controls.Add(this.lbLoai);
            this.groupBox1.Controls.Add(this.lbTenMon);
            this.groupBox1.Controls.Add(this.lbMaMon);
            this.groupBox1.Location = new System.Drawing.Point(11, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(269, 266);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin món ăn";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(149, 222);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Cick);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(97, 103);
            this.txtGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(150, 20);
            this.txtGia.TabIndex = 8;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(45, 222);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(17, 106);
            this.lbGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(23, 13);
            this.lbGia.TabIndex = 7;
            this.lbGia.Text = "Giá";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(149, 222);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(45, 222);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbDonVi
            // 
            this.cbDonVi.FormattingEnabled = true;
            this.cbDonVi.Location = new System.Drawing.Point(97, 172);
            this.cbDonVi.Margin = new System.Windows.Forms.Padding(2);
            this.cbDonVi.Name = "cbDonVi";
            this.cbDonVi.Size = new System.Drawing.Size(150, 21);
            this.cbDonVi.TabIndex = 4;
            // 
            // cbLoaiMonAn
            // 
            this.cbLoaiMonAn.FormattingEnabled = true;
            this.cbLoaiMonAn.Location = new System.Drawing.Point(97, 137);
            this.cbLoaiMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.cbLoaiMonAn.Name = "cbLoaiMonAn";
            this.cbLoaiMonAn.Size = new System.Drawing.Size(150, 21);
            this.cbLoaiMonAn.TabIndex = 4;
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.Location = new System.Drawing.Point(97, 69);
            this.txtTenMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(150, 20);
            this.txtTenMonAn.TabIndex = 3;
            // 
            // txtMaMonAn
            // 
            this.txtMaMonAn.Location = new System.Drawing.Point(97, 35);
            this.txtMaMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaMonAn.Name = "txtMaMonAn";
            this.txtMaMonAn.Size = new System.Drawing.Size(150, 20);
            this.txtMaMonAn.TabIndex = 3;
            // 
            // lbDonVi
            // 
            this.lbDonVi.AutoSize = true;
            this.lbDonVi.Location = new System.Drawing.Point(17, 175);
            this.lbDonVi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDonVi.Name = "lbDonVi";
            this.lbDonVi.Size = new System.Drawing.Size(38, 13);
            this.lbDonVi.TabIndex = 3;
            this.lbDonVi.Text = "Đơn vị";
            // 
            // lbLoai
            // 
            this.lbLoai.AutoSize = true;
            this.lbLoai.Location = new System.Drawing.Point(17, 140);
            this.lbLoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLoai.Name = "lbLoai";
            this.lbLoai.Size = new System.Drawing.Size(65, 13);
            this.lbLoai.TabIndex = 2;
            this.lbLoai.Text = "Loại món ăn";
            // 
            // lbTenMon
            // 
            this.lbTenMon.AutoSize = true;
            this.lbTenMon.Location = new System.Drawing.Point(17, 72);
            this.lbTenMon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenMon.Name = "lbTenMon";
            this.lbTenMon.Size = new System.Drawing.Size(49, 13);
            this.lbTenMon.TabIndex = 1;
            this.lbTenMon.Text = "Tên món";
            // 
            // lbMaMon
            // 
            this.lbMaMon.AutoSize = true;
            this.lbMaMon.Location = new System.Drawing.Point(17, 38);
            this.lbMaMon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaMon.Name = "lbMaMon";
            this.lbMaMon.Size = new System.Drawing.Size(60, 13);
            this.lbMaMon.TabIndex = 0;
            this.lbMaMon.Text = "Mã món ăn";
            // 
            // frmQuanLyMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 394);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.dataMonAn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQuanLyMonAn";
            this.Text = "QuanLyMonAn";
            this.Load += new System.EventHandler(this.QuanLyMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataMonAn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataMonAn;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbDonVi;
        private System.Windows.Forms.Label lbLoai;
        private System.Windows.Forms.Label lbTenMon;
        private System.Windows.Forms.Label lbMaMon;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbDonVi;
        private System.Windows.Forms.ComboBox cbLoaiMonAn;
        private System.Windows.Forms.TextBox txtTenMonAn;
        private System.Windows.Forms.TextBox txtMaMonAn;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lbGia;
    }
}