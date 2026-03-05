namespace _02._VhodNaElementi
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //int[] 
              var    num = new int[5];

            //Вход на елементи ред по ред
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"num[{i}]=");
                num[i] = int.Parse(Console.ReadLine());                
            }
            
            Console.WriteLine("==============");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"num[{i}]={num[i]}");
            }

            Console.WriteLine("==============");
            Console.WriteLine(num[5]);

        }
    }
}
