namespace _06.Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            Car car = new Car(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));

            var inputTruck = Console.ReadLine().Split(' ').ToArray();
            Truck truck = new Truck(double.Parse(inputTruck[1]), double.Parse(inputTruck[2]), double.Parse(inputTruck[3]));
            var inputB = Console.ReadLine().Split(' ').ToArray();
            Bus bus = new Bus(double.Parse(inputB[1]), double.Parse(inputB[2]), double.Parse(inputB[3]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var cmd = Console.ReadLine().Split(' ').ToArray();
                if (cmd[0] == "Drive")
                {
                    var km = double.Parse(cmd[2]);
                    if (cmd[1] == "Car")
                    {
                        car.Drive(km);
                    }
                    if (cmd[1] == "Truck")
                    {
                        truck.Drive(km);
                    }
                    if (cmd[1] == "Bus")
                    {
                        bus.Drive(km);
                    }
                }

                if (cmd[0] == "Refuel")
                {
                    var liters = double.Parse(cmd[2]);
                    if (cmd[1] == "Car")
                    {
                        car.Refuel(liters);
                    }
                    if (cmd[1] == "Truck")
                    {
                        truck.Refuel(liters);
                    }
                    if (cmd[1] == "Bus")
                    {
                        bus.Refuel(liters);
                    }
                    else
                    {
                        bus.Passangers = false;
                        bus.Drive(double.Parse(cmd[2]));
                    }
                }

               


            }

            Console.WriteLine($"Car: {car.Fuel:f2}");
            Console.WriteLine($"Truck: {truck.Fuel:f2}");
            Console.WriteLine($"Bus: {bus.Fuel:f2}");

        }
    }
}
