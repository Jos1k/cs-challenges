using ArrayRotation;
using ArrayRotation.Implementation;

using NUnit.Framework;

using CollectionAssert = NUnit.Framework.CollectionAssert;

namespace Arrays.Tests.ArrayRotation
{
    [TestFixture]
    public class JuggingArrayRotatorTests
    {
        private IArrayRotator _arrayRotator;

        [OneTimeSetUp]
        public void Setup()
        {
            _arrayRotator = new JuggingArrayRotator();
        }

        [TestCaseSource(nameof(RotateLeftPositiveTestCases))]
        public void RotateLeft_Positive(int[] inputArray, int rotateTimes, int[] expectedResult)
        {
            var actualResult = _arrayRotator.RotateLeft(inputArray, rotateTimes);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestCaseSource(nameof(RotateRightPositiveTestCases))]
        public void RotateRight_Positive(int[] inputArray, int rotateTimes, int[] expectedResult)
        {
            var actualResult = _arrayRotator.RotateRight(inputArray, rotateTimes);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        private static readonly object[] RotateLeftPositiveTestCases = {
            new object[] {
                new [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 },
                3,
                new [] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 1, 2, 3 }
            },
            new object[] {
                new [] { 1, 2, 3, 4, 5, 6, 7 },
                2,
                new [] { 3, 4, 5, 6, 7, 1, 2 }
            },
            new object[]
            {
                new int[0],
                0,
                new int[0]
            },
            new object[]
            {
                new []{ 1, 2, 3, 4, 5, 6, 7 },
                0,
                new []{ 1, 2, 3, 4, 5, 6, 7 },
            }
        };

        private static readonly object[] RotateRightPositiveTestCases = {
            new object[] {
                new [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 },
                3,
                new [] { 10, 11, 12, 1, 2, 3, 4, 5, 6, 7, 8, 9 }
            },
            new object[] {
                new [] { 1, 2, 3, 4, 5, 6, 7 },
                2,
                new [] { 6, 7, 1, 2, 3, 4, 5 }
            },
            new object[]
            {
                new int[0],
                0,
                new int[0]
            },
            new object[]
            {
                new []{ 1, 2, 3, 4, 5, 6, 7 },
                0,
                new []{ 1, 2, 3, 4, 5, 6, 7 },
            }
        };
    }
}
