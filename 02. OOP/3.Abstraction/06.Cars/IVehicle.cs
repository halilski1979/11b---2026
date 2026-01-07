using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Cars
{
    public interface IVehicle
    {
        void Drive(double km);
        void Refuel(double liters);

        double Fuel { get; set; }
        double LitersPerKm { get; set; }
        double Distance { get; set; }
        double FuelCapacity { get; set; }
    }
}
