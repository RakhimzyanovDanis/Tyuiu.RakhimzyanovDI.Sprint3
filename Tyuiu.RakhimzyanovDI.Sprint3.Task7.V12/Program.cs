using Tyuiu.RakhimzyanovDI.Sprint3.Task7.V12.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint3.Task7.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine(startValue);
            Console.WriteLine(stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            for (int i = 0; i <= len - 1; i++) 
            {
                Console.WriteLine("|{0,5:d}| {1,5:f2} |", startValue, valueArray[i]);
                startValue++;
            }
            Console.ReadKey();
        }
    }
}
