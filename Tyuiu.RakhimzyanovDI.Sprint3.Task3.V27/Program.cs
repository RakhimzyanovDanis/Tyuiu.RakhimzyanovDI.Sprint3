using Tyuiu.RakhimzyanovDI.Sprint3.Task3.V27.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint3.Task3.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var service = new DataService();

            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            try
            {
                int result = service.ConvertStringToInt(input);
                Console.WriteLine($"Результат: {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
