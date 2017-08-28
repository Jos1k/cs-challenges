using ArrayRotation.Implementation;
using NUnit.Framework;

namespace ArrayRotation.Tests.ArrayRotation {
	[TestFixture]
	public class JuggingArrayRotatorTests {

		private IArrayRotator _jugginArrayRotator;
		
		[OneTimeSetUp]
		public void Setup() {
			_jugginArrayRotator = new JuggingArrayRotator();
		}

		[TestCaseSource( "RotateLeftPositive_TestCases" )]
		public void RotateLeft_Positive( int[] inputArray, int rotateTimes, int[] expectedResult) {
			var actulResult = _jugginArrayRotator.RotateLeft( inputArray, rotateTimes );
			CollectionAssert.AreEqual( expectedResult, actulResult );
		}

		private static object[] RotateLeftPositive_TestCases = new object[]{
			//new object[] { 
			//	new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, 
			//	3, 
			//	new int[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 1, 2, 3 }
			//},
			new object[] { 
				new int[] { 1, 2, 3, 4, 5, 6, 7 }, 
				2, 
				new int[] { 3, 4, 5, 6, 7, 1, 2 }
			}
		};
	}
}
