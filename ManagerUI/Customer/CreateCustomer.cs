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
    public partial class CreateCustomer : Form
    {

        private List<InternetServiceModel> availableInternetServiceModels = GlobalConfig.Connection.GetInternetService_All();

        private List<PhoneServiceModel> availablePhoneServiceModels = GlobalConfig.Connection.GetPhoneService_All();

        private List<TvServiceModel> availableTvServiceModels = GlobalConfig.Connection.GetTvService_All();

        private ServicePackageModel selectedServicePackage = new();

        public CreateCustomer()
        {
            InitializeComponent();
            WireUpLists();
        }
        /// <summary>
        /// Populates dropdowns from available internet,phone and tv services.
        /// </summary>
        private void WireUpLists()
        {
            internetTypeDropdown.DataSource = null;
            phoneTypeDropdown.DataSource = null;
            tvTypeDropdown.DataSource = null;
            selectedInternetType.Text = null;

            internetTypeDropdown.DataSource = availableInternetServiceModels;
            internetTypeDropdown.DisplayMember = "Name";
            internetMonthsBox.Text = "";
            phoneTypeDropdown.DataSource = availablePhoneServiceModels;
            phoneTypeDropdown.DisplayMember = "Name";
            phoneMonthsBox.Text = "";
            tvTypeDropdown.DataSource = availableTvServiceModels;
            tvTypeDropdown.DisplayMember = "Name";
            tvMonthsBox.Text = "";

            if (selectedServicePackage.InternetService != null) selectedInternetType.Text = $"{selectedServicePackage.InternetService.Name} : {selectedServicePackage.InternetServiceDurationMonths}";
            if (selectedServicePackage.TvService != null) selectedTvType.Text = $"{selectedServicePackage.TvService.Name} : {selectedServicePackage.TvServiceDurationMonths}";
            if (selectedServicePackage.PhoneService != null) selectedPhoneType.Text = $"{selectedServicePackage.PhoneService.Name} : {selectedServicePackage.PhoneServiceDurationMonths}";
        }

        private void addInternetServiceButton_Click(object sender, EventArgs e)
        {
            InternetServiceModel i = (InternetServiceModel)internetTypeDropdown.SelectedItem;

            if(ValidateMonths(internetMonthsBox.Text))
            {
                selectedServicePackage.InternetServiceDurationMonths = int.Parse(internetMonthsBox.Text);

                availableInternetServiceModels.Remove(i);
                selectedServicePackage.InternetService = i;

                WireUpLists();
                DisplayCost();
            }
        }
        private void removeSelectedInternetType_Click(object sender, EventArgs e)
        {
 
            if(selectedServicePackage.InternetService != null)
            {
                selectedInternetType.Text = null;
                availableInternetServiceModels.Add(selectedServicePackage.InternetService);
                selectedServicePackage.InternetService = new();

                WireUpLists();
                DisplayCost();
            }
            else
            {
                MessageBox.Show("Nothing to remove.");
            }

        }
        private void addTvServiceButton_Click(object sender, EventArgs e)
        {
            TvServiceModel i = (TvServiceModel)tvTypeDropdown.SelectedItem;

            if (ValidateMonths(tvMonthsBox.Text))
            {
                selectedServicePackage.TvServiceDurationMonths = int.Parse(tvMonthsBox.Text);

                availableTvServiceModels.Remove(i);
                selectedServicePackage.TvService = i;

                WireUpLists();
                DisplayCost();
            }
        }

        private void removeSelectedTvType_Click(object sender, EventArgs e)
        {
            if (selectedServicePackage.TvService != null)
            {
                selectedTvType.Text = null;
                availableTvServiceModels.Add(selectedServicePackage.TvService);
                selectedServicePackage.TvService = new();

                WireUpLists();
                DisplayCost();
            }
            else
            {
                MessageBox.Show("Nothing to remove.");
            }
        }

        private void addPhoneServiceButton_Click(object sender, EventArgs e)
        {
            PhoneServiceModel i = (PhoneServiceModel)phoneTypeDropdown.SelectedItem;

            if (ValidateMonths(phoneMonthsBox.Text))
            {
                selectedServicePackage.PhoneServiceDurationMonths = int.Parse(phoneMonthsBox.Text);

                availablePhoneServiceModels.Remove(i);
                selectedServicePackage.PhoneService = i;

                WireUpLists();
                DisplayCost();
            }
        }
        private void removeSelectedPhoneType_Click(object sender, EventArgs e)
        {
            if (selectedServicePackage.PhoneService != null)
            {
                selectedPhoneType.Text = null;
                availablePhoneServiceModels.Add(selectedServicePackage.PhoneService);
                selectedServicePackage.PhoneService = new();

                WireUpLists();
                DisplayCost();
            }
            else
            {
                MessageBox.Show("Nothing to remove.");
            }
        }
        private void DisplayCost()
        {
            costPerMonthValueLabel.Text = null;
            decimal totalCost = 0;
            if (selectedServicePackage.InternetService != null) totalCost += selectedServicePackage.InternetService.CostPerMonth;
            if (selectedServicePackage.TvService != null) totalCost += selectedServicePackage.TvService.CostPerMonth;
            if (selectedServicePackage.PhoneService != null) totalCost += selectedServicePackage.PhoneService.CostPerMonth;
            costPerMonthValueLabel.Text = totalCost.ToString();
        }
        /// <summary>
        /// Validates the month box in add service.
        /// </summary>
        /// <param name="boxText">Expects box value in string form, gets parsed to int.</param>
        /// <returns>Bool depending on validity of value in box.</returns>
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

        private void createCustomerButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                if (selectedServicePackage.InternetService != null)
                {
                    selectedServicePackage.InternetServiceStartingDate = DateTime.Now;
                    selectedServicePackage.InternetServiceEndingDate = selectedServicePackage.InternetServiceStartingDate.AddMonths((int)selectedServicePackage.InternetServiceDurationMonths);
                }
                if (selectedServicePackage.TvService != null)
                {
                    selectedServicePackage.TvServiceStartingDate = DateTime.Now;
                    selectedServicePackage.TvServiceEndingDate = selectedServicePackage.TvServiceStartingDate.AddMonths((int)selectedServicePackage.TvServiceDurationMonths);
                }
                if (selectedServicePackage.PhoneService != null)
                {
                    selectedServicePackage.PhoneServiceStartingDate = DateTime.Now;
                    selectedServicePackage.PhoneServiceEndingDate = selectedServicePackage.PhoneServiceStartingDate.AddMonths((int)selectedServicePackage.PhoneServiceDurationMonths);
                }

                bool validateAddress = false;
                List<CustomerModel> customers = GlobalConfig.Connection.GetCustomer_All();
                foreach (CustomerModel customer in customers)
                {
                    if(addressNameBox.Text == customer.AddressName && int.Parse(addressNumberBox.Text) == customer.AddressNumber)
                    {
                        validateAddress = true;
                    }
                }

                if (validateAddress)
                {
                    MessageBox.Show("Customer already registered under this address, try a new address.");
                    firstNameBox.Text = "";
                    lastNameBox.Text = "";
                    addressNameBox.Text = "";
                    addressNumberBox.Text = "";
                    emailAddressBox.Text = "";
                    phoneNumberBox.Text = "";
                }

                if(!validateAddress)
                {
                    GlobalConfig.Connection.CreateServicePackage(selectedServicePackage);

                    CustomerModel customerModel = new();
                    customerModel.ServicePackage = selectedServicePackage;
                    customerModel.FirstName = firstNameBox.Text;
                    customerModel.LastName = lastNameBox.Text;
                    customerModel.AddressName = addressNameBox.Text;
                    customerModel.AddressNumber = int.Parse(addressNumberBox.Text);
                    customerModel.EmailAddress = emailAddressBox.Text;
                    customerModel.PhoneNumber = phoneNumberBox.Text;
                    customerModel.Registered = DateTime.Now;

                    GlobalConfig.Connection.CreateCustomer(customerModel);


                    MessageBox.Show("Customer Created.");
                    this.Close();


                    selectedServicePackage = new();
                    firstNameBox.Text = "";
                    lastNameBox.Text = "";
                    addressNameBox.Text = "";
                    addressNumberBox.Text = "";
                    emailAddressBox.Text = "";
                    phoneNumberBox.Text = "";
                }
               

                
            }
            else
            {
                MessageBox.Show("Invalid information.Please add all values and try again.");
            }
        }
        /// <summary>
        /// Validate Create new user form.
        /// </summary>
        /// <returns>Boolean value, true if all fields are valid, false in other cases.</returns>
        private bool ValidateForm()
        {
            bool output = true;

            if(firstNameBox.Text.Length < 1)
            {
                output = false;
            }

            if(lastNameBox.Text.Length < 1)
            {
                output=false;
            }

            if(addressNameBox.Text.Length < 1)
            {
                output = false;
            }

            int addressNum = 0;
            bool validateAddressNumber = int.TryParse(addressNumberBox.Text, out addressNum);

            if (!validateAddressNumber)
            {
                output = false;
            }

            if(addressNum < 1)
            {
                output = false;
            }

            if (emailAddressBox.Text.Length < 1)
            {
                output = false;
            }

            if (phoneNumberBox.Text.Length < 1)
            {
                output = false;
            }


            return output;
        }
    }
}
