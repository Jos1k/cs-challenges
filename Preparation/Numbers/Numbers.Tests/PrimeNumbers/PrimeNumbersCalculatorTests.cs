using System;
using NUnit.Framework;
using PrimeNumbers;

namespace Numbers.Tests {
	[TestFixture]
	public class PrimeNumbersCalculatorTests {

		private IPrimeNumberChecker _primeNumbersChecker;

		[OneTimeSetUp]
		protected void SetUp() {
			_primeNumbersChecker = new PrimeNumberChecker();
		}
		
		[TestCaseSource("PrimeNumberCases")]
		public void Check_Positive(int inputNumber, bool expectedResult) {
			var actualResult = _primeNumbersChecker.Check(inputNumber);
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void Check_ZeroCheck() {
			var actualResult = _primeNumbersChecker.Check( 0 );
			Assert.False( actualResult );
		}

		private static object[] PrimeNumberCases = {
			new object[] { 29, true },
			new object[] { 31, true },
			new object[] { 37, true },
			new object[] { 38, false},
			new object[] { 41, true},
			new object[] { 43, true},
			new object[] { 47, true},
			new object[] { 97, true}
		};
	}
}
