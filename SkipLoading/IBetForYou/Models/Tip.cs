namespace IBetForYou.Models
{
    public abstract class Tip
    {
        public int Id { get; set; }

        public string? QueryResultTeams { get; set; }

        public string? QueryResultScore { get; set; }

        public string? Home { get; set; }

        public string? Away { get; set; }

        public int HomeScore { get; set; }

        public int AwayScore { get; set; }

        public string? Bet { get; set; }

        public string? SafeBet { get; set; }

        public override string ToString()
        {
            return $"{Home} - {Away} : {HomeScore}-{AwayScore} : Bet {Bet} : Safe Bet {SafeBet}";
        }
    }
}