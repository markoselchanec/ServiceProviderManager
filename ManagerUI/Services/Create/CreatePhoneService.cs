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
    public partial class CreatePhoneService : Form
    {
        public CreatePhoneService()
        {
            InitializeComponent();
        }

        private void createPhoneServiceButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PhoneServiceModel phoneServiceModel = new(
                    phoneServiceNameBox.Text,
                    phoneServiceCostPerMonthBox.Text,
                    phoneServiceTalkingMinutesBox.Text,
                    phoneServiceMessageAmountBox.Text);

                GlobalConfig.Connection.CreatePhoneService(phoneServiceModel);

                phoneServiceNameBox.Text = "";
                phoneServiceCostPerMonthBox.Text = "0";
                phoneServiceTalkingMinutesBox.Text = "0";
                phoneServiceMessageAmountBox.Text = "0";
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid information.Please add all values and try again.");
            }
        }
        /// <summary>
        /// Validate Phone Service Create form.
        /// </summary>
        /// <returns>Boolean value, true if all fields are valid, false in other cases.</returns>
        private bool ValidateForm()
        {
            bool output = true;

            if(phoneServiceNameBox.Text.Length == 0)
            {
                output = false;
            }

            decimal costPerMonth = 0;
            bool validateCostPerMonth = decimal.TryParse(phoneServiceCostPerMonthBox.Text, out costPerMonth);

            if (!validateCostPerMonth)
            {
                output = false;
            }

            if(costPerMonth < 1)
            {
                output = false;
            }

            int talkingMinutes = 0;
            bool validateTalkingMinutes = int.TryParse(phoneServiceTalkingMinutesBox.Text,out talkingMinutes);

            if (!validateTalkingMinutes)
            {
                output=false;
            }

            if(talkingMinutes < 1)
            {
                output = false;
            }

            int messageAmount = 0;
            bool validateMessageAmount = int.TryParse(phoneServiceTalkingMinutesBox.Text,out messageAmount);

            if(!validateMessageAmount)
            {
                output = false;
            }

            if(messageAmount < 1)
            {
                output = false;
            }

            return output;
        }
    }
}
