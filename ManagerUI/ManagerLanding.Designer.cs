namespace ManagerUI
{
    partial class ManagerLanding
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerLanding));
            this.headerLabel = new System.Windows.Forms.Label();
            this.searchCustomerButton = new System.Windows.Forms.Button();
            this.createCustomer = new System.Windows.Forms.Button();
            this.createNewInternetService = new System.Windows.Forms.Button();
            this.createNewTvService = new System.Windows.Forms.Button();
            this.createNewPhoneService = new System.Windows.Forms.Button();
            this.deleteInternetServiceButton = new System.Windows.Forms.Button();
            this.deleteTvServiceButton = new System.Windows.Forms.Button();
            this.deletePhoneServiceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.headerLabel.Location = new System.Drawing.Point(340, 34);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(227, 40);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Service Manager";
            // 
            // searchCustomerButton
            // 
            this.searchCustomerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.searchCustomerButton.Location = new System.Drawing.Point(39, 127);
            this.searchCustomerButton.Name = "searchCustomerButton";
            this.searchCustomerButton.Size = new System.Drawing.Size(227, 65);
            this.searchCustomerButton.TabIndex = 1;
            this.searchCustomerButton.Text = "Search Customer";
            this.searchCustomerButton.UseVisualStyleBackColor = true;
            this.searchCustomerButton.Click += new System.EventHandler(this.searchCustomerButton_Click);
            // 
            // createCustomer
            // 
            this.createCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.createCustomer.Location = new System.Drawing.Point(39, 198);
            this.createCustomer.Name = "createCustomer";
            this.createCustomer.Size = new System.Drawing.Size(227, 65);
            this.createCustomer.TabIndex = 2;
            this.createCustomer.Text = "Create New Customer";
            this.createCustomer.UseVisualStyleBackColor = true;
            this.createCustomer.Click += new System.EventHandler(this.createCustomer_Click);
            // 
            // createNewInternetService
            // 
            this.createNewInternetService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.createNewInternetService.Location = new System.Drawing.Point(272, 127);
            this.createNewInternetService.Name = "createNewInternetService";
            this.createNewInternetService.Size = new System.Drawing.Size(295, 65);
            this.createNewInternetService.TabIndex = 3;
            this.createNewInternetService.Text = "Create New Internet Service";
            this.createNewInternetService.UseVisualStyleBackColor = true;
            this.createNewInternetService.Click += new System.EventHandler(this.createNewInternetService_Click);
            // 
            // createNewTvService
            // 
            this.createNewTvService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.createNewTvService.Location = new System.Drawing.Point(272, 198);
            this.createNewTvService.Name = "createNewTvService";
            this.createNewTvService.Size = new System.Drawing.Size(295, 65);
            this.createNewTvService.TabIndex = 4;
            this.createNewTvService.Text = "Create New TV Service";
            this.createNewTvService.UseVisualStyleBackColor = true;
            this.createNewTvService.Click += new System.EventHandler(this.createNewTvService_Click);
            // 
            // createNewPhoneService
            // 
            this.createNewPhoneService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.createNewPhoneService.Location = new System.Drawing.Point(272, 269);
            this.createNewPhoneService.Name = "createNewPhoneService";
            this.createNewPhoneService.Size = new System.Drawing.Size(295, 65);
            this.createNewPhoneService.TabIndex = 5;
            this.createNewPhoneService.Text = "Create New Phone Service";
            this.createNewPhoneService.UseVisualStyleBackColor = true;
            this.createNewPhoneService.Click += new System.EventHandler(this.createNewPhoneService_Click);
            // 
            // deleteInternetServiceButton
            // 
            this.deleteInternetServiceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.deleteInternetServiceButton.Location = new System.Drawing.Point(573, 127);
            this.deleteInternetServiceButton.Name = "deleteInternetServiceButton";
            this.deleteInternetServiceButton.Size = new System.Drawing.Size(295, 65);
            this.deleteInternetServiceButton.TabIndex = 6;
            this.deleteInternetServiceButton.Text = "Delete Internet Service";
            this.deleteInternetServiceButton.UseVisualStyleBackColor = true;
            this.deleteInternetServiceButton.Click += new System.EventHandler(this.deleteInternetServiceButton_Click);
            // 
            // deleteTvServiceButton
            // 
            this.deleteTvServiceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.deleteTvServiceButton.Location = new System.Drawing.Point(573, 198);
            this.deleteTvServiceButton.Name = "deleteTvServiceButton";
            this.deleteTvServiceButton.Size = new System.Drawing.Size(295, 65);
            this.deleteTvServiceButton.TabIndex = 7;
            this.deleteTvServiceButton.Text = "Delete TV Service";
            this.deleteTvServiceButton.UseVisualStyleBackColor = true;
            this.deleteTvServiceButton.Click += new System.EventHandler(this.deleteTvServiceButton_Click);
            // 
            // deletePhoneServiceButton
            // 
            this.deletePhoneServiceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.deletePhoneServiceButton.Location = new System.Drawing.Point(573, 269);
            this.deletePhoneServiceButton.Name = "deletePhoneServiceButton";
            this.deletePhoneServiceButton.Size = new System.Drawing.Size(295, 65);
            this.deletePhoneServiceButton.TabIndex = 8;
            this.deletePhoneServiceButton.Text = "Delete Phone Service";
            this.deletePhoneServiceButton.UseVisualStyleBackColor = true;
            this.deletePhoneServiceButton.Click += new System.EventHandler(this.deletePhoneServiceButton_Click);
            // 
            // ManagerLanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(907, 404);
            this.Controls.Add(this.deletePhoneServiceButton);
            this.Controls.Add(this.deleteTvServiceButton);
            this.Controls.Add(this.deleteInternetServiceButton);
            this.Controls.Add(this.createNewPhoneService);
            this.Controls.Add(this.createNewTvService);
            this.Controls.Add(this.createNewInternetService);
            this.Controls.Add(this.createCustomer);
            this.Controls.Add(this.searchCustomerButton);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ManagerLanding";
            this.Text = "Landing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private Button searchCustomerButton;
        private Button createCustomer;
        private Button createNewInternetService;
        private Button createNewTvService;
        private Button createNewPhoneService;
        private Button deleteInternetServiceButton;
        private Button deleteTvServiceButton;
        private Button deletePhoneServiceButton;
    }
}