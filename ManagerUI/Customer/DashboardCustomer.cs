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

namespace ManagerUI.Customer
{
    public partial class DashboardCustomer : Form
    {
        public CustomerModel customer { get; set; }
        public DashboardCustomer(CustomerModel model)
        {
            InitializeComponent();
            customer = model;
            PopulateData();
        }
        
        private void PopulateData()
        {
            if(customer == null)
            {
                customerNameValueLabel.Text = "X";
                customerAddressValueLabel.Text = "X";
                customerEmailAddressValueLabel.Text = "X";
                customerPhoneNumberValueLabel.Text = "X";
                customerRegistrationDateValueLabel.Text = "X";
            }
            if(customer != null)
            {
                customerNameValueLabel.Text = customer.FullName;
                customerAddressValueLabel.Text = customer.AddressName + " " + customer.AddressNumber;
                customerEmailAddressValueLabel.Text = customer.EmailAddress;
                customerPhoneNumberValueLabel.Text = customer.PhoneNumber;
                customerRegistrationDateValueLabel.Text = customer.Registered.ToString();

                if (customer.ServicePackage.InternetService.Id == null)
                {
                    internetNameValueLabel.Text = "X";
                    internetSpeedValueLabel.Text = "X";
                    internetCostValueLabel.Text = "X";
                    internetStartingDateValueLabel.Text = "X";
                    internetEndingDateValueLabel.Text = "X";
                }
                else 
                {
                    internetNameValueLabel.Text = customer.ServicePackage.InternetService.Name;
                    internetSpeedValueLabel.Text = customer.ServicePackage.InternetService.Speed;
                    internetCostValueLabel.Text = customer.ServicePackage.InternetService.CostPerMonth.ToString();
                    internetStartingDateValueLabel.Text = customer.ServicePackage.InternetServiceStartingDate.ToString();
                    internetEndingDateValueLabel.Text = customer.ServicePackage.InternetServiceEndingDate.ToString();
                }

                if (customer.ServicePackage.TvService.Id == null)
                {
                    tvNameValueLabel.Text = "X";
                    tvChannelNumberValueLabel.Text = "X";
                    tvCostValueLabel.Text = "X";
                    tvStartingDateValueLabel.Text = "X";
                    tvEndingDateValueLabel.Text = "X";
                }
                else 
                {
                    tvNameValueLabel.Text = customer.ServicePackage.TvService.Name;
                    tvChannelNumberValueLabel.Text = customer.ServicePackage.TvService.ChannelCount.ToString();
                    tvCostValueLabel.Text = customer.ServicePackage.TvService.CostPerMonth.ToString();
                    tvStartingDateValueLabel.Text = customer.ServicePackage.TvServiceStartingDate.ToString();
                    tvEndingDateValueLabel.Text = customer.ServicePackage.TvServiceEndingDate.ToString();

                }

                if (customer.ServicePackage.PhoneService.Id == null)
                {
                    phoneNameValueLabel.Text = "X";
                    phoneTalkingMinutesValueLabel.Text = "X";
                    phoneMessageAmountValueLabel.Text = "X";
                    phoneCostValueLabel.Text = "X";
                    phoneStartingDateValueLabel.Text = "X";
                    phoneEndingDateValueLabel.Text = "X";
                }
                else 
                {
                    phoneNameValueLabel.Text = customer.ServicePackage.PhoneService.Name;
                    phoneTalkingMinutesValueLabel.Text = customer.ServicePackage.PhoneService.TalkingMinutes.ToString();
                    phoneMessageAmountValueLabel.Text = customer.ServicePackage.PhoneService.MessageAmount.ToString();
                    phoneCostValueLabel.Text = customer.ServicePackage.PhoneService.CostPerMonth.ToString();
                    phoneStartingDateValueLabel.Text = customer.ServicePackage.PhoneServiceStartingDate.ToString();
                    phoneEndingDateValueLabel.Text = customer.ServicePackage.PhoneServiceEndingDate.ToString();
                }
            }
            
        }

        private void openUpdateMenuButton_Click(object sender, EventArgs e)
        {
            UpdateCustomer updateCustomer = new(customer);
            updateCustomer.Show();
            this.Close();
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            GlobalConfig.Connection.DeleteCustomer(customer);

            MessageBox.Show("Customer removed.");
            this.Close();
        }

    }
}
