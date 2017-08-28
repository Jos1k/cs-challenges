using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotation.Implementation {
	public class JuggingArrayRotator : IArrayRotator {
		public int[] RotateLeft( int[] inputArray, int rotateTimes ) {
			rotateTimes = rotateTimes % inputArray.Length;
			int gcd = GetCGD( inputArray.Length, rotateTimes );
			int insertPointer = inputArray.Length - rotateTimes;
			for( int rotateIndex = 0; rotateIndex < rotateTimes; rotateIndex++ ) {
				int temp = inputArray[rotateIndex];

				for( int shiftIndex = rotateIndex; shiftIndex < insertPointer; shiftIndex += gcd ) {
					inputArray[shiftIndex] = inputArray[shiftIndex + gcd];
				}
				inputArray[insertPointer] = temp;
				insertPointer++;
			}
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
