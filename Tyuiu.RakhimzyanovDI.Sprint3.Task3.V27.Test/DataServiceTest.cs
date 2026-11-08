using Tyuiu.RakhimzyanovDI.Sprint3.Task3.V27.Lib;   

namespace Tyuiu.RakhimzyanovDI.Sprint3.Task3.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertStringToInt()
        {
            DataService ds = new DataService();

            string text = "!bt, g567ki!";
            int expected = 567;

            int actual = ds.ConvertStringToInt(text);

            Assert.AreEqual(expected, actual);
        }
    }
}
