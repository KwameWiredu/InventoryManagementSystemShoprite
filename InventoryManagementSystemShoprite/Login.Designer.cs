namespace InventoryManagementSystemShoprite
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.emaillbl = new System.Windows.Forms.Label();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shopritelbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.enterDetailslbl = new System.Windows.Forms.Label();
            this.showPasswordchk = new System.Windows.Forms.CheckBox();
            this.closepicbox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closepicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.closepicbox);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.shopritelbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 125);
            this.panel1.TabIndex = 0;
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(132, 321);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(292, 27);
            this.emailtxt.TabIndex = 1;
            this.emailtxt.TextChanged += new System.EventHandler(this.emailtxt_TextChanged);
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Location = new System.Drawing.Point(27, 328);
            this.emaillbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(62, 20);
            this.emaillbl.TabIndex = 2;
            this.emaillbl.Text = "Email:";
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Location = new System.Drawing.Point(27, 395);
            this.passwordlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(97, 20);
            this.passwordlbl.TabIndex = 4;
            this.passwordlbl.Text = "Password:";
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(132, 388);
            this.passwordtxt.Margin = new System.Windows.Forms.Padding(4);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(292, 27);
            this.passwordtxt.TabIndex = 3;
            this.passwordtxt.UseSystemPasswordChar = true;
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.Lime;
            this.loginbtn.FlatAppearance.BorderSize = 0;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Location = new System.Drawing.Point(287, 449);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(137, 43);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(162, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // shopritelbl
            // 
            this.shopritelbl.AutoSize = true;
            this.shopritelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopritelbl.Location = new System.Drawing.Point(138, 45);
            this.shopritelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shopritelbl.Name = "shopritelbl";
            this.shopritelbl.Size = new System.Drawing.Size(174, 36);
            this.shopritelbl.TabIndex = 7;
            this.shopritelbl.Text = "SHOPRITE";
            this.shopritelbl.Click += new System.EventHandler(this.shopritelbl_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // enterDetailslbl
            // 
            this.enterDetailslbl.AutoSize = true;
            this.enterDetailslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterDetailslbl.Location = new System.Drawing.Point(158, 271);
            this.enterDetailslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enterDetailslbl.Name = "enterDetailslbl";
            this.enterDetailslbl.Size = new System.Drawing.Size(150, 29);
            this.enterDetailslbl.TabIndex = 7;
            this.enterDetailslbl.Text = "Enter Details";
            // 
            // showPasswordchk
            // 
            this.showPasswordchk.AutoSize = true;
            this.showPasswordchk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPasswordchk.Location = new System.Drawing.Point(132, 468);
            this.showPasswordchk.Name = "showPasswordchk";
            this.showPasswordchk.Size = new System.Drawing.Size(138, 20);
            this.showPasswordchk.TabIndex = 8;
            this.showPasswordchk.Text = "Show Password";
            this.showPasswordchk.UseVisualStyleBackColor = true;
            this.showPasswordchk.CheckedChanged += new System.EventHandler(this.showPasswordchk_CheckedChanged);
            // 
            // closepicbox
            // 
            this.closepicbox.Image = ((System.Drawing.Image)(resources.GetObject("closepicbox.Image")));
            this.closepicbox.Location = new System.Drawing.Point(408, 0);
            this.closepicbox.Name = "closepicbox";
            this.closepicbox.Size = new System.Drawing.Size(31, 28);
            this.closepicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closepicbox.TabIndex = 8;
            this.closepicbox.TabStop = false;
            this.closepicbox.Click += new System.EventHandler(this.closepicbox_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 617);
            this.Controls.Add(this.showPasswordchk);
            this.Controls.Add(this.enterDetailslbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closepicbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label shopritelbl;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label enterDetailslbl;
        private System.Windows.Forms.CheckBox showPasswordchk;
        private System.Windows.Forms.PictureBox closepicbox;
    }
}

