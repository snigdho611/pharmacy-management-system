namespace Pharmacy_Management_System
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.mainGridView = new System.Windows.Forms.DataGridView();
            this.catalogueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnShowRefresh = new System.Windows.Forms.Button();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLaunchPanel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelPurchase = new System.Windows.Forms.Panel();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panelCatalogPanel = new System.Windows.Forms.Panel();
            this.catalogPanel = new System.Windows.Forms.Label();
            this.catalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRefreshCart = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.cartGridView = new System.Windows.Forms.DataGridView();
            this.cartId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCustomerPanel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogueBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelPurchase.SuspendLayout();
            this.panelCatalogPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainGridView
            // 
            this.mainGridView.BackgroundColor = System.Drawing.Color.Thistle;
            this.mainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.mainGridView.Location = new System.Drawing.Point(792, 18);
            this.mainGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainGridView.MultiSelect = false;
            this.mainGridView.Name = "mainGridView";
            this.mainGridView.ReadOnly = true;
            this.mainGridView.RowHeadersWidth = 62;
            this.mainGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainGridView.Size = new System.Drawing.Size(1035, 512);
            this.mainGridView.TabIndex = 0;
            this.mainGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainGridView_CellContentClick);
            // 
            // catalogueBindingSource
            // 
            this.catalogueBindingSource.DataMember = "Catalogue";
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddItem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.Indigo;
            this.btnAddItem.Location = new System.Drawing.Point(69, 145);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(158, 42);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // btnShowRefresh
            // 
            this.btnShowRefresh.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnShowRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowRefresh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowRefresh.ForeColor = System.Drawing.Color.Indigo;
            this.btnShowRefresh.Location = new System.Drawing.Point(67, 93);
            this.btnShowRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowRefresh.Name = "btnShowRefresh";
            this.btnShowRefresh.Size = new System.Drawing.Size(160, 42);
            this.btnShowRefresh.TabIndex = 2;
            this.btnShowRefresh.Text = "Show/Refresh";
            this.btnShowRefresh.UseVisualStyleBackColor = false;
            this.btnShowRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateItem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateItem.ForeColor = System.Drawing.Color.Indigo;
            this.btnUpdateItem.Location = new System.Drawing.Point(69, 197);
            this.btnUpdateItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(158, 42);
            this.btnUpdateItem.TabIndex = 3;
            this.btnUpdateItem.Text = "Update Item";
            this.btnUpdateItem.UseVisualStyleBackColor = false;
            this.btnUpdateItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 535);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Logged in As: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.Location = new System.Drawing.Point(146, 532);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(194, 26);
            this.textBox1.TabIndex = 6;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteItem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.ForeColor = System.Drawing.Color.Indigo;
            this.btnDeleteItem.Location = new System.Drawing.Point(69, 249);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(158, 42);
            this.btnDeleteItem.TabIndex = 9;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Indigo;
            this.btnLogOut.Location = new System.Drawing.Point(524, 532);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(126, 42);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnLaunchPanel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(18, 395);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 117);
            this.panel1.TabIndex = 11;
            // 
            // btnLaunchPanel
            // 
            this.btnLaunchPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLaunchPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLaunchPanel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchPanel.ForeColor = System.Drawing.Color.Indigo;
            this.btnLaunchPanel.Location = new System.Drawing.Point(9, 63);
            this.btnLaunchPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLaunchPanel.Name = "btnLaunchPanel";
            this.btnLaunchPanel.Size = new System.Drawing.Size(144, 42);
            this.btnLaunchPanel.TabIndex = 12;
            this.btnLaunchPanel.Text = "Launch Panel";
            this.btnLaunchPanel.UseVisualStyleBackColor = false;
            this.btnLaunchPanel.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "Admin Panel:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panelPurchase
            // 
            this.panelPurchase.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelPurchase.Controls.Add(this.btnTransactions);
            this.panelPurchase.Controls.Add(this.label14);
            this.panelPurchase.Controls.Add(this.textBox8);
            this.panelPurchase.Controls.Add(this.btnCheckOut);
            this.panelPurchase.Controls.Add(this.btnAddToCart);
            this.panelPurchase.Controls.Add(this.label4);
            this.panelPurchase.Location = new System.Drawing.Point(361, 18);
            this.panelPurchase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelPurchase.Name = "panelPurchase";
            this.panelPurchase.Size = new System.Drawing.Size(322, 337);
            this.panelPurchase.TabIndex = 12;
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTransactions.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.ForeColor = System.Drawing.Color.Indigo;
            this.btnTransactions.Location = new System.Drawing.Point(65, 64);
            this.btnTransactions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(153, 42);
            this.btnTransactions.TabIndex = 14;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = false;
            this.btnTransactions.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(90, 227);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 42);
            this.label14.TabIndex = 25;
            this.label14.Text = "Customer ID \r\n    (If valid): ";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(118, 187);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(66, 26);
            this.textBox8.TabIndex = 24;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckOut.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.Indigo;
            this.btnCheckOut.Location = new System.Drawing.Point(94, 274);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(124, 42);
            this.btnCheckOut.TabIndex = 13;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddToCart.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.Indigo;
            this.btnAddToCart.Location = new System.Drawing.Point(65, 135);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(147, 42);
            this.btnAddToCart.TabIndex = 14;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "Purchase Panel:";
            // 
            // panelCatalogPanel
            // 
            this.panelCatalogPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCatalogPanel.Controls.Add(this.catalogPanel);
            this.panelCatalogPanel.Controls.Add(this.btnDeleteItem);
            this.panelCatalogPanel.Controls.Add(this.btnUpdateItem);
            this.panelCatalogPanel.Controls.Add(this.btnAddItem);
            this.panelCatalogPanel.Controls.Add(this.btnShowRefresh);
            this.panelCatalogPanel.Location = new System.Drawing.Point(18, 18);
            this.panelCatalogPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelCatalogPanel.Name = "panelCatalogPanel";
            this.panelCatalogPanel.Size = new System.Drawing.Size(326, 337);
            this.panelCatalogPanel.TabIndex = 14;
            // 
            // catalogPanel
            // 
            this.catalogPanel.AutoSize = true;
            this.catalogPanel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalogPanel.Location = new System.Drawing.Point(18, 15);
            this.catalogPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.catalogPanel.Name = "catalogPanel";
            this.catalogPanel.Size = new System.Drawing.Size(174, 27);
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
            this.panel4.Controls.Add(this.btnRefreshCart);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.textBoxTotal);
            this.panel4.Controls.Add(this.cartGridView);
            this.panel4.Location = new System.Drawing.Point(792, 540);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1035, 382);
            this.panel4.TabIndex = 15;
            // 
            // btnRefreshCart
            // 
            this.btnRefreshCart.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRefreshCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefreshCart.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshCart.ForeColor = System.Drawing.Color.Indigo;
            this.btnRefreshCart.Location = new System.Drawing.Point(45, 332);
            this.btnRefreshCart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefreshCart.Name = "btnRefreshCart";
            this.btnRefreshCart.Size = new System.Drawing.Size(134, 42);
            this.btnRefreshCart.TabIndex = 17;
            this.btnRefreshCart.Text = "Refresh";
            this.btnRefreshCart.UseVisualStyleBackColor = false;
            this.btnRefreshCart.Click += new System.EventHandler(this.button10_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 25);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 27);
            this.label12.TabIndex = 23;
            this.label12.Text = "Cart:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(447, 338);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 27);
            this.label6.TabIndex = 13;
            this.label6.Text = "BDT";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(516, 338);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTotal.Multiline = true;
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(96, 30);
            this.textBoxTotal.TabIndex = 17;
            this.textBoxTotal.Text = "0";
            // 
            // cartGridView
            // 
            this.cartGridView.BackgroundColor = System.Drawing.Color.Thistle;
            this.cartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cartId,
            this.cartItem,
            this.cartQuantity,
            this.cartPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cartGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.cartGridView.Location = new System.Drawing.Point(9, 54);
            this.cartGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cartGridView.Name = "cartGridView";
            this.cartGridView.ReadOnly = true;
            this.cartGridView.RowHeadersWidth = 62;
            this.cartGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartGridView.Size = new System.Drawing.Size(1022, 268);
            this.cartGridView.TabIndex = 0;
            // 
            // cartId
            // 
            this.cartId.HeaderText = "ID";
            this.cartId.MinimumWidth = 8;
            this.cartId.Name = "cartId";
            this.cartId.ReadOnly = true;
            this.cartId.Width = 150;
            // 
            // cartItem
            // 
            this.cartItem.HeaderText = "Item";
            this.cartItem.MinimumWidth = 8;
            this.cartItem.Name = "cartItem";
            this.cartItem.ReadOnly = true;
            this.cartItem.Width = 150;
            // 
            // cartQuantity
            // 
            this.cartQuantity.HeaderText = "Quantity";
            this.cartQuantity.MinimumWidth = 8;
            this.cartQuantity.Name = "cartQuantity";
            this.cartQuantity.ReadOnly = true;
            this.cartQuantity.Width = 150;
            // 
            // cartPrice
            // 
            this.cartPrice.HeaderText = "Price";
            this.cartPrice.MinimumWidth = 8;
            this.cartPrice.Name = "cartPrice";
            this.cartPrice.ReadOnly = true;
            this.cartPrice.Width = 150;
            // 
            // btnCustomerPanel
            // 
            this.btnCustomerPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCustomerPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomerPanel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerPanel.ForeColor = System.Drawing.Color.Indigo;
            this.btnCustomerPanel.Location = new System.Drawing.Point(366, 524);
            this.btnCustomerPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCustomerPanel.Name = "btnCustomerPanel";
            this.btnCustomerPanel.Size = new System.Drawing.Size(134, 62);
            this.btnCustomerPanel.TabIndex = 16;
            this.btnCustomerPanel.Text = "Customer Panel";
            this.btnCustomerPanel.UseVisualStyleBackColor = false;
            this.btnCustomerPanel.Click += new System.EventHandler(this.button9_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1840, 934);
            this.Controls.Add(this.btnCustomerPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.panelCatalogPanel);
            this.Controls.Add(this.panelPurchase);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainFrame";
            this.Text = "Pharmacy Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogueBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPurchase.ResumeLayout(false);
            this.panelPurchase.PerformLayout();
            this.panelCatalogPanel.ResumeLayout(false);
            this.panelCatalogPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).EndInit();
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
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnShowRefresh;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource catalogBindingSource;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLaunchPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelPurchase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelCatalogPanel;
        private System.Windows.Forms.Label catalogPanel;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView cartGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button btnCustomerPanel;
        private System.Windows.Forms.Button btnRefreshCart;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartPrice;
    }
}