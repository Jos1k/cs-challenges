using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrayRotation.Tests
{
    [TestClass]
    public class ArrayRotatorTest
    {
        [TestMethod]
        public void RotateArrayTest()
        {
            var inputArray = new [] { 1, 2, 3, 4, 5, 6, 7 };
            var expectedResult = new[] { 3, 4, 5, 6, 7, 1, 2 };
            var rotateNumber = 2;

            var outputArray = ArrayRotator.RotateArray(inputArray, rotateNumber);

            CollectionAssert.AreEqual(outputArray, expectedResult);
        }
    }
}
