using ObjectOrientedProgramming_Exercise.Enums;

namespace ObjectOrientedProgramming_Exercise.Classes
{
    abstract class Vehicle
    {
        /// <summary>
        /// This string type property contains the vehicle name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// This integer type property contains the vehicle engine power.
        /// </summary>
        public int EnginePower { get; set; }

        /// <summary>
        /// This integer type property contains the vehicle passenger count.
        /// </summary>
        public int PasssengerCount { get; set; }

        /// <summary>
        /// This Colors type property contains the vehicle color.
        /// </summary>
        public Colors Color { get; set; }

        /// <summary>
        /// This VehicleType type property contains the vehicle type.
        /// </summary>
        public VehicleType TypeOfVehicle { get; set; }
    }
}