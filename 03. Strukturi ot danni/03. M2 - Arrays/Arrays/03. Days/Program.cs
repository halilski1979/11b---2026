namespace _03._Days
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = new int[]  {11,23,33,4,5};
            Console.WriteLine(string.Join(' ',num));

            string[] days = {"Monday","Tuesday","Wednesday","Thursday",
                    "Friday",
                    "Saturday",
                    "Sunday"
                              };

            foreach (var item in days)
            {
                Console.WriteLine(item);
            }
        }
    }
}
