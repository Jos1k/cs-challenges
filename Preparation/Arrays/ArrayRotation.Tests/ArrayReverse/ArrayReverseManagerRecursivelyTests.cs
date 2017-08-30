using ArrayReverse;
using ArrayReverse.Implementation;

using NUnit.Framework;

namespace Arrays.Tests.ArrayReverse
{
    [TestFixture]
    public class ArrayReverseManagerRecursivelyTests
    {
        private IArrayReverseManager _arrayReverseManager;

        [OneTimeSetUp]
        public void SetUp()
        {
            _arrayReverseManager = new ArrayReverseManagerRecursively();
        }

        [TestCaseSource(nameof(ReverseArrayPositiveTestCases))]
        public void ReverseArray_Reverse_Positive(int[] inputArray, int[] expectedResult)
        {
            var actualResult = _arrayReverseManager.Reverse(inputArray);
            CollectionAssert.AreEqual(actualResult, expectedResult);
        }

        private static readonly object[] ReverseArrayPositiveTestCases =
        {
            new object[]
            {
                new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }
            },
            new object[]
            {
                new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 },
                new[] { 8, 7, 6, 5, 4, 3, 2, 1, 0 }
            }
        };
    }
}
