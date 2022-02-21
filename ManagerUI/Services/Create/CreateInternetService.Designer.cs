namespace ManagerUI
{
    partial class CreateInternetService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateInternetService));
            this.headerLabel = new System.Windows.Forms.Label();
            this.internetServiceSpeedBox = new System.Windows.Forms.TextBox();
            this.internetServiceSpeedLabel = new System.Windows.Forms.Label();
            this.internetServiceCostPerMonthBox = new System.Windows.Forms.TextBox();
            this.internetServiceCostPerMonthLabel = new System.Windows.Forms.Label();
            this.internetServiceNameBox = new System.Windows.Forms.TextBox();
            this.internetServiceNameLabel = new System.Windows.Forms.Label();
            this.createInternetServiceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.headerLabel.Location = new System.Drawing.Point(67, 45);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(301, 40);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Create Internet Service";
            // 
            // internetServiceSpeedBox
            // 
            this.internetServiceSpeedBox.BackColor = System.Drawing.Color.Gainsboro;
            this.internetServiceSpeedBox.Location = new System.Drawing.Point(116, 307);
            this.internetServiceSpeedBox.Name = "internetServiceSpeedBox";
            this.internetServiceSpeedBox.Size = new System.Drawing.Size(193, 35);
            this.internetServiceSpeedBox.TabIndex = 13;
            // 
            // internetServiceSpeedLabel
            // 
            this.internetServiceSpeedLabel.AutoSize = true;
            this.internetServiceSpeedLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.internetServiceSpeedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.internetServiceSpeedLabel.Location = new System.Drawing.Point(175, 274);
            this.internetServiceSpeedLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.internetServiceSpeedLabel.Name = "internetServiceSpeedLabel";
            this.internetServiceSpeedLabel.Size = new System.Drawing.Size(70, 30);
            this.internetServiceSpeedLabel.TabIndex = 12;
            this.internetServiceSpeedLabel.Text = "Speed";
            // 
            // internetServiceCostPerMonthBox
            // 
            this.internetServiceCostPerMonthBox.BackColor = System.Drawing.Color.Gainsboro;
            this.internetServiceCostPerMonthBox.Location = new System.Drawing.Point(116, 236);
            this.internetServiceCostPerMonthBox.Name = "internetServiceCostPerMonthBox";
            this.internetServiceCostPerMonthBox.Size = new System.Drawing.Size(193, 35);
            this.internetServiceCostPerMonthBox.TabIndex = 11;
            this.internetServiceCostPerMonthBox.Text = "0";
            // 
            // internetServiceCostPerMonthLabel
            // 
            this.internetServiceCostPerMonthLabel.AutoSize = true;
            this.internetServiceCostPerMonthLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.internetServiceCostPerMonthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.internetServiceCostPerMonthLabel.Location = new System.Drawing.Point(125, 203);
            this.internetServiceCostPerMonthLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.internetServiceCostPerMonthLabel.Name = "internetServiceCostPerMonthLabel";
            this.internetServiceCostPerMonthLabel.Size = new System.Drawing.Size(157, 30);
            this.internetServiceCostPerMonthLabel.TabIndex = 10;
            this.internetServiceCostPerMonthLabel.Text = "Cost per month";
            // 
            // internetServiceNameBox
            // 
            this.internetServiceNameBox.BackColor = System.Drawing.Color.Gainsboro;
            this.internetServiceNameBox.Location = new System.Drawing.Point(116, 165);
            this.internetServiceNameBox.Name = "internetServiceNameBox";
            this.internetServiceNameBox.Size = new System.Drawing.Size(193, 35);
            this.internetServiceNameBox.TabIndex = 9;
            // 
            // internetServiceNameLabel
            // 
            this.internetServiceNameLabel.AutoSize = true;
            this.internetServiceNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.internetServiceNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.internetServiceNameLabel.Location = new System.Drawing.Point(175, 132);
            this.internetServiceNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.internetServiceNameLabel.Name = "internetServiceNameLabel";
            this.internetServiceNameLabel.Size = new System.Drawing.Size(69, 30);
            this.internetServiceNameLabel.TabIndex = 8;
            this.internetServiceNameLabel.Text = "Name";
            // 
            // createInternetServiceButton
            // 
            this.createInternetServiceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.createInternetServiceButton.Location = new System.Drawing.Point(98, 389);
            this.createInternetServiceButton.Name = "createInternetServiceButton";
            this.createInternetServiceButton.Size = new System.Drawing.Size(227, 65);
            this.createInternetServiceButton.TabIndex = 22;
            this.createInternetServiceButton.Text = "Create";
            this.createInternetServiceButton.UseVisualStyleBackColor = true;
            this.createInternetServiceButton.Click += new System.EventHandler(this.createInternetServiceButton_Click);
            // 
            // CreateInternetService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(434, 499);
            this.Controls.Add(this.createInternetServiceButton);
            this.Controls.Add(this.internetServiceSpeedBox);
            this.Controls.Add(this.internetServiceSpeedLabel);
            this.Controls.Add(this.internetServiceCostPerMonthBox);
            this.Controls.Add(this.internetServiceCostPerMonthLabel);
            this.Controls.Add(this.internetServiceNameBox);
            this.Controls.Add(this.internetServiceNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateInternetService";
            this.Text = "Create Internet Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private TextBox internetServiceSpeedBox;
        private Label internetServiceSpeedLabel;
        private TextBox internetServiceCostPerMonthBox;
        private Label internetServiceCostPerMonthLabel;
        private TextBox internetServiceNameBox;
        private Label internetServiceNameLabel;
        private Button createInternetServiceButton;
    }
}