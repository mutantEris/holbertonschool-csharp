using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(2, Text.Str.CamelCase("jumboWumbo"));
        }
        [Test]
        public void Test30()
        {
            Assert.AreEqual(4, Text.Str.CamelCase("the Egg Has Hatched"));
        }
        [Test]
        public void Test465()
        {
            Assert.AreEqual(0, Text.Str.CamelCase(""));
        }
        [Test]
        public void Test7()
        {
            Assert.AreEqual(6, Text.Str.CamelCase("doNotLetItCatchYou"));
        }
        [Test]
        public void Test5()
        {
            Assert.AreEqual(1, Text.Str.CamelCase("wumbo"));
        }
        [Test]
        public void Test()
        {
            Assert.AreEqual(2, Text.Str.CamelCase("helloWorld"));
        }
    }
}