using Tyuiu.RakhimzyanovDI.Sprint3.Task1.V19.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint3.Task1.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int value = 1;
            int startValue = 1;
            int stopValue = 9;

            Console.WriteLine(value);
            Console.WriteLine(startValue);
            Console.WriteLine(stopValue);

            Console.WriteLine(ds.GetMultiplySeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}
