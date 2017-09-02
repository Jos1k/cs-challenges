using FIrstMinMaxElements;
using FIrstMinMaxElements.Implementation;

using NUnit.Framework;

namespace Arrays.Tests.FIrstMinMaxElements
{
    [TestFixture]
    public class TempArrayFIrstMinMaxElementsTests
    {
        private IFirstMinMaxFinder _firstMinMaxFinder;

        [OneTimeSetUp]
        public void SetUp()
        {
            _firstMinMaxFinder = new TempArrayFirstMinMaxFinder();
        }

        [TestCaseSource(nameof(getFirstKMaxElements_TestCases))]
        public void GetFirstKMaxElements_Positive(int[] input, int k, int[] expected)
        {
            var actualResult = _firstMinMaxFinder.FindFirstMaxElements(input, k);
            CollectionAssert.AreEquivalent(actualResult, expected);
        }

        private static readonly object[] getFirstKMaxElements_TestCases =
        {
            new object[]
            {
                new[] { 2, 1, 8, 4, 7, 5, 3, 10, 9 },
                3,
                new[] { 8, 10, 9 }
            },
            new object[]
            {
                new[] { 1, 2, 3, 7, 4},
                1,
                new[] { 7 }
            },
            new object[]
            {
                new[] { 1, 2, 3, 7, 4},
                0,
                new int[]{}
            },
            new object[]
            {
                new[] { 1, 2, 2, 2, 2},
                3,
                new[] { 2, 2, 2 }
            }
        };
    }
}
