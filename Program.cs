using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                MainColor = "Purple",
                MaximumOccupancy = 2,
                BatteryKWh = 20.25
            };

            Tesla modelS = new Tesla()
            {
                MainColor = "Black",
                MaximumOccupancy = 4,
                BatteryKWh = 20.25
            };

            Cessna mx410 = new Cessna()
            {
                MainColor = "White",
                MaximumOccupancy = 4,
                FuelCapacity = 200
            };

            Ram HD1500 = new Ram()
            {
                MainColor = "Silver",
                MaximumOccupancy = 4,
                FuelCapacity = 50
            };

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            HD1500.Drive();
            Console.WriteLine();
            fxs.Turn("left");
            modelS.Turn("right");
            mx410.Turn("left");
            HD1500.Turn("right");
            Console.WriteLine();
            fxs.Stop();
            modelS.Stop();
            mx410.Stop();
            HD1500.Stop();

        }
    }
}
