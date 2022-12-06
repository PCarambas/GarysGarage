using System;

namespace Garage
{
    public class Cessna : Vehicle
    {


        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine("Zoooooom!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine("The vehicle carefully turns right.");
        }

        public override void Stop()
        {
            Console.WriteLine("The white Cessna rolls to a stop.");
        }


    }
}