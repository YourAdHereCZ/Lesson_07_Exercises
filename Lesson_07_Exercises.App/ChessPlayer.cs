using System;

namespace Lesson_07_Exercises.App
{
    public class ChessPlayer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public int AgeInYears { get; set; }
        public int EloRating { get; set; }
        public TimeSpan ThisYearTrainingTime { get; set; }
        public Country Country { get; set; }

        public ChessPlayer(string firstName, string lastName, int ageInYears, int eloRating, Country country)
        {
            FirstName = firstName;
            LastName = lastName;
            AgeInYears = ageInYears;
            EloRating = eloRating;
            Country = country;
        }
    }
}
