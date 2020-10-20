using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericsProject;
using System.Data;

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
            string expected = "33";
            GenericsMain program = new GenericsMain();
            string result = program.getStringMax("22", "44", "33");
            Assert.AreEqual(expected, result);
        }

        //Refactor for all above 3
        [TestMethod]
        [DataRow(2, 4, 3)]
        [DataRow(2, 3, 4)]
        [DataRow(4, 1, 3)]
        [DataRow(4, 4, 4)]

        public void TestMethodForGeneric(int a,int b,int c)
        {
            int expected = 4;
            GenericsMain genericsMain = new GenericsMain();
            int result = genericsMain.getMax<int>(a,b,c);
            Assert.AreEqual(expected, result);
        }
    }
}
