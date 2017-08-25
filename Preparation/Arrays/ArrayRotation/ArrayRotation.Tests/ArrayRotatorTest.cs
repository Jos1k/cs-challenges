using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrayRotation.Tests
{
    [TestClass]
    public class ArrayRotatorTest
    {
        [TestMethod]
        public void RotateArrayLeftTest()
        {
            var inputArray = new [] { 1, 2, 3, 4, 5, 6, 7 };
            var expectedResult = new[] { 3, 4, 5, 6, 7, 1, 2 };
            var rotateNumber = 2;

            var outputArray = ArrayRotator.RotateArrayLeft(inputArray, rotateNumber);

            CollectionAssert.AreEqual(outputArray, expectedResult);
        }

        [TestMethod]
        public void RotateArrayLeftFewFullTimesTest()
        {
            var inputArray = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var expectedResult = new[] { 3, 4, 5, 6, 7, 1, 2 };
            var rotateNumber = 9;

            var outputArray = ArrayRotator.RotateArrayLeft(inputArray, rotateNumber);

            CollectionAssert.AreEqual(outputArray, expectedResult);
        }

        [TestMethod]
        public void RotateArrayRightTest()
        {
            var inputArray = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var expectedResult = new[] { 6, 7, 1, 2, 3, 4, 5 };
            var rotateNumber = 2;

            var outputArray = ArrayRotator.RotateArrayRight(inputArray, rotateNumber);

            CollectionAssert.AreEqual(outputArray, expectedResult);
        }

        [TestMethod]
        public void RotateArrayRightFewFullTimesTest()
        {
            var inputArray = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var expectedResult = new[] { 6, 7, 1, 2, 3, 4, 5 };
            var rotateNumber = 9;

            var outputArray = ArrayRotator.RotateArrayRight(inputArray, rotateNumber);

            CollectionAssert.AreEqual(outputArray, expectedResult);
        }
    }
}
