using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBetForYou
{
    public class MatchPrediction
    {
        public string HomeTeam { get; set; }

        public string ScorePrediction { get; set; }

        public string AwayTeam { get; set; }

        public int FinalResult { get; set; }

        public string SafeSuggestion { get; set; }

        public override string ToString()
        {
            return $"{HomeTeam} {ScorePrediction} {AwayTeam} : Bet - {FinalResult}";
        }
    }
}
