using System;
using System.Collections.Generic;
using System.Linq;

using CommonDivisorMultiplier;

namespace GreaterCommonDividor.Implementation
{
    public class CommonDivisorsBaseCalculator:ICommonDivisorMultiplierCalculator
    {
        public int GetCGD(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                throw new ArgumentOutOfRangeException("Values could not be zero!");
            }

            var CGD_Divisors = new List<Divisor>();
            var divisorsA = GetDivisors(a);
            var divisorsB = GetDivisors(b);
            var longerDivisiors = divisorsA.Count > divisorsB.Count ? divisorsA : divisorsB;
            var shorterDivisiors = divisorsA.Count <= divisorsB.Count ? divisorsA : divisorsB;

            foreach (var divisor in longerDivisiors)
            {
                var oppositeDivisor = shorterDivisiors.FirstOrDefault(x => x.Number == divisor.Number);
                if (oppositeDivisor == null) continue;
                CGD_Divisors.Add(divisor.Grade < oppositeDivisor.Grade ? divisor : oppositeDivisor);
            }

            return CalcValueFromDivisiors(CGD_Divisors);
        }

        public int GetLCM(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                throw new ArgumentOutOfRangeException("Values could not be zero!");
            }
            var LCM_Divisors = new List<Divisor>();
            var divisorsA = GetDivisors(a);
            var divisorsB = GetDivisors(b);
            var longerDivisiors = divisorsA.Count > divisorsB.Count ? divisorsA : divisorsB;
            var shorterDivisiors = divisorsA.Count <= divisorsB.Count ? divisorsA : divisorsB;

            foreach (var divisor in longerDivisiors)
            {
                var oppositeDivisor = shorterDivisiors.FirstOrDefault(x => x.Number == divisor.Number);
                if (oppositeDivisor == null)
                {
                    LCM_Divisors.Add(divisor);
                    continue;
                }
                LCM_Divisors.Add(divisor.Grade > oppositeDivisor.Grade ? divisor : oppositeDivisor);
            }
            var result = CalcValueFromDivisiors(LCM_Divisors);
            return result;
        }

        private static ICollection<Divisor> GetDivisors(int inputNumber)
        {
            IList<Divisor> divisors = new List<Divisor>();

            inputNumber = CheckDivisor(inputNumber, 2, divisors);
            inputNumber = CheckDivisor(inputNumber, 3, divisors);

            int currentDivisor = 5;
            while (currentDivisor <= inputNumber)
            {
                inputNumber = CheckDivisor(inputNumber, currentDivisor, divisors);
                inputNumber = CheckDivisor(inputNumber, currentDivisor+2, divisors);

                currentDivisor += 6;
            }
            return divisors;
        }

        private static int CheckDivisor(int number, int divisor, IList<Divisor> divisors)
        {
            int grade = 0;
            while (number % divisor == 0)
            {
                number = number / divisor;
                grade++;
            }

            divisors.Add(new Divisor(divisor, grade));
            return number;
        }

        private static int CalcValueFromDivisiors(IEnumerable<Divisor> divisors)
        {
            int result = 1;
            foreach (var divisor in divisors)
            {
                result = (int)(result * Math.Pow(divisor.Number, divisor.Grade));
            }
            return result;
        }

        private class Divisor
        {
            public Divisor(int number, int grade)
            {
                Number = number;
                Grade = grade;
            }
            public int Number { get; }
            public int Grade { get; }
        }
    }
}
