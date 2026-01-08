using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Cars
{
    public class Car : IVehicle
    {
        public Car(double fuel, double litersPerKm, double fuelCapacity)
        {
            Fuel = fuel;
            LitersPerKm = litersPerKm + 0.9;
            FuelCapacity = fuelCapacity;
            Distance = 0;            
        }

        public double Fuel { get ; set ; }
        public double LitersPerKm { get ; set ; }
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

        public void Refuel(double litres)
        {
            if (litres < 0 || litres > FuelCapacity)
            {
                Console.WriteLine("Cannot fit fuel in car");
            }
            else
            {
                Fuel += litres; // 100%
            }
           
        }

        public override string ToString()
        {
            return $"{GetType().Name} : {Fuel:f2}";
        }
    }
}
