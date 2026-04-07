namespace _01._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. catch (улавяне):Програмата реагира на грешка, която вече се е случила(външно обстоятелство).
            //2. throw (хвърляне):Ти самият решаваш да спреш програмата, защото нещо не отговаря на твоите правила.
            //С throw new ArgumentException(...) ти казваш: "Математически това е възможно,
            //но за моята програма е грешно!"

            try
            {
                Console.Write("Vavedi tvoite godini: ");
                int godini = int.Parse(Console.ReadLine());

                if (godini < 0 || godini > 120)
                {
                    // ТУК НИЕ РЪЧНО ХВЪРЛЯМЕ ГРЕШКА (throw)
                    throw new ArgumentException("Nerealni godini! Nikoi ne jivee tolkova.");
                }

                if (godini < 18)
                {
                    // ХВЪРЛЯМЕ ДРУГА ГРЕШКА (throw)
                    throw new Exception("Prekaleno si maluk za knijka!");
                }

                // Този ред ще се изпълни САМО ако горните throw НЕ се задействат
                Console.WriteLine("Mojesh da zapochnesh kursovete!");
            }
            catch (FormatException)
            {
                // Улавяме автоматична грешка от системата (ако напишат текст)
                Console.WriteLine("Greshka: Napishi chislo, a ne bukvi!");
            }
            catch (ArgumentException ex)
            {
                // Улавяме нашето ръчно изключение за нереални години
                Console.WriteLine("Problem s dannite: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Улавяме общата грешка (например за малките години)
                Console.WriteLine("Otkazano: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Proverkata zavurshi.");
            }



        }
    }
}
