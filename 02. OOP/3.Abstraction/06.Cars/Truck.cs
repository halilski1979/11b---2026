using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Cars
{
    internal class Truck : IVehicle
    {
        public Truck(double fuel, double litersPerKm)
        {
            Fuel = fuel;
            LitersPerKm = litersPerKm+1.6;
            Distance = 0;
        }

        public double Fuel { get ; set ; }
        public double LitersPerKm { get; set ; }
        public double Distance { get ; set ; }
        public double FuelCapacity { get ; set ; }

        public void Drive(double km)
        {
            var travelLiters = LitersPerKm * km;
            if (travelLiters <= Fuel)
            {
                Fuel -= travelLiters;
                Distance += km;
                Console.WriteLine($"{GetType().Name} travelled {Distance} km");               
            }
            else
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
        }

        public void Refuel(double liters)
        {
           Fuel += (liters*0.95);
        }

        public override string ToString()
        {
            return $"{GetType().Name} : {Fuel:f2}";
        }

    }
}
