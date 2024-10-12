namespace DATABASE
{
    partial class Form1
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
            this.lbwoman = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.lbpass = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.btlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbwoman
            // 
            this.lbwoman.AutoSize = true;
            this.lbwoman.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbwoman.Location = new System.Drawing.Point(12, 25);
            this.lbwoman.Name = "lbwoman";
            this.lbwoman.Size = new System.Drawing.Size(408, 72);
            this.lbwoman.TabIndex = 0;
            this.lbwoman.Text = "PINK WOMAN";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.Location = new System.Drawing.Point(61, 213);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(68, 26);
            this.lbname.TabIndex = 1;
            this.lbname.Text = "Name";
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpass.Location = new System.Drawing.Point(61, 251);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(53, 26);
            this.lbpass.TabIndex = 2;
            this.lbpass.Text = "Pass";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(157, 217);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(165, 22);
            this.tbname.TabIndex = 3;
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(157, 255);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(165, 22);
            this.tbpass.TabIndex = 4;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(61, 97);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(282, 30);
            this.lb1.TabIndex = 5;
            this.lb1.Text = "The world of all sisters";
            // 
            // btlogin
            // 
            this.btlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlogin.Location = new System.Drawing.Point(176, 308);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(75, 31);
            this.btlogin.TabIndex = 6;
            this.btlogin.Text = "Login";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DATABASE.Properties.Resources.ee33ba62_8ac3_46af_a619_8601aa0e14a1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lbpass);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.lbwoman);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbwoman;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbpass;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btlogin;
    }
}

