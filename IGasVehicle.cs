using System;

namespace Garage
{

    public interface IGasVehicle
    {
        double FuelCapacity { get; set; }

        double CurrentTankPercentage { get; }
        void RefuelTank();

    }
}