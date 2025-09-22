using Tyuiu.KarpenkoAL.Sprint2.Task4.V20.Lib;

namespace Tyuiu.KarpenkoAL.Sprint2.Task4.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 0.173;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 15;
            double res = ds.Calculate(x, y);
            double wait = 99.933;
            Assert.AreEqual(wait, res);
        }
    }
}
