namespace Transaction_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.list_bttn = new System.Windows.Forms.Button();
            this.sell_bttn = new System.Windows.Forms.Button();
            this.price_txtbox = new System.Windows.Forms.TextBox();
            this.customer_combobox = new System.Windows.Forms.ComboBox();
            this.personnel_combobox = new System.Windows.Forms.ComboBox();
            this.product_combobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.updatelist_bttn = new System.Windows.Forms.Button();
            this.purchasePrice_txtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.productadd_bttn = new System.Windows.Forms.Button();
            this.sellingPrice_txtbox = new System.Windows.Forms.TextBox();
            this.stock_txtbox = new System.Windows.Forms.TextBox();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.updateCustomer_bttn = new System.Windows.Forms.Button();
            this.customeradd_bttn = new System.Windows.Forms.Button();
            this.customername_txtbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.updatePersonnel_bttn = new System.Windows.Forms.Button();
            this.personneladd_bttn = new System.Windows.Forms.Button();
            this.personnelname_txtbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.exit_bttn = new System.Windows.Forms.Button();
            this.clear_bttn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(376, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction Record";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(605, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(386, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales Application";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.list_bttn);
            this.groupBox2.Controls.Add(this.sell_bttn);
            this.groupBox2.Controls.Add(this.price_txtbox);
            this.groupBox2.Controls.Add(this.customer_combobox);
            this.groupBox2.Controls.Add(this.personnel_combobox);
            this.groupBox2.Controls.Add(this.product_combobox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 257);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Sale";
            // 
            // list_bttn
            // 
            this.list_bttn.Location = new System.Drawing.Point(189, 200);
            this.list_bttn.Name = "list_bttn";
            this.list_bttn.Size = new System.Drawing.Size(133, 34);
            this.list_bttn.TabIndex = 9;
            this.list_bttn.Text = "List";
            this.list_bttn.UseVisualStyleBackColor = true;
            this.list_bttn.Click += new System.EventHandler(this.list_bttn_Click);
            // 
            // sell_bttn
            // 
            this.sell_bttn.Location = new System.Drawing.Point(38, 200);
            this.sell_bttn.Name = "sell_bttn";
            this.sell_bttn.Size = new System.Drawing.Size(133, 34);
            this.sell_bttn.TabIndex = 8;
            this.sell_bttn.Text = "Sell";
            this.sell_bttn.UseVisualStyleBackColor = true;
            this.sell_bttn.Click += new System.EventHandler(this.sell_bttn_Click);
            // 
            // price_txtbox
            // 
            this.price_txtbox.Location = new System.Drawing.Point(127, 163);
            this.price_txtbox.Name = "price_txtbox";
            this.price_txtbox.Size = new System.Drawing.Size(195, 27);
            this.price_txtbox.TabIndex = 7;
            // 
            // customer_combobox
            // 
            this.customer_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customer_combobox.FormattingEnabled = true;
            this.customer_combobox.Location = new System.Drawing.Point(127, 119);
            this.customer_combobox.Name = "customer_combobox";
            this.customer_combobox.Size = new System.Drawing.Size(195, 27);
            this.customer_combobox.TabIndex = 6;
            // 
            // personnel_combobox
            // 
            this.personnel_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.personnel_combobox.FormattingEnabled = true;
            this.personnel_combobox.Location = new System.Drawing.Point(127, 75);
            this.personnel_combobox.Name = "personnel_combobox";
            this.personnel_combobox.Size = new System.Drawing.Size(195, 27);
            this.personnel_combobox.TabIndex = 5;
            // 
            // product_combobox
            // 
            this.product_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.product_combobox.FormattingEnabled = true;
            this.product_combobox.Location = new System.Drawing.Point(127, 32);
            this.product_combobox.Name = "product_combobox";
            this.product_combobox.Size = new System.Drawing.Size(195, 27);
            this.product_combobox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Price: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Customer: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Personnel: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.updatelist_bttn);
            this.groupBox3.Controls.Add(this.purchasePrice_txtbox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.productadd_bttn);
            this.groupBox3.Controls.Add(this.sellingPrice_txtbox);
            this.groupBox3.Controls.Add(this.stock_txtbox);
            this.groupBox3.Controls.Add(this.name_txtbox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 345);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 240);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "New Product";
            // 
            // updatelist_bttn
            // 
            this.updatelist_bttn.Location = new System.Drawing.Point(189, 191);
            this.updatelist_bttn.Name = "updatelist_bttn";
            this.updatelist_bttn.Size = new System.Drawing.Size(133, 34);
            this.updatelist_bttn.TabIndex = 13;
            this.updatelist_bttn.Text = "Update List";
            this.updatelist_bttn.UseVisualStyleBackColor = true;
            this.updatelist_bttn.Click += new System.EventHandler(this.updatelist_bttn_Click);
            // 
            // purchasePrice_txtbox
            // 
            this.purchasePrice_txtbox.Location = new System.Drawing.Point(154, 109);
            this.purchasePrice_txtbox.Name = "purchasePrice_txtbox";
            this.purchasePrice_txtbox.Size = new System.Drawing.Size(195, 27);
            this.purchasePrice_txtbox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Purchasing Price: ";
            // 
            // productadd_bttn
            // 
            this.productadd_bttn.Location = new System.Drawing.Point(40, 191);
            this.productadd_bttn.Name = "productadd_bttn";
            this.productadd_bttn.Size = new System.Drawing.Size(133, 34);
            this.productadd_bttn.TabIndex = 8;
            this.productadd_bttn.Text = "Add";
            this.productadd_bttn.UseVisualStyleBackColor = true;
            this.productadd_bttn.Click += new System.EventHandler(this.productadd_bttn_Click);
            // 
            // sellingPrice_txtbox
            // 
            this.sellingPrice_txtbox.Location = new System.Drawing.Point(154, 147);
            this.sellingPrice_txtbox.Name = "sellingPrice_txtbox";
            this.sellingPrice_txtbox.Size = new System.Drawing.Size(195, 27);
            this.sellingPrice_txtbox.TabIndex = 9;
            // 
            // stock_txtbox
            // 
            this.stock_txtbox.Location = new System.Drawing.Point(154, 70);
            this.stock_txtbox.Name = "stock_txtbox";
            this.stock_txtbox.Size = new System.Drawing.Size(195, 27);
            this.stock_txtbox.TabIndex = 8;
            // 
            // name_txtbox
            // 
            this.name_txtbox.Location = new System.Drawing.Point(154, 32);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(195, 27);
            this.name_txtbox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Selling Price: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Stock: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Name: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.updateCustomer_bttn);
            this.groupBox4.Controls.Add(this.customeradd_bttn);
            this.groupBox4.Controls.Add(this.customername_txtbox);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(396, 345);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(378, 120);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "New Customer";
            // 
            // updateCustomer_bttn
            // 
            this.updateCustomer_bttn.Location = new System.Drawing.Point(200, 66);
            this.updateCustomer_bttn.Name = "updateCustomer_bttn";
            this.updateCustomer_bttn.Size = new System.Drawing.Size(133, 34);
            this.updateCustomer_bttn.TabIndex = 9;
            this.updateCustomer_bttn.Text = "Update List";
            this.updateCustomer_bttn.UseVisualStyleBackColor = true;
            this.updateCustomer_bttn.Click += new System.EventHandler(this.updateCustomer_bttn_Click);
            // 
            // customeradd_bttn
            // 
            this.customeradd_bttn.Location = new System.Drawing.Point(61, 66);
            this.customeradd_bttn.Name = "customeradd_bttn";
            this.customeradd_bttn.Size = new System.Drawing.Size(133, 34);
            this.customeradd_bttn.TabIndex = 8;
            this.customeradd_bttn.Text = "Add";
            this.customeradd_bttn.UseVisualStyleBackColor = true;
            this.customeradd_bttn.Click += new System.EventHandler(this.customeradd_bttn_Click);
            // 
            // customername_txtbox
            // 
            this.customername_txtbox.Location = new System.Drawing.Point(154, 32);
            this.customername_txtbox.Name = "customername_txtbox";
            this.customername_txtbox.Size = new System.Drawing.Size(195, 27);
            this.customername_txtbox.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(57, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Full Name: ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.updatePersonnel_bttn);
            this.groupBox5.Controls.Add(this.personneladd_bttn);
            this.groupBox5.Controls.Add(this.personnelname_txtbox);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(396, 471);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(378, 114);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "New Personnel";
            // 
            // updatePersonnel_bttn
            // 
            this.updatePersonnel_bttn.Location = new System.Drawing.Point(200, 64);
            this.updatePersonnel_bttn.Name = "updatePersonnel_bttn";
            this.updatePersonnel_bttn.Size = new System.Drawing.Size(133, 34);
            this.updatePersonnel_bttn.TabIndex = 9;
            this.updatePersonnel_bttn.Text = "Update List";
            this.updatePersonnel_bttn.UseVisualStyleBackColor = true;
            this.updatePersonnel_bttn.Click += new System.EventHandler(this.updatePersonnel_bttn_Click);
            // 
            // personneladd_bttn
            // 
            this.personneladd_bttn.Location = new System.Drawing.Point(61, 64);
            this.personneladd_bttn.Name = "personneladd_bttn";
            this.personneladd_bttn.Size = new System.Drawing.Size(133, 34);
            this.personneladd_bttn.TabIndex = 8;
            this.personneladd_bttn.Text = "Add";
            this.personneladd_bttn.UseVisualStyleBackColor = true;
            this.personneladd_bttn.Click += new System.EventHandler(this.personneladd_bttn_Click);
            // 
            // personnelname_txtbox
            // 
            this.personnelname_txtbox.Location = new System.Drawing.Point(154, 29);
            this.personnelname_txtbox.Name = "personnelname_txtbox";
            this.personnelname_txtbox.Size = new System.Drawing.Size(195, 27);
            this.personnelname_txtbox.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Full Name: ";
            // 
            // exit_bttn
            // 
            this.exit_bttn.Location = new System.Drawing.Point(791, 478);
            this.exit_bttn.Name = "exit_bttn";
            this.exit_bttn.Size = new System.Drawing.Size(192, 38);
            this.exit_bttn.TabIndex = 7;
            this.exit_bttn.Text = "Exit";
            this.exit_bttn.UseVisualStyleBackColor = true;
            this.exit_bttn.Click += new System.EventHandler(this.exit_bttn_Click);
            // 
            // clear_bttn
            // 
            this.clear_bttn.Location = new System.Drawing.Point(791, 427);
            this.clear_bttn.Name = "clear_bttn";
            this.clear_bttn.Size = new System.Drawing.Size(192, 38);
            this.clear_bttn.TabIndex = 8;
            this.clear_bttn.Text = "Clear";
            this.clear_bttn.UseVisualStyleBackColor = true;
            this.clear_bttn.Click += new System.EventHandler(this.clear_bttn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 64);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 64);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(621, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(354, 64);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(999, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clear_bttn);
            this.Controls.Add(this.exit_bttn);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button list_bttn;
        private System.Windows.Forms.Button sell_bttn;
        private System.Windows.Forms.TextBox price_txtbox;
        private System.Windows.Forms.ComboBox customer_combobox;
        private System.Windows.Forms.ComboBox personnel_combobox;
        private System.Windows.Forms.ComboBox product_combobox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox purchasePrice_txtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button productadd_bttn;
        private System.Windows.Forms.TextBox sellingPrice_txtbox;
        private System.Windows.Forms.TextBox stock_txtbox;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button customeradd_bttn;
        private System.Windows.Forms.TextBox customername_txtbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button personneladd_bttn;
        private System.Windows.Forms.TextBox personnelname_txtbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button exit_bttn;
        private System.Windows.Forms.Button updatelist_bttn;
        private System.Windows.Forms.Button updateCustomer_bttn;
        private System.Windows.Forms.Button updatePersonnel_bttn;
        private System.Windows.Forms.Button clear_bttn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

