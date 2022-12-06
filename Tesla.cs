using System;
namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public double CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {

            CurrentChargePercentage = 100;
        }
    }
}

