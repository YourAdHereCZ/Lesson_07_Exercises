using System.Collections.Generic;

namespace Lesson_07_Exercises.App
{
    public interface INumberHandler
    {
        IEnumerable<int> GetEvenNumbers(IEnumerable<int> numbers);
        IEnumerable<int> GetOddNumbers(IEnumerable<int> numbers);
        IEnumerable<int> GetNumbersDivisibleByAllDivisors(IEnumerable<int> numbers, IEnumerable<int> divisors);
        IEnumerable<int> GetNumbersNotDivisibleByAnyDivisor(IEnumerable<int> numbers, IEnumerable<int> divisors);
        IEnumerable<int> GetNumbersDivisibleByAtLeastOneDivisor(IEnumerable<int> numbers, IEnumerable<int> divisors);
        IEnumerable<int> GetPrimeNumbers(IEnumerable<int> numbers);
    }
}
