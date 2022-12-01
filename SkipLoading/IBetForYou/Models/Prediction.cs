using System;
using System.Collections.Generic;
using System.Linq;

namespace IBetForYou.Models
{
    public class Prediction
    {
        public Guid Id => Guid.NewGuid();

        public int WinsBasedPrediction => GetWinBasedPredictions();

        public int ScoresBasedPrediction => GetScoresBasedPrediction();

        public int MixedPrediction => GetMixedPredictions();

        public string? MixedSafePrediction { get; set; } //TODO

        private readonly List<(int hScore, int aScore)> _scores;

        private readonly Game? _game;

        public Prediction(List<Game> games)
        {
            _scores = games.GetScores();
            _game = games.FirstOrDefault();
        }

        private int GetWinBasedPredictions()
        {
            int homeTeamWins = GetHomeTeamWins();
            int awayTeamWins = GetAwayTeamWins();

            if (homeTeamWins > awayTeamWins) return 1;
            else if (homeTeamWins < awayTeamWins) return 2;
            else return 3; //if 3 bet is unsure so ignore it
        }

        private int GetScoresBasedPrediction()
        {
            int homeScore = 0;
            int awayScore = 0;

            foreach (var score in _scores)
            {
                homeScore += score.hScore;
                awayScore += score.aScore;
            }

            homeScore /= _scores.Count();
            awayScore /= _scores.Count();

            if (homeScore > awayScore) return 1;
            else if (homeScore < awayScore) return 2;
            else return 3; //if 3 bet is unsure so ignore it
        }

        private int GetMixedPredictions()
        {
            int winP = GetWinBasedPredictions();
            int scoreP = GetScoresBasedPrediction();

            if (winP == scoreP) return winP;
            else return 3; //if 3 bet is unsure so ignore it
        }

        private int GetHomeTeamWins()
        {
            return _scores.Where(g => g.hScore > g.aScore).ToList().Count;
        }

        private int GetAwayTeamWins()
        {
            return _scores.Where(g => g.hScore < g.aScore).ToList().Count;
        }

        private int GetDraws()
        {
            return _scores.Where(g => g.hScore == g.aScore).ToList().Count;
        }

        public override string ToString()
        {
            return $"{_game.HomeTeam}-{_game.AwayTeam} : {MixedPrediction}";
        }
    }
}