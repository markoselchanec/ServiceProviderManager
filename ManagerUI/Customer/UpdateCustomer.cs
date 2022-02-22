using ManagerUI.Customer;
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
    public partial class UpdateCustomer : Form
    {
        private List<InternetServiceModel> availableInternetServiceModels = GlobalConfig.Connection.GetInternetService_All();
        private List<PhoneServiceModel> availablePhoneServiceModels = GlobalConfig.Connection.GetPhoneService_All();
        private List<TvServiceModel> availableTvServiceModels = GlobalConfig.Connection.GetTvService_All();
        private List<InternetServiceModel> newListInternet = new();
        private List<TvServiceModel> newListTv = new();
        private List<PhoneServiceModel> newListPhone = new();
        public CustomerModel Customer { get; set; }
        public UpdateCustomer(CustomerModel customer)
        {
            Customer = customer;
            InitializeComponent();
            WireUp();
            DisplayCost();
        }
        
        private void WireUp()
        {

            if (Customer.ServicePackage.InternetService != null) newListInternet = availableInternetServiceModels.Where(x => x.Id != Customer.ServicePackage.InternetService.Id).ToList();
            if (Customer.ServicePackage.TvService != null) newListTv = availableTvServiceModels.Where(x => x.Id != Customer.ServicePackage.TvService.Id).ToList();
            if (Customer.ServicePackage.PhoneService != null) newListPhone = availablePhoneServiceModels.Where(x => x.Id != Customer.ServicePackage.PhoneService.Id).ToList();


            updateFirstNameBox.Text = Customer.FirstName;
            updateLastNameBox.Text = Customer.LastName;
            updateAddressNameBox.Text = Customer.AddressName;
            updateAddressNumberBox.Text = Customer.AddressNumber.ToString();
            updateEmailAddressBox.Text = Customer.EmailAddress;
            updatePhoneNumberBox.Text = Customer.PhoneNumber;

            updateInternetTypeDropdown.DataSource = null;
            updatePhoneTypeDropdown.DataSource = null;
            updateTvTypeDropdown.DataSource = null;

            updateInternetTypeDropdown.DataSource = newListInternet;
            updateInternetTypeDropdown.DisplayMember = "Name";
            updateInternetMonthsBox.Text = "";
            updatePhoneTypeDropdown.DataSource = newListPhone;
            updatePhoneTypeDropdown.DisplayMember = "Name";
            updatePhoneMonthsBox.Text = "";
            updateTvTypeDropdown.DataSource = newListTv;
            updateTvTypeDropdown.DisplayMember = "Name";
            updateTvMonthsBox.Text = "";


            if (Customer.ServicePackage.InternetService != null) updateSelectedInternetType.Text = $"{Customer.ServicePackage.InternetService.Name} : {Customer.ServicePackage.InternetServiceDurationMonths}";
            if (Customer.ServicePackage.TvService != null) updateSelectedTvType.Text = $"{Customer.ServicePackage.TvService.Name} : {Customer.ServicePackage.TvServiceDurationMonths}";
            if (Customer.ServicePackage.PhoneService != null) updateSelectedPhoneType.Text = $"{Customer.ServicePackage.PhoneService.Name} : {Customer.ServicePackage.PhoneServiceDurationMonths}";
            if (Customer.ServicePackage.InternetServiceDurationMonths == 0) updateSelectedInternetType.Text = "";
            if (Customer.ServicePackage.TvServiceDurationMonths == 0) updateSelectedTvType.Text = "";
            if (Customer.ServicePackage.PhoneServiceDurationMonths == 0) updateSelectedPhoneType.Text = "";
        }

        private void updaterAddInternetServiceButton_Click(object sender, EventArgs e)
        {
            InternetServiceModel i = (InternetServiceModel)updateInternetTypeDropdown.SelectedItem;

            if (ValidateMonths(updateInternetMonthsBox.Text))
            {
                Customer.ServicePackage.InternetServiceDurationMonths = int.Parse(updateInternetMonthsBox.Text);

                newListInternet.Remove(i);
                Customer.ServicePackage.InternetService = i;

                WireUp();
                DisplayCost();
            }
        }
        private void updateAddTvServiceButton_Click(object sender, EventArgs e)
        {
            TvServiceModel i = (TvServiceModel)updateTvTypeDropdown.SelectedItem;

            if (ValidateMonths(updateTvMonthsBox.Text))
            {
                Customer.ServicePackage.TvServiceDurationMonths = int.Parse(updateTvMonthsBox.Text);

                newListTv.Remove(i);
                Customer.ServicePackage.TvService = i;

                WireUp();
                DisplayCost();
            }
        }

        private void updateAddPhoneServiceButton_Click(object sender, EventArgs e)
        {
            PhoneServiceModel i = (PhoneServiceModel)updatePhoneTypeDropdown.SelectedItem;

            if (ValidateMonths(updatePhoneMonthsBox.Text))
            {
                Customer.ServicePackage.PhoneServiceDurationMonths = int.Parse(updatePhoneMonthsBox.Text);

                newListPhone.Remove(i);
                Customer.ServicePackage.PhoneService = i;

                WireUp();
                DisplayCost();
            }
        }
        private void updateRemoveSelectedInternetType_Click(object sender, EventArgs e)
        {

            if (Customer.ServicePackage.InternetService.Id != 0 || Customer.ServicePackage.InternetService != null)
            {
                updateSelectedInternetType.Text = null;
                newListInternet.Add(Customer.ServicePackage.InternetService);
                Customer.ServicePackage.InternetService = null;

                WireUp();
                DisplayCost();
            }
            else
            {
                MessageBox.Show("Nothing to remove.");
            }
        }

        private void updateRemoveSelectedTvType_Click(object sender, EventArgs e)
        {
            if (Customer.ServicePackage.TvService.Id != 0 || Customer.ServicePackage.TvService != null)
            {
                updateSelectedTvType.Text = null;
                newListTv.Add(Customer.ServicePackage.TvService);
                Customer.ServicePackage.TvService = null;

                WireUp();
                DisplayCost();
            }
            else
            {
                MessageBox.Show("Nothing to remove.");
            }
        }

        private void updateRemoveSelectedPhoneType_Click(object sender, EventArgs e)
        {
            if (Customer.ServicePackage.PhoneService.Id != 0 || Customer.ServicePackage.PhoneService != null)
            {
                updateSelectedPhoneType.Text = null;
                newListPhone.Add(Customer.ServicePackage.PhoneService);
                Customer.ServicePackage.PhoneService = null;

                WireUp();
                DisplayCost();
            }
            else
            {
                MessageBox.Show("Nothing to remove.");
            }
        }
        private bool ValidateMonths(string boxText)
        {
            bool output = true;
            int months = 0;
            bool validateMonths = int.TryParse(boxText, out months);

            if (!validateMonths)
            {
                MessageBox.Show("Invalid information.Please add a number.");
                output = false;
            }

            return output;
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                if (Customer.ServicePackage.InternetService != null)
                {
                    Customer.ServicePackage.InternetServiceStartingDate = DateTime.Now;
                    Customer.ServicePackage.InternetServiceEndingDate = Customer.ServicePackage.InternetServiceStartingDate.AddMonths(Customer.ServicePackage.InternetServiceDurationMonths);
                }
                if (Customer.ServicePackage.TvService != null)
                {
                    Customer.ServicePackage.TvServiceStartingDate = DateTime.Now;
                    Customer.ServicePackage.TvServiceEndingDate = Customer.ServicePackage.TvServiceStartingDate.AddMonths(Customer.ServicePackage.TvServiceDurationMonths);
                }
                if (Customer.ServicePackage.PhoneService != null)
                {
                    Customer.ServicePackage.PhoneServiceStartingDate = DateTime.Now;
                    Customer.ServicePackage.PhoneServiceEndingDate = Customer.ServicePackage.PhoneServiceStartingDate.AddMonths(Customer.ServicePackage.PhoneServiceDurationMonths);
                }

                GlobalConfig.Connection.UpdateServicePackage(Customer.ServicePackage);


                CustomerModel customerModel = new();
                customerModel.Id = Customer.Id;
                customerModel.ServicePackage = Customer.ServicePackage;
                customerModel.FirstName = updateFirstNameBox.Text;
                customerModel.LastName = updateLastNameBox.Text;
                customerModel.AddressName = updateAddressNameBox.Text;
                customerModel.AddressNumber = int.Parse(updateAddressNumberBox.Text);
                customerModel.EmailAddress = updateEmailAddressBox.Text;
                customerModel.PhoneNumber = updatePhoneNumberBox.Text;


                GlobalConfig.Connection.UpdateCustomer(customerModel);


                MessageBox.Show("Customer Updated.");
                DashboardCustomer dc = new(GlobalConfig.Connection.GetCustomer_ByAddressNameAndNumber(customerModel.AddressName,customerModel.AddressNumber));
                dc.Show();
                this.Close();

                updateFirstNameBox.Text = "";
                updateLastNameBox.Text = "";
                updateAddressNameBox.Text = "";
                updateAddressNumberBox.Text = "";
                updateEmailAddressBox.Text = "";
                updatePhoneNumberBox.Text = "";
             
            }
            else
            {
                MessageBox.Show("Invalid information.Please add all values and try again.");
            }
        }

        private void DisplayCost()
        {
            updateCostPerMonthValueLabel.Text = null;
            decimal totalCost = 0;
            if(Customer.ServicePackage.InternetService != null)
            {
                if (Customer.ServicePackage.InternetService.Id != 0) totalCost += Customer.ServicePackage.InternetService.CostPerMonth;
            }
            if (Customer.ServicePackage.TvService != null)
            {
                if (Customer.ServicePackage.TvService.Id != 0) totalCost += Customer.ServicePackage.TvService.CostPerMonth;
            }
            if (Customer.ServicePackage.PhoneService != null)
            {
                if (Customer.ServicePackage.PhoneService.Id != 0) totalCost += Customer.ServicePackage.PhoneService.CostPerMonth;
            }
                   
            updateCostPerMonthValueLabel.Text = totalCost.ToString();
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (updateFirstNameBox.Text.Length < 1)
            {
                output = false;
            }

            if (updateLastNameBox.Text.Length < 1)
            {
                output = false;
            }

            if (updateAddressNameBox.Text.Length < 1)
            {
                output = false;
            }

            int addressNum = 0;
            bool validateAddressNumber = int.TryParse(updateAddressNumberBox.Text, out addressNum);

            if (!validateAddressNumber)
            {
                output = false;
            }

            if (addressNum < 1)
            {
                output = false;
            }

            if (updateEmailAddressBox.Text.Length < 1)
            {
                output = false;
            }

            if (updatePhoneNumberBox.Text.Length < 1)
            {
                output = false;
            }


            return output;
        }


    }
}
