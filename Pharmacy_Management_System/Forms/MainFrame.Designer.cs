namespace SemesterDemo
{
    partial class MainFrame
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
            this.mainGridView = new System.Windows.Forms.DataGridView();
            this.catalogueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddItem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.catalogPanel = new System.Windows.Forms.Label();
            this.catalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogueBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainGridView
            // 
            this.mainGridView.BackgroundColor = System.Drawing.Color.Thistle;
            this.mainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGridView.Location = new System.Drawing.Point(528, 12);
            this.mainGridView.Name = "mainGridView";
            this.mainGridView.ReadOnly = true;
            this.mainGridView.RowHeadersWidth = 62;
            this.mainGridView.Size = new System.Drawing.Size(543, 333);
            this.mainGridView.TabIndex = 0;
            this.mainGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainGridView_CellContentClick);
            // 
            // catalogueBindingSource
            // 
            this.catalogueBindingSource.DataMember = "Catalogue";
            // 
            // AddItem
            // 
            this.AddItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.AddItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItem.ForeColor = System.Drawing.Color.Indigo;
            this.AddItem.Location = new System.Drawing.Point(40, 48);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(89, 27);
            this.AddItem.TabIndex = 1;
            this.AddItem.Text = "Add Item";
            this.AddItem.UseVisualStyleBackColor = false;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Indigo;
            this.button1.Location = new System.Drawing.Point(160, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show/Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Indigo;
            this.button2.Location = new System.Drawing.Point(130, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "Update Item";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Logged in As: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.Location = new System.Drawing.Point(100, 559);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter the product ID: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(59, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Indigo;
            this.button3.Location = new System.Drawing.Point(130, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 27);
            this.button3.TabIndex = 9;
            this.button3.Text = "Delete Item";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Indigo;
            this.button4.Location = new System.Drawing.Point(415, 552);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 27);
            this.button4.TabIndex = 10;
            this.button4.Text = "Log Out";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(15, 470);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 76);
            this.panel1.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Indigo;
            this.button5.Location = new System.Drawing.Point(6, 41);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 27);
            this.button5.TabIndex = 12;
            this.button5.Text = "Launch Panel";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Admin Panel:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(15, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 227);
            this.panel2.TabIndex = 12;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.RoyalBlue;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Indigo;
            this.button8.Location = new System.Drawing.Point(377, 31);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(102, 27);
            this.button8.TabIndex = 14;
            this.button8.Text = "Transactions";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(399, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 30);
            this.label14.TabIndex = 25;
            this.label14.Text = "Customer ID \r\n    (If valid): ";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(417, 125);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(45, 20);
            this.textBox8.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(249, 18);
            this.label13.TabIndex = 23;
            this.label13.Text = "Only for new customers (Optional)";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.RoyalBlue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Indigo;
            this.button7.Location = new System.Drawing.Point(402, 190);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 27);
            this.button7.TabIndex = 13;
            this.button7.Text = "Check Out";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Phone number: ";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Plum;
            this.textBox7.Location = new System.Drawing.Point(123, 194);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(139, 20);
            this.textBox7.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Email: ";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Plum;
            this.textBox6.Location = new System.Drawing.Point(123, 168);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(139, 20);
            this.textBox6.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Customer Name: ";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Plum;
            this.textBox5.Location = new System.Drawing.Point(123, 142);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(139, 20);
            this.textBox5.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(79, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Click an item from the catalog table";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Select the quantity: ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(214, 55);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(45, 20);
            this.textBox3.TabIndex = 15;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.RoyalBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Indigo;
            this.button6.Location = new System.Drawing.Point(188, 81);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 27);
            this.button6.TabIndex = 14;
            this.button6.Text = "Add to Cart";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Purchase Panel:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.catalogPanel);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.AddItem);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 219);
            this.panel3.TabIndex = 14;
            // 
            // catalogPanel
            // 
            this.catalogPanel.AutoSize = true;
            this.catalogPanel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalogPanel.Location = new System.Drawing.Point(12, 10);
            this.catalogPanel.Name = "catalogPanel";
            this.catalogPanel.Size = new System.Drawing.Size(110, 18);
            this.catalogPanel.TabIndex = 13;
            this.catalogPanel.Text = "Catalog Panel:";
            // 
            // catalogBindingSource
            // 
            this.catalogBindingSource.DataMember = "Catalog";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.button10);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Location = new System.Drawing.Point(565, 351);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(454, 248);
            this.panel4.TabIndex = 15;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.RoyalBlue;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Indigo;
            this.button10.Location = new System.Drawing.Point(30, 216);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(89, 27);
            this.button10.TabIndex = 17;
            this.button10.Text = "Refresh";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 18);
            this.label12.TabIndex = 23;
            this.label12.Text = "Cart:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(298, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "BDT";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(344, 220);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(65, 21);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "0";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView2.Location = new System.Drawing.Point(3, 37);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(443, 174);
            this.dataGridView2.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.RoyalBlue;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Indigo;
            this.button9.Location = new System.Drawing.Point(291, 552);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(89, 40);
            this.button9.TabIndex = 16;
            this.button9.Text = "Customer Panel";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1096, 607);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainGridView);
            this.Name = "MainFrame";
            this.Text = "Pharmacy Management System";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogueBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void admin(string adminName)
        {
            textBox1.Text = adminName;
        }

        public void activateAdminPanel(string verify)
        {
            if(verify == "y")
            {
                panel1.Show();
            }
            else if(verify == "n")
            {
                panel1.Hide();
            }
        }

        #endregion

        private System.Windows.Forms.DataGridView mainGridView;
        private System.Windows.Forms.BindingSource catalogueBindingSource;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource catalogBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label catalogPanel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button8;
    }
}