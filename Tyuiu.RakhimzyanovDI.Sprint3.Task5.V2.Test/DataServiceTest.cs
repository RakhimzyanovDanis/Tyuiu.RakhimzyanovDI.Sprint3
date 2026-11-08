using Tyuiu.RakhimzyanovDI.Sprint3.Task5.V2.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint3.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 12;

            double res = ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2);

            double wait = 9.861;

            Assert.AreEqual(wait, res);
        }
    }
}
