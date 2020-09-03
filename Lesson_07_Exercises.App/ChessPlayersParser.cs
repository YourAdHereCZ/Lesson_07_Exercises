using System.Collections.Generic;
using System.Linq;

namespace Lesson_07_Exercises.App
{
    public class ChessPlayersParser : IChessPlayersParser
    {
        public IEnumerable<ChessPlayer> Players { get; }

        public ChessPlayersParser(IEnumerable<ChessPlayer> players)
        {
            Players = players;
        }

        public IEnumerable<ChessPlayer> GetChessPlayersInEloRatingRange(int minEloRating, int maxEloRating)
        {
            return Players.Where(x => x.EloRating >= minEloRating && x.EloRating <= maxEloRating);
        }

        public IEnumerable<ChessPlayer> GetChessPlayersOlderThanSpecifiedAge(int ageInYears)
        {
            return Players.Where(x => x.AgeInYears > ageInYears);
        }

        public IEnumerable<ChessPlayer> GetChessPlayersOlderThanSpecifiedAgeFromSpecifiedCoutry(int ageInYears, Country country)
        {
            return Players.Where(x => x.AgeInYears > ageInYears && x.Country == country);
        }

        public IEnumerable<IGrouping<Country, ChessPlayer>> GetChessPlayersWithHigherOrEqualEloRatingGroupedByCountry(int minEloRating)
        {
            return Players.Where(x => x.EloRating >= minEloRating).GroupBy(x => x.Country);
        }
    }
}
