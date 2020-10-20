using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericsProject;

namespace UnitTestProjectGenerics
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int expected = 3;
            GenericsMain program = new GenericsMain();

            int result = program.getMax(3, 2, 1);
            Assert.AreEqual(expected, result);
        }
    }
}
