using System;

namespace ArrayRotation.Implementation {
	public class JuggingArrayRotator : IArrayRotator {
		public int[] RotateLeft( int[] outputArray, int rotateTimes ) {
		    int n = outputArray.Length;
			for(int i = 0; i < GetCGD( rotateTimes, n ); i++ ) {
				int temp = outputArray[i];
				var j = i;
				while( true ) {
					var k = j + rotateTimes;
					if( k >= n )
						k = k - n;
					if( k == i )
						break;
					outputArray[j] = outputArray[k];
					j = k;
				}
				outputArray[j] = temp;
			}
			return outputArray;
		}

		public int[] RotateRight( int[] inputArray, int rotateTimes ) {
			throw new NotImplementedException();
		}

		private static int GetCGD( int a, int b ) {
		    while( b != 0 ) {
				var temp = b;
				b = a % b;
				a = temp;
			}
			return a;
		}
	}
}
