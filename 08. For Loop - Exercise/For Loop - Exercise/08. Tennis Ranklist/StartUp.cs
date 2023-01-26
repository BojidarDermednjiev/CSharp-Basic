namespace _08._Tennis_Ranklist
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            Dictionary<string, int> endOfTournamentOption
                = new Dictionary<string, int>()
                {
                    { "W", 2000 },
                    { "F", 1200 },
                    { "SF", 720 },
                };
            int countOfTournamentsWhatHePlaying = int.Parse(Console.ReadLine());
            int startedPointsInRankingList = int.Parse(Console.ReadLine());
            double counterForWins = default(double);
            double counterForTournaments = default(double);
            double pointFromTournament = default(double);
            for (int currentTournament = 0; currentTournament < countOfTournamentsWhatHePlaying; currentTournament++)
            {
                var tournament = Console.ReadLine();
                if (tournament == "W")
                    counterForWins++;
                if (endOfTournamentOption.ContainsKey(tournament))
                    startedPointsInRankingList += GetValue(endOfTournamentOption, tournament);
                pointFromTournament += GetValue(endOfTournamentOption, tournament);
                counterForTournaments++;
            }
            Console.WriteLine($"Final points: {startedPointsInRankingList}");
            Console.WriteLine($"Average points: {Math.Floor(pointFromTournament / counterForTournaments)}");
            Console.WriteLine($"{(counterForWins / counterForTournaments * 100):f2}%");
          }

        private static int GetValue(Dictionary<string, int> endOfTournamentOption, string tournament)
            => endOfTournamentOption.FirstOrDefault(x => x.Key == tournament).Value;
    }
}
