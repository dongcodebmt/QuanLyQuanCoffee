namespace Coffee_Shop
{
    partial class frmThongTin
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTenDangNhap_ThongTin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMatKhauMoi_ThongTin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtNhapLaiMatKhau_ThongTin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTenDangNhap_ThongTin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(26, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 37);
            this.panel2.TabIndex = 1;
            // 
            // txtTenDangNhap_ThongTin
            // 
            this.txtTenDangNhap_ThongTin.Location = new System.Drawing.Point(107, 4);
            this.txtTenDangNhap_ThongTin.Name = "txtTenDangNhap_ThongTin";
            this.txtTenDangNhap_ThongTin.ReadOnly = true;
            this.txtTenDangNhap_ThongTin.Size = new System.Drawing.Size(295, 20);
            this.txtTenDangNhap_ThongTin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMatKhauMoi_ThongTin);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(26, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(421, 37);
            this.panel3.TabIndex = 3;
            // 
            // txtMatKhauMoi_ThongTin
            // 
            this.txtMatKhauMoi_ThongTin.Location = new System.Drawing.Point(107, 4);
            this.txtMatKhauMoi_ThongTin.Name = "txtMatKhauMoi_ThongTin";
            this.txtMatKhauMoi_ThongTin.Size = new System.Drawing.Size(295, 20);
            this.txtMatKhauMoi_ThongTin.TabIndex = 1;
            this.txtMatKhauMoi_ThongTin.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu Mới:\r\n";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtNhapLaiMatKhau_ThongTin);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(26, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(421, 37);
            this.panel4.TabIndex = 4;
            // 
            // txtNhapLaiMatKhau_ThongTin
            // 
            this.txtNhapLaiMatKhau_ThongTin.Location = new System.Drawing.Point(107, 4);
            this.txtNhapLaiMatKhau_ThongTin.Name = "txtNhapLaiMatKhau_ThongTin";
            this.txtNhapLaiMatKhau_ThongTin.Size = new System.Drawing.Size(295, 20);
            this.txtNhapLaiMatKhau_ThongTin.TabIndex = 1;
            this.txtNhapLaiMatKhau_ThongTin.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập lại:";
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(285, 186);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 5;
            this.button_Update.Text = "Cập nhật";
            this.button_Update.UseVisualStyleBackColor = true;
            // 
            // button_Exit
            // 
            this.button_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Exit.Location = new System.Drawing.Point(372, 186);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 5;
            this.button_Exit.Text = "Thoát";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // frmThongTin
            // 
            this.AcceptButton = this.button_Update;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Exit;
            this.ClientSize = new System.Drawing.Size(458, 223);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "frmThongTin";
            this.Text = "Thông Tin Đăng Nhập";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTenDangNhap_ThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMatKhauMoi_ThongTin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtNhapLaiMatKhau_ThongTin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Exit;
    }
}