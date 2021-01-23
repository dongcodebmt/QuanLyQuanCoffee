
namespace QuanLyQuanCaffe
{
    partial class frmThongTinKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinKho));
            this.QuanLy = new System.Windows.Forms.TabControl();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbTodate = new System.Windows.Forms.Label();
            this.lbFromdate = new System.Windows.Forms.Label();
            this.dtpkTodate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromdate = new System.Windows.Forms.DateTimePicker();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel29 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel24 = new System.Windows.Forms.Panel();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.QuanLy.SuspendLayout();
            this.tpBill.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tpAccount.SuspendLayout();
            this.panel29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel24.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuanLy
            // 
            this.QuanLy.Controls.Add(this.tpBill);
            this.QuanLy.Controls.Add(this.tpAccount);
            this.QuanLy.Location = new System.Drawing.Point(117, 33);
            this.QuanLy.Name = "QuanLy";
            this.QuanLy.SelectedIndex = 0;
            this.QuanLy.Size = new System.Drawing.Size(566, 385);
            this.QuanLy.TabIndex = 4;
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.panel7);
            this.tpBill.Controls.Add(this.panel6);
            this.tpBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpBill.Location = new System.Drawing.Point(4, 22);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(558, 359);
            this.tpBill.TabIndex = 1;
            this.tpBill.Text = "Doanh thu";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button3);
            this.panel7.Controls.Add(this.button2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(3, 295);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(552, 61);
            this.panel7.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(379, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 41);
            this.button3.TabIndex = 8;
            this.button3.Text = "Xuất File";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "Thống Kê";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbTodate);
            this.panel6.Controls.Add(this.lbFromdate);
            this.panel6.Controls.Add(this.dtpkTodate);
            this.panel6.Controls.Add(this.dtpkFromdate);
            this.panel6.Location = new System.Drawing.Point(6, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(709, 30);
            this.panel6.TabIndex = 1;
            // 
            // lbTodate
            // 
            this.lbTodate.AutoSize = true;
            this.lbTodate.Location = new System.Drawing.Point(262, 8);
            this.lbTodate.Name = "lbTodate";
            this.lbTodate.Size = new System.Drawing.Size(53, 13);
            this.lbTodate.TabIndex = 3;
            this.lbTodate.Text = "Đến ngày";
            // 
            // lbFromdate
            // 
            this.lbFromdate.AutoSize = true;
            this.lbFromdate.Location = new System.Drawing.Point(3, 8);
            this.lbFromdate.Name = "lbFromdate";
            this.lbFromdate.Size = new System.Drawing.Size(46, 13);
            this.lbFromdate.TabIndex = 2;
            this.lbFromdate.Text = "Từ ngày";
            // 
            // dtpkTodate
            // 
            this.dtpkTodate.Location = new System.Drawing.Point(321, 7);
            this.dtpkTodate.Name = "dtpkTodate";
            this.dtpkTodate.Size = new System.Drawing.Size(200, 20);
            this.dtpkTodate.TabIndex = 1;
            // 
            // dtpkFromdate
            // 
            this.dtpkFromdate.Location = new System.Drawing.Point(55, 7);
            this.dtpkFromdate.Name = "dtpkFromdate";
            this.dtpkFromdate.Size = new System.Drawing.Size(200, 20);
            this.dtpkFromdate.TabIndex = 0;
            this.dtpkFromdate.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.comboBox1);
            this.tpAccount.Controls.Add(this.button4);
            this.tpAccount.Controls.Add(this.textBox1);
            this.tpAccount.Controls.Add(this.label4);
            this.tpAccount.Controls.Add(this.label3);
            this.tpAccount.Controls.Add(this.panel29);
            this.tpAccount.Controls.Add(this.panel24);
            this.tpAccount.Location = new System.Drawing.Point(4, 22);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(558, 359);
            this.tpAccount.TabIndex = 6;
            this.tpAccount.Text = "Tài khoản";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(329, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(351, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Cấp Quyền";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(329, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Chức vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên đăng nhập";
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.dataGridView1);
            this.panel29.Location = new System.Drawing.Point(3, 97);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(478, 232);
            this.panel29.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(468, 226);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.btnEditAccount);
            this.panel24.Controls.Add(this.btnDeleteAccount);
            this.panel24.Controls.Add(this.btnAddAccount);
            this.panel24.Location = new System.Drawing.Point(10, 20);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(147, 50);
            this.panel24.TabIndex = 3;
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnEditAccount.Image")));
            this.btnEditAccount.Location = new System.Drawing.Point(99, 3);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(40, 40);
            this.btnEditAccount.TabIndex = 2;
            this.btnEditAccount.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAccount.Image")));
            this.btnDeleteAccount.Location = new System.Drawing.Point(53, 3);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(40, 40);
            this.btnDeleteAccount.TabIndex = 1;
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAccount.Image")));
            this.btnAddAccount.Location = new System.Drawing.Point(4, 2);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(44, 40);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // frmThongTinKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuanLy);
            this.Name = "frmThongTinKho";
            this.Text = "Thông tin kho";
            this.Load += new System.EventHandler(this.frmThongTinKho_Load);
            this.QuanLy.ResumeLayout(false);
            this.tpBill.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tpAccount.ResumeLayout(false);
            this.tpAccount.PerformLayout();
            this.panel29.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel24.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl QuanLy;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbTodate;
        private System.Windows.Forms.Label lbFromdate;
        private System.Windows.Forms.DateTimePicker dtpkTodate;
        private System.Windows.Forms.DateTimePicker dtpkFromdate;
        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAddAccount;
    }
}