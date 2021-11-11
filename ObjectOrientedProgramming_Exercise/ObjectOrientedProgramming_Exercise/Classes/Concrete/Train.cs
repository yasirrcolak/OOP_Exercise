using ObjectOrientedProgramming_Exercise.Interfaces;
using System.IO;
using System.Text;

namespace ObjectOrientedProgramming_Exercise.Classes
{
    class Train : Vehicle, IDataBaseOperations<Train>
    {
        /// <summary>
        /// This field contains number of vagons.
        /// </summary>
        private int _numberOfWagons;

        /// <summary>
        /// This integer type property contains the train number of wagons.
        /// </summary>
        public int NumberOfWagons
        {
            get
            {
                return _numberOfWagons;
            }
            set
            {
                if (value < 1)
                {
                    _numberOfWagons = 1;
                }
                else
                {
                    _numberOfWagons = value;
                }
            }
        }

        /// <summary>
        /// This method adds objects derived from this class to the database.
        /// </summary>
        /// <param name="train"></param>
        /// <param name="databaseTxtPath"></param>
        public void AddToDataBase(Train train, string databaseTxtPath)
        {
            File.AppendAllText(
                databaseTxtPath,

                "\n" +
                "Train" + "#" +
                train.Name.ToString() + "#" +
                train.EnginePower.ToString() + "#" +
                train.PasssengerCount.ToString() + "#" +
                train.TypeOfVehicle.ToString() + "#" +
                train.Color.ToString() + "#" +
                train.NumberOfWagons.ToString(),

                Encoding.UTF8);
        }
    }
}
