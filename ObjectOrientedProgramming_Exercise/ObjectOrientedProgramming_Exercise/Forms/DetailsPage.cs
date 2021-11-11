using System;
using System.IO;
using System.Windows.Forms;

namespace ObjectOrientedProgramming_Exercise.Forms
{
    public partial class DetailsPage : Form
    {
        // This string array contains all vehicle.
        private string[] _allVehicle = File.ReadAllLines(@"..\..\Datas\Data.txt");

        // This string array contains vehicle details.
        private string[] _vehicleDetails;

        public DetailsPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Details Page load method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailsPage_Load(object sender, EventArgs e)
        {
            // listview configurations.
            vehicleDetailListView.View = View.Details;
            vehicleDetailListView.GridLines = true;

            AddColumnToListView();

            AddVehicleToListView();
        }

        /// <summary>
        /// Add columns to listview.
        /// </summary>
        private void AddColumnToListView()
        {
            // Clear to all vehicle string array.
            _allVehicle = File.ReadAllLines(@"..\..\Datas\Data.txt");

            for (int i = 0; i < _allVehicle.Length; i++)
            {
                _vehicleDetails = _allVehicle[i].Split('#');

                //if the clicked vehicle is equal to the vehicle in the index
                if (UserPage._detailVehicleName == _vehicleDetails[1])
                {
                    // add columns.
                    if (_vehicleDetails[0] == "Car")
                    {
                        vehicleDetailListView.Columns.Add("İsim", 100);
                        vehicleDetailListView.Columns.Add("Motor Gücü", 170);
                        vehicleDetailListView.Columns.Add("Yolcu Kapasitesi", 220);
                        vehicleDetailListView.Columns.Add("Araç Tipi", 120);
                        vehicleDetailListView.Columns.Add("Color", 100);
                        vehicleDetailListView.Columns.Add("Toplam KM", 170);
                        return;
                    }
                    else if (_vehicleDetails[0] == "Plane")
                    {
                        vehicleDetailListView.Columns.Add("İsim", 100);
                        vehicleDetailListView.Columns.Add("Motor Gücü", 170);
                        vehicleDetailListView.Columns.Add("Yolcu Kapasitesi", 220);
                        vehicleDetailListView.Columns.Add("Araç Tipi", 120);
                        vehicleDetailListView.Columns.Add("Color", 100);
                        vehicleDetailListView.Columns.Add("Kanat Boyu", 175);
                        return;
                    }
                    else if (_vehicleDetails[0] == "Ship")
                    {
                        vehicleDetailListView.Columns.Add("İsim", 100);
                        vehicleDetailListView.Columns.Add("Motor Gücü", 170);
                        vehicleDetailListView.Columns.Add("Yolcu Kapasitesi", 220);
                        vehicleDetailListView.Columns.Add("Araç Tipi", 120);
                        vehicleDetailListView.Columns.Add("Color", 100);
                        vehicleDetailListView.Columns.Add("Toplam MİL", 170);
                        return;
                    }
                    else if (_vehicleDetails[0] == "Train")
                    {
                        vehicleDetailListView.Columns.Add("İsim", 100);
                        vehicleDetailListView.Columns.Add("Motor Gücü", 170);
                        vehicleDetailListView.Columns.Add("Yolcu Kapasitesi", 220);
                        vehicleDetailListView.Columns.Add("Araç Tipi", 120);
                        vehicleDetailListView.Columns.Add("Color", 100);
                        vehicleDetailListView.Columns.Add("Vagon Sayısı", 170);
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Add vehicle to listview.
        /// </summary>
        private void AddVehicleToListView()
        {
            vehicleDetailListView.Items.Add(_vehicleDetails[1]);
            vehicleDetailListView.Items[0].SubItems.Add(_vehicleDetails[2]);
            vehicleDetailListView.Items[0].SubItems.Add(_vehicleDetails[3]);
            vehicleDetailListView.Items[0].SubItems.Add(_vehicleDetails[4]);
            vehicleDetailListView.Items[0].SubItems.Add(_vehicleDetails[5]);
            vehicleDetailListView.Items[0].SubItems.Add(_vehicleDetails[6]);
        }
    }
}
