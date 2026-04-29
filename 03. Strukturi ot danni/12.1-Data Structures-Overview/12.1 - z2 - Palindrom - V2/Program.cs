namespace _12._1___z2___Palindrom___V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine().ToLower();
            bool isPal = true;

            for (int i = 0; i < s.Length / 2; i++)
                if (s[i] != s[s.Length - 1 - i]) { isPal = false; break; }

            Console.WriteLine($"The word {s} is {(isPal ? "" : "not ")}a palindrome.");
        }
    }
}
