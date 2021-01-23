
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabKho = new System.Windows.Forms.TabControl();
            this.tpKho = new System.Windows.Forms.TabPage();
            this.tpNguyenLieu = new System.Windows.Forms.TabPage();
            this.dataKho = new System.Windows.Forms.DataGridView();
            this.dataNguyenLieu = new System.Windows.Forms.DataGridView();
            this.tabKho.SuspendLayout();
            this.tpKho.SuspendLayout();
            this.tpNguyenLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNguyenLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // tabKho
            // 
            this.tabKho.Controls.Add(this.tpKho);
            this.tabKho.Controls.Add(this.tpNguyenLieu);
            this.tabKho.Location = new System.Drawing.Point(12, 12);
            this.tabKho.Name = "tabKho";
            this.tabKho.SelectedIndex = 0;
            this.tabKho.Size = new System.Drawing.Size(456, 260);
            this.tabKho.TabIndex = 4;
            // 
            // tpKho
            // 
            this.tpKho.Controls.Add(this.dataKho);
            this.tpKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpKho.Location = new System.Drawing.Point(4, 22);
            this.tpKho.Name = "tpKho";
            this.tpKho.Padding = new System.Windows.Forms.Padding(3);
            this.tpKho.Size = new System.Drawing.Size(448, 234);
            this.tpKho.TabIndex = 1;
            this.tpKho.Text = "Kho";
            this.tpKho.UseVisualStyleBackColor = true;
            // 
            // tpNguyenLieu
            // 
            this.tpNguyenLieu.Controls.Add(this.dataNguyenLieu);
            this.tpNguyenLieu.Location = new System.Drawing.Point(4, 22);
            this.tpNguyenLieu.Name = "tpNguyenLieu";
            this.tpNguyenLieu.Padding = new System.Windows.Forms.Padding(3);
            this.tpNguyenLieu.Size = new System.Drawing.Size(448, 234);
            this.tpNguyenLieu.TabIndex = 6;
            this.tpNguyenLieu.Text = "Nguyên liệu";
            this.tpNguyenLieu.UseVisualStyleBackColor = true;
            // 
            // dataKho
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataKho.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataKho.Location = new System.Drawing.Point(6, 6);
            this.dataKho.Name = "dataKho";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataKho.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataKho.Size = new System.Drawing.Size(436, 222);
            this.dataKho.TabIndex = 0;
            // 
            // dataNguyenLieu
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataNguyenLieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataNguyenLieu.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataNguyenLieu.Location = new System.Drawing.Point(6, 6);
            this.dataNguyenLieu.Name = "dataNguyenLieu";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataNguyenLieu.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataNguyenLieu.Size = new System.Drawing.Size(433, 221);
            this.dataNguyenLieu.TabIndex = 1;
            // 
            // frmThongTinKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 281);
            this.Controls.Add(this.tabKho);
            this.Name = "frmThongTinKho";
            this.Text = "Thông tin kho";
            this.Load += new System.EventHandler(this.frmThongTinKho_Load);
            this.tabKho.ResumeLayout(false);
            this.tpKho.ResumeLayout(false);
            this.tpNguyenLieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNguyenLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabKho;
        private System.Windows.Forms.TabPage tpKho;
        private System.Windows.Forms.TabPage tpNguyenLieu;
        private System.Windows.Forms.DataGridView dataKho;
        private System.Windows.Forms.DataGridView dataNguyenLieu;
    }
}