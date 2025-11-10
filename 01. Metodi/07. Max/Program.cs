namespace _07._Max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Max2(2,5,7));
        }

        public static void Max()

        {
            Console.Write("a=");
            int a =int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            int c = int.Parse(Console.ReadLine());

           if (a>=b && a>=c)
            {
                Console.WriteLine(a);
            }
            else if (b>=c && b>= a)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
        public static int Max2(int a,int b,int c)
        {
            if (a >= b && a >= c)
            {
                return a;
            }
            else if (b >= c && b >= a)
            {
                return b;
            }
            else
            {
                return c; 
            }
        }
    }
}
