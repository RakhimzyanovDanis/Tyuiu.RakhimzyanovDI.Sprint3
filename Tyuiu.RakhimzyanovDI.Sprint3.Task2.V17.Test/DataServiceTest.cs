using Tyuiu.RakhimzyanovDI.Sprint3.Task2.V17.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint3.Task2.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(startValue, stopValue);

            double wait = 4.399;

            Assert.AreEqual(wait, res);
        }
    }
}
