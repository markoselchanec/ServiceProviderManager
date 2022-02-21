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

namespace ManagerUI.Services.Delete
{
    public partial class DeleteInternetService : Form
    {
        public DeleteInternetService()
        {
            InitializeComponent();
            InitializeBox();
        }

        private void InitializeBox()
        {
            internetServicesListBox.DataSource = null;

            internetServicesListBox.DataSource = GlobalConfig.Connection.GetInternetService_All();
            internetServicesListBox.DisplayMember = "Name";
        }

        private void deleteInternetServiceButton_Click(object sender, EventArgs e)
        {
            var selectedItem = (InternetServiceModel)internetServicesListBox.SelectedItem;
            GlobalConfig.Connection.DeleteInternetService(selectedItem);
            InitializeBox();
        }
    }
}
