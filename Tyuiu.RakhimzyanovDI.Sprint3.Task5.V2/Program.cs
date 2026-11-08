using System.Net.Http.Headers;
using Tyuiu.RakhimzyanovDI.Sprint3.Task5.V2.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint3.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 12;

            Console.WriteLine(ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
            Console.ReadKey();

        }
    }
}
