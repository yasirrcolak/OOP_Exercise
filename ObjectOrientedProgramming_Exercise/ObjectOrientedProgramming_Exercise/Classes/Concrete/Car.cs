using ObjectOrientedProgramming_Exercise.Enums;
using ObjectOrientedProgramming_Exercise.Interfaces;
using System.IO;
using System.Text;

namespace ObjectOrientedProgramming_Exercise.Classes
{
    class Car : Vehicle, IDataBaseOperations<Car>
    {
        /// <summary>
        /// This field contains fuel type.
        /// </summary>
        private CarFuelType _fuelType;

        /// <summary>
        /// This field contains total kilometers.
        /// </summary>
        private int totalKilometers;

        /// <summary>
        /// This CarFuelType type property contains the car fuel type. 
        /// </summary>
        public CarFuelType FuelType
        {
            get
            {
                return _fuelType;
            }
            set
            {
                if (value != CarFuelType.Diesel && value != CarFuelType.Electric && value != CarFuelType.Gasoline && value != CarFuelType.LPG)
                {
                    _fuelType = CarFuelType.NoInfo;
                }
                else
                {
                    _fuelType = value;
                }
            }
        }

        /// <summary>
        /// This integer type property contains the car total kilometers.
        /// </summary>
        public int TotalKilometers
        {
            get
            {
                return totalKilometers;
            }
            set
            {
                if (value < 0)
                {
                    totalKilometers = 0;
                }
                else
                {
                    totalKilometers = value;
                }
            }
        }

        /// <summary>
        /// This method adds objects derived from this class to the database.
        /// </summary>
        public void AddToDataBase(Car car, string databaseTxtPath)
        {
            File.AppendAllText(
                databaseTxtPath,

                "\n" +
                "Car" + "#" +
                car.Name.ToString() + "#" +
                car.EnginePower.ToString() + "#" +
                car.PasssengerCount.ToString() + "#" +
                car.TypeOfVehicle.ToString() + "#" +
                car.Color.ToString() + "#" +
                car.TotalKilometers.ToString(),

                Encoding.UTF8);
        }
    }
}
