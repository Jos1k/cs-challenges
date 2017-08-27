using System;
using CommonDivisorMultiplier;
using NUnit.Framework;
using NUnit.Framework.Constraints;
namespace Numbers.Tests.CommonDivisorMultiplier {
	
	[TestFixture]
	public class EuclideanBaseCalculatorTests {
	
		protected ICommonDivisorMultiplierCalculator _euclideanCalc;

		[OneTimeSetUp]
		public void SetUp() {
			_euclideanCalc = new EuclideanBaseCalculator();
		}
		
		[TestCaseSource("CommonGreaterDivisorCases")]
		public void GetCGD_Positive( int a, int b, int expectedResult) {
			int actualResult = _euclideanCalc.GetCGD( a, b );
			Assert.AreEqual( expectedResult, actualResult );
		}

		[Test]
		public void GetCGD_ZeroValues( ) {
			int a = 0, b = 1;
			Assert.Throws<ArgumentOutOfRangeException>( () => _euclideanCalc.GetCGD( a, b ) );
		}

		private static object[] CommonGreaterDivisorCases = {
			new object[] { 5, 10, 5 },
			new object[] { 7, 3, 1 },
			new object[] { 413, 89, 1 },
			new object[] { 99, 66, 33 },
			new object[] { 67, 43, 1 },
			new object[] { 21, 63, 21 },
			new object[] { 120, 90, 30 },
			new object[] { 120, 1, 1 }
		};
	}
}
