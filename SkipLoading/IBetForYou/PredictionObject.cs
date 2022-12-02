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

        public PredictionObject(string? homeTeam, string? awayTeam, List<string> scores)
        {
            this.homeTeam = homeTeam;
            this.awayTeam = awayTeam;
            this.scores = scores;

            GetHighRiskPredictions();
        }

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