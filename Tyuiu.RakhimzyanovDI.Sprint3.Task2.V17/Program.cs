using Tyuiu.RakhimzyanovDI.Sprint3.Task2.V17.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint3.Task2.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            
            int startValue = 1;
            int stopValue = 10;

            
            Console.WriteLine(startValue);
            Console.WriteLine(stopValue);

            Console.WriteLine(ds.GetSumSeries( startValue, stopValue));
            Console.ReadKey();
        }
    }
}
