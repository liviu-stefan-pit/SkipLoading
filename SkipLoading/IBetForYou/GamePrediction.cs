using System.Linq;
using System.Text;

namespace IBetForYou
{
    public class GamePrediction
    {
        private readonly string _homeTeam;

        private readonly string _awayTeam;

        private readonly string _score;

        public string GameId => GetMatchId();

        public int HomeTeamId => GetTeamId(HomeTeam);

        public int AwayTeamId => GetTeamId(AwayTeam);

        public int HomeTeamScore => GetTeamScore();

        public int AwayTeamScore => GetTeamScore(true);

        public string HomeTeam => _homeTeam;

        public string Score => _score;

        public string AwayTeam => _awayTeam;

        public int FinalResult { get; set; }

        public string SafeSuggestion { get; set; }

        public GamePrediction(string homeTeam, string awayTeam, string score)
        {
            _homeTeam = homeTeam;
            _awayTeam = awayTeam;
            _score = score;
        }

        public override string ToString()
        {
            return $"{HomeTeam} {Score} {AwayTeam} : Bet - {FinalResult}";
        }

        private string GetMatchId()
        {
            byte[] homeBytes = Encoding.ASCII.GetBytes(HomeTeam);
            byte[] awayBytes = Encoding.ASCII.GetBytes(AwayTeam);

            return $"{homeBytes.GetBytesSum() + awayBytes.GetBytesSum()}";
        }

        private int GetTeamId(string team)
        {
            return Encoding.ASCII.GetBytes(team).GetBytesSum();
        }

        private int GetTeamScore(bool away = false)
        {
            string[] data = Score.Split("-");

            int.TryParse(data.FirstOrDefault().Trim(), out int homeScore);
            int.TryParse(data.LastOrDefault().Trim(), out int awayScore);

            return !away ? homeScore : awayScore;
        }
    }
}