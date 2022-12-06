using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }

        public double CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        // public override void Drive()
        // {
        //     Console.WriteLine("Zoooooom!");
        // }
        // public override void Turn(string direction)
        // {
        //     Console.WriteLine("The vehicle carefully turns right.");
        // }

        // public override void Stop()
        // {
        //     Console.WriteLine("The white Cessna rolls to a stop.");
        // }


    }
}