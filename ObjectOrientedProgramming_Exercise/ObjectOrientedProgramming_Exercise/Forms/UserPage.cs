using ObjectOrientedProgramming_Exercise.Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace ObjectOrientedProgramming_Exercise
{
    public partial class UserPage : Form
    {
        /// <summary>
        /// This string array contains all vehicle details.
        /// </summary>
        private string[] _allVehicle = File.ReadAllLines(@"..\..\Datas\Data.txt");

        /// <summary>
        /// This string array contains vehicle details.
        /// </summary>
        private string[] _vehicleDetails;

        /// <summary>
        /// This string contains detail vehicle name.
        /// </summary>
        public static string _detailVehicleName;

        public UserPage()
        {
            InitializeComponent();
        }

        #region Events

        /// <summary>
        /// User Page load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserPage_Load(object sender, EventArgs e)
        {
            // listview configurations.
            vehiclesListView.View = View.Details;
            vehiclesListView.GridLines = true;

            // add columns.
            vehiclesListView.Columns.Add("İsim", 100);
            vehiclesListView.Columns.Add("Motor Gücü", 170);
            vehiclesListView.Columns.Add("Yolcu Kapasitesi", 220);
            vehiclesListView.Columns.Add("Araç Tipi", 120);
            vehiclesListView.Columns.Add("Color", 100);

            AllVehiclesAddToCombobox();
        }

        /// <summary>
        /// Back button method. Go to Login Page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            var loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        /// <summary>
        /// Combobox selected index changed event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vehiclesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            vehiclesListView.Items.Clear();

            AddToSelectedVehicleToListView(vehicleNamesComboBox.Text);
        }

        /// <summary>
        /// listview double click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vehiclesListView_DoubleClick(object sender, EventArgs e)
        {
            _detailVehicleName = vehiclesListView.SelectedItems[0].Text.ToString();

            DetailsPage detailsPage = new DetailsPage();
            detailsPage.Show();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Items added to vehicle names combobox.
        /// </summary>
        private void AllVehiclesAddToCombobox()
        {
            vehicleNamesComboBox.Items.Add("Car");
            vehicleNamesComboBox.Items.Add("Plane");
            vehicleNamesComboBox.Items.Add("Ship");
            vehicleNamesComboBox.Items.Add("Train");
        }

        /// <summary>
        /// Select vehicle add to listview.
        /// </summary>
        /// <param name="vehicleClassName"></param>
        private void AddToSelectedVehicleToListView(string vehicleClassName)
        {
            // Clear to all vehicle string array.
            _allVehicle = File.ReadAllLines(@"..\..\Datas\Data.txt");

            int count = 0;

            for (int i = 0; i < _allVehicle.Length; i++)
            {

                _vehicleDetails = _allVehicle[i].Split('#');

                if (_vehicleDetails[0] == vehicleClassName)
                {
                    vehiclesListView.Items.Add(_vehicleDetails[1]);
                    vehiclesListView.Items[count].SubItems.Add(_vehicleDetails[2]);
                    vehiclesListView.Items[count].SubItems.Add(_vehicleDetails[3]);
                    vehiclesListView.Items[count].SubItems.Add(_vehicleDetails[4]);
                    vehiclesListView.Items[count].SubItems.Add(_vehicleDetails[5]);
                    vehiclesListView.Items[count].SubItems.Add(_vehicleDetails[6]);
                    count++;
                }
            }

        }

        #endregion

    }
}
