using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrayRotation.Tests
{
    [TestClass]
    public class OneByOneArrayRotatorTest
    {
        private IArrayRotator _arrayRotator;

        [TestInitialize]
        public void Init()
        {
            _arrayRotator = new OneByOneArrayRotator();
        }

        [TestMethod]
        public void RotateArrayLeftTest()
        {
            var inputArray = new [] { 1, 2, 3, 4, 5, 6, 7 };
            var expectedResult = new[] { 3, 4, 5, 6, 7, 1, 2 };
            var rotateNumber = 2;

            var outputArray = _arrayRotator.RotateLeft(inputArray, rotateNumber);

            CollectionAssert.AreEqual(outputArray, expectedResult);
        }

        [TestMethod]
        public void RotateArrayLeftFewFullTimesTest()
        {
            var inputArray = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var expectedResult = new[] { 3, 4, 5, 6, 7, 1, 2 };
            var rotateNumber = 9;

            var outputArray = _arrayRotator.RotateLeft(inputArray, rotateNumber);

            CollectionAssert.AreEqual(outputArray, expectedResult);
        }

        [TestMethod]
        public void RotateArrayRightTest()
        {
            var inputArray = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var expectedResult = new[] { 6, 7, 1, 2, 3, 4, 5 };
            var rotateNumber = 2;

            var outputArray = _arrayRotator.RotateRight(inputArray, rotateNumber);

            CollectionAssert.AreEqual(outputArray, expectedResult);
        }

        [TestMethod]
        public void RotateArrayRightFewFullTimesTest()
        {
            var inputArray = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var expectedResult = new[] { 6, 7, 1, 2, 3, 4, 5 };
            var rotateNumber = 9;

            var outputArray = _arrayRotator.RotateRight(inputArray, rotateNumber);

            CollectionAssert.AreEqual(outputArray, expectedResult);
        }
    }
}
