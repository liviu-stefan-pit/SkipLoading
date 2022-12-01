using System.Linq;
using System.Text;

namespace IBetForYou
{
    public class MatchPrediction
    {
        public string GameId => GetMatchId();

        public int HomeTeamId => GetTeamId(HomeTeam);

        public int AwayTeamId => GetTeamId(AwayTeam);

        public int HomeTeamScore => GetTeamScore();

        public int AwayTeamScore => GetTeamScore(true);

        public string HomeTeam { get; set; }

        public string ScorePrediction { get; set; }

        public string AwayTeam { get; set; }

        public int FinalResult { get; set; }

        public string SafeSuggestion { get; set; }

        public override string ToString()
        {
            return $"{HomeTeam} {ScorePrediction} {AwayTeam} : Bet - {FinalResult}";
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
            string[] data = ScorePrediction.Split("-");

            int.TryParse(data.FirstOrDefault(), out int homeScore);
            int.TryParse(data.LastOrDefault(), out int awayScore);

            return !away ? homeScore : awayScore;
        }
    }
}