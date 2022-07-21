using Number2Text;

namespace Number2TextTest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodConvert1()
        {
            Assert.AreEqual("ноль", new Number2Text.Number2Text().Convert(0));
        }
        [TestMethod]
        public void TestMethodConvert2()
        {
            Assert.AreEqual("десять", new Number2Text.Number2Text().Convert(10));
        }
        [TestMethod]
        public void TestMethodConvert3()
        {
            Assert.AreEqual("сто одиннадцать", new Number2Text.Number2Text().Convert(111));
        }
        [TestMethod]
        public void TestMethodConvert4()
        {
            Assert.AreEqual("одна тысяча одиннадцать", new Number2Text.Number2Text().Convert(1011));
        }
        [TestMethod]
        public void TestMethodConvert5()
        {
            Object obj = new Number2Text.Number2Text().Convert(10000);
            Assert.IsInstanceOfType(obj, typeof(string));
        }

    }
}