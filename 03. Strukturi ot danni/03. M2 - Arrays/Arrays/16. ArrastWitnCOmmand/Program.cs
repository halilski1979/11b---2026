namespace _16._ArrastWitnCOmmand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var cmd = Console.ReadLine().Split(' ').ToList();

            while (true)
            {
                if (cmd[0] == "end")
                {
                    break;
                }

                if (cmd[0] == "Contains")
                {
                    if (list.Contains(int.Parse(cmd[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else 
                    {
                        Console.WriteLine("No such number");
                    }
                }


                if (cmd[0] == "PrintEven")
                {
                    var listEven = new List<int>();
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] % 2 == 0)
                        {
                            listEven.Add(list[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", listEven));
                }
                if (cmd[0] == "PrintOdd")
                {
                    var listOdd = new List<int>();
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] % 2 != 0)
                        {
                            listOdd.Add(list[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", listOdd));
                }
                if (cmd[0] == "GetSum")
                {
                    Console.WriteLine(list.Sum());
                }
                if (cmd[0] == "Filter")
                {
                    var list2 = new List<int>();
                    int num = int.Parse(cmd[2]);
                    if (cmd[1] == "<")
                    {
                        list2 = list.Where(x => x < num).ToList();
                        Console.WriteLine(string.Join(" ",list2));
                    }
                    if (cmd[1] == ">")
                    {
                        list2 = list.Where(x => x > num).ToList();
                        Console.WriteLine(string.Join(" ", list2));
                    }
                    if (cmd[1] == ">=")
                    {
                        list2 = list.Where(x => x >= num).ToList();
                        Console.WriteLine(string.Join(" ", list2));
                    }
                    if (cmd[1] == "<=")
                    {
                        list2 = list.Where(x => x <= num).ToList();
                        Console.WriteLine(string.Join(" ", list2));
                    }
                }
                cmd = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}
