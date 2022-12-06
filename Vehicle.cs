using System;
namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public double FuelCapacity { get; set; }

        public double BatteryKWh { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The {this} quickly turns {direction}.");
        }

        public virtual void Stop()
        {
            Console.WriteLine($"The {this} comes to a fast stop!");
        }

        public override string ToString()
        {
            return MainColor + GetType().Name;

        }
    }
}