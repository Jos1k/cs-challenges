﻿namespace PrimeNumbers {
	public class PrimeNumberChecker : IPrimeNumberChecker {
		public bool Check( int number ) {
			if( number <= 1 ) return false;
			if( number <= 3 ) return true;
			if( number % 2 == 0 || number % 3 == 0 ) return false;

			int factor = 5;
			while( factor * factor <= number ) {
				if( number % factor == 0 || number % ( factor + 2 ) == 0 )
					return false;
				factor += 6;
			}
			return true;
		}
	}
}
