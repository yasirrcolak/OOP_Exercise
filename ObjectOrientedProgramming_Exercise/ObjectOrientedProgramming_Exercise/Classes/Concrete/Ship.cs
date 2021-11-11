using ObjectOrientedProgramming_Exercise.Interfaces;
using System.IO;
using System.Text;

namespace ObjectOrientedProgramming_Exercise.Classes
{
    class Ship : Vehicle, IDataBaseOperations<Ship>
    {
        /// <summary>
        /// This field contains total mile.
        /// </summary>
        private int _totalMile;

        /// <summary>
        /// This integer type property contains the ship total mile.
        /// </summary>
        public int TotalMile
        {
            get
            {
                return _totalMile;
            }
            set
            {
                if (value < 0)
                {
                    _totalMile = 0;
                }
                else
                {
                    _totalMile = value;
                }
            }
        }

        /// <summary>
        /// This method adds objects derived from this class to the database.
        /// </summary>
        /// <param name="ship"></param>
        /// <param name="databaseTxtPath"></param>
        public void AddToDataBase(Ship ship, string databaseTxtPath)
        {
            File.AppendAllText(
                databaseTxtPath,

                "\n" +
                "Ship" + "#" +
                ship.Name.ToString() + "#" +
                ship.EnginePower.ToString() + "#" +
                ship.PasssengerCount.ToString() + "#" +
                ship.TypeOfVehicle.ToString() + "#" +
                ship.Color.ToString() + "#" +
                ship.TotalMile.ToString(),

                Encoding.UTF8);
        }
    }
}
