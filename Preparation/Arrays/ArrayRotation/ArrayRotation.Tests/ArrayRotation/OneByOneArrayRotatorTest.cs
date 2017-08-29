using ArrayRotation.Implementation;
using NUnit.Framework;

using CollectionAssert = NUnit.Framework.CollectionAssert;

namespace ArrayRotation.Tests.ArrayRotation
{
	[TestFixture]
	public class OneByOneArrayRotatorTest
	{
	    private IArrayRotator _arrayRotator;

        [OneTimeSetUp]
		public void Init()
		{
		    _arrayRotator = new OneByOneArrayRotator();
		}

		[TestCaseSource(nameof(RotateLeftPositiveTestCases))]
		public void RotateLeft_Positive(int[] inputArray, int rotateTimes, int[] expectedResult)
		{
			var actualResult = _arrayRotator.RotateLeft(inputArray, rotateTimes);
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
	        }
	    };
    }
}
