namespace InventoryManagementSystemShoprite
{
    partial class CategoryDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryDetailsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.closepicbox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updatebtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.sectiontxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.catIDlbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closepicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.closepicbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 87);
            this.panel1.TabIndex = 14;
            // 
            // closepicbox
            // 
            this.closepicbox.Image = ((System.Drawing.Image)(resources.GetObject("closepicbox.Image")));
            this.closepicbox.Location = new System.Drawing.Point(741, 1);
            this.closepicbox.Name = "closepicbox";
            this.closepicbox.Size = new System.Drawing.Size(31, 28);
            this.closepicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closepicbox.TabIndex = 12;
            this.closepicbox.TabStop = false;
            this.closepicbox.Click += new System.EventHandler(this.closepicbox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category Details";
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.Red;
            this.updatebtn.FlatAppearance.BorderSize = 0;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(292, 226);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(121, 47);
            this.updatebtn.TabIndex = 25;
            this.updatebtn.Text = "UPDATE";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.Green;
            this.clearbtn.FlatAppearance.BorderSize = 0;
            this.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.Location = new System.Drawing.Point(588, 226);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(121, 47);
            this.clearbtn.TabIndex = 24;
            this.clearbtn.Text = "CLEAR";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.Yellow;
            this.savebtn.FlatAppearance.BorderSize = 0;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.Location = new System.Drawing.Point(440, 226);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(121, 47);
            this.savebtn.TabIndex = 23;
            this.savebtn.Text = "SAVE";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // sectiontxt
            // 
            this.sectiontxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectiontxt.Location = new System.Drawing.Point(237, 176);
            this.sectiontxt.Name = "sectiontxt";
            this.sectiontxt.Size = new System.Drawing.Size(472, 27);
            this.sectiontxt.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Section No. :";
            // 
            // nametxt
            // 
            this.nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(237, 126);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(472, 27);
            this.nametxt.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Name :";
            // 
            // catIDlbl
            // 
            this.catIDlbl.AutoSize = true;
            this.catIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catIDlbl.Location = new System.Drawing.Point(56, 239);
            this.catIDlbl.Name = "catIDlbl";
            this.catIDlbl.Size = new System.Drawing.Size(109, 20);
            this.catIDlbl.TabIndex = 26;
            this.catIDlbl.Text = "Category ID";
            // 
            // CategoryDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 311);
            this.Controls.Add(this.catIDlbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.sectiontxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CategoryDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryDetailsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closepicbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closepicbox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button updatebtn;
        public System.Windows.Forms.Button clearbtn;
        public System.Windows.Forms.Button savebtn;
        public System.Windows.Forms.TextBox sectiontxt;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label catIDlbl;
    }
}