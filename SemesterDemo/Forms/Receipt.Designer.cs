namespace SemesterDemo.Windows
{
    partial class Receipt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_NameR = new System.Windows.Forms.Label();
            this.label_PhoneNoR = new System.Windows.Forms.Label();
            this.label_TPR = new System.Windows.Forms.Label();
            this.labelTPR = new System.Windows.Forms.Label();
            this.labelPNR = new System.Windows.Forms.Label();
            this.labelNameR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thank You For Purchasing!!";
            // 
            // label_NameR
            // 
            this.label_NameR.AutoSize = true;
            this.label_NameR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NameR.Location = new System.Drawing.Point(104, 181);
            this.label_NameR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NameR.Name = "label_NameR";
            this.label_NameR.Size = new System.Drawing.Size(84, 29);
            this.label_NameR.TabIndex = 1;
            this.label_NameR.Text = "Name:";
            // 
            // label_PhoneNoR
            // 
            this.label_PhoneNoR.AutoSize = true;
            this.label_PhoneNoR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PhoneNoR.Location = new System.Drawing.Point(74, 234);
            this.label_PhoneNoR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_PhoneNoR.Name = "label_PhoneNoR";
            this.label_PhoneNoR.Size = new System.Drawing.Size(127, 29);
            this.label_PhoneNoR.TabIndex = 1;
            this.label_PhoneNoR.Text = "Phone No:";
            // 
            // label_TPR
            // 
            this.label_TPR.AutoSize = true;
            this.label_TPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TPR.Location = new System.Drawing.Point(70, 290);
            this.label_TPR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TPR.Name = "label_TPR";
            this.label_TPR.Size = new System.Drawing.Size(136, 29);
            this.label_TPR.TabIndex = 1;
            this.label_TPR.Text = "Total Price:";
            // 
            // labelTPR
            // 
            this.labelTPR.AutoSize = true;
            this.labelTPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTPR.Location = new System.Drawing.Point(204, 290);
            this.labelTPR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTPR.Name = "labelTPR";
            this.labelTPR.Size = new System.Drawing.Size(45, 29);
            this.labelTPR.TabIndex = 1;
            this.labelTPR.Text = "TP";
            // 
            // labelPNR
            // 
            this.labelPNR.AutoSize = true;
            this.labelPNR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPNR.Location = new System.Drawing.Point(204, 234);
            this.labelPNR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPNR.Name = "labelPNR";
            this.labelPNR.Size = new System.Drawing.Size(47, 29);
            this.labelPNR.TabIndex = 1;
            this.labelPNR.Text = "PN";
            // 
            // labelNameR
            // 
            this.labelNameR.AutoSize = true;
            this.labelNameR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameR.Location = new System.Drawing.Point(204, 181);
            this.labelNameR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameR.Name = "labelNameR";
            this.labelNameR.Size = new System.Drawing.Size(31, 29);
            this.labelNameR.TabIndex = 1;
            this.labelNameR.Text = "N";
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 437);
            this.Controls.Add(this.labelTPR);
            this.Controls.Add(this.label_TPR);
            this.Controls.Add(this.labelPNR);
            this.Controls.Add(this.label_PhoneNoR);
            this.Controls.Add(this.labelNameR);
            this.Controls.Add(this.label_NameR);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_NameR;
        private System.Windows.Forms.Label label_PhoneNoR;
        private System.Windows.Forms.Label label_TPR;
        public System.Windows.Forms.Label labelTPR;
        public System.Windows.Forms.Label labelPNR;
        public System.Windows.Forms.Label labelNameR;
    }
}