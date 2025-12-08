namespace _04._Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<BaseEmployee> baseEmployees = new List<BaseEmployee>();

            while (true)
            {
                Console.Write("Employee ID: ");
                string id=Console.ReadLine();

                if (id=="END")
                {
                    break;
                }

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Adress: ");
                string adress = Console.ReadLine();

                Console.WriteLine($"Type (FullTime / Contract): ");
                string type=Console.ReadLine();

                if (type=="fulltime")
                {
                    Console.Write("POSTION: ");
                    string position = Console.ReadLine();

                    Console.Write("Department: ");
                    string department = Console.ReadLine();

                    Console.Write("Working hours: ");
                    int workingHours=int.Parse(Console.ReadLine());
                     
                    BaseEmployee employee = new FullTimeEmployee(id,name,adress,position,department);
                    baseEmployees.Add(employee);

                    double salary = employee.CalculateSalary(workingHours);
                    Console.WriteLine(salary);
                }


                if (type == "contract")
                {
                    Console.Write("Task: ");
                    string task = Console.ReadLine();

                    Console.Write("Department: ");
                    string department = Console.ReadLine();

                    Console.Write("Working hours: ");
                    int workingHours = int.Parse(Console.ReadLine());

                    BaseEmployee employee = new ContractEmployee(id, name, adress, task, department);
                    baseEmployees.Add(employee);
                    double salary = employee.CalculateSalary(workingHours);
                    Console.WriteLine(salary);
                }              

            }

            foreach (var item in baseEmployees)
            {
                item.Show();
                item.GetDepartment();
                Console.WriteLine($"Salary: {item}");
            }
        }
    }
}
