using IBetForYou.Models;
using IBetForYou.Services;
using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace IBetForYou
{
    internal class PredictionObject : BaseViewModel
    {
        private string? homeTeam;
        private string? awayTeam;
        private List<string> scores;
        private int _highRisk;

        private readonly ScoresService _scoresService;

        public GameResult GameResult => GetGameResult();

        public PredictionObject(string? homeTeam, string? awayTeam, List<string> scores)
        {
            this.homeTeam = homeTeam;
            this.awayTeam = awayTeam;
            this.scores = scores;

            _scoresService = new ScoresService(this.scores);

            HomeScores = new();
            AwayScores = new();

            //GetScores();

            GetHighRiskPredictions();
        }

        private void GetScores()
        {
            foreach (var score in scores)
            {
                string[] data = score.Split("-");

                int.TryParse(data[0], out int res1);
                int.TryParse(data[1], out int res2);

                HomeScores.Add(res1);
                AwayScores.Add(res2);
            }
        }

        public List<int> HomeScores { get; set; }

        public List<int> AwayScores { get; set; }

        public string? Home => homeTeam;

        public string? Away => awayTeam;

        public int HomeScore => CalculateScore(scores, true);

        public int AwayScore => CalculateScore(scores);

        public int HighRiskHighReward
        {
            get => _highRisk;
            set
            {
                _highRisk = value;
                OnPropertyChanged();
            }
        }

        public string ScoreBasedPredictions => GetScoreBasedPredictions();

        private GameResult GetGameResult()
        {
            //int winBasedPrediction = GetWinBasedPrediction();

            return null;
        }

        //private int GetWinBasedPrediction()
        //{

        //}

        private string GetScoreBasedPredictions()
        {
            string result = string.Empty;

            if (HomeScore > AwayScore)
            {
                HighRiskHighReward = 1;
                result = "1 1X 12";
            }
            else if (HomeScore < AwayScore)
            {
                HighRiskHighReward = 2;
                result = "2 X2 12";
            }
            else
            {
                HighRiskHighReward = 0;
                result = "1X X X2";
            }

            return result;
        }

        private void GetHighRiskPredictions()
        {
            if (HomeScore > AwayScore)
            {
                HighRiskHighReward = 1;
            }
            else if (HomeScore < AwayScore)
            {
                HighRiskHighReward = 2;
            }
            else
            {
                HighRiskHighReward = 0;
            }
        }

        private int CalculateScore(List<string> scores, bool isHome = false)
        {
            int homeScore = 0;
            int awayScore = 0;

            foreach (var score in scores)
            {
                string[] data = score.Split("-");

                int.TryParse(data[0], out int res1);
                int.TryParse(data[1], out int res2);

                homeScore += res1;
                awayScore += res2;
            }

            return isHome ? homeScore / scores.Count : awayScore / scores.Count;
        }
    }
}