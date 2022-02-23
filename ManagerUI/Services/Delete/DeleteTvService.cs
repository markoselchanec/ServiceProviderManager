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
    public partial class DeleteTvService : Form
    {
        public DeleteTvService()
        {
            InitializeComponent();
            InitializeBox();
        }
        private void InitializeBox()
        {
            tvServiceListBox.DataSource = null;

            tvServiceListBox.DataSource = GlobalConfig.Connection.GetTvService_All();
            tvServiceListBox.DisplayMember = "Name";
        }
        private void deleteTvServiceButton_Click_1(object sender, EventArgs e)
        {
            var selectedItem = (TvServiceModel)tvServiceListBox.SelectedItem;
            GlobalConfig.Connection.DeleteTvService(selectedItem);
            InitializeBox();
        }
    }
}
