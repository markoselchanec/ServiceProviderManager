namespace ManagerUI.Services.Delete
{
    partial class DeleteInternetService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteInternetService));
            this.headerLabel = new System.Windows.Forms.Label();
            this.internetServicesListBox = new System.Windows.Forms.ListBox();
            this.deleteInternetServiceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.headerLabel.Location = new System.Drawing.Point(228, 34);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(299, 40);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Delete Internet Service";
            // 
            // internetServicesListBox
            // 
            this.internetServicesListBox.FormattingEnabled = true;
            this.internetServicesListBox.ItemHeight = 30;
            this.internetServicesListBox.Location = new System.Drawing.Point(65, 112);
            this.internetServicesListBox.Name = "internetServicesListBox";
            this.internetServicesListBox.Size = new System.Drawing.Size(611, 214);
            this.internetServicesListBox.TabIndex = 2;
            // 
            // deleteInternetServiceButton
            // 
            this.deleteInternetServiceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.deleteInternetServiceButton.Location = new System.Drawing.Point(255, 350);
            this.deleteInternetServiceButton.Name = "deleteInternetServiceButton";
            this.deleteInternetServiceButton.Size = new System.Drawing.Size(227, 65);
            this.deleteInternetServiceButton.TabIndex = 39;
            this.deleteInternetServiceButton.Text = "Delete";
            this.deleteInternetServiceButton.UseVisualStyleBackColor = true;
            this.deleteInternetServiceButton.Click += new System.EventHandler(this.deleteInternetServiceButton_Click);
            // 
            // DeleteInternetService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(740, 448);
            this.Controls.Add(this.deleteInternetServiceButton);
            this.Controls.Add(this.internetServicesListBox);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "DeleteInternetService";
            this.Text = "Delete Internet Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private ListBox internetServicesListBox;
        private Button deleteInternetServiceButton;
    }
}