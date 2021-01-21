
namespace QuanLyQuanCaffe
{
    partial class frmNhapNguyenLieu
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
            this.lbNguyenLieu = new System.Windows.Forms.Label();
            this.txtTrongLuong = new System.Windows.Forms.TextBox();
            this.txtGiaMua = new System.Windows.Forms.TextBox();
            this.lbTrongLuong = new System.Windows.Forms.Label();
            this.lbGiaMua = new System.Windows.Forms.Label();
            this.cbNguyenLieu = new System.Windows.Forms.ComboBox();
            this.dataNhapNN = new System.Windows.Forms.DataGridView();
            this.btnNhap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataNhapNN)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNguyenLieu
            // 
            this.lbNguyenLieu.AutoSize = true;
            this.lbNguyenLieu.Location = new System.Drawing.Point(12, 131);
            this.lbNguyenLieu.Name = "lbNguyenLieu";
            this.lbNguyenLieu.Size = new System.Drawing.Size(63, 13);
            this.lbNguyenLieu.TabIndex = 0;
            this.lbNguyenLieu.Text = "Nguyên liệu";
            // 
            // txtTrongLuong
            // 
            this.txtTrongLuong.Location = new System.Drawing.Point(81, 155);
            this.txtTrongLuong.Name = "txtTrongLuong";
            this.txtTrongLuong.Size = new System.Drawing.Size(193, 20);
            this.txtTrongLuong.TabIndex = 2;
            // 
            // txtGiaMua
            // 
            this.txtGiaMua.Location = new System.Drawing.Point(81, 181);
            this.txtGiaMua.Name = "txtGiaMua";
            this.txtGiaMua.Size = new System.Drawing.Size(193, 20);
            this.txtGiaMua.TabIndex = 3;
            // 
            // lbTrongLuong
            // 
            this.lbTrongLuong.AutoSize = true;
            this.lbTrongLuong.Location = new System.Drawing.Point(12, 158);
            this.lbTrongLuong.Name = "lbTrongLuong";
            this.lbTrongLuong.Size = new System.Drawing.Size(64, 13);
            this.lbTrongLuong.TabIndex = 10;
            this.lbTrongLuong.Text = "Trọng lượng";
            // 
            // lbGiaMua
            // 
            this.lbGiaMua.AutoSize = true;
            this.lbGiaMua.Location = new System.Drawing.Point(12, 184);
            this.lbGiaMua.Name = "lbGiaMua";
            this.lbGiaMua.Size = new System.Drawing.Size(46, 13);
            this.lbGiaMua.TabIndex = 11;
            this.lbGiaMua.Text = "Giá mua";
            // 
            // cbNguyenLieu
            // 
            this.cbNguyenLieu.FormattingEnabled = true;
            this.cbNguyenLieu.Location = new System.Drawing.Point(81, 128);
            this.cbNguyenLieu.Name = "cbNguyenLieu";
            this.cbNguyenLieu.Size = new System.Drawing.Size(193, 21);
            this.cbNguyenLieu.TabIndex = 1;
            // 
            // dataNhapNN
            // 
            this.dataNhapNN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNhapNN.Location = new System.Drawing.Point(280, 17);
            this.dataNhapNN.Name = "dataNhapNN";
            this.dataNhapNN.Size = new System.Drawing.Size(539, 320);
            this.dataNhapNN.TabIndex = 13;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(115, 223);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 4;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // frmNhapNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 358);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.dataNhapNN);
            this.Controls.Add(this.cbNguyenLieu);
            this.Controls.Add(this.lbGiaMua);
            this.Controls.Add(this.lbTrongLuong);
            this.Controls.Add(this.txtGiaMua);
            this.Controls.Add(this.txtTrongLuong);
            this.Controls.Add(this.lbNguyenLieu);
            this.Name = "frmNhapNguyenLieu";
            this.Text = "Nhập nguyên liệu";
            this.Load += new System.EventHandler(this.frmNhapNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataNhapNN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNguyenLieu;
        private System.Windows.Forms.TextBox txtTrongLuong;
        private System.Windows.Forms.TextBox txtGiaMua;
        private System.Windows.Forms.Label lbTrongLuong;
        private System.Windows.Forms.Label lbGiaMua;
        private System.Windows.Forms.ComboBox cbNguyenLieu;
        private System.Windows.Forms.DataGridView dataNhapNN;
        private System.Windows.Forms.Button btnNhap;
    }
}