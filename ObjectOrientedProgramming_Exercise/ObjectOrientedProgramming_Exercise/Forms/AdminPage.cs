using ObjectOrientedProgramming_Exercise.Classes;
using ObjectOrientedProgramming_Exercise.Enums;
using System;
using System.Windows.Forms;

namespace ObjectOrientedProgramming_Exercise
{
    public partial class AdminPage : Form
    {
        /// <summary>
        /// This string field contains database path.
        /// </summary>
        private string _databaseTxtPath = @"..\..\Datas\Data.txt";

        public AdminPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Admin Page Load method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminPage_Load(object sender, EventArgs e)
        {
            // call to 'Items add to comboboxes' method.
            ItemsAddToComboBoxes();
        }

        #region Events

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
        private void memberNames_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vehicleNamesComboBox.Text == "Car")
            {
                newVehicleVariableLabel.Text = "Toplam KM:";
            }
            else if (vehicleNamesComboBox.Text == "Plane")
            {
                newVehicleVariableLabel.Text = "Kanat Boyu:";
            }
            else if (vehicleNamesComboBox.Text == "Ship")
            {
                newVehicleVariableLabel.Text = "Toplam MİL:";
            }
            else if (vehicleNamesComboBox.Text == "Train")
            {
                newVehicleVariableLabel.Text = "Vagon Sayısı:";
            }
        }

        /// <summary>
        /// Save button click method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            // call to 'Check to entered informations' method.
            if (CheckToEnteredInformations() == true)
            {
                // call to 'Save Vehicle' method.
                SaveVehicle(vehicleNamesComboBox.Text);
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Items add to comboboxes.
        /// </summary>
        private void ItemsAddToComboBoxes()
        {
            // Items added to vehicle names combobox.
            vehicleNamesComboBox.Items.Add("Car");
            vehicleNamesComboBox.Items.Add("Plane");
            vehicleNamesComboBox.Items.Add("Ship");
            vehicleNamesComboBox.Items.Add("Train");

            // Items added to vehicle type combobox.
            newVehicleTypeComboBox.Items.Add(VehicleType.Commercial);
            newVehicleTypeComboBox.Items.Add(VehicleType.Personal);

            // items addded to vehicle color combobox.
            newVehicleColorComboBox.Items.Add(Colors.Black);
            newVehicleColorComboBox.Items.Add(Colors.Blue);
            newVehicleColorComboBox.Items.Add(Colors.Green);
            newVehicleColorComboBox.Items.Add(Colors.Red);
            newVehicleColorComboBox.Items.Add(Colors.White);
            newVehicleColorComboBox.Items.Add(Colors.Yellow);
        }

        /// <summary>
        /// Check to entered new vehicle informations.
        /// </summary>
        /// <returns>if checked is right return true else return false.</returns>
        private bool CheckToEnteredInformations()
        {
            if (vehicleNamesComboBox.Text == "")
            {
                MessageBox.Show("Lütfen 'Araç Sınıfı Seçiniz' bilgisini girin.");
                return false;
            }
            else if (newVehicleNameTextBox.Text == "")
            {
                MessageBox.Show("Lütfen 'Araç Adı' bilgisini girin.");
                return false;
            }
            else if (newVehicleEnginePowerNumericUpDown.Value == 0)
            {
                MessageBox.Show("Lütfen 'Motor Gücü' bilgis girin.");
                return false;
            }
            else if (newVehiclePassengerCountNumericUpDown.Value == 0)
            {
                MessageBox.Show("Lütfen 'Yolcu kapasitesi' bilgis girin.");
                return false;
            }
            else if (newVehicleTypeComboBox.Text == "")
            {
                MessageBox.Show("Lütfen 'Araç Tipi' bilgis girin.");
                return false;
            }
            else if (newVehicleColorComboBox.Text == "")
            {
                MessageBox.Show("Lütfen 'Araç Rengi' bilgis girin.");
                return false;
            }
            else if (newVehicleVariableNumericUpDown.Value < 0)
            {
                MessageBox.Show("Lütfen " + newVehicleVariableLabel.Text + " bilgisi girin.");
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// This method save vehicle to database.
        /// </summary>
        /// <param name="vehicleClass"></param>
        public void SaveVehicle(string vehicleClass)
        {
            if (vehicleClass == "Car")
            {
                var newCar = new Car();

                newCar.Name = newVehicleNameTextBox.Text;

                newCar.EnginePower = Convert.ToInt32(newVehicleEnginePowerNumericUpDown.Value);

                newCar.PasssengerCount = Convert.ToInt32(newVehiclePassengerCountNumericUpDown.Value);

                if (newVehicleColorComboBox.Text == "White")
                {
                    newCar.Color = Colors.White;
                }
                else if (newVehicleColorComboBox.Text == "Black")
                {
                    newCar.Color = Colors.Black;
                }
                else if (newVehicleColorComboBox.Text == "Red")
                {
                    newCar.Color = Colors.Red;
                }
                else if (newVehicleColorComboBox.Text == "Blue")
                {
                    newCar.Color = Colors.Blue;
                }
                else if (newVehicleColorComboBox.Text == "Green")
                {
                    newCar.Color = Colors.Green;
                }
                else if (newVehicleColorComboBox.Text == "Yellow")
                {
                    newCar.Color = Colors.Yellow;
                }

                if (newVehicleTypeComboBox.Text == "Commercial")
                {
                    newCar.TypeOfVehicle = VehicleType.Commercial;
                }
                else if (newVehicleTypeComboBox.Text == "Personal")
                {
                    newCar.TypeOfVehicle = VehicleType.Personal;
                }

                newCar.TotalKilometers = Convert.ToInt32(newVehicleVariableNumericUpDown.Value);

                // new car save to database.
                newCar.AddToDataBase(newCar, _databaseTxtPath);

                MessageBox.Show("Yeni Araba Kaydedildi.");

            }
            else if (vehicleClass == "Plane")
            {
                var newPlane = new Plane();

                newPlane.Name = newVehicleNameTextBox.Text;

                newPlane.EnginePower = Convert.ToInt32(newVehicleEnginePowerNumericUpDown.Value);

                newPlane.PasssengerCount = Convert.ToInt32(newVehiclePassengerCountNumericUpDown.Value);

                if (newVehicleColorComboBox.Text == "White")
                {
                    newPlane.Color = Colors.White;
                }
                else if (newVehicleColorComboBox.Text == "Black")
                {
                    newPlane.Color = Colors.Black;
                }
                else if (newVehicleColorComboBox.Text == "Red")
                {
                    newPlane.Color = Colors.Red;
                }
                else if (newVehicleColorComboBox.Text == "Blue")
                {
                    newPlane.Color = Colors.Blue;
                }
                else if (newVehicleColorComboBox.Text == "Green")
                {
                    newPlane.Color = Colors.Green;
                }
                else if (newVehicleColorComboBox.Text == "Yellow")
                {
                    newPlane.Color = Colors.Yellow;
                }

                if (newVehicleTypeComboBox.Text == "Commercial")
                {
                    newPlane.TypeOfVehicle = VehicleType.Commercial;
                }
                else if (newVehicleTypeComboBox.Text == "Personal")
                {
                    newPlane.TypeOfVehicle = VehicleType.Personal;
                }

                newPlane.Wingspan = Convert.ToInt32(newVehicleVariableNumericUpDown.Value);

                // new plane save to database.
                newPlane.AddToDataBase(newPlane, _databaseTxtPath);

                MessageBox.Show("Yeni Uçak Kaydedildi.");

            }
            else if (vehicleClass == "Ship")
            {
                var newShip = new Ship();

                newShip.Name = newVehicleNameTextBox.Text;

                newShip.EnginePower = Convert.ToInt32(newVehicleEnginePowerNumericUpDown.Value);

                newShip.PasssengerCount = Convert.ToInt32(newVehiclePassengerCountNumericUpDown.Value);

                if (newVehicleColorComboBox.Text == "White")
                {
                    newShip.Color = Colors.White;
                }
                else if (newVehicleColorComboBox.Text == "Black")
                {
                    newShip.Color = Colors.Black;
                }
                else if (newVehicleColorComboBox.Text == "Red")
                {
                    newShip.Color = Colors.Red;
                }
                else if (newVehicleColorComboBox.Text == "Blue")
                {
                    newShip.Color = Colors.Blue;
                }
                else if (newVehicleColorComboBox.Text == "Green")
                {
                    newShip.Color = Colors.Green;
                }
                else if (newVehicleColorComboBox.Text == "Yellow")
                {
                    newShip.Color = Colors.Yellow;
                }

                if (newVehicleTypeComboBox.Text == "Commercial")
                {
                    newShip.TypeOfVehicle = VehicleType.Commercial;
                }
                else if (newVehicleTypeComboBox.Text == "Personal")
                {
                    newShip.TypeOfVehicle = VehicleType.Personal;
                }

                newShip.TotalMile = Convert.ToInt32(newVehicleVariableNumericUpDown.Value);

                // new ship save to database.
                newShip.AddToDataBase(newShip, _databaseTxtPath);

                MessageBox.Show("Yeni Gemi Kaydedildi.");
            }
            else if (vehicleClass == "Train")
            {
                var newTrain = new Train();

                newTrain.Name = newVehicleNameTextBox.Text;

                newTrain.EnginePower = Convert.ToInt32(newVehicleEnginePowerNumericUpDown.Value);

                newTrain.PasssengerCount = Convert.ToInt32(newVehiclePassengerCountNumericUpDown.Value);

                if (newVehicleColorComboBox.Text == "White")
                {
                    newTrain.Color = Colors.White;
                }
                else if (newVehicleColorComboBox.Text == "Black")
                {
                    newTrain.Color = Colors.Black;
                }
                else if (newVehicleColorComboBox.Text == "Red")
                {
                    newTrain.Color = Colors.Red;
                }
                else if (newVehicleColorComboBox.Text == "Blue")
                {
                    newTrain.Color = Colors.Blue;
                }
                else if (newVehicleColorComboBox.Text == "Green")
                {
                    newTrain.Color = Colors.Green;
                }
                else if (newVehicleColorComboBox.Text == "Yellow")
                {
                    newTrain.Color = Colors.Yellow;
                }

                if (newVehicleTypeComboBox.Text == "Commercial")
                {
                    newTrain.TypeOfVehicle = VehicleType.Commercial;
                }
                else if (newVehicleTypeComboBox.Text == "Personal")
                {
                    newTrain.TypeOfVehicle = VehicleType.Personal;
                }

                newTrain.NumberOfWagons = Convert.ToInt32(newVehicleVariableNumericUpDown.Value);

                // new train save to database.
                newTrain.AddToDataBase(newTrain, _databaseTxtPath);

                MessageBox.Show("Yeni Tren Kaydedildi.");
            }
        }

        #endregion

    }
}
