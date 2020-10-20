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
            string expected = "44";
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

        public void TestMethodForGenericMethodInt(int a,int b,int c)
        {
            int expected = 4;
            GenericsMain genericsMain = new GenericsMain();
            int result = genericsMain.getMax<int>(a,b,c);
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        [DataRow(2.2, 4.4, 3.3)]
        [DataRow(2.3, 3.3, 4.4)]
        [DataRow(4.4, 1.1, 3.3)]
        [DataRow(4.4, 4.4, 4.4)]

        public void TestMethodForGenericMethodDouble(double a, double b, double c)
        {
            double expected = 4.4;
            GenericsMain genericsMain = new GenericsMain();
            double result = genericsMain.getMax<double>(a, b, c);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        [DataRow("22", "44", "33")]
        [DataRow("22", "33", "44")]
        [DataRow("44", "11", "33")]
        [DataRow("44", "44", "44")]

        public void TestMethodForGenericMethodString(string a, string b, string c)
        {
            string expected = "44";
            GenericsMain genericsMain = new GenericsMain();
            string result = genericsMain.getMax<string>(a, b, c);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(2, 4, 3)]
        [DataRow(2, 3, 4)]
        [DataRow(4, 1, 3)]
        [DataRow(4, 4, 4)]
        public void testMaximum(int a,int b,int c)
        {
            GenericsClass<int> genericsClass = new GenericsClass<int>(a,b,c);
            int expected = 4;
            int result = genericsClass.maxMethod();
            Assert.AreEqual(expected, result);
        }


    }
}
