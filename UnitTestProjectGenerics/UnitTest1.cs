using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericsProject;

namespace UnitTestProjectGenerics
{
    [TestClass]
    public class UnitTest1
    {
        //UC-1
        [TestMethod]
        public void TestMethodForIntMax()
        {
            int expected = 9;
            GenericsMain program = new GenericsMain();

            int result = program.getIntMax(3, 9, 3);
            Assert.AreEqual(expected, result);
        }
        //UC-2
        [TestMethod]
        public void TestMethodForDoubleMax()
        {
            double expected = 9.3;
            GenericsMain program = new GenericsMain();

            double result = program.getDoubleMax(3.2, 9.3, 3.4);
            Assert.AreEqual(expected, result);
        }
        //UC-3
        [TestMethod]
        public void TestMethodForStringMax()
        {
            string expected = "44";
            GenericsMain program = new GenericsMain();

            string result = program.getStringMax("22", "44", "33");
            Assert.AreEqual(expected, result);
        }

    }
}
