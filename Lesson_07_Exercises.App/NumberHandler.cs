using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_07_Exercises.App
{
    public class NumberHandler : INumberHandler
    {
        private bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public IEnumerable<int> GetEvenNumbers(IEnumerable<int> numbers)
        {
            return numbers.Where(number => IsNumberEven(number));
        }

        public IEnumerable<int> GetOddNumbers(IEnumerable<int> numbers)
        {
            return numbers.Where(number => !IsNumberEven(number));
        }

        public IEnumerable<int> GetNumbersDivisibleByAllDivisors(IEnumerable<int> numbers, IEnumerable<int> divisors)
        {
            return numbers.Where(number => (divisors.All(divisor => number % divisor == 0)));
        }

        public IEnumerable<int> GetNumbersDivisibleByAtLeastOneDivisor(IEnumerable<int> numbers, IEnumerable<int> divisors)
        {
            return numbers.Where(number => (divisors.Any(divisor => number % divisor == 0)));
        }

        public IEnumerable<int> GetNumbersNotDivisibleByAnyDivisor(IEnumerable<int> numbers, IEnumerable<int> divisors)
        {
            return numbers.Where(number => (divisors.All(divisor => number % divisor != 0)));
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
