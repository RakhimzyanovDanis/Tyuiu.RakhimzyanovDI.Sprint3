using Tyuiu.RakhimzyanovDI.Sprint3.Task6.V6.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint3.Task6.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = 16;
            int stopValue = 24;
            Console.WriteLine(ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadKey();

        }
    }
}
