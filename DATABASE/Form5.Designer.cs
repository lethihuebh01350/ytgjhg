namespace DATABASE
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.dgvgridview = new System.Windows.Forms.DataGridView();
            this.FromFile = new System.Windows.Forms.DataGridViewImageColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hueDataSet = new DATABASE.hueDataSet();
            this.btadd = new System.Windows.Forms.Button();
            this.btedit = new System.Windows.Forms.Button();
            this.btclear = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btformfile = new System.Windows.Forms.Button();
            this.tbformfile = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tbtotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbquantity = new System.Windows.Forms.TextBox();
            this.lbquantity = new System.Windows.Forms.Label();
            this.tbprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textnameproduct = new System.Windows.Forms.TextBox();
            this.lbproductName = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btsearch = new System.Windows.Forms.Button();
            this.textboxsearch = new System.Windows.Forms.TextBox();
            this.productsTableAdapter = new DATABASE.hueDataSetTableAdapters.ProductsTableAdapter();
            this.btoutt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvgridview
            // 
            this.dgvgridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvgridview.AutoGenerateColumns = false;
            this.dgvgridview.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FromFile,
            this.ProductName,
            this.category,
            this.price,
            this.quantity,
            this.total,
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.productImageDataGridViewImageColumn});
            this.dgvgridview.DataSource = this.productsBindingSource;
            this.dgvgridview.Location = new System.Drawing.Point(12, 87);
            this.dgvgridview.Name = "dgvgridview";
            this.dgvgridview.RowHeadersWidth = 51;
            this.dgvgridview.RowTemplate.Height = 24;
            this.dgvgridview.Size = new System.Drawing.Size(528, 351);
            this.dgvgridview.TabIndex = 0;
            this.dgvgridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvgridview_CellContentClick_1);
            // 
            // FromFile
            // 
            this.FromFile.Frozen = true;
            this.FromFile.HeaderText = "Image";
            this.FromFile.MinimumWidth = 6;
            this.FromFile.Name = "FromFile";
            this.FromFile.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FromFile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.FromFile.Width = 130;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductId";
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 125;
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.Width = 125;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 125;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.Width = 125;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.Width = 125;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // productImageDataGridViewImageColumn
            // 
            this.productImageDataGridViewImageColumn.DataPropertyName = "ProductImage";
            this.productImageDataGridViewImageColumn.HeaderText = "ProductImage";
            this.productImageDataGridViewImageColumn.MinimumWidth = 6;
            this.productImageDataGridViewImageColumn.Name = "productImageDataGridViewImageColumn";
            this.productImageDataGridViewImageColumn.Width = 125;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.hueDataSet;
            // 
            // hueDataSet
            // 
            this.hueDataSet.DataSetName = "hueDataSet";
            this.hueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btadd
            // 
            this.btadd.BackColor = System.Drawing.Color.MistyRose;
            this.btadd.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btadd.Location = new System.Drawing.Point(12, 25);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(96, 45);
            this.btadd.TabIndex = 1;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = false;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btedit
            // 
            this.btedit.BackColor = System.Drawing.Color.MistyRose;
            this.btedit.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btedit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btedit.Location = new System.Drawing.Point(124, 25);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(96, 45);
            this.btedit.TabIndex = 2;
            this.btedit.Text = "Edit";
            this.btedit.UseVisualStyleBackColor = false;
            // 
            // btclear
            // 
            this.btclear.BackColor = System.Drawing.Color.MistyRose;
            this.btclear.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btclear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btclear.Location = new System.Drawing.Point(236, 25);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(96, 45);
            this.btclear.TabIndex = 3;
            this.btclear.Text = "Clear";
            this.btclear.UseVisualStyleBackColor = false;
            this.btclear.Click += new System.EventHandler(this.btclear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.btformfile);
            this.groupBox1.Controls.Add(this.tbformfile);
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.tbtotal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbquantity);
            this.groupBox1.Controls.Add(this.lbquantity);
            this.groupBox1.Controls.Add(this.tbprice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textnameproduct);
            this.groupBox1.Controls.Add(this.lbproductName);
            this.groupBox1.Controls.Add(this.lbid);
            this.groupBox1.Controls.Add(this.textid);
            this.groupBox1.Location = new System.Drawing.Point(546, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 351);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btformfile
            // 
            this.btformfile.BackColor = System.Drawing.Color.MistyRose;
            this.btformfile.Font = new System.Drawing.Font("Microsoft Uighur", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btformfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btformfile.Location = new System.Drawing.Point(163, 123);
            this.btformfile.Name = "btformfile";
            this.btformfile.Size = new System.Drawing.Size(67, 32);
            this.btformfile.TabIndex = 12;
            this.btformfile.Text = "Upload File";
            this.btformfile.UseVisualStyleBackColor = false;
            // 
            // tbformfile
            // 
            this.tbformfile.Location = new System.Drawing.Point(10, 130);
            this.tbformfile.Name = "tbformfile";
            this.tbformfile.Size = new System.Drawing.Size(147, 22);
            this.tbformfile.TabIndex = 11;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(32, 21);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(194, 96);
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            // 
            // tbtotal
            // 
            this.tbtotal.Location = new System.Drawing.Point(97, 292);
            this.tbtotal.Name = "tbtotal";
            this.tbtotal.Size = new System.Drawing.Size(145, 22);
            this.tbtotal.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total:";
            // 
            // tbquantity
            // 
            this.tbquantity.Location = new System.Drawing.Point(97, 260);
            this.tbquantity.Name = "tbquantity";
            this.tbquantity.Size = new System.Drawing.Size(145, 22);
            this.tbquantity.TabIndex = 7;
            // 
            // lbquantity
            // 
            this.lbquantity.AutoSize = true;
            this.lbquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbquantity.Location = new System.Drawing.Point(6, 262);
            this.lbquantity.Name = "lbquantity";
            this.lbquantity.Size = new System.Drawing.Size(85, 20);
            this.lbquantity.TabIndex = 6;
            this.lbquantity.Text = "Quantity:";
            // 
            // tbprice
            // 
            this.tbprice.Location = new System.Drawing.Point(97, 228);
            this.tbprice.Name = "tbprice";
            this.tbprice.Size = new System.Drawing.Size(145, 22);
            this.tbprice.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Price:";
            // 
            // textnameproduct
            // 
            this.textnameproduct.Location = new System.Drawing.Point(97, 193);
            this.textnameproduct.Name = "textnameproduct";
            this.textnameproduct.Size = new System.Drawing.Size(145, 22);
            this.textnameproduct.TabIndex = 3;
            // 
            // lbproductName
            // 
            this.lbproductName.AutoSize = true;
            this.lbproductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbproductName.Location = new System.Drawing.Point(6, 195);
            this.lbproductName.Name = "lbproductName";
            this.lbproductName.Size = new System.Drawing.Size(63, 20);
            this.lbproductName.TabIndex = 2;
            this.lbproductName.Text = "Name:";
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbid.Location = new System.Drawing.Point(6, 160);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(34, 20);
            this.lbid.TabIndex = 1;
            this.lbid.Text = "ID:";
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(97, 158);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(147, 22);
            this.textid.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.btsearch);
            this.groupBox2.Controls.Add(this.textboxsearch);
            this.groupBox2.Location = new System.Drawing.Point(462, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 79);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btsearch
            // 
            this.btsearch.BackColor = System.Drawing.Color.MistyRose;
            this.btsearch.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btsearch.Location = new System.Drawing.Point(18, 21);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(94, 45);
            this.btsearch.TabIndex = 6;
            this.btsearch.Text = "Search";
            this.btsearch.UseVisualStyleBackColor = false;
            // 
            // textboxsearch
            // 
            this.textboxsearch.Location = new System.Drawing.Point(130, 34);
            this.textboxsearch.Name = "textboxsearch";
            this.textboxsearch.Size = new System.Drawing.Size(170, 22);
            this.textboxsearch.TabIndex = 11;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // btoutt
            // 
            this.btoutt.BackColor = System.Drawing.Color.MistyRose;
            this.btoutt.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoutt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btoutt.Location = new System.Drawing.Point(347, 25);
            this.btoutt.Name = "btoutt";
            this.btoutt.Size = new System.Drawing.Size(96, 45);
            this.btoutt.TabIndex = 6;
            this.btoutt.Text = "Out";
            this.btoutt.UseVisualStyleBackColor = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DATABASE.Properties.Resources._98ffb957671f891b46c7876e06354c15;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btoutt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btclear);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.dgvgridview);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvgridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvgridview;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Button btclear;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textnameproduct;
        private System.Windows.Forms.Label lbproductName;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox tbtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbquantity;
        private System.Windows.Forms.Label lbquantity;
        private System.Windows.Forms.TextBox tbprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.TextBox textboxsearch;
        private System.Windows.Forms.TextBox tbformfile;
        private System.Windows.Forms.Button btformfile;
        private hueDataSet hueDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private hueDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Button btoutt;
        private System.Windows.Forms.DataGridViewImageColumn FromFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn productImageDataGridViewImageColumn;
    }
}