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
    public partial class AllCustomers : Form
    {
        List<CustomerModel> customers = GlobalConfig.Connection.GetCustomer_All();
        public AllCustomers()
        {
            InitializeComponent();
            WireUp();
        }
        private void WireUp()
        {
            foreach (CustomerModel c in customers)
            {
                this.customerDataGridView.Rows.Add(c.FirstName,c.LastName,c.AddressName,c.AddressNumber,c.PhoneNumber,c.EmailAddress);
            }
        }

        private void allCustomersSlectCustomerButton_Click(object sender, EventArgs e)
        {
            string addressName = customerDataGridView.CurrentRow.Cells[2].Value.ToString();
            int addressNum = int.Parse(customerDataGridView.CurrentRow.Cells[3].Value.ToString());
            DashboardCustomer dc = new(GlobalConfig.Connection.GetCustomer_ByAddressNameAndNumber(addressName,addressNum));
            dc.Show();
            this.Close();
        }
    }
}
