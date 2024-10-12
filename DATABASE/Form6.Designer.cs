namespace DATABASE
{
    partial class Form6
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbprd = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.mot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btthongkesp = new System.Windows.Forms.Button();
            this.btthongkedoanhthu = new System.Windows.Forms.Button();
            this.btthongkeloinhuan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.MistyRose;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 54);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lbprd
            // 
            this.lbprd.AutoSize = true;
            this.lbprd.BackColor = System.Drawing.Color.MistyRose;
            this.lbprd.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprd.Location = new System.Drawing.Point(339, 18);
            this.lbprd.Name = "lbprd";
            this.lbprd.Size = new System.Drawing.Size(101, 24);
            this.lbprd.TabIndex = 5;
            this.lbprd.Text = "Statistics";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mot});
            this.dataGridView1.Location = new System.Drawing.Point(0, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hai});
            this.dataGridView2.Location = new System.Drawing.Point(283, 75);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 7;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ba});
            this.dataGridView3.Location = new System.Drawing.Point(555, 75);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(214, 150);
            this.dataGridView3.TabIndex = 8;
            // 
            // mot
            // 
            this.mot.HeaderText = " Hiển thị thống kê nhập khẩu sản phẩm";
            this.mot.MinimumWidth = 6;
            this.mot.Name = "mot";
            this.mot.Width = 125;
            // 
            // hai
            // 
            this.hai.HeaderText = "Hiển thị thống kê doanh thu";
            this.hai.MinimumWidth = 6;
            this.hai.Name = "hai";
            this.hai.Width = 125;
            // 
            // ba
            // 
            this.ba.HeaderText = "Hiển thị thống kê lợi nhuận";
            this.ba.MinimumWidth = 6;
            this.ba.Name = "ba";
            this.ba.Width = 125;
            // 
            // btthongkesp
            // 
            this.btthongkesp.Location = new System.Drawing.Point(83, 249);
            this.btthongkesp.Name = "btthongkesp";
            this.btthongkesp.Size = new System.Drawing.Size(157, 23);
            this.btthongkesp.TabIndex = 9;
            this.btthongkesp.Text = "thống kê sản phẩm";
            this.btthongkesp.UseVisualStyleBackColor = true;
            this.btthongkesp.Click += new System.EventHandler(this.btthongkesp_Click);
            // 
            // btthongkedoanhthu
            // 
            this.btthongkedoanhthu.Location = new System.Drawing.Point(328, 249);
            this.btthongkedoanhthu.Name = "btthongkedoanhthu";
            this.btthongkedoanhthu.Size = new System.Drawing.Size(157, 23);
            this.btthongkedoanhthu.TabIndex = 10;
            this.btthongkedoanhthu.Text = "thống kê doanh thu";
            this.btthongkedoanhthu.UseVisualStyleBackColor = true;
            this.btthongkedoanhthu.Click += new System.EventHandler(this.btthongkedoanhthu_Click);
            // 
            // btthongkeloinhuan
            // 
            this.btthongkeloinhuan.Location = new System.Drawing.Point(572, 249);
            this.btthongkeloinhuan.Name = "btthongkeloinhuan";
            this.btthongkeloinhuan.Size = new System.Drawing.Size(157, 23);
            this.btthongkeloinhuan.TabIndex = 11;
            this.btthongkeloinhuan.Text = "thống kê lợi nhuận";
            this.btthongkeloinhuan.UseVisualStyleBackColor = true;
            this.btthongkeloinhuan.Click += new System.EventHandler(this.btthongkeloinhuan_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DATABASE.Properties.Resources.mau_background_hong_nhat_trang_0122012101;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btthongkeloinhuan);
            this.Controls.Add(this.btthongkedoanhthu);
            this.Controls.Add(this.btthongkesp);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbprd);
            this.Controls.Add(this.listView1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lbprd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mot;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hai;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ba;
        private System.Windows.Forms.Button btthongkesp;
        private System.Windows.Forms.Button btthongkedoanhthu;
        private System.Windows.Forms.Button btthongkeloinhuan;
    }
}