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
            return Players.Where(player => player.EloRating >= minEloRating && player.EloRating <= maxEloRating);
        }

        public IEnumerable<ChessPlayer> GetChessPlayersOlderThanSpecifiedAge(int ageInYears)
        {
            return Players.Where(player => player.AgeInYears > ageInYears);
        }

        public IEnumerable<ChessPlayer> GetChessPlayersOlderThanSpecifiedAgeFromSpecifiedCoutry(int ageInYears, Country country)
        {
            return Players.Where(player => player.AgeInYears > ageInYears && player.Country == country);
        }

        public IEnumerable<IGrouping<Country, ChessPlayer>> GetChessPlayersWithHigherOrEqualEloRatingGroupedByCountry(int minEloRating)
        {
            return Players.Where(player => player.EloRating >= minEloRating).GroupBy(player => player.Country);
        }
    }
}
