namespace DATABASE
{
    partial class Form3
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
            this.lbcustomer = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchases = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbPhone = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.lbpoint = new System.Windows.Forms.Label();
            this.lbpurchases = new System.Windows.Forms.Label();
            this.tbpoint = new System.Windows.Forms.TextBox();
            this.tbpurchases = new System.Windows.Forms.TextBox();
            this.btadd = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.lbproductcode = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lbtotal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btmuiten = new System.Windows.Forms.Button();
            this.btedit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lbcustomer
            // 
            this.lbcustomer.AutoSize = true;
            this.lbcustomer.BackColor = System.Drawing.Color.MistyRose;
            this.lbcustomer.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcustomer.Location = new System.Drawing.Point(316, 18);
            this.lbcustomer.Name = "lbcustomer";
            this.lbcustomer.Size = new System.Drawing.Size(118, 24);
            this.lbcustomer.TabIndex = 1;
            this.lbcustomer.Text = "Customers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Phone,
            this.Name,
            this.Point,
            this.Purchases});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 170);
            this.dataGridView1.TabIndex = 2;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.Width = 210;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 200;
            // 
            // Point
            // 
            this.Point.HeaderText = "Point";
            this.Point.MinimumWidth = 6;
            this.Point.Name = "Point";
            this.Point.Width = 170;
            // 
            // Purchases
            // 
            this.Purchases.HeaderText = "Purchases";
            this.Purchases.MinimumWidth = 6;
            this.Purchases.Name = "Purchases";
            this.Purchases.Width = 170;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(445, 84);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(67, 22);
            this.lbPhone.TabIndex = 3;
            this.lbPhone.Text = "Phone";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(561, 84);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(146, 22);
            this.tbPhone.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(561, 112);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(146, 22);
            this.tbname.TabIndex = 6;
            // 
            // lbpoint
            // 
            this.lbpoint.AutoSize = true;
            this.lbpoint.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpoint.Location = new System.Drawing.Point(445, 151);
            this.lbpoint.Name = "lbpoint";
            this.lbpoint.Size = new System.Drawing.Size(60, 22);
            this.lbpoint.TabIndex = 7;
            this.lbpoint.Text = "Point";
            // 
            // lbpurchases
            // 
            this.lbpurchases.AutoSize = true;
            this.lbpurchases.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpurchases.Location = new System.Drawing.Point(446, 184);
            this.lbpurchases.Name = "lbpurchases";
            this.lbpurchases.Size = new System.Drawing.Size(100, 22);
            this.lbpurchases.TabIndex = 8;
            this.lbpurchases.Text = "Purchases";
            // 
            // tbpoint
            // 
            this.tbpoint.Location = new System.Drawing.Point(561, 151);
            this.tbpoint.Name = "tbpoint";
            this.tbpoint.Size = new System.Drawing.Size(146, 22);
            this.tbpoint.TabIndex = 9;
            // 
            // tbpurchases
            // 
            this.tbpurchases.Location = new System.Drawing.Point(561, 184);
            this.tbpurchases.Name = "tbpurchases";
            this.tbpurchases.Size = new System.Drawing.Size(146, 22);
            this.tbpurchases.TabIndex = 10;
            // 
            // btadd
            // 
            this.btadd.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadd.Location = new System.Drawing.Point(430, 227);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(75, 31);
            this.btadd.TabIndex = 11;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            // 
            // btexit
            // 
            this.btexit.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexit.Location = new System.Drawing.Point(597, 227);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(75, 31);
            this.btexit.TabIndex = 12;
            this.btexit.Text = "Exit";
            this.btexit.UseVisualStyleBackColor = true;
            // 
            // lbproductcode
            // 
            this.lbproductcode.AutoSize = true;
            this.lbproductcode.BackColor = System.Drawing.Color.White;
            this.lbproductcode.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbproductcode.Location = new System.Drawing.Point(33, 82);
            this.lbproductcode.Name = "lbproductcode";
            this.lbproductcode.Size = new System.Drawing.Size(35, 22);
            this.lbproductcode.TabIndex = 13;
            this.lbproductcode.Text = "ID";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "M01",
            "M02",
            "M03",
            "M04",
            "M05",
            "M06",
            "M07",
            "M08",
            "M09",
            "M010",
            "M011",
            "M012",
            "M013",
            "M014",
            "M015",
            "M016",
            "M017",
            "M018"});
            this.checkedListBox1.Location = new System.Drawing.Point(120, 84);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(169, 106);
            this.checkedListBox1.TabIndex = 15;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotal.Location = new System.Drawing.Point(33, 215);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(57, 22);
            this.lbtotal.TabIndex = 16;
            this.lbtotal.Text = "Total";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 215);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 22);
            this.textBox1.TabIndex = 17;
            // 
            // btmuiten
            // 
            this.btmuiten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmuiten.Location = new System.Drawing.Point(320, 215);
            this.btmuiten.Name = "btmuiten";
            this.btmuiten.Size = new System.Drawing.Size(44, 22);
            this.btmuiten.TabIndex = 18;
            this.btmuiten.Text = "=>";
            this.btmuiten.UseVisualStyleBackColor = true;
            // 
            // btedit
            // 
            this.btedit.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btedit.Location = new System.Drawing.Point(516, 227);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(75, 31);
            this.btedit.TabIndex = 19;
            this.btedit.Text = "Edit";
            this.btedit.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DATABASE.Properties.Resources._98ffb957671f891b46c7876e06354c15;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.btmuiten);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbtotal);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lbproductcode);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.tbpurchases);
            this.Controls.Add(this.tbpoint);
            this.Controls.Add(this.lbpurchases);
            this.Controls.Add(this.lbpoint);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbcustomer);
            this.Controls.Add(this.listView1);
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lbcustomer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Point;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchases;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label lbpoint;
        private System.Windows.Forms.Label lbpurchases;
        private System.Windows.Forms.TextBox tbpoint;
        private System.Windows.Forms.TextBox tbpurchases;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Label lbproductcode;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btmuiten;
        private System.Windows.Forms.Button btedit;
    }
}