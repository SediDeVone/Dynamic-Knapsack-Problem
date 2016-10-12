namespace zaladunek3
{
    partial class ProductList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductList));
            this.ListOfProducts = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListOfProducts
            // 
            this.ListOfProducts.AutoSize = true;
            this.ListOfProducts.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfProducts.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ListOfProducts.Location = new System.Drawing.Point(28, 54);
            this.ListOfProducts.Name = "ListOfProducts";
            this.ListOfProducts.Size = new System.Drawing.Size(52, 18);
            this.ListOfProducts.TabIndex = 0;
            this.ListOfProducts.Text = "label1";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Cooper Std Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CloseButton.Location = new System.Drawing.Point(151, 199);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(117, 39);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "CLOSE";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Cooper Std Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.name.Location = new System.Drawing.Point(3, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(275, 45);
            this.name.TabIndex = 8;
            this.name.Text = "LIST OF PRODUCTS";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(283, 250);
            this.Controls.Add(this.name);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ListOfProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductWindow";
            this.Load += new System.EventHandler(this.ProductList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ListOfProducts;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label name;
    }
}