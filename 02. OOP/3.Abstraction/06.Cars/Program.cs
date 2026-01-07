namespace _06.Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cmdCar=Console.ReadLine().Split(' ').ToList();
            Car car = new Car(double.Parse(cmdCar[1]), double.Parse(cmdCar[2]));

            var cmdTruck= Console.ReadLine().Split(' ').ToList();
            Truck truck = new Truck(double.Parse(cmdTruck[1]), double.Parse(cmdTruck[2]));

            int n=int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var cmd=Console.ReadLine().Split(' ').ToList();

                var deystvie = cmd[0];
                var type=cmd[1];
                var stoynost=double.Parse(cmd[2]);

                if (deystvie=="Drive")
                {
                    if (type=="Car")
                    {
                        car.Drive(stoynost);
                    }
                    else if (type == "Truck")
                    {
                        truck.Drive(stoynost);
                    }
                }

                if (deystvie == "Refuel")
                {
                    if (type == "Car")
                    {
                        car.Refuel(stoynost);
                    }
                    else if (type == "Truck")
                    {
                        truck.Refuel(stoynost);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine(car);
            Console.WriteLine(truck);

        }
    }
}
