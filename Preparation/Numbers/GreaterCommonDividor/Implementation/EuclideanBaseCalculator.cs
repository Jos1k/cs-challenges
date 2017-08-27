using System;

namespace CommonDivisorMultiplier {
	public class EuclideanBaseCalculator : ICommonDivisorMultiplierCalculator {
		
		public int GetCGD( int a, int b ) {
			if( a == 0 || b == 0 ) {
				throw new ArgumentOutOfRangeException( "Values could not be zero!" );
			}

			if( a == 1 || b == 1 ) {
				return 1;
			}

			int temp;
			while( b != 0 ) {
				temp = b;
				b = a % b;
				a = temp;
			}
			return a;
		}

		public int GetLCM( int a, int b ) {
			return Math.Abs( a ) / GetCGD( a, b ) * Math.Abs( b );
		}
	}
}
