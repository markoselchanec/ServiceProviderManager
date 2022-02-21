namespace ManagerUI
{
    partial class CreateTvService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTvService));
            this.createTvServiceButton = new System.Windows.Forms.Button();
            this.tvServiceChannelCountBox = new System.Windows.Forms.TextBox();
            this.tvSericeChannelCountLabel = new System.Windows.Forms.Label();
            this.tvServiceCostPerMonthBox = new System.Windows.Forms.TextBox();
            this.tvServiceCostPerMonthLabel = new System.Windows.Forms.Label();
            this.tvServiceNameBox = new System.Windows.Forms.TextBox();
            this.tvServiceNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createTvServiceButton
            // 
            this.createTvServiceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.createTvServiceButton.Location = new System.Drawing.Point(98, 389);
            this.createTvServiceButton.Name = "createTvServiceButton";
            this.createTvServiceButton.Size = new System.Drawing.Size(227, 65);
            this.createTvServiceButton.TabIndex = 30;
            this.createTvServiceButton.Text = "Create";
            this.createTvServiceButton.UseVisualStyleBackColor = true;
            this.createTvServiceButton.Click += new System.EventHandler(this.createTvServiceButton_Click);
            // 
            // tvServiceChannelCountBox
            // 
            this.tvServiceChannelCountBox.BackColor = System.Drawing.Color.Gainsboro;
            this.tvServiceChannelCountBox.Location = new System.Drawing.Point(116, 307);
            this.tvServiceChannelCountBox.Name = "tvServiceChannelCountBox";
            this.tvServiceChannelCountBox.Size = new System.Drawing.Size(193, 35);
            this.tvServiceChannelCountBox.TabIndex = 29;
            this.tvServiceChannelCountBox.Text = "0";
            // 
            // tvSericeChannelCountLabel
            // 
            this.tvSericeChannelCountLabel.AutoSize = true;
            this.tvSericeChannelCountLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tvSericeChannelCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.tvSericeChannelCountLabel.Location = new System.Drawing.Point(143, 274);
            this.tvSericeChannelCountLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tvSericeChannelCountLabel.Name = "tvSericeChannelCountLabel";
            this.tvSericeChannelCountLabel.Size = new System.Drawing.Size(148, 30);
            this.tvSericeChannelCountLabel.TabIndex = 28;
            this.tvSericeChannelCountLabel.Text = "Channel count";
            // 
            // tvServiceCostPerMonthBox
            // 
            this.tvServiceCostPerMonthBox.BackColor = System.Drawing.Color.Gainsboro;
            this.tvServiceCostPerMonthBox.Location = new System.Drawing.Point(116, 236);
            this.tvServiceCostPerMonthBox.Name = "tvServiceCostPerMonthBox";
            this.tvServiceCostPerMonthBox.Size = new System.Drawing.Size(193, 35);
            this.tvServiceCostPerMonthBox.TabIndex = 27;
            this.tvServiceCostPerMonthBox.Text = "0";
            // 
            // tvServiceCostPerMonthLabel
            // 
            this.tvServiceCostPerMonthLabel.AutoSize = true;
            this.tvServiceCostPerMonthLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tvServiceCostPerMonthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.tvServiceCostPerMonthLabel.Location = new System.Drawing.Point(125, 203);
            this.tvServiceCostPerMonthLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tvServiceCostPerMonthLabel.Name = "tvServiceCostPerMonthLabel";
            this.tvServiceCostPerMonthLabel.Size = new System.Drawing.Size(157, 30);
            this.tvServiceCostPerMonthLabel.TabIndex = 26;
            this.tvServiceCostPerMonthLabel.Text = "Cost per month";
            // 
            // tvServiceNameBox
            // 
            this.tvServiceNameBox.BackColor = System.Drawing.Color.Gainsboro;
            this.tvServiceNameBox.Location = new System.Drawing.Point(116, 165);
            this.tvServiceNameBox.Name = "tvServiceNameBox";
            this.tvServiceNameBox.Size = new System.Drawing.Size(193, 35);
            this.tvServiceNameBox.TabIndex = 25;
            // 
            // tvServiceNameLabel
            // 
            this.tvServiceNameLabel.AutoSize = true;
            this.tvServiceNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tvServiceNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.tvServiceNameLabel.Location = new System.Drawing.Point(175, 132);
            this.tvServiceNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tvServiceNameLabel.Name = "tvServiceNameLabel";
            this.tvServiceNameLabel.Size = new System.Drawing.Size(69, 30);
            this.tvServiceNameLabel.TabIndex = 24;
            this.tvServiceNameLabel.Text = "Name";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.headerLabel.Location = new System.Drawing.Point(98, 45);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(238, 40);
            this.headerLabel.TabIndex = 23;
            this.headerLabel.Text = "Create TV Service";
            // 
            // CreateTvService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(434, 499);
            this.Controls.Add(this.createTvServiceButton);
            this.Controls.Add(this.tvServiceChannelCountBox);
            this.Controls.Add(this.tvSericeChannelCountLabel);
            this.Controls.Add(this.tvServiceCostPerMonthBox);
            this.Controls.Add(this.tvServiceCostPerMonthLabel);
            this.Controls.Add(this.tvServiceNameBox);
            this.Controls.Add(this.tvServiceNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTvService";
            this.Text = "Create Tv Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button createTvServiceButton;
        private TextBox tvServiceChannelCountBox;
        private Label tvSericeChannelCountLabel;
        private TextBox tvServiceCostPerMonthBox;
        private Label tvServiceCostPerMonthLabel;
        private TextBox tvServiceNameBox;
        private Label tvServiceNameLabel;
        private Label headerLabel;
    }
}