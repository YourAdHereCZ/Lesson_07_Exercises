using System.Collections.Generic;
using System.Linq;

namespace Lesson_07_Exercises.App
{
    public interface IChessPlayersParser
    {
        IEnumerable<ChessPlayer> GetChessPlayersInEloRatingRange(int minEloRating, int maxEloRating);
        IEnumerable<ChessPlayer> GetChessPlayersOlderThanSpecifiedAge(int ageInYears);
        IEnumerable<ChessPlayer> GetChessPlayersOlderThanSpecifiedAgeFromSpecifiedCoutry(int ageInYears, Country country);
        IEnumerable<IGrouping<Country, ChessPlayer>> GetChessPlayersWithHigherOrEqualEloRatingGroupedByCountry(int minEloRating);
    }
}
