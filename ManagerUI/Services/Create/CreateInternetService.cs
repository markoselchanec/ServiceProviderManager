using ServiceManagerLibrary;
using ServiceManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerUI
{
    public partial class CreateInternetService : Form
    {
        public CreateInternetService()
        {
            InitializeComponent();
        }

        private void createInternetServiceButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                InternetServiceModel internetServiceModel = new(
                    internetServiceNameBox.Text,                 
                    internetServiceSpeedBox.Text,            
                    internetServiceCostPerMonthBox.Text);
                
                GlobalConfig.Connection.CreateInternetService(internetServiceModel);

                internetServiceNameBox.Text = "";             
                internetServiceSpeedBox.Text = "";
                internetServiceCostPerMonthBox.Text = "0";
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid information.Please add all values and try again.");
            }
        }
        /// <summary>
        /// Validate Internet Service Create form.
        /// </summary>
        /// <returns>Boolean value, true if all fields are valid, false in other cases.</returns>
        private bool ValidateForm()
        {
            bool output = true;

            if(internetServiceNameBox.Text.Length == 0)
            {
                output = false;
            }

            decimal costPerMonth = 0;
            bool costPerMonthValidNumber = decimal.TryParse(internetServiceCostPerMonthBox.Text, out costPerMonth);

            if (!costPerMonthValidNumber)
            {
                output = false;
            }

            if(costPerMonth < 1)
            {
                output = false;
            }

            if(internetServiceSpeedBox.Text.Length == 0)
            {
                output = false;
            }

            return output;
        }
    }
}
