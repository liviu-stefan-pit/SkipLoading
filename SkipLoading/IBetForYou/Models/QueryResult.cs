using IBetForYou.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBetForYou.Models
{
    public class QueryResult
    {
        private IEnumerable<string> teams;
        private IEnumerable<string> scores;

        private readonly Website _website;

        public QueryResult(IEnumerable<string> teams, IEnumerable<string> scores, Website website)
        {
            this.teams = teams;
            this.scores = scores;
            _website = website;
        }

        public List<Game> Games => BuildGames(_website);

        private List<Game> BuildGames(Website website)
        {
            List<Game> games = new();

            if(website == Website.Forebet)
            {
                return ForebetGamesBuilder();
            }
            else if(
                website == Website.PredictZ || 
                website == Website.WinDrawWin)
            {
                return PredictzGamesBuilder();
            }

            return games;
        }

        private List<Game> PredictzGamesBuilder()
        {
            List<Game> games = new();

            if (teams.Count() != scores.Count())
                return games;

            for (int i = 0; i < teams.Count() - 1; i++)
            {
                string[] teamData = teams.ElementAt(i).Split("v");
                string[] scoreData = scores.ElementAt(i).Split(" ");

                games.Add(new Game
                {
                    HomeTeam = teamData.FirstOrDefault().Trim(),
                    Score = scoreData.LastOrDefault().Trim(),
                    AwayTeam = teamData.LastOrDefault().Trim(),
                });
            }

            return games;
        }

        private List<Game> ForebetGamesBuilder()
        {
            List<Game> games = new();

            scores = scores.Where(val => !val.Contains("score")).ToArray();

            for (int i = 0; i < (scores.Count() * 2) - 1; i += 2)
            {
                games.Add(new Game
                {
                    HomeTeam = teams.ElementAt(i),
                    Score = scores.ElementAt(i / 2),
                    AwayTeam = teams.ElementAt(i + 1)
                });
            }

            return games;
        }
    }
}
