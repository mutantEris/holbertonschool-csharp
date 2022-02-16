using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System;

namespace MyMath.Tests
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            List<int> list1 = new List<int>() {1, 5, -3, 0};
            Assert.AreEqual(Operations.Max(list1), 5);
            
        }
        [Test]
        public void Test2()
        {
            List<int> list2 = new List<int>();
            Assert.AreEqual(Operations.Max(list2), 0);
        }
    }
}