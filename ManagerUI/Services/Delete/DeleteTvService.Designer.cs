namespace ManagerUI.Services.Delete
{
    partial class DeleteTvService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteTvService));
            this.deleteTvServiceButton = new System.Windows.Forms.Button();
            this.tvServiceListBox = new System.Windows.Forms.ListBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteTvServiceButton
            // 
            this.deleteTvServiceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.deleteTvServiceButton.Location = new System.Drawing.Point(255, 350);
            this.deleteTvServiceButton.Name = "deleteTvServiceButton";
            this.deleteTvServiceButton.Size = new System.Drawing.Size(227, 65);
            this.deleteTvServiceButton.TabIndex = 42;
            this.deleteTvServiceButton.Text = "Delete";
            this.deleteTvServiceButton.UseVisualStyleBackColor = true;
            this.deleteTvServiceButton.Click += new System.EventHandler(this.deleteTvServiceButton_Click_1);
            // 
            // tvServiceListBox
            // 
            this.tvServiceListBox.FormattingEnabled = true;
            this.tvServiceListBox.ItemHeight = 30;
            this.tvServiceListBox.Location = new System.Drawing.Point(65, 112);
            this.tvServiceListBox.Name = "tvServiceListBox";
            this.tvServiceListBox.Size = new System.Drawing.Size(611, 214);
            this.tvServiceListBox.TabIndex = 41;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.headerLabel.Location = new System.Drawing.Point(228, 34);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(236, 40);
            this.headerLabel.TabIndex = 40;
            this.headerLabel.Text = "Delete TV Service";
            // 
            // DeleteTvService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(740, 448);
            this.Controls.Add(this.deleteTvServiceButton);
            this.Controls.Add(this.tvServiceListBox);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "DeleteTvService";
            this.Text = "Delete TV Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button deleteTvServiceButton;
        private ListBox tvServiceListBox;
        private Label headerLabel;
    }
}