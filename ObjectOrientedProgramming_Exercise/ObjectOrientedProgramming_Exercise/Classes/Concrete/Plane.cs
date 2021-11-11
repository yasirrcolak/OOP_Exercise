using ObjectOrientedProgramming_Exercise.Interfaces;
using System.IO;
using System.Text;

namespace ObjectOrientedProgramming_Exercise.Classes
{
    class Plane : Vehicle, IDataBaseOperations<Plane>
    {
        /// <summary>
        /// This field contains wingspan.
        /// </summary>
        private int _wingspan;

        /// <summary>
        /// This int type property contains the plane wingspan.
        /// </summary>
        public int Wingspan
        {
            get
            {
                return _wingspan;
            }
            set
            {
                if (value < 0)
                {
                    _wingspan = 0;
                }
                else
                {
                    _wingspan = value;
                }
            }
        }

        /// <summary>
        /// This method adds objects derived from this class to the database.
        /// </summary>
        /// <param name="plane"></param>
        /// <param name="databaseTxtPath"></param>
        public void AddToDataBase(Plane plane, string databaseTxtPath)
        {
            File.AppendAllText(
                databaseTxtPath,

                "\n" +
                "Plane" + "#" +
                plane.Name.ToString() + "#" +
                plane.EnginePower.ToString() + "#" +
                plane.PasssengerCount.ToString() + "#" +
                plane.TypeOfVehicle.ToString() + "#" +
                plane.Color.ToString() + "#" +
                plane.Wingspan.ToString(),

                Encoding.UTF8);
        }
    }
}
