
namespace QuanLyQuanCaffe
{
    partial class frmNhapKho
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
            this.lbSLLe = new System.Windows.Forms.Label();
            this.txtSLLe = new System.Windows.Forms.TextBox();
            this.lbQuyCach = new System.Windows.Forms.Label();
            this.rbtnLe = new System.Windows.Forms.RadioButton();
            this.rbtnThung = new System.Windows.Forms.RadioButton();
            this.btnNhap = new System.Windows.Forms.Button();
            this.dataNhapKho = new System.Windows.Forms.DataGridView();
            this.cbMonAn = new System.Windows.Forms.ComboBox();
            this.lbGiaMua = new System.Windows.Forms.Label();
            this.lbTrongLuong = new System.Windows.Forms.Label();
            this.txtGiaMua = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lbMonAn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataNhapKho)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSLLe
            // 
            this.lbSLLe.AutoSize = true;
            this.lbSLLe.Location = new System.Drawing.Point(15, 194);
            this.lbSLLe.Name = "lbSLLe";
            this.lbSLLe.Size = new System.Drawing.Size(81, 13);
            this.lbSLLe.TabIndex = 40;
            this.lbSLLe.Text = "Số lượng/thùng";
            // 
            // txtSLLe
            // 
            this.txtSLLe.Location = new System.Drawing.Point(98, 191);
            this.txtSLLe.Name = "txtSLLe";
            this.txtSLLe.Size = new System.Drawing.Size(194, 20);
            this.txtSLLe.TabIndex = 6;
            // 
            // lbQuyCach
            // 
            this.lbQuyCach.AutoSize = true;
            this.lbQuyCach.Location = new System.Drawing.Point(15, 144);
            this.lbQuyCach.Name = "lbQuyCach";
            this.lbQuyCach.Size = new System.Drawing.Size(53, 13);
            this.lbQuyCach.TabIndex = 38;
            this.lbQuyCach.Text = "Quy cách";
            // 
            // rbtnLe
            // 
            this.rbtnLe.AutoSize = true;
            this.rbtnLe.Location = new System.Drawing.Point(221, 142);
            this.rbtnLe.Name = "rbtnLe";
            this.rbtnLe.Size = new System.Drawing.Size(69, 17);
            this.rbtnLe.TabIndex = 4;
            this.rbtnLe.TabStop = true;
            this.rbtnLe.Text = "Lon/Chai";
            this.rbtnLe.UseVisualStyleBackColor = true;
            // 
            // rbtnThung
            // 
            this.rbtnThung.AutoSize = true;
            this.rbtnThung.Location = new System.Drawing.Point(98, 142);
            this.rbtnThung.Name = "rbtnThung";
            this.rbtnThung.Size = new System.Drawing.Size(56, 17);
            this.rbtnThung.TabIndex = 3;
            this.rbtnThung.TabStop = true;
            this.rbtnThung.Text = "Thùng";
            this.rbtnThung.UseVisualStyleBackColor = true;
            this.rbtnThung.CheckedChanged += new System.EventHandler(this.rbtnThung_CheckedChanged);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(122, 231);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 7;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // dataNhapKho
            // 
            this.dataNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNhapKho.Location = new System.Drawing.Point(298, 12);
            this.dataNhapKho.Name = "dataNhapKho";
            this.dataNhapKho.Size = new System.Drawing.Size(546, 320);
            this.dataNhapKho.TabIndex = 34;
            // 
            // cbMonAn
            // 
            this.cbMonAn.FormattingEnabled = true;
            this.cbMonAn.Location = new System.Drawing.Point(98, 89);
            this.cbMonAn.Name = "cbMonAn";
            this.cbMonAn.Size = new System.Drawing.Size(194, 21);
            this.cbMonAn.TabIndex = 1;
            // 
            // lbGiaMua
            // 
            this.lbGiaMua.AutoSize = true;
            this.lbGiaMua.Location = new System.Drawing.Point(15, 119);
            this.lbGiaMua.Name = "lbGiaMua";
            this.lbGiaMua.Size = new System.Drawing.Size(46, 13);
            this.lbGiaMua.TabIndex = 32;
            this.lbGiaMua.Text = "Giá mua";
            // 
            // lbTrongLuong
            // 
            this.lbTrongLuong.AutoSize = true;
            this.lbTrongLuong.Location = new System.Drawing.Point(15, 168);
            this.lbTrongLuong.Name = "lbTrongLuong";
            this.lbTrongLuong.Size = new System.Drawing.Size(49, 13);
            this.lbTrongLuong.TabIndex = 31;
            this.lbTrongLuong.Text = "Số lượng";
            // 
            // txtGiaMua
            // 
            this.txtGiaMua.Location = new System.Drawing.Point(98, 116);
            this.txtGiaMua.Name = "txtGiaMua";
            this.txtGiaMua.Size = new System.Drawing.Size(193, 20);
            this.txtGiaMua.TabIndex = 2;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(98, 165);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(193, 20);
            this.txtSoLuong.TabIndex = 5;
            // 
            // lbMonAn
            // 
            this.lbMonAn.AutoSize = true;
            this.lbMonAn.Location = new System.Drawing.Point(15, 92);
            this.lbMonAn.Name = "lbMonAn";
            this.lbMonAn.Size = new System.Drawing.Size(28, 13);
            this.lbMonAn.TabIndex = 28;
            this.lbMonAn.Text = "Món";
            // 
            // frmNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 346);
            this.Controls.Add(this.lbSLLe);
            this.Controls.Add(this.txtSLLe);
            this.Controls.Add(this.lbQuyCach);
            this.Controls.Add(this.rbtnLe);
            this.Controls.Add(this.rbtnThung);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.dataNhapKho);
            this.Controls.Add(this.cbMonAn);
            this.Controls.Add(this.lbGiaMua);
            this.Controls.Add(this.lbTrongLuong);
            this.Controls.Add(this.txtGiaMua);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lbMonAn);
            this.Name = "frmNhapKho";
            this.Text = "Nhập kho";
            this.Load += new System.EventHandler(this.frmNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataNhapKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSLLe;
        private System.Windows.Forms.TextBox txtSLLe;
        private System.Windows.Forms.Label lbQuyCach;
        private System.Windows.Forms.RadioButton rbtnLe;
        private System.Windows.Forms.RadioButton rbtnThung;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.DataGridView dataNhapKho;
        private System.Windows.Forms.ComboBox cbMonAn;
        private System.Windows.Forms.Label lbGiaMua;
        private System.Windows.Forms.Label lbTrongLuong;
        private System.Windows.Forms.TextBox txtGiaMua;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lbMonAn;
    }
}