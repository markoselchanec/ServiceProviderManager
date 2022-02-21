namespace ManagerUI
{
    partial class SearchCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCustomer));
            this.searchAddressNumberBox = new System.Windows.Forms.TextBox();
            this.searchAddressNumberLabel = new System.Windows.Forms.Label();
            this.searchAddressNameBox = new System.Windows.Forms.TextBox();
            this.searchAddressNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.searchUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchAddressNumberBox
            // 
            this.searchAddressNumberBox.BackColor = System.Drawing.Color.Gainsboro;
            this.searchAddressNumberBox.Location = new System.Drawing.Point(268, 166);
            this.searchAddressNumberBox.Name = "searchAddressNumberBox";
            this.searchAddressNumberBox.Size = new System.Drawing.Size(193, 35);
            this.searchAddressNumberBox.TabIndex = 45;
            // 
            // searchAddressNumberLabel
            // 
            this.searchAddressNumberLabel.AutoSize = true;
            this.searchAddressNumberLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchAddressNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.searchAddressNumberLabel.Location = new System.Drawing.Point(91, 169);
            this.searchAddressNumberLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.searchAddressNumberLabel.Name = "searchAddressNumberLabel";
            this.searchAddressNumberLabel.Size = new System.Drawing.Size(169, 30);
            this.searchAddressNumberLabel.TabIndex = 44;
            this.searchAddressNumberLabel.Text = "Address Number";
            // 
            // searchAddressNameBox
            // 
            this.searchAddressNameBox.BackColor = System.Drawing.Color.Gainsboro;
            this.searchAddressNameBox.Location = new System.Drawing.Point(268, 125);
            this.searchAddressNameBox.Name = "searchAddressNameBox";
            this.searchAddressNameBox.Size = new System.Drawing.Size(193, 35);
            this.searchAddressNameBox.TabIndex = 43;
            // 
            // searchAddressNameLabel
            // 
            this.searchAddressNameLabel.AutoSize = true;
            this.searchAddressNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchAddressNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.searchAddressNameLabel.Location = new System.Drawing.Point(111, 128);
            this.searchAddressNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.searchAddressNameLabel.Name = "searchAddressNameLabel";
            this.searchAddressNameLabel.Size = new System.Drawing.Size(149, 30);
            this.searchAddressNameLabel.TabIndex = 42;
            this.searchAddressNameLabel.Text = "Address Name";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.headerLabel.Location = new System.Drawing.Point(130, 50);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(292, 40);
            this.headerLabel.TabIndex = 50;
            this.headerLabel.Text = "Search for a customer";
            // 
            // searchUserButton
            // 
            this.searchUserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.searchUserButton.Location = new System.Drawing.Point(170, 241);
            this.searchUserButton.Name = "searchUserButton";
            this.searchUserButton.Size = new System.Drawing.Size(227, 65);
            this.searchUserButton.TabIndex = 51;
            this.searchUserButton.Text = "Search";
            this.searchUserButton.UseVisualStyleBackColor = true;
            this.searchUserButton.Click += new System.EventHandler(this.searchUserButton_Click);
            // 
            // SearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(552, 356);
            this.Controls.Add(this.searchUserButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.searchAddressNumberBox);
            this.Controls.Add(this.searchAddressNumberLabel);
            this.Controls.Add(this.searchAddressNameBox);
            this.Controls.Add(this.searchAddressNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "SearchCustomer";
            this.Text = "Search Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox searchAddressNumberBox;
        private Label searchAddressNumberLabel;
        private TextBox searchAddressNameBox;
        private Label searchAddressNameLabel;
        private Label headerLabel;
        private Button searchUserButton;
    }
}