using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tax=double.Parse(Console.ReadLine());

            double prKecove = tax * 0.6;
            double prEkip = prKecove * 0.8;
            double prBall = prEkip / 4;
            double accesoars = prBall / 5;

            Console.WriteLine(tax+prEkip+prKecove+prBall+accesoars);
        }
    }
}
