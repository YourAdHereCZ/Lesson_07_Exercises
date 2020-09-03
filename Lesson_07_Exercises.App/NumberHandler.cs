using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_07_Exercises.App
{
    public class NumberHandler : INumberHandler
    {
        public IEnumerable<int> GetEvenNumbers(IEnumerable<int> numbers)
        {
            return numbers.Where(x => x % 2 == 0);
        }

        public IEnumerable<int> GetNumbersDivisibleByAllDivisors(IEnumerable<int> numbers, IEnumerable<int> divisors)
        {
            return numbers.Where(x => (divisors.All(y => x % y == 0)));
        }

        public IEnumerable<int> GetNumbersDivisibleByAtLeastOneDivisor(IEnumerable<int> numbers, IEnumerable<int> divisors)
        {
            return numbers.Where(x => (divisors.Any(y => x % y == 0)));
        }

        public IEnumerable<int> GetNumbersNotDivisibleByAnyDivisor(IEnumerable<int> numbers, IEnumerable<int> divisors)
        {
            return numbers.Where(x => (divisors.All(y => x % y != 0)));
        }

        public IEnumerable<int> GetOddNumbers(IEnumerable<int> numbers)
        {
            return numbers.Where(x => x % 2 == 1);
        }

        public IEnumerable<int> GetPrimeNumbers(IEnumerable<int> numbers)
        {
            // TODO: how to achieve this with a LINQ one-liner? (and do we even want to?)
            static bool IsPrime(int number)
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
             
            return numbers.Where(x => IsPrime(x));
        }
    }
}
