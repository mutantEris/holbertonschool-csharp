using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            int[,] matrix = new int[,]
            {
                {0, 1, 2},
                {3, 4, 5},
                {6, 7, 8}
            };
            int[,] g = Matrix.Divide(matrix, 2);
            Assert.AreEqual(g[1, 1], 2);
            Assert.AreEqual(Matrix.Divide(null, 2), null);
            Assert.AreEqual(Matrix.Divide(matrix, 0), null);
        }
        [Test]
        public void Test2()
        {
            int[,] matrix = null;
            Assert.IsNull(MyMath.Matrix.Divide(matrix, 1));
        }
    }
}