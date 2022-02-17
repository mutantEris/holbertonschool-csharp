using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void Test2()
        {
            Assert.True(Text.Str.IsPalindrome(""));
        }
        [Test]
        public void Test3()
        {
            Assert.True(Text.Str.IsPalindrome("racecaR"));
        }
        [Test]
        public void Test4()
        {
            Assert.True(Text.Str.IsPalindrome("Racecar"));
        }
        [Test]
        public void Test5()
        {
            Assert.True(Text.Str.IsPalindrome("Racecar racecaR"));
        }
        [Test]
        public void Test6()
        {
            Assert.True(Text.Str.IsPalindrome("Racecar , ciaraic , racecaR"));
        }

    }
}