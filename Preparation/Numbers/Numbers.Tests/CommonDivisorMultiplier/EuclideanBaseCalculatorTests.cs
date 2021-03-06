﻿using System;
using CommonDivisorMultiplier;
using NUnit.Framework;
namespace Numbers.Tests.CommonDivisorMultiplier {
	
	[TestFixture]
	public class EuclideanBaseCalculatorTests {
	
		private ICommonDivisorMultiplierCalculator _commonDivisorCalc;

		[OneTimeSetUp]
		public void SetUp() {
			_commonDivisorCalc = new EuclideanBaseCalculator();
		}
		
		[TestCaseSource(nameof(CommonGreaterDivisorCases))]
		public void GetCGD_Positive( int a, int b, int expectedResult) {
			int actualResult = _commonDivisorCalc.GetCGD( a, b );
			Assert.AreEqual( expectedResult, actualResult );
		}

		[Test]
		public void GetCGD_ZeroValues( ) {
			int a = 0, b = 1;
			Assert.Throws<ArgumentOutOfRangeException>( () => _commonDivisorCalc.GetCGD( a, b ) );
		}

		[TestCaseSource( nameof(LowestCommonMultiplierCases) )]
		public void GetLCM_Positive(int a, int b, int expectedResult) {
			int actualResult = _commonDivisorCalc.GetLCM( a, b );
			Assert.AreEqual( expectedResult, actualResult );
		}

		[Test]
		public void GetLCM_ZeroValues() {
			int a = 0, b = 1;
			Assert.Throws<ArgumentOutOfRangeException>( () => _commonDivisorCalc.GetLCM( a, b ) );
		}

		private static readonly object[] LowestCommonMultiplierCases = {
			new object[] { 65, 10, 130 },
			new object[] { 70, 10, 70 },
			new object[] { 34, 16, 272 },
			new object[] { 45, 18, 90 },
			new object[] { 65, 10, 130 },
			new object[] { 18, 1, 18 },
			new object[] { 3, 91, 273 },
			new object[] { 4, 18, 36 },
		};

		private static readonly object[] CommonGreaterDivisorCases = {
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
