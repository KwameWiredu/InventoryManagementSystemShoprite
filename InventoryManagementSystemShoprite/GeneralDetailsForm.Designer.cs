namespace InventoryManagementSystemShoprite
{
    partial class GeneralDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralDetailsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closepicbox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.generalidlbl = new System.Windows.Forms.Label();
            this.quantitynud = new System.Windows.Forms.NumericUpDown();
            this.clearbtn = new System.Windows.Forms.Button();
            this.insertbtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.generaldate = new System.Windows.Forms.DateTimePicker();
            this.productnametxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.productidtxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productsearchtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productdgv = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closepicbox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantitynud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productdgv)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(888, 87);
            this.panel1.TabIndex = 1;
            // 
            // closepicbox
            // 
            this.closepicbox.Image = ((System.Drawing.Image)(resources.GetObject("closepicbox.Image")));
            this.closepicbox.Location = new System.Drawing.Point(854, 3);
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
            this.label2.Size = new System.Drawing.Size(169, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Order Details";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.generalidlbl);
            this.panel2.Controls.Add(this.quantitynud);
            this.panel2.Controls.Add(this.clearbtn);
            this.panel2.Controls.Add(this.insertbtn);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.generaldate);
            this.panel2.Controls.Add(this.productnametxt);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.totaltxt);
            this.panel2.Controls.Add(this.pricetxt);
            this.panel2.Controls.Add(this.productidtxt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.productsearchtxt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.productdgv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(888, 605);
            this.panel2.TabIndex = 2;
            // 
            // generalidlbl
            // 
            this.generalidlbl.AutoSize = true;
            this.generalidlbl.Location = new System.Drawing.Point(13, 574);
            this.generalidlbl.Name = "generalidlbl";
            this.generalidlbl.Size = new System.Drawing.Size(69, 20);
            this.generalidlbl.TabIndex = 26;
            this.generalidlbl.Text = "label10";
            this.generalidlbl.Visible = false;
            // 
            // quantitynud
            // 
            this.quantitynud.Location = new System.Drawing.Point(669, 459);
            this.quantitynud.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quantitynud.Name = "quantitynud";
            this.quantitynud.Size = new System.Drawing.Size(167, 27);
            this.quantitynud.TabIndex = 25;
            this.quantitynud.ValueChanged += new System.EventHandler(this.quantitynud_ValueChanged);
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.Green;
            this.clearbtn.FlatAppearance.BorderSize = 0;
            this.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.Location = new System.Drawing.Point(713, 547);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(121, 47);
            this.clearbtn.TabIndex = 23;
            this.clearbtn.Text = "CLEAR";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // insertbtn
            // 
            this.insertbtn.BackColor = System.Drawing.Color.Yellow;
            this.insertbtn.FlatAppearance.BorderSize = 0;
            this.insertbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertbtn.Location = new System.Drawing.Point(565, 547);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(121, 47);
            this.insertbtn.TabIndex = 22;
            this.insertbtn.Text = "INSERT";
            this.insertbtn.UseVisualStyleBackColor = false;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 509);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Date:";
            // 
            // generaldate
            // 
            this.generaldate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generaldate.CustomFormat = "dd/MM/yyyy";
            this.generaldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generaldate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.generaldate.Location = new System.Drawing.Point(17, 532);
            this.generaldate.Name = "generaldate";
            this.generaldate.Size = new System.Drawing.Size(200, 27);
            this.generaldate.TabIndex = 20;
            this.generaldate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // productnametxt
            // 
            this.productnametxt.Location = new System.Drawing.Point(16, 466);
            this.productnametxt.Name = "productnametxt";
            this.productnametxt.Size = new System.Drawing.Size(237, 27);
            this.productnametxt.TabIndex = 19;
            this.productnametxt.TextChanged += new System.EventHandler(this.productnametxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Product Name :";
            // 
            // totaltxt
            // 
            this.totaltxt.Location = new System.Drawing.Point(669, 505);
            this.totaltxt.MaxLength = 327670;
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.Size = new System.Drawing.Size(167, 27);
            this.totaltxt.TabIndex = 17;
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(669, 411);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(167, 27);
            this.pricetxt.TabIndex = 15;
            // 
            // productidtxt
            // 
            this.productidtxt.Location = new System.Drawing.Point(16, 392);
            this.productidtxt.Name = "productidtxt";
            this.productidtxt.Size = new System.Drawing.Size(237, 27);
            this.productidtxt.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(582, 508);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(582, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Quantity :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(582, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Product ID :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Search Box :";
            // 
            // productsearchtxt
            // 
            this.productsearchtxt.Location = new System.Drawing.Point(422, 294);
            this.productsearchtxt.Name = "productsearchtxt";
            this.productsearchtxt.Size = new System.Drawing.Size(454, 27);
            this.productsearchtxt.TabIndex = 8;
            this.productsearchtxt.TextChanged += new System.EventHandler(this.productsearchtxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Products";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // productdgv
            // 
            this.productdgv.AllowUserToAddRows = false;
            this.productdgv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productdgv.ColumnHeadersHeight = 30;
            this.productdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Price,
            this.Column4,
            this.Column5});
            this.productdgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.productdgv.EnableHeadersVisualStyles = false;
            this.productdgv.Location = new System.Drawing.Point(0, 0);
            this.productdgv.Name = "productdgv";
            this.productdgv.RowHeadersVisible = false;
            this.productdgv.RowHeadersWidth = 51;
            this.productdgv.RowTemplate.Height = 24;
            this.productdgv.Size = new System.Drawing.Size(888, 288);
            this.productdgv.TabIndex = 6;
            this.productdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productdgv_CellClick);
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "SSN";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 75;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Product ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 128;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 86;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 108;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 82;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Description";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Category";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 113;
            // 
            // GeneralDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 692);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GeneralDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneralDetailsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closepicbox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantitynud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closepicbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox productsearchtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView productdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button clearbtn;
        public System.Windows.Forms.Button insertbtn;
        public System.Windows.Forms.Label generalidlbl;
        public System.Windows.Forms.TextBox pricetxt;
        public System.Windows.Forms.DateTimePicker generaldate;
        public System.Windows.Forms.TextBox productidtxt;
        public System.Windows.Forms.TextBox totaltxt;
        public System.Windows.Forms.TextBox productnametxt;
        public System.Windows.Forms.NumericUpDown quantitynud;
    }
}