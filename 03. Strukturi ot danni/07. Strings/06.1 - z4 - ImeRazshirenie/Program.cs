namespace _06._1___z4___ImeRazshirenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            // Взимаме само името на файла (след последния '\')
            string fileWithExtension = path.Substring(path.LastIndexOf('\\') + 1);

            // Разделяме име и разширение
            int dotIndex = fileWithExtension.LastIndexOf('.');
            string fileName = fileWithExtension.Substring(0, dotIndex);
            string extension = fileWithExtension.Substring(dotIndex + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
