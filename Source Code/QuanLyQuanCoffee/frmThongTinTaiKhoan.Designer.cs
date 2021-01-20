
namespace QuanLyQuanCaffe
{
    partial class frmThongTinTaiKhoan
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
            this.lbXinChao = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.lbTenHienThi = new System.Windows.Forms.Label();
            this.lbTenTaiKhoan = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbXinChao
            // 
            this.lbXinChao.AutoSize = true;
            this.lbXinChao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXinChao.Location = new System.Drawing.Point(9, 13);
            this.lbXinChao.Name = "lbXinChao";
            this.lbXinChao.Size = new System.Drawing.Size(136, 31);
            this.lbXinChao.TabIndex = 31;
            this.lbXinChao.Text = "Xin chào!";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(289, 146);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 30;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(192, 146);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 29;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(248, 69);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(168, 20);
            this.txtTenTaiKhoan.TabIndex = 26;
            // 
            // lbTenHienThi
            // 
            this.lbTenHienThi.AutoSize = true;
            this.lbTenHienThi.BackColor = System.Drawing.Color.Transparent;
            this.lbTenHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenHienThi.Location = new System.Drawing.Point(110, 98);
            this.lbTenHienThi.Name = "lbTenHienThi";
            this.lbTenHienThi.Size = new System.Drawing.Size(63, 13);
            this.lbTenHienThi.TabIndex = 24;
            this.lbTenHienThi.Text = "Họ và tên";
            // 
            // lbTenTaiKhoan
            // 
            this.lbTenTaiKhoan.AutoSize = true;
            this.lbTenTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lbTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTaiKhoan.Location = new System.Drawing.Point(110, 72);
            this.lbTenTaiKhoan.Name = "lbTenTaiKhoan";
            this.lbTenTaiKhoan.Size = new System.Drawing.Size(86, 13);
            this.lbTenTaiKhoan.TabIndex = 23;
            this.lbTenTaiKhoan.Text = "Tên tài khoản";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(248, 95);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(168, 20);
            this.txtHoTen.TabIndex = 32;
            // 
            // frmThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 183);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lbXinChao);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.lbTenHienThi);
            this.Controls.Add(this.lbTenTaiKhoan);
            this.Name = "frmThongTinTaiKhoan";
            this.Text = "Thông tin tài khoản";
            this.Load += new System.EventHandler(this.frmThongTinTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbXinChao;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label lbTenHienThi;
        private System.Windows.Forms.Label lbTenTaiKhoan;
        private System.Windows.Forms.TextBox txtHoTen;
    }
}