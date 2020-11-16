namespace SemesterDemo.Windows
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
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1A2C = new System.Windows.Forms.Button();
            this.label1Cart = new System.Windows.Forms.Label();
            this.textBox1Qnt = new System.Windows.Forms.TextBox();
            this.labelSelect = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_item = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5_total = new System.Windows.Forms.Label();
            this.textBox_TP = new System.Windows.Forms.TextBox();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.label_Stock = new System.Windows.Forms.Label();
            this.textBox_Stock = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.label_stockLeft = new System.Windows.Forms.Label();
            this.textBox_Leftstock = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Location = new System.Drawing.Point(22, 42);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.Size = new System.Drawing.Size(507, 159);
            this.dataGridViewItems.TabIndex = 0;
            this.dataGridViewItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellClick);
            this.dataGridViewItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellContentClick);
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quantity,
            this.Price,
            this.ID,
            this.StockLeft});
            this.dataGridViewCart.Location = new System.Drawing.Point(22, 242);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.Size = new System.Drawing.Size(343, 169);
            this.dataGridViewCart.TabIndex = 0;
            this.dataGridViewCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCart_CellClick);
            this.dataGridViewCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCart_CellContentClick);
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // StockLeft
            // 
            this.StockLeft.HeaderText = "StockLeft";
            this.StockLeft.Name = "StockLeft";
            this.StockLeft.Visible = false;
            // 
            // button1A2C
            // 
            this.button1A2C.Location = new System.Drawing.Point(646, 85);
            this.button1A2C.Name = "button1A2C";
            this.button1A2C.Size = new System.Drawing.Size(83, 41);
            this.button1A2C.TabIndex = 1;
            this.button1A2C.Text = "Add to cart";
            this.button1A2C.UseVisualStyleBackColor = true;
            this.button1A2C.Click += new System.EventHandler(this.button1A2C_Click);
            // 
            // label1Cart
            // 
            this.label1Cart.AutoSize = true;
            this.label1Cart.Location = new System.Drawing.Point(19, 213);
            this.label1Cart.Name = "label1Cart";
            this.label1Cart.Size = new System.Drawing.Size(29, 13);
            this.label1Cart.TabIndex = 2;
            this.label1Cart.Text = "Cart:";
            // 
            // textBox1Qnt
            // 
            this.textBox1Qnt.Location = new System.Drawing.Point(646, 59);
            this.textBox1Qnt.Name = "textBox1Qnt";
            this.textBox1Qnt.Size = new System.Drawing.Size(83, 20);
            this.textBox1Qnt.TabIndex = 3;
            this.textBox1Qnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1Qnt_KeyPress);
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelect.Location = new System.Drawing.Point(18, 19);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(195, 20);
            this.labelSelect.TabIndex = 2;
            this.labelSelect.Text = "Select your preferred item:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cart:";
            // 
            // label_item
            // 
            this.label_item.AutoSize = true;
            this.label_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_item.Location = new System.Drawing.Point(584, 59);
            this.label_item.Name = "label_item";
            this.label_item.Size = new System.Drawing.Size(33, 16);
            this.label_item.TabIndex = 2;
            this.label_item.Text = "Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(643, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity:";
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(746, 59);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.ReadOnly = true;
            this.textBox_Price.Size = new System.Drawing.Size(41, 20);
            this.textBox_Price.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(743, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price:";
            // 
            // label5_total
            // 
            this.label5_total.AutoSize = true;
            this.label5_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5_total.Location = new System.Drawing.Point(220, 417);
            this.label5_total.Name = "label5_total";
            this.label5_total.Size = new System.Drawing.Size(42, 16);
            this.label5_total.TabIndex = 2;
            this.label5_total.Text = "Total:";
            // 
            // textBox_TP
            // 
            this.textBox_TP.Location = new System.Drawing.Point(265, 417);
            this.textBox_TP.Name = "textBox_TP";
            this.textBox_TP.ReadOnly = true;
            this.textBox_TP.Size = new System.Drawing.Size(100, 20);
            this.textBox_TP.TabIndex = 3;
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(646, 132);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(83, 43);
            this.buttonBuy.TabIndex = 5;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // label_Stock
            // 
            this.label_Stock.AutoSize = true;
            this.label_Stock.Location = new System.Drawing.Point(798, 43);
            this.label_Stock.Name = "label_Stock";
            this.label_Stock.Size = new System.Drawing.Size(38, 13);
            this.label_Stock.TabIndex = 4;
            this.label_Stock.Text = "Stock:";
            this.label_Stock.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox_Stock
            // 
            this.textBox_Stock.Location = new System.Drawing.Point(801, 59);
            this.textBox_Stock.Name = "textBox_Stock";
            this.textBox_Stock.ReadOnly = true;
            this.textBox_Stock.Size = new System.Drawing.Size(41, 20);
            this.textBox_Stock.TabIndex = 3;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(848, 59);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(21, 13);
            this.label_ID.TabIndex = 4;
            this.label_ID.Text = "ID:";
            this.label_ID.Click += new System.EventHandler(this.label5_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(401, 242);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 6;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label_stockLeft
            // 
            this.label_stockLeft.AutoSize = true;
            this.label_stockLeft.Location = new System.Drawing.Point(746, 111);
            this.label_stockLeft.Name = "label_stockLeft";
            this.label_stockLeft.Size = new System.Drawing.Size(59, 13);
            this.label_stockLeft.TabIndex = 7;
            this.label_stockLeft.Text = "Stock Left:";
            // 
            // textBox_Leftstock
            // 
            this.textBox_Leftstock.Location = new System.Drawing.Point(746, 128);
            this.textBox_Leftstock.Name = "textBox_Leftstock";
            this.textBox_Leftstock.ReadOnly = true;
            this.textBox_Leftstock.Size = new System.Drawing.Size(61, 20);
            this.textBox_Leftstock.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.textBox_Leftstock);
            this.Controls.Add(this.label_stockLeft);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label_Stock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_TP);
            this.Controls.Add(this.textBox_Stock);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.textBox1Qnt);
            this.Controls.Add(this.label5_total);
            this.Controls.Add(this.label_item);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.label1Cart);
            this.Controls.Add(this.button1A2C);
            this.Controls.Add(this.dataGridViewCart);
            this.Controls.Add(this.dataGridViewItems);
            this.Name = "Form1";
            this.Text = "Customer Cart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewItems;
        public System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.Button button1A2C;
        private System.Windows.Forms.Label label1Cart;
        private System.Windows.Forms.TextBox textBox1Qnt;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_item;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5_total;
        private System.Windows.Forms.TextBox textBox_TP;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Label label_Stock;
        private System.Windows.Forms.TextBox textBox_Stock;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label_stockLeft;
        private System.Windows.Forms.TextBox textBox_Leftstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockLeft;
    }
}