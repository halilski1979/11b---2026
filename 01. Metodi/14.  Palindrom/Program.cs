using static System.Net.Mime.MediaTypeNames;

namespace _14.__Palindrom
{
    internal class Program
    {
        //Напишете метод IsPalindrome(string text), който проверява дали даден низ е палиндром
        //(чете се еднакво отпред и отзад), като игнорира главни/малки букви и интервали.

        static void Main(string[] args)
        {
            Console.WriteLine(PalindromTekst("alena fanela"));
        }

        public static void PalindromNumber()
        {
            Console.Write("Vavedete chisloto: ");
            string number = Console.ReadLine();

            string secondNumber = new string(number.Reverse().ToArray());

            int a = int.Parse(secondNumber);
            int b = int.Parse(number);

            if (a == b)
            {
                Console.WriteLine("Palindrom");
            }
            else
            {
                Console.WriteLine("Ne e palindrom");
            }

        }

        public static void PalindromTekst()
        {
            Console.Write("Vavedi tekst: ");
           string text = Console.ReadLine();


            //  string cleaned = new string(text.ToLower().Where(c => c != ' ').ToArray());  
            string cleaned = new string(text.ToLower().Replace(" ","").ToArray());

            string reversed = new string(cleaned.Reverse().ToArray());       
        if (cleaned == reversed)
            Console.WriteLine("Palindrom!");
        else
            Console.WriteLine("Ne e palindrom!");
        }

        public static string PalindromTekst(string text)
        {       
                       
            string cleaned = new string(text.ToLower().Replace(" ", "").ToArray());

            string reversed = new string(cleaned.Reverse().ToArray());
            if (cleaned == reversed)
                return("Palindrom!");
            else
                return("Ne e palindrom!");
        }
    }
}
