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
    public partial class DeletePhoneService : Form
    {
        public DeletePhoneService()
        {
            InitializeComponent();
            InitializeBox();
        }
        private void InitializeBox()
        {
            phoneServicesListBox.DataSource = null;

            phoneServicesListBox.DataSource = GlobalConfig.Connection.GetPhoneService_All();
            phoneServicesListBox.DisplayMember = "Name";
        }
        private void deletePhoneServiceButton_Click(object sender, EventArgs e)
        {
            var selectedItem = (PhoneServiceModel)phoneServicesListBox.SelectedItem;
            GlobalConfig.Connection.DeletePhoneService(selectedItem);
            InitializeBox();
        }
    }
}
