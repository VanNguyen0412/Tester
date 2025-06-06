using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KTPM_BaiTapLon;

namespace TamGiacTest
{

    [TestClass]
    public class UnitTestTamGiac
    {
        public TestContext TestContext { get; set; }

        private TinhToanVoiTamGiac tamGiac = new TinhToanVoiTamGiac();
        [TestInitialize]

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\DataTest\TamGiacDataTest.csv", "TamGiacDataTest#csv",
            DataAccessMethod.Sequential)]
        public void TamGiacTest()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int c = int.Parse(TestContext.DataRow[2].ToString());

            bool isTriangle = bool.Parse(TestContext.DataRow[3].ToString());

            Assert.AreEqual(isTriangle, tamGiac.IsTriangle(a, b, c));
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\DataTest\TamGiacDataTest.csv", "TamGiacDataTest#csv",
            DataAccessMethod.Sequential)]
        public void LoaiTamGiacTest()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int c = int.Parse(TestContext.DataRow[2].ToString());
            string expectedType = TestContext.DataRow[4].ToString();

            expectedType = expectedType == "1" ? "Đây là tam giác thường!!!" :
                (expectedType == "2" ? "Đây là tam giác đều!!!" :
                (expectedType == "3" ? "Đây là tam giác cân!!!" : "Đây không phải là tam giác!!!"));

            Assert.AreEqual(expectedType,
                  tamGiac.DetermineTriangleType(a, b, c));
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\DataTest\DienTichDataTest.csv", "DienTichDataTest#csv",
            DataAccessMethod.Sequential)]
        public void DienTichTest()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int c = int.Parse(TestContext.DataRow[2].ToString());
            string expectedType = double.Parse(TestContext.DataRow[4].ToString()) < 0 ? "Đây không phải là tam giác!!!" :
                TestContext.DataRow[4].ToString();
            Assert.AreEqual(expectedType, tamGiac.CalculateArea(a, b, c));

        }
    }
}