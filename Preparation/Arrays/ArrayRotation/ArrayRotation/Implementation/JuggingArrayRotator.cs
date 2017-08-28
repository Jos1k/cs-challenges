using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotation.Implementation {
	public class JuggingArrayRotator : IArrayRotator {
		public int[] RotateLeft( int[] inputArray, int rotateTimes ) {

			int i, j, k, temp;
			int n = inputArray.Length;
			for( i = 0; i < GetCGD( rotateTimes, n ); i++ ) {
				temp = inputArray[i];
				j = i;
				while( 1 != 0 ) {
					k = j + rotateTimes;
					if( k >= n )
						k = k - n;
					if( k == i )
						break;
					inputArray[j] = inputArray[k];
					j = k;
				}
				inputArray[j] = temp;
			}



			//rotateTimes = rotateTimes % inputArray.Length;

			//int gcd = GetCGD( inputArray.Length, rotateTimes );

			//if( gcd > 1 ) {
			//	int insertPointer = inputArray.Length - rotateTimes;
			//	for( int rotateIndex = 0; rotateIndex < rotateTimes; rotateIndex++ ) {
			//		int temp = inputArray[rotateIndex];
			//		for( int shiftIndex = rotateIndex; shiftIndex < insertPointer; shiftIndex += gcd ) {
			//			inputArray[shiftIndex] = inputArray[shiftIndex + gcd];
			//		}
			//		inputArray[insertPointer] = temp;
			//		insertPointer++;
			//	}
			//} else {
			//	for( int rotateIndex = 0; rotateIndex < rotateTimes; rotateIndex++ ) {
			//		int temp = inputArray[0];
			//		for( int i = 0; i < inputArray.Length - 1; i++ ) {
			//			inputArray[i] = inputArray[i + 1];
			//		}
			//		inputArray[inputArray.Length - 1] = temp;
			//	}
			//}
			return inputArray;
		}

		public int[] RotateRight( int[] inputArray, int rotateTimes ) {
			throw new NotImplementedException();
		}

		private static int GetCGD( int a, int b ) {
			int temp;
			while( b != 0 ) {
				temp = b;
				b = a % b;
				a = temp;
			}
			return a;
		}
	}
}
