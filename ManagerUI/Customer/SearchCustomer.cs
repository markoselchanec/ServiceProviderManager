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
    public partial class SearchCustomer : Form
    {
        private CustomerModel customerModel = new();
        public SearchCustomer()
        {
            InitializeComponent();

        }

        private void searchUserButton_Click(object sender, EventArgs e)
        {
            SearchWorker();
        }



        private void SearchWorker()
        {
            if(ValidateData())
            {
                customerModel = GlobalConfig.Connection.GetCustomer_ByAddressNameAndNumber(searchAddressNameBox.Text, int.Parse(searchAddressNumberBox.Text));
                if(customerModel != null)
                {
                    DashboardCustomer dashboardCustomer = new(customerModel);
                    dashboardCustomer.Show();
                }
                if (customerModel == null)
                {
                    MessageBox.Show("No such customer.");
                }

            } 
            else if(!ValidateData())
            {
                MessageBox.Show("Please input valid info.");
            }
            searchAddressNameBox.Text = "";
            searchAddressNumberBox.Text = "";
        }

        private bool ValidateData()
        {
            bool output = true;
            int searchAddressNumber = 0;
            bool searchAddressNumberValid = int.TryParse(searchAddressNumberBox.Text, out searchAddressNumber);

            if (!searchAddressNumberValid)
            {
                output = false;
            }

            if(searchAddressNumber < 0)
            {
                output=false;
            }


            return output;
        }
    }
}
