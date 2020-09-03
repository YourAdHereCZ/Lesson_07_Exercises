using System;
using System.Collections.Generic;

namespace Lesson_07_Exercises.App
{
    internal class Program
    {
        private static void Main()
        {
            #region NumberHandler examples
            var handler = new NumberHandler();
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 18, 19, 20 };

            var odds = handler.GetOddNumbers(numbers);
            var evens = handler.GetEvenNumbers(numbers);

            Console.Write("Odd numbers: ");
            foreach (int i in odds)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();

            Console.Write("Even numbers: ");
            foreach (int i in evens)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();

            int[] divisors = { 1, 2, 3 };
            var byAll = handler.GetNumbersDivisibleByAllDivisors(numbers, divisors);
            var byAny = handler.GetNumbersDivisibleByAtLeastOneDivisor(numbers, divisors);
            var byNone = handler.GetNumbersNotDivisibleByAnyDivisor(numbers, divisors);

            Console.Write("Numbers divisible by 1, 2 and 3: ");
            foreach (int i in byAll)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();

            Console.Write("Numbers divisible by 1, 2 or 3: ");
            foreach (int i in byAny)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();

            Console.Write("Numbers indivisible by 1, 2 and 3: ");
            foreach (int i in byNone)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();

            var prime = handler.GetPrimeNumbers(numbers);

            Console.Write("Prime numbers: ");
            foreach (int i in prime)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();
            #endregion


            #region ChessPlayerParser examples
            ChessPlayer[] top10july2000 = {
                new ChessPlayer("Garry", "Kasparov", 47, 2849, Country.Russia),
                new ChessPlayer("Vladimir", "Kramnik", 25, 2770, Country.Russia),
                new ChessPlayer("Viswanathan", "Anand", 47, 2762, Country.India),
                new ChessPlayer("Alexander", "Morozevich", 23, 2756, Country.Russia),
                new ChessPlayer("Michael", "Adams", 29, 2755, Country.England),
                new ChessPlayer("Alexei", "Shirov", 28, 2746, Country.Spain),
                new ChessPlayer("Peter", "Leko", 21, 2743, Country.Hungary),
                new ChessPlayer("Vassily", "Ivanchuk", 31, 2719, Country.Ukraine),
                new ChessPlayer("Veselin", "Topalov", 25, 2707, Country.Bulgaria),
                new ChessPlayer("Michal", "Krasenkow", 37, 2702, Country.Poland),
            };

            var top10september2020 = new List<ChessPlayer>
            {
                new ChessPlayer("Carlsen", "Magnus", 30, 2863, Country.Norway),
                new ChessPlayer("Fabiano", "Caruana", 28, 2835, Country.USA),
                new ChessPlayer("Liren", "Ding", 28, 2791, Country.China),
                new ChessPlayer("Ian", "Nepomniachtchi", 30, 2784, Country.Russia),
                new ChessPlayer("Maxime", "Vachier-Lagrave", 30, 2778, Country.France),
                new ChessPlayer("Alexander", "Grischuk", 37, 2777, Country.Russia),
                new ChessPlayer("Levon", "Aronian", 38, 2773, Country.Armenia),
                new ChessPlayer("Wesley", "So", 27, 2770, Country.USA),
                new ChessPlayer("Teimour", "Radjabov", 33, 2765, Country.Azerbaijan),
                new ChessPlayer("Anish", "Giri", 26, 2764, Country.Netherlands)
            };

            var parser1 = new ChessPlayersParser(top10july2000);
            var parser2 = new ChessPlayersParser(top10september2020);

            var between2700and2750ELOinJuly2000 = parser1.GetChessPlayersInEloRatingRange(2700, 2750);
            var between2700and2750ELOinSeptember2020 = parser2.GetChessPlayersInEloRatingRange(2700, 2750);

            var olderThan30inJuly2000 = parser1.GetChessPlayersOlderThanSpecifiedAge(30);
            var olderThan30inSeptember2020 = parser2.GetChessPlayersOlderThanSpecifiedAge(30);

            var russiansOlderThan30inJuly2000 = parser1.GetChessPlayersOlderThanSpecifiedAgeFromSpecifiedCoutry(30, Country.Russia);
            var americansOlderThan27inSeptember2020 = parser2.GetChessPlayersOlderThanSpecifiedAgeFromSpecifiedCoutry(27, Country.USA);

            var higherThan2700ELOgroupedByCountryInJuly2000 = parser1.GetChessPlayersWithHigherOrEqualEloRatingGroupedByCountry(2700);
            var higherThan2700ELOgroupedByCountryInSeptember2020 = parser2.GetChessPlayersWithHigherOrEqualEloRatingGroupedByCountry(2700);


            Console.Write("Top 10 players between 2700 and 2750 ELO in July 2000: ");
            foreach (var player in between2700and2750ELOinJuly2000)
            {
                Console.Write($"{player.FirstName} {player.LastName}, ");
            }
            Console.WriteLine();

            Console.Write("Top 10 players between 2700 and 2750 ELO in September 2020: ");
            foreach (var player in between2700and2750ELOinSeptember2020)
            {
                Console.Write($"{player.FirstName} {player.LastName}, ");
            }
            Console.WriteLine();

            Console.Write("Top 10 players older than 30 in July 2000: ");
            foreach (var player in olderThan30inJuly2000)
            {
                Console.Write($"{player.FirstName} {player.LastName}, ");
            }
            Console.WriteLine();

            Console.Write("Top 10 players older than 30 in September 2020: ");
            foreach (var player in olderThan30inSeptember2020)
            {
                Console.Write($"{player.FirstName} {player.LastName}, ");
            }
            Console.WriteLine();

            Console.Write("Top 10 Russian players older than 30 in July 2000: ");
            foreach (var player in russiansOlderThan30inJuly2000)
            {
                Console.Write($"{player.FirstName} {player.LastName}, ");
            }
            Console.WriteLine();

            Console.Write("Top 10 American players older than 27 in September 2020: ");
            foreach (var player in americansOlderThan27inSeptember2020)
            {
                Console.Write($"{player.FirstName} {player.LastName}, ");
            }
            Console.WriteLine();

            Console.WriteLine("Top 10 players of ELO 2700 or greater grouped by country in July 2000: ");
            foreach (var grouping in higherThan2700ELOgroupedByCountryInJuly2000)
            {
                Console.WriteLine($"{grouping.Key}: ");
                foreach (var player in grouping)
                {
                    Console.Write($"{player.FirstName} {player.LastName}; ");
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Top 10 players of ELO 2700 or greater grouped by country in September 2020: ");
            foreach (var grouping in higherThan2700ELOgroupedByCountryInSeptember2020)
            {
                Console.WriteLine($"{grouping.Key}: ");
                foreach (var player in grouping)
                {
                    Console.Write($"{player.FirstName} {player.LastName}; ");
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            #endregion
        }
    }
}
