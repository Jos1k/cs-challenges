using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterCommonDividor {
	class Program {
		static void Main( string[] args ) {
			Console.WriteLine( GetCGD( 252, 105 ) );
			Console.ReadKey();
		}

		public static int GetCGD( int a, int b ) {
			int temp = 0;
			while (b != 0) {
				temp = b;
				b = a % b;
				a = temp;
			}
			return a;
		}
	}
}
