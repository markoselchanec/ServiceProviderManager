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
    public partial class CreateTvService : Form
    {
        public CreateTvService()
        {
            InitializeComponent();
        }

        private void createTvServiceButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                TvServiceModel tvServiceModel = new(
                    tvServiceNameBox.Text,
                    tvServiceChannelCountBox.Text,
                    tvServiceCostPerMonthBox.Text
                    );

                GlobalConfig.Connection.CreateTvService(tvServiceModel);

                tvServiceNameBox.Text = "";
                tvServiceChannelCountBox.Text = "0";
                tvServiceCostPerMonthBox.Text = "0";
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid information.Please add all values and try again.");
            }
        }
        /// <summary>
        /// Validate Tv Service Create form.
        /// </summary>
        /// <returns>Boolean value, true if all fields are valid, false in other cases.</returns>
        private bool ValidateForm()
        {
            bool output = true;

            if(tvServiceNameBox.Text.Length == 0)
            {
                output = false;
            }

            decimal costPerMonth = 0;
            bool validateCostPerMonth = decimal.TryParse(tvServiceCostPerMonthBox.Text, out costPerMonth);

            if (!validateCostPerMonth)
            {
                output = false;
            }

            if(costPerMonth < 1)
            {
                output = false;
            }

            int channelCount = 0;
            bool validateChannelCount = int.TryParse(tvServiceChannelCountBox.Text,out channelCount);

            if (!validateChannelCount)
            {
                output = false;
            }

            if(channelCount < 1)
            {
                output = false;
            }

            return output;
        }
    }
}
