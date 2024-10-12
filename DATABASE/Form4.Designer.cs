namespace DATABASE
{
    partial class Form4
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
            this.lbEmployee = new System.Windows.Forms.Label();
            this.lbepl = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbid = new System.Windows.Forms.Label();
            this.lbnamee = new System.Windows.Forms.Label();
            this.lbbirth = new System.Windows.Forms.Label();
            this.lblocation = new System.Windows.Forms.Label();
            this.lbaddress = new System.Windows.Forms.Label();
            this.lbphonee = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btaddd = new System.Windows.Forms.Button();
            this.bteditt = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btoutt = new System.Windows.Forms.Button();
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
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lbEmployee
            // 
            this.lbEmployee.AutoSize = true;
            this.lbEmployee.BackColor = System.Drawing.Color.MistyRose;
            this.lbEmployee.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployee.Location = new System.Drawing.Point(332, 18);
            this.lbEmployee.Name = "lbEmployee";
            this.lbEmployee.Size = new System.Drawing.Size(0, 24);
            this.lbEmployee.TabIndex = 2;
            // 
            // lbepl
            // 
            this.lbepl.AutoSize = true;
            this.lbepl.BackColor = System.Drawing.Color.MistyRose;
            this.lbepl.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbepl.Location = new System.Drawing.Point(332, 18);
            this.lbepl.Name = "lbepl";
            this.lbepl.Size = new System.Drawing.Size(112, 24);
            this.lbepl.TabIndex = 3;
            this.lbepl.Text = "Employee";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.MistyRose;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.birth,
            this.location,
            this.address,
            this.phone});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 276);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(800, 174);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 80;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 150;
            // 
            // birth
            // 
            this.birth.Text = "Birth";
            this.birth.Width = 120;
            // 
            // location
            // 
            this.location.Text = "Location";
            this.location.Width = 120;
            // 
            // address
            // 
            this.address.Text = "Address";
            this.address.Width = 160;
            // 
            // phone
            // 
            this.phone.Text = "Phone";
            this.phone.Width = 170;
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbid.Location = new System.Drawing.Point(45, 74);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(28, 20);
            this.lbid.TabIndex = 5;
            this.lbid.Text = "ID";
            // 
            // lbnamee
            // 
            this.lbnamee.AutoSize = true;
            this.lbnamee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnamee.Location = new System.Drawing.Point(45, 121);
            this.lbnamee.Name = "lbnamee";
            this.lbnamee.Size = new System.Drawing.Size(57, 20);
            this.lbnamee.TabIndex = 6;
            this.lbnamee.Text = "Name";
            // 
            // lbbirth
            // 
            this.lbbirth.AutoSize = true;
            this.lbbirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbirth.Location = new System.Drawing.Point(45, 166);
            this.lbbirth.Name = "lbbirth";
            this.lbbirth.Size = new System.Drawing.Size(50, 20);
            this.lbbirth.TabIndex = 7;
            this.lbbirth.Text = "Birth";
            // 
            // lblocation
            // 
            this.lblocation.AutoSize = true;
            this.lblocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblocation.Location = new System.Drawing.Point(375, 74);
            this.lblocation.Name = "lblocation";
            this.lblocation.Size = new System.Drawing.Size(81, 20);
            this.lblocation.TabIndex = 8;
            this.lblocation.Text = "Location";
            // 
            // lbaddress
            // 
            this.lbaddress.AutoSize = true;
            this.lbaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaddress.Location = new System.Drawing.Point(378, 121);
            this.lbaddress.Name = "lbaddress";
            this.lbaddress.Size = new System.Drawing.Size(78, 20);
            this.lbaddress.TabIndex = 9;
            this.lbaddress.Text = "Address";
            // 
            // lbphonee
            // 
            this.lbphonee.AutoSize = true;
            this.lbphonee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbphonee.Location = new System.Drawing.Point(383, 164);
            this.lbphonee.Name = "lbphonee";
            this.lbphonee.Size = new System.Drawing.Size(61, 20);
            this.lbphonee.TabIndex = 10;
            this.lbphonee.Text = "Phone";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 22);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 22);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(117, 166);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 22);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(481, 74);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(151, 22);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(481, 119);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(151, 22);
            this.textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(481, 164);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(151, 22);
            this.textBox6.TabIndex = 16;
            // 
            // btaddd
            // 
            this.btaddd.BackColor = System.Drawing.Color.Snow;
            this.btaddd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btaddd.Location = new System.Drawing.Point(205, 223);
            this.btaddd.Name = "btaddd";
            this.btaddd.Size = new System.Drawing.Size(70, 28);
            this.btaddd.TabIndex = 17;
            this.btaddd.Text = "Add";
            this.btaddd.UseVisualStyleBackColor = false;
            // 
            // bteditt
            // 
            this.bteditt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteditt.Location = new System.Drawing.Point(300, 223);
            this.bteditt.Name = "bteditt";
            this.bteditt.Size = new System.Drawing.Size(73, 28);
            this.bteditt.TabIndex = 18;
            this.bteditt.Text = "Edit";
            this.bteditt.UseVisualStyleBackColor = true;
            // 
            // btdelete
            // 
            this.btdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdelete.Location = new System.Drawing.Point(398, 223);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(77, 28);
            this.btdelete.TabIndex = 19;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            // 
            // btoutt
            // 
            this.btoutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoutt.Location = new System.Drawing.Point(499, 223);
            this.btoutt.Name = "btoutt";
            this.btoutt.Size = new System.Drawing.Size(77, 28);
            this.btoutt.TabIndex = 20;
            this.btoutt.Text = "Out";
            this.btoutt.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DATABASE.Properties.Resources._98ffb957671f891b46c7876e06354c15;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btoutt);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.bteditt);
            this.Controls.Add(this.btaddd);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbphonee);
            this.Controls.Add(this.lbaddress);
            this.Controls.Add(this.lblocation);
            this.Controls.Add(this.lbbirth);
            this.Controls.Add(this.lbnamee);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.lbepl);
            this.Controls.Add(this.lbEmployee);
            this.Controls.Add(this.listView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lbEmployee;
        private System.Windows.Forms.Label lbepl;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader birth;
        private System.Windows.Forms.ColumnHeader location;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Label lbnamee;
        private System.Windows.Forms.Label lbbirth;
        private System.Windows.Forms.Label lblocation;
        private System.Windows.Forms.Label lbaddress;
        private System.Windows.Forms.Label lbphonee;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btaddd;
        private System.Windows.Forms.Button bteditt;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btoutt;
    }
}