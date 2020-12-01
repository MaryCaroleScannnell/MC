using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods
{
    [TestClass]
    public class MethodExamples
    {
        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        [TestMethod]
        public void MethodsTests()
        {
            int sum = AddTwoNumbers(7, 12);
            int sumTWo = AddTwoNumbers(5, 42);

            Assert.AreEqual(19, sum);

            int subtractedBanana = SubtractTwoNumbers(10, 5);
            Assert.AreEqual(5, subtractedBanana);

            int product = MultiplyTwoNumbers(12, 5);
            Assert.AreEqual(60, product);
        }
        private int SubtractTwoNumbers(int a, int b)
        {
            int num = a - b;
            return num;
        }
        private int MultiplyTwoNumbers(int x, int z)
        {
            int prod = x * z;
            return prod;
        }

    }
}
