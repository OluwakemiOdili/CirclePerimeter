using CirclePerimeter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1Base
    {
        [TestMethod]
        [DataRow(7d, 44d)]
        [DataRow(14d, 88d)]
        [DataRow(21d, 132d)]
        [DataRow(28, 176d)]


        public void Perimeter(double radius, double expectedPer)
        {
            var per = new CirclePer();
            double circlePer = per.Perimeter(radius);
            Assert.AreEqual(expectedPer, circlePer);

        }
    }
}