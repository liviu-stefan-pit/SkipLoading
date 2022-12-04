using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBetForYou.Services
{
    public class ScoresService
    {
        private readonly List<string> _scores;

        private List<int> _homeScores;

        private List<int> _awayScores;

        private int _homeWins = 0;

        private int _awayWins = 0;

        private int _draws = 0;

        public ScoresService(List<string> scores)
        {
            _scores = scores;
            _homeScores = new();
            _awayScores = new();

            GetGameDataFromScore();
        }

        public List<int> HomeScores => _homeScores;

        public List<int> AwayScores => _awayScores;

        public int HomeWins => _homeWins;

        public int AwayWins => _awayWins;

        public int Draws => _draws;

        private void GetGameDataFromScore()
        {
            foreach (var score in _scores)
            {
                string[] data = score.Split("-");

                int.TryParse(data[0], out int res1);
                int.TryParse(data[1], out int res2);

                HomeScores.Add(res1);
                AwayScores.Add(res2);

                GetWinsDraws(res1, res2);
            }
        }

        private void GetWinsDraws(int scoreT1, int scoreT2)
        {
            if (scoreT1 > scoreT2) _homeWins += 1;
            else if (scoreT1 < scoreT2) _awayWins += 1;
            else _draws += 1;
        }
    }
}
