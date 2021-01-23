
namespace QuanLyQuanCaffe
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
            this.lbName3 = new System.Windows.Forms.Label();
            this.lbName2 = new System.Windows.Forms.Label();
            this.lbName1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbName3
            // 
            this.lbName3.AutoSize = true;
            this.lbName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName3.Location = new System.Drawing.Point(17, 197);
            this.lbName3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbName3.Name = "lbName3";
            this.lbName3.Size = new System.Drawing.Size(123, 29);
            this.lbName3.TabIndex = 5;
            this.lbName3.Text = "Thông tin";
            // 
            // lbName2
            // 
            this.lbName2.AutoSize = true;
            this.lbName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName2.Location = new System.Drawing.Point(17, 116);
            this.lbName2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbName2.Name = "lbName2";
            this.lbName2.Size = new System.Drawing.Size(123, 29);
            this.lbName2.TabIndex = 4;
            this.lbName2.Text = "Thông tin";
            // 
            // lbName1
            // 
            this.lbName1.AutoSize = true;
            this.lbName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName1.Location = new System.Drawing.Point(17, 39);
            this.lbName1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbName1.Name = "lbName1";
            this.lbName1.Size = new System.Drawing.Size(123, 29);
            this.lbName1.TabIndex = 3;
            this.lbName1.Text = "Thông tin";
            // 
            // frmThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 269);
            this.Controls.Add(this.lbName3);
            this.Controls.Add(this.lbName2);
            this.Controls.Add(this.lbName1);
            this.Name = "frmThongTin";
            this.Text = "frmThongTin";
            this.Load += new System.EventHandler(this.frmThongTin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName3;
        private System.Windows.Forms.Label lbName2;
        private System.Windows.Forms.Label lbName1;
    }
}