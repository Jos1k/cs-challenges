using NUnit.Framework;
namespace ArrayRotation.Tests
{
    [TestFixture]
    public class TempArrayRotatorTest
    {
        private IArrayRotator _arrayRotator;

        [OneTimeSetUp]
        public void Init()
        {
            _arrayRotator = new TempArrayRotator();
        }

        [Test]
        public void RotateArrayLeftTestZeroTimes()
        {
            var inputArray = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var expectedResult = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var rotateNumber = 0;

            var outputArray = _arrayRotator.RotateLeft(inputArray, rotateNumber);

            CollectionAssert.AreEqual(outputArray, expectedResult);
        }

		[Test]
        public void RotateArrayLeftTest()
        {
            var inputArray = new [] { 1, 2, 3, 4, 5, 6, 7 };
            var expectedResult = new[] { 3, 4, 5, 6, 7, 1, 2 };
            var rotateNumber = 2;

            var outputArray = _arrayRotator.RotateLeft(inputArray, rotateNumber);

            CollectionAssert.AreEqual(outputArray, expectedResult);
        }

		[Test]
        public void RotateArrayLeftFewFullTimesTest()
        {
            var inputArray = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var expectedResult = new[] { 3, 4, 5, 6, 7, 1, 2 };
            var rotateNumber = 9;

            var outputArray = _arrayRotator.RotateLeft(inputArray, rotateNumber);

            CollectionAssert.AreEqual(outputArray, expectedResult);
        }

		[Test]
        public void RotateArrayRightTestZeroTimes()
        {
            var inputArray = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var expectedResult = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var rotateNumber = 0;

            var outputArray = _arrayRotator.RotateRight(inputArray, rotateNumber);

            CollectionAssert.AreEqual(outputArray, expectedResult);
        }

		[Test]
        public void RotateArrayRightTest()
        {
            var inputArray = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var expectedResult = new[] { 6, 7, 1, 2, 3, 4, 5 };
            var rotateNumber = 2;

            var outputArray = _arrayRotator.RotateRight(inputArray, rotateNumber);

            CollectionAssert.AreEqual(outputArray, expectedResult);
        }

        [Test]
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
