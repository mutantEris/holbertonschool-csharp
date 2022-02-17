using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
        Assert.AreEqual(0, Text.Str.UniqueChar("g"));
        }
        [Test]
        public void Test2()
        {
        Assert.AreEqual(10, Text.Str.UniqueChar("ggggggggggx"));
        }
        [Test]
        public void Test3()
        {
        Assert.AreEqual(0, Text.Str.UniqueChar("xgggggggggggggggggggggggg"));
        }
        [Test]
        public void Test4()
        {
            Assert.Pass();
        }
        [Test]
        public void Test5()
        {
        Assert.AreEqual(-1, Text.Str.UniqueChar("gg"));
        }
        [Test]
        public void Test6()
        {
        Assert.AreEqual(-1, Text.Str.UniqueChar(""));
        }
    }
}