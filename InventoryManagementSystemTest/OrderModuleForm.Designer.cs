namespace InventoryManagementSystemTest
{
    partial class OrderModuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderModuleForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcustname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcustid = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtsearchcust = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dvgcustomers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsearchproduct = new System.Windows.Forms.TextBox();
            this.dvgproduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.btnorderclear = new System.Windows.Forms.Button();
            this.btnorderinsert = new System.Windows.Forms.Button();
            this.UDQty = new System.Windows.Forms.NumericUpDown();
            this.lblo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgcustomers)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDQty)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 49);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(961, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order Module";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtcustname);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtcustid);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txtsearchcust);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dvgcustomers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 615);
            this.panel2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Customer Name :";
            // 
            // txtcustname
            // 
            this.txtcustname.Enabled = false;
            this.txtcustname.Location = new System.Drawing.Point(76, 461);
            this.txtcustname.Name = "txtcustname";
            this.txtcustname.Size = new System.Drawing.Size(228, 22);
            this.txtcustname.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Customer ID :";
            // 
            // txtcustid
            // 
            this.txtcustid.Enabled = false;
            this.txtcustid.Location = new System.Drawing.Point(76, 393);
            this.txtcustid.Name = "txtcustid";
            this.txtcustid.Size = new System.Drawing.Size(228, 22);
            this.txtcustid.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 275);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // txtsearchcust
            // 
            this.txtsearchcust.Location = new System.Drawing.Point(51, 278);
            this.txtsearchcust.Name = "txtsearchcust";
            this.txtsearchcust.Size = new System.Drawing.Size(228, 22);
            this.txtsearchcust.TabIndex = 20;
            this.txtsearchcust.TextChanged += new System.EventHandler(this.txtsearchcust_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(13, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "CUSTOMER";
            // 
            // dvgcustomers
            // 
            this.dvgcustomers.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dvgcustomers.AllowUserToAddRows = false;
            this.dvgcustomers.AllowUserToResizeRows = false;
            this.dvgcustomers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgcustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dvgcustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvgcustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dvgcustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvgcustomers.EnableHeadersVisualStyles = false;
            this.dvgcustomers.Location = new System.Drawing.Point(0, 0);
            this.dvgcustomers.Name = "dvgcustomers";
            this.dvgcustomers.RowHeadersVisible = false;
            this.dvgcustomers.Size = new System.Drawing.Size(323, 259);
            this.dvgcustomers.TabIndex = 17;
            this.dvgcustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgcustomers_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "No.";
            this.Column1.Name = "Column1";
            this.Column1.Width = 53;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Customer ID";
            this.Column2.Name = "Column2";
            this.Column2.Width = 105;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.UDQty);
            this.panel3.Controls.Add(this.btnorderclear);
            this.panel3.Controls.Add(this.btnorderinsert);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.dtpdate);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtproductname);
            this.panel3.Controls.Add(this.txttotal);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtproductid);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtsearchproduct);
            this.panel3.Controls.Add(this.txtprice);
            this.panel3.Controls.Add(this.dvgproduct);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(339, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(646, 615);
            this.panel3.TabIndex = 17;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 275);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(26, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "PRODUCT";
            // 
            // txtsearchproduct
            // 
            this.txtsearchproduct.Location = new System.Drawing.Point(61, 278);
            this.txtsearchproduct.Name = "txtsearchproduct";
            this.txtsearchproduct.Size = new System.Drawing.Size(228, 22);
            this.txtsearchproduct.TabIndex = 22;
            this.txtsearchproduct.TextChanged += new System.EventHandler(this.txtsearchproduct_TextChanged);
            // 
            // dvgproduct
            // 
            this.dvgproduct.AllowUserToAddRows = false;
            this.dvgproduct.AllowUserToResizeRows = false;
            this.dvgproduct.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgproduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dvgproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvgproduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column5,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column4,
            this.Column6,
            this.Column7});
            this.dvgproduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvgproduct.EnableHeadersVisualStyles = false;
            this.dvgproduct.Location = new System.Drawing.Point(0, 0);
            this.dvgproduct.Name = "dvgproduct";
            this.dvgproduct.RowHeadersVisible = false;
            this.dvgproduct.Size = new System.Drawing.Size(646, 259);
            this.dvgproduct.TabIndex = 18;
            this.dvgproduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgproduct_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "No.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 53;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Product_Id";
            this.Column5.Name = "Column5";
            this.Column5.Width = 97;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 119;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 54;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.Width = 63;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Description";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Catergory";
            this.Column7.Name = "Column7";
            this.Column7.Width = 93;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(437, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Qty :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(426, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Price :";
            // 
            // txtprice
            // 
            this.txtprice.Enabled = false;
            this.txtprice.Location = new System.Drawing.Point(485, 367);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(138, 22);
            this.txtprice.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(430, 454);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Total :";
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(485, 452);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(138, 22);
            this.txttotal.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Product Name :";
            // 
            // txtproductname
            // 
            this.txtproductname.Enabled = false;
            this.txtproductname.Location = new System.Drawing.Point(27, 461);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(228, 22);
            this.txtproductname.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Product ID :";
            // 
            // txtproductid
            // 
            this.txtproductid.Enabled = false;
            this.txtproductid.Location = new System.Drawing.Point(27, 393);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.Size = new System.Drawing.Size(228, 22);
            this.txtproductid.TabIndex = 25;
            // 
            // dtpdate
            // 
            this.dtpdate.CustomFormat = "dd/MM/yyyy";
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdate.Location = new System.Drawing.Point(30, 540);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(146, 22);
            this.dtpdate.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 506);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Order Date :";
            // 
            // btnorderclear
            // 
            this.btnorderclear.BackColor = System.Drawing.Color.Red;
            this.btnorderclear.FlatAppearance.BorderSize = 0;
            this.btnorderclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnorderclear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorderclear.ForeColor = System.Drawing.Color.White;
            this.btnorderclear.Location = new System.Drawing.Point(521, 551);
            this.btnorderclear.Name = "btnorderclear";
            this.btnorderclear.Size = new System.Drawing.Size(113, 40);
            this.btnorderclear.TabIndex = 35;
            this.btnorderclear.Text = "Clear";
            this.btnorderclear.UseVisualStyleBackColor = false;
            this.btnorderclear.Click += new System.EventHandler(this.btnorderclear_Click);
            // 
            // btnorderinsert
            // 
            this.btnorderinsert.BackColor = System.Drawing.Color.ForestGreen;
            this.btnorderinsert.FlatAppearance.BorderSize = 0;
            this.btnorderinsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnorderinsert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorderinsert.ForeColor = System.Drawing.Color.White;
            this.btnorderinsert.Location = new System.Drawing.Point(389, 551);
            this.btnorderinsert.Name = "btnorderinsert";
            this.btnorderinsert.Size = new System.Drawing.Size(126, 41);
            this.btnorderinsert.TabIndex = 33;
            this.btnorderinsert.Text = "Order Insert";
            this.btnorderinsert.UseVisualStyleBackColor = false;
            this.btnorderinsert.Click += new System.EventHandler(this.btnorderinsert_Click);
            // 
            // UDQty
            // 
            this.UDQty.Location = new System.Drawing.Point(485, 412);
            this.UDQty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.UDQty.Name = "UDQty";
            this.UDQty.Size = new System.Drawing.Size(138, 22);
            this.UDQty.TabIndex = 36;
            this.UDQty.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblo
            // 
            this.lblo.AutoSize = true;
            this.lblo.Location = new System.Drawing.Point(38, 550);
            this.lblo.Name = "lblo";
            this.lblo.Size = new System.Drawing.Size(54, 17);
            this.lblo.TabIndex = 25;
            this.lblo.Text = "order Id";
            // 
            // OrderModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 664);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderModuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderModuleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgcustomers)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDQty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dvgcustomers;
        private System.Windows.Forms.DataGridView dvgproduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button btnorderclear;
        public System.Windows.Forms.Button btnorderinsert;
        public System.Windows.Forms.TextBox txttotal;
        public System.Windows.Forms.TextBox txtprice;
        public System.Windows.Forms.DateTimePicker dtpdate;
        public System.Windows.Forms.TextBox txtproductname;
        public System.Windows.Forms.TextBox txtproductid;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txtsearchcust;
        public System.Windows.Forms.TextBox txtsearchproduct;
        public System.Windows.Forms.TextBox txtcustname;
        public System.Windows.Forms.TextBox txtcustid;
        public System.Windows.Forms.Label lblo;
        public System.Windows.Forms.NumericUpDown UDQty;
    }
}