namespace IBetForYou.Models
{
    public class Teams
    {
        public string? Home { get; set; }

        public string? Away { get; set; }
    }

    public class Score
    {
        public string? QueryResultScore { get; set; }

        //1-2 1 - 5

        public int HomeScore => GetScore(true);

        public int AwayScore => GetScore();

        private int GetScore(bool home = false)
        {
            string[] data = QueryResultScore.Split(" - ");

            int.TryParse(data[1], out int homeS);
            int.TryParse(data[2], out int awayS);

            return home ? homeS : awayS;
        }
    }

    public abstract class Tip
    {
        public int Id { get; set; }

        public string? QueryResultTeams { get; set; }

        public Score Score { get; set; }

        public Teams Teams { get; set; }

        public int HomeScore { get; set; }

        public int AwayScore { get; set; }

        public string? Bet { get; set; }

        public string? SafeBet { get; set; }

        public override string ToString()
        {
            return $" {HomeScore}-{AwayScore} : Bet {Bet} : Safe Bet {SafeBet}";
        }
    }
}