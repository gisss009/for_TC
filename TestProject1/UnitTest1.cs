using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fermap;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(CheckFermat(3, 4, 5,2), false);

        }
    }
}