namespace InventoryManagementSystemShoprite
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.attendantBtn2 = new InventoryManagementSystemShoprite.AttendantBtn();
            this.label4 = new System.Windows.Forms.Label();
            this.attendantBtn1 = new InventoryManagementSystemShoprite.AttendantBtn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.generalbtn = new InventoryManagementSystemShoprite.AttendantBtn();
            this.attendantBtn = new InventoryManagementSystemShoprite.AttendantBtn();
            this.productbtn = new InventoryManagementSystemShoprite.AttendantBtn();
            this.shopritelbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendantBtn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendantBtn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendantBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.attendantBtn2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.attendantBtn1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.generalbtn);
            this.panel1.Controls.Add(this.attendantBtn);
            this.panel1.Controls.Add(this.productbtn);
            this.panel1.Controls.Add(this.shopritelbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 111);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // attendantBtn2
            // 
            this.attendantBtn2.Image = ((System.Drawing.Image)(resources.GetObject("attendantBtn2.Image")));
            this.attendantBtn2.ImageHover = ((System.Drawing.Image)(resources.GetObject("attendantBtn2.ImageHover")));
            this.attendantBtn2.ImageNormal = ((System.Drawing.Image)(resources.GetObject("attendantBtn2.ImageNormal")));
            this.attendantBtn2.Location = new System.Drawing.Point(19, 54);
            this.attendantBtn2.Name = "attendantBtn2";
            this.attendantBtn2.Size = new System.Drawing.Size(44, 54);
            this.attendantBtn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.attendantBtn2.TabIndex = 17;
            this.attendantBtn2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Categories";
            // 
            // attendantBtn1
            // 
            this.attendantBtn1.Image = ((System.Drawing.Image)(resources.GetObject("attendantBtn1.Image")));
            this.attendantBtn1.ImageHover = ((System.Drawing.Image)(resources.GetObject("attendantBtn1.ImageHover")));
            this.attendantBtn1.ImageNormal = ((System.Drawing.Image)(resources.GetObject("attendantBtn1.ImageNormal")));
            this.attendantBtn1.Location = new System.Drawing.Point(572, 7);
            this.attendantBtn1.Name = "attendantBtn1";
            this.attendantBtn1.Size = new System.Drawing.Size(77, 77);
            this.attendantBtn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.attendantBtn1.TabIndex = 15;
            this.attendantBtn1.TabStop = false;
            this.attendantBtn1.Click += new System.EventHandler(this.attendantBtn1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(739, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "General";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Attendants";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Products";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // generalbtn
            // 
            this.generalbtn.Image = ((System.Drawing.Image)(resources.GetObject("generalbtn.Image")));
            this.generalbtn.ImageHover = ((System.Drawing.Image)(resources.GetObject("generalbtn.ImageHover")));
            this.generalbtn.ImageNormal = ((System.Drawing.Image)(resources.GetObject("generalbtn.ImageNormal")));
            this.generalbtn.Location = new System.Drawing.Point(731, 7);
            this.generalbtn.Name = "generalbtn";
            this.generalbtn.Size = new System.Drawing.Size(77, 77);
            this.generalbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.generalbtn.TabIndex = 11;
            this.generalbtn.TabStop = false;
            this.generalbtn.Click += new System.EventHandler(this.generalbtn_Click);
            // 
            // attendantBtn
            // 
            this.attendantBtn.Image = ((System.Drawing.Image)(resources.GetObject("attendantBtn.Image")));
            this.attendantBtn.ImageHover = ((System.Drawing.Image)(resources.GetObject("attendantBtn.ImageHover")));
            this.attendantBtn.ImageNormal = ((System.Drawing.Image)(resources.GetObject("attendantBtn.ImageNormal")));
            this.attendantBtn.Location = new System.Drawing.Point(413, 7);
            this.attendantBtn.Name = "attendantBtn";
            this.attendantBtn.Size = new System.Drawing.Size(77, 77);
            this.attendantBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.attendantBtn.TabIndex = 10;
            this.attendantBtn.TabStop = false;
            this.attendantBtn.Click += new System.EventHandler(this.attendantBtn2_Click);
            // 
            // productbtn
            // 
            this.productbtn.Image = ((System.Drawing.Image)(resources.GetObject("productbtn.Image")));
            this.productbtn.ImageHover = ((System.Drawing.Image)(resources.GetObject("productbtn.ImageHover")));
            this.productbtn.ImageNormal = ((System.Drawing.Image)(resources.GetObject("productbtn.ImageNormal")));
            this.productbtn.Location = new System.Drawing.Point(254, 7);
            this.productbtn.Name = "productbtn";
            this.productbtn.Size = new System.Drawing.Size(77, 77);
            this.productbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productbtn.TabIndex = 9;
            this.productbtn.TabStop = false;
            this.productbtn.Click += new System.EventHandler(this.productbtn_Click);
            // 
            // shopritelbl
            // 
            this.shopritelbl.AutoSize = true;
            this.shopritelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopritelbl.Location = new System.Drawing.Point(13, 26);
            this.shopritelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shopritelbl.Name = "shopritelbl";
            this.shopritelbl.Size = new System.Drawing.Size(174, 36);
            this.shopritelbl.TabIndex = 8;
            this.shopritelbl.Text = "SHOPRITE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 527);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 21);
            this.panel2.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 111);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(982, 416);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(982, 548);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendantBtn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendantBtn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendantBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productbtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label shopritelbl;
        private AttendantBtn productbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AttendantBtn generalbtn;
        private AttendantBtn attendantBtn;
        private System.Windows.Forms.Label label4;
        private AttendantBtn attendantBtn1;
        private AttendantBtn attendantBtn2;
    }
}