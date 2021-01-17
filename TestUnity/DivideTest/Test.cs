using NUnit.Framework;
using System;
using TestUnity;

namespace DivideTest
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
        }

        [Test]
        public void DivideTest()
        {
            Divide mc = new Divide();

            int result = mc.DivideNumber(12, 6);

            Assert.AreEqual(2, result);
            // 
            // Dividing by zero should result in -1 since the function handles this case.
            result = mc.DivideNumber(0, 22);
            Assert.AreEqual(0, result);

            int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            Assert.That(arr, Is.Ordered.Descending);
            mc.Quick_Sort(arr, 0, arr.Length - 1);
            Array.Reverse(arr);

            Assert.That(arr, Is.Ordered.Descending);

            int[] arr1 = new int[] { 5,4,3,2,1 };
            mc.Bubble(arr1);
            Array.Reverse(arr1);
            Assert.That(arr1, Is.Ordered.Descending);


        }
    }
}
