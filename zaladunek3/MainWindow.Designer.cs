namespace zaladunek3
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ExitButton = new System.Windows.Forms.Button();
            this.SimulationButton = new System.Windows.Forms.Button();
            this.BinsBox = new System.Windows.Forms.ComboBox();
            this.NumberOfItemsAdded = new System.Windows.Forms.Label();
            this.AddProduct = new System.Windows.Forms.Button();
            this.RemoveProductButton = new System.Windows.Forms.Button();
            this.ViewProductsButton = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ExitButton.Location = new System.Drawing.Point(12, 285);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(119, 45);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SimulationButton
            // 
            this.SimulationButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.SimulationButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SimulationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SimulationButton.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.SimulationButton.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SimulationButton.Location = new System.Drawing.Point(164, 285);
            this.SimulationButton.Name = "SimulationButton";
            this.SimulationButton.Size = new System.Drawing.Size(117, 45);
            this.SimulationButton.TabIndex = 1;
            this.SimulationButton.Text = "RUN";
            this.SimulationButton.UseVisualStyleBackColor = false;
            this.SimulationButton.Click += new System.EventHandler(this.SimulationButton_Click);
            // 
            // BinsBox
            // 
            this.BinsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.BinsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BinsBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BinsBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinsBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.BinsBox.FormattingEnabled = true;
            this.BinsBox.Location = new System.Drawing.Point(15, 72);
            this.BinsBox.Name = "BinsBox";
            this.BinsBox.Size = new System.Drawing.Size(268, 26);
            this.BinsBox.TabIndex = 2;
            // 
            // NumberOfItemsAdded
            // 
            this.NumberOfItemsAdded.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfItemsAdded.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.NumberOfItemsAdded.Location = new System.Drawing.Point(15, 126);
            this.NumberOfItemsAdded.Name = "NumberOfItemsAdded";
            this.NumberOfItemsAdded.Size = new System.Drawing.Size(269, 18);
            this.NumberOfItemsAdded.TabIndex = 3;
            this.NumberOfItemsAdded.Text = "Added items:  ";
            this.NumberOfItemsAdded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddProduct
            // 
            this.AddProduct.BackColor = System.Drawing.SystemColors.GrayText;
            this.AddProduct.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProduct.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.AddProduct.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.AddProduct.Location = new System.Drawing.Point(12, 160);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(120, 50);
            this.AddProduct.TabIndex = 4;
            this.AddProduct.Text = "CHOOSE PRODUCTS";
            this.AddProduct.UseVisualStyleBackColor = false;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // RemoveProductButton
            // 
            this.RemoveProductButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.RemoveProductButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RemoveProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveProductButton.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.RemoveProductButton.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.RemoveProductButton.Location = new System.Drawing.Point(164, 160);
            this.RemoveProductButton.Name = "RemoveProductButton";
            this.RemoveProductButton.Size = new System.Drawing.Size(120, 50);
            this.RemoveProductButton.TabIndex = 5;
            this.RemoveProductButton.Text = "REMOVE PRODUCTS";
            this.RemoveProductButton.UseVisualStyleBackColor = false;
            this.RemoveProductButton.Click += new System.EventHandler(this.RemoveProductButton_Click);
            // 
            // ViewProductsButton
            // 
            this.ViewProductsButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.ViewProductsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ViewProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewProductsButton.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.ViewProductsButton.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ViewProductsButton.Location = new System.Drawing.Point(12, 230);
            this.ViewProductsButton.Name = "ViewProductsButton";
            this.ViewProductsButton.Size = new System.Drawing.Size(272, 35);
            this.ViewProductsButton.TabIndex = 6;
            this.ViewProductsButton.Text = "VIEW PRODUCTS";
            this.ViewProductsButton.UseVisualStyleBackColor = false;
            this.ViewProductsButton.Click += new System.EventHandler(this.ViewProductsButton_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Cooper Std Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(18, 13);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(266, 45);
            this.name.TabIndex = 7;
            this.name.Text = "KNAPSACK PROBLEM";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Checked = true;
            this.checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox.Location = new System.Drawing.Point(15, 104);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(126, 17);
            this.checkBox.TabIndex = 8;
            this.checkBox.Text = "Advanced Knapsack";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(300, 346);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.name);
            this.Controls.Add(this.ViewProductsButton);
            this.Controls.Add(this.RemoveProductButton);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.NumberOfItemsAdded);
            this.Controls.Add(this.BinsBox);
            this.Controls.Add(this.SimulationButton);
            this.Controls.Add(this.ExitButton);
            this.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 346);
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Knapsack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SimulationButton;
        private System.Windows.Forms.ComboBox BinsBox;
        private System.Windows.Forms.Label NumberOfItemsAdded;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button RemoveProductButton;
        private System.Windows.Forms.Button ViewProductsButton;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.CheckBox checkBox;
    }
}