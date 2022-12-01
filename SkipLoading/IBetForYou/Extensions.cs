using IBetForYou.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IBetForYou
{
    public static class Extensions
    {
        public static int GetBytesSum(this byte[] bytes)
        {
            int sum = 0;

            foreach (var b in bytes)
            {
                int.TryParse(b.ToString(), out int result);
                sum += result;
            }

            return sum;
        }

        public static int GetHomeTeamWins(this List<GamePrediction> games)
        {
            return games.Where(g => g.AwayTeamScore > g.HomeTeamScore).ToList().Count;
        }

        public static int GetAwayTeamWins(this List<GamePrediction> games)
        {
            return games.Where(g => g.AwayTeamScore < g.HomeTeamScore).ToList().Count;
        }

        public static int GetDraws(this List<GamePrediction> games)
        {
            return games.Where(g => g.AwayTeamScore == g.HomeTeamScore).ToList().Count;
        }

        public static string GetFinalScore(this List<string> scores)
        {
            int homeScore = 0;
            int awayScore = 0;

            foreach (var score in scores)
            {
                string[] data = score.Split("-");

                int.TryParse(data.FirstOrDefault(), out int homeS);
                int.TryParse(data.LastOrDefault(), out int awayS);

                homeScore += homeS;
                awayScore += awayS;
            }

            homeScore /= scores.Count();
            awayScore /= scores.Count();

            return $"{homeScore}-{awayScore}";
        }

        public static List<(int hScore, int aScore)> GetScores(this List<Game> matchPredictions)
        {
            List<(int hScore, int aScore)> scores = new();

            foreach (var item in matchPredictions)
            {
                string[] data = item.Score.Split("-");

                if(data.Count() > 1)
                {
                    int.TryParse(data.FirstOrDefault().Trim(), out int r1);
                    int.TryParse(data.LastOrDefault().Trim(), out int r2);

                    scores.Add((r1, r2));
                }
            }

            return scores;
        }
    }
}
