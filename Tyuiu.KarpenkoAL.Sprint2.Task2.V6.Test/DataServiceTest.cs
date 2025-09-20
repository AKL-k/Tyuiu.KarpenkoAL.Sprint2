using Tyuiu.KarpenkoAL.Sprint2.Task2.V6.Lib;

namespace Tyuiu.KarpenkoAL.Sprint2.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 8;
            int y = 7;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
