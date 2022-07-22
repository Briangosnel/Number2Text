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
        [TestMethod]
        public void TestMethodConvert6()
        {
            Assert.AreEqual("рубль", new Number2Text.RoubleCases().ConvertPadej(1));
        }
        [TestMethod]
        public void TestMethodConvert7()
        {
            Assert.AreEqual("рубля", new Number2Text.RoubleCases().ConvertPadej(102));
        }
        [TestMethod]
        public void TestMethodConvert8()
        {
            Assert.AreEqual("рублей", new Number2Text.RoubleCases().ConvertPadej(11));
        }
        [TestMethod]
        public void TestMethodConvert9()
        {
            Assert.AreEqual("рублей", new Number2Text.RoubleCases().ConvertPadej(1011));
        }


    }
}