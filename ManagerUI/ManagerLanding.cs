using ManagerUI.Customer;
using ManagerUI.Services.Delete;

namespace ManagerUI
{
    public partial class ManagerLanding : Form
    {
        public ManagerLanding()
        {
            InitializeComponent();
        }

        private void searchCustomerButton_Click(object sender, EventArgs e)
        {
            SearchCustomer searchCustomer = new();
            searchCustomer.Show();
        }

        private void createCustomer_Click(object sender, EventArgs e)
        {
            CreateCustomer createCustomer = new();
            createCustomer.Show();
        }

        private void createNewInternetService_Click(object sender, EventArgs e)
        {
            CreateInternetService createInternetService = new();
            createInternetService.Show();
        }

        private void createNewTvService_Click(object sender, EventArgs e)
        {
            CreateTvService createTvService = new();
            createTvService.Show();
        }

        private void createNewPhoneService_Click(object sender, EventArgs e)
        {
            CreatePhoneService createPhoneService = new();
            createPhoneService.Show();
        }

        private void deleteInternetServiceButton_Click(object sender, EventArgs e)
        {
            DeleteInternetService deleteInternetService = new();
            deleteInternetService.Show();
        }

        private void deleteTvServiceButton_Click(object sender, EventArgs e)
        {
            DeleteTvService deleteTvService = new();
            deleteTvService.Show();
        }

        private void deletePhoneServiceButton_Click(object sender, EventArgs e)
        {
            DeletePhoneService deletePhoneService = new();
            deletePhoneService.Show();
        }

        private void allCustomers_Click(object sender, EventArgs e)
        {
            AllCustomers allCustomers = new();
            allCustomers.Show();
        }
    }
}