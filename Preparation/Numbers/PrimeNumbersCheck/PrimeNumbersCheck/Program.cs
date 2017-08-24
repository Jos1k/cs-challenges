using System;

namespace PrimeNumbersCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            var is0Prime = IsNumberPrime(29);
            var is2Prime = IsNumberPrime(31);
            var is4Prime = IsNumberPrime(37);
            var is5Prime = IsNumberPrime(38);
            var is7Prime = IsNumberPrime(41);
            var is11Prime = IsNumberPrime(43);
            var is15Prime = IsNumberPrime(47);
            var is29Prime = IsNumberPrime(97);
            Console.ReadKey();
        }

        public static bool IsNumberPrime(int number)
        {
            if (number <= 1) return false;
            if (number <= 3) return true;
            if (number % 2 == 0 || number % 3 == 0) return false;

            int factor = 5;
            while (factor * factor <= number)
            {
                if (number % factor == 0 || number % (factor + 2) == 0)
                    return false;
                factor += 6;
            }
            return true;
        }
    }
}
