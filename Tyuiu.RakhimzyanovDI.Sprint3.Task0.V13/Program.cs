using Tyuiu.RakhimzyanovDI.Sprint3.Task0.V13.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint3.Task0.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double value = 0.5;
            int startValue = 1;
            int stopValue = 20;

            Console.WriteLine(value);
            Console.WriteLine(startValue);
            Console.WriteLine(stopValue);

            Console.WriteLine(ds.GetSumSeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}
