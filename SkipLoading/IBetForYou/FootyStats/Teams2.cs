using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBetForYou.FootyStats
{
    public class Teams2
    {
        public string TeamName { get; set; }
        public string CommonName { get; set; }
        public string Season { get; set; }
        public string Country { get; set; }
        public int AverageAttendanceOverall { get; set; }
        public int AverageAttendanceHome { get; set; }
        public int AverageAttendanceAway { get; set; }
        public int MinutesPerGoalScoredOverall { get; set; }
        public int MinutesPerGoalScoredHome { get; set; }
        public int MinutesPerGoalScoredAway { get; set; }
        public int MinutesPerGoalConcededOverall { get; set; }
        public int MinutesPerGoalConcededHome { get; set; }
        public int MinutesPerGoalConcededAway { get; set; }
        public int HighestGoalsScoredHome { get; set; }
        public int HighestGoalsScoredAway { get; set; }
        public int HighestGoalsConcededHome { get; set; }
        public int HighestGoalsConcededAway { get; set; }
        public int HalfTimePointsOverall { get; set; }
        public int HalfTimePointsHome { get; set; }
        public int HalfTimePointsAway { get; set; }
        public int CornersRecordedMatchesNumOverall { get; set; }
        public int CornersRecordedMatchesNumHome { get; set; }
        public int CornersRecordedMatchesAway { get; set; }
        public double CornersTotalPerMatchOverall { get; set; }
        public double CornersTotalPerMatchHome { get; set; }
        public double CornersTotalPerMatchAway { get; set; }
        public int CornersAgainstOverall { get; set; }
        public int CornersAgainstHome { get; set; }
        public int CornersAgainstAway { get; set; }
        public double CornersAgainstPerMatchOverall { get; set; }
        public double CornersAgainstPerMatchHome { get; set; }
        public double CornersAgainstPerMatchAway { get; set; }
        public int Over65CornersNumOverall { get; set; }
        public int Over75CornersNumOverall { get; set; }
        public int Over85CornersNumOverall { get; set; }
        public int Over95CornersNumOverall { get; set; }
        public int Over105CornersNumOverall { get; set; }
        public int Over115CornersNumOverall { get; set; }
        public int Over125CornersNumOverall { get; set; }
        public int Over135CornersNumOverall { get; set; }
        public int Over145CornersNumOverall { get; set; }
        public int Over65CornersNumHome { get; set; }
        public int Over75CornersNumHome { get; set; }
        public int Over85CornersNumHome { get; set; }
        public int Over95CornersNumHome { get; set; }
        public int Over105CornersNumHome { get; set; }
        public int Over115CornersNumHome { get; set; }
        public int Over125CornersNumHome { get; set; }
        public int Over135CornersNumHome { get; set; }
        public int Over145CornersNumHome { get; set; }
        public int Over65CornersPercentageHome { get; set; }
        public int Over75CornersPercentageHome { get; set; }
        public int Over85CornersPercentageHome { get; set; }
        public int Over95CornersPercentageHome { get; set; }
        public int Over105CornersPercentageHome { get; set; }
        public int Over115CornersPercentageHome { get; set; }
        public int Over125CornersPercentageHome { get; set; }
        public int Over135CornersPercentageHome { get; set; }
        public int Over145CornersPercentageHome { get; set; }
        public int Over65CornersNumAway { get; set; }
        public int Over75CornersNumAway { get; set; }
        public int Over85CornersNumAway { get; set; }
        public int Over95CornersNumAway { get; set; }
        public int Over105CornersNumAway { get; set; }
        public int Over115CornersNumAway { get; set; }
        public int Over125CornersNumAway { get; set; }
        public int Over135CornersNumAway { get; set; }
        public int Over145CornersNumAway { get; set; }
        public int Over65CornersPercentageAway { get; set; }
        public int Over75CornersPercentageAway { get; set; }
        public int Over85CornersPercentageAway { get; set; }
        public int Over95CornersPercentageAway { get; set; }
        public int Over105CornersPercentageAway { get; set; }
        public int Over115CornersPercentageAway { get; set; }
        public int Over125CornersPercentageAway { get; set; }
        public int Over135CornersPercentageAway { get; set; }
        public int Over145CornersPercentageAway { get; set; }
        public int Over25CornersForOverall { get; set; }
        public int Over35CornersForOverall { get; set; }
        public int Over45CornersForOverall { get; set; }
        public int Over55CornersForOverall { get; set; }
        public int Over65CornersForOverall { get; set; }
        public int Over75CornersForOverall { get; set; }
        public int Over85CornersForOverall { get; set; }
        public int Over25CornersForPercentageOverall { get; set; }
        public int Over35CornersForPercentageOverall { get; set; }
        public int Over45CornersForPercentageOverall { get; set; }
        public int Over55CornersForPercentageOverall { get; set; }
        public int Over65CornersForPercentageOverall { get; set; }
        public int Over75CornersForPercentageOverall { get; set; }
        public int Over85CornersForPercentageOverall { get; set; }
        public int Over25CornersForHome { get; set; }
        public int Over35CornersForHome { get; set; }
        public int Over45CornersForHome { get; set; }
        public int Over55CornersForHome { get; set; }
        public int Over65CornersForHome { get; set; }
        public int Over75CornersForHome { get; set; }
        public int Over85CornersForHome { get; set; }
        public int Over25CornersForPercentageHome { get; set; }
        public int Over35CornersForPercentageHome { get; set; }
        public int Over45CornersForPercentageHome { get; set; }
        public int Over55CornersForPercentageHome { get; set; }
        public int Over65CornersForPercentageHome { get; set; }
        public int Over75CornersForPercentageHome { get; set; }
        public int Over85CornersForPercentageHome { get; set; }
        public int Over25CornersForAway { get; set; }
        public int Over35CornersForAway { get; set; }
        public int Over45CornersForAway { get; set; }
        public int Over55CornersForAway { get; set; }
        public int Over65CornersForAway { get; set; }
        public int Over75CornersForAway { get; set; }
        public int Over85CornersForAway { get; set; }
        public int Over25CornersForPercentageAway { get; set; }
        public int Over35CornersForPercentageAway { get; set; }
        public int Over45CornersForPercentageAway { get; set; }
        public int Over55CornersForPercentageAway { get; set; }
        public int Over65CornersForPercentageAway { get; set; }
        public int Over75CornersForPercentageAway { get; set; }
        public int Over85CornersForPercentageAway { get; set; }
        public int Over25CornersAgainstOverall { get; set; }
        public int Over35CornersAgainstOverall { get; set; }
        public int Over45CornersAgainstOverall { get; set; }
        public int Over55CornersAgainstOverall { get; set; }
        public int Over65CornersAgainstOverall { get; set; }
        public int Over75CornersAgainstOverall { get; set; }
        public int Over85CornersAgainstOverall { get; set; }
        public int Over25CornersAgainstPercentageOverall { get; set; }
        public int Over35CornersAgainstPercentageOverall { get; set; }
        public int Over45CornersAgainstPercentageOverall { get; set; }
        public int Over55CornersAgainstPercentageOverall { get; set; }
        public int Over65CornersAgainstPercentageOverall { get; set; }
        public int Over75CornersAgainstPercentageOverall { get; set; }
        public int Over85CornersAgainstPercentageOverall { get; set; }
        public int Over25CornersAgainstHome { get; set; }
        public int Over35CornersAgainstHome { get; set; }
        public int Over45CornersAgainstHome { get; set; }
        public int Over55CornersAgainstHome { get; set; }
        public int Over65CornersAgainstHome { get; set; }
        public int Over75CornersAgainstHome { get; set; }
        public int Over85CornersAgainstHome { get; set; }
        public int Over25CornersAgainstPercentageHome { get; set; }
        public int Over35CornersAgainstPercentageHome { get; set; }
        public int Over45CornersAgainstPercentageHome { get; set; }
        public int Over55CornersAgainstPercentageHome { get; set; }
        public int Over65CornersAgainstPercentageHome { get; set; }
        public int Over75CornersAgainstPercentageHome { get; set; }
        public int Over85CornersAgainstPercentageHome { get; set; }
        public int Over25CornersAgainstAway { get; set; }
        public int Over35CornersAgainstAway { get; set; }
        public int Over45CornersAgainstAway { get; set; }
        public int Over55CornersAgainstAway { get; set; }
        public int Over65CornersAgainstAway { get; set; }
        public int Over75CornersAgainstAway { get; set; }
        public int Over85CornersAgainstAway { get; set; }
        public int Over25CornersAgainstPercentageAway { get; set; }
        public int Over35CornersAgainstPercentageAway { get; set; }
        public int Over45CornersAgainstPercentageAway { get; set; }
        public int Over55CornersAgainstPercentageAway { get; set; }
        public int Over65CornersAgainstPercentageAway { get; set; }
        public int Over75CornersAgainstPercentageAway { get; set; }
        public int Over85CornersAgainstPercentageAway { get; set; }
        public int CornerTimingRecordedMatchesOverall { get; set; }
        public int CornerTimingRecordedMatchesHome { get; set; }
        public int CornerTimingRecordedMatchesAway { get; set; }
        public int CornersTotalFhOverall { get; set; }
        public int CornersTotalFhHome { get; set; }
        public int CornersTotalFhAway { get; set; }
        public int CornersTotal2hOverall { get; set; }
        public int CornersTotal2hHome { get; set; }
        public int CornersTotal2hAway { get; set; }
        public double CornersTotalPerMatchFhOverall { get; set; }
        public double CornersTotalPerMatchFhHome { get; set; }
        public double CornersTotalPerMatchFhAway { get; set; }
        public double CornersTotalPerMatch2hOverall { get; set; }
        public double CornersTotalPerMatch2hHome { get; set; }
        public double CornersTotalPerMatch2hAway { get; set; }
        public int CornersTotalFhOver4Overall { get; set; }
        public int CornersTotalFhOver5Overall { get; set; }
        public int CornersTotalFhOver6Overall { get; set; }
        public int CornersTotal2hOver4Overall { get; set; }
        public int CornersTotal2hOver5Overall { get; set; }
        public int CornersTotal2hOver6Overall { get; set; }
        public int Over05CardsTotalOverall { get; set; }
        public int Over15CardsTotalOverall { get; set; }
        public int Over25CardsTotalOverall { get; set; }
        public int Over35CardsTotalOverall { get; set; }
        public int Over45CardsTotalOverall { get; set; }
        public int Over55CardsTotalOverall { get; set; }
        public int Over65CardsTotalOverall { get; set; }
        public int Over75CardsTotalOverall { get; set; }
        public int Over85CardsTotalOverall { get; set; }
        public int Over05CardsTotalPercentageOverall { get; set; }
        public int Over15CardsTotalPercentageOverall { get; set; }
        public int Over25CardsTotalPercentageOverall { get; set; }
        public int Over35CardsTotalPercentageOverall { get; set; }
        public int Over45CardsTotalPercentageOverall { get; set; }
        public int Over55CardsTotalPercentageOverall { get; set; }
        public int Over65CardsTotalPercentageOverall { get; set; }
        public int Over75CardsTotalPercentageOverall { get; set; }
        public int Over85CardsTotalPercentageOverall { get; set; }
        public int Over05CardsTotalHome { get; set; }
        public int Over15CardsTotalHome { get; set; }
        public int Over25CardsTotalHome { get; set; }
        public int Over35CardsTotalHome { get; set; }
        public int Over45CardsTotalHome { get; set; }
        public int Over55CardsTotalHome { get; set; }
        public int Over65CardsTotalHome { get; set; }
        public int Over75CardsTotalHome { get; set; }
        public int Over85CardsTotalHome { get; set; }
        public int Over05CardsTotalPercentageHome { get; set; }
        public int Over15CardsTotalPercentageHome { get; set; }
        public int Over25CardsTotalPercentageHome { get; set; }
        public int Over35CardsTotalPercentageHome { get; set; }
        public int Over45CardsTotalPercentageHome { get; set; }
        public int Over55CardsTotalPercentageHome { get; set; }
        public int Over65CardsTotalPercentageHome { get; set; }
        public int Over75CardsTotalPercentageHome { get; set; }
        public int Over85CardsTotalPercentageHome { get; set; }
        public int Over05CardsTotalAway { get; set; }
        public int Over15CardsTotalAway { get; set; }
        public int Over25CardsTotalAway { get; set; }
        public int Over35CardsTotalAway { get; set; }
        public int Over45CardsTotalAway { get; set; }
        public int Over55CardsTotalAway { get; set; }
        public int Over65CardsTotalAway { get; set; }
        public int Over75CardsTotalAway { get; set; }
        public int Over85CardsTotalAway { get; set; }
        public int Over05CardsTotalPercentageAway { get; set; }
        public int Over15CardsTotalPercentageAway { get; set; }
        public int Over25CardsTotalPercentageAway { get; set; }
        public int Over35CardsTotalPercentageAway { get; set; }
        public int Over45CardsTotalPercentageAway { get; set; }
        public int Over55CardsTotalPercentageAway { get; set; }
        public int Over65CardsTotalPercentageAway { get; set; }
        public int Over75CardsTotalPercentageAway { get; set; }
        public int Over85CardsTotalPercentageAway { get; set; }
        public int Over05CardsForOverall { get; set; }
        public int Over15CardsForOverall { get; set; }
        public int Over25CardsForOverall { get; set; }
        public int Over35CardsForOverall { get; set; }
        public int Over45CardsForOverall { get; set; }
        public int Over55CardsForOverall { get; set; }
        public int Over65CardsForOverall { get; set; }
        public int Over05CardsForPercentageOverall { get; set; }
        public int Over15CardsForPercentageOverall { get; set; }
        public int Over25CardsForPercentageOverall { get; set; }
        public int Over35CardsForPercentageOverall { get; set; }
        public int Over45CardsForPercentageOverall { get; set; }
        public int Over55CardsForPercentageOverall { get; set; }
        public int Over65CardsForPercentageOverall { get; set; }
        public int Over05CardsForHome { get; set; }
        public int Over15CardsForHome { get; set; }
        public int Over25CardsForHome { get; set; }
        public int Over35CardsForHome { get; set; }
        public int Over45CardsForHome { get; set; }
        public int Over55CardsForHome { get; set; }
        public int Over65CardsForHome { get; set; }
        public int Over05CardsForPercentageHome { get; set; }
        public int Over15CardsForPercentageHome { get; set; }
        public int Over25CardsForPercentageHome { get; set; }
        public int Over35CardsForPercentageHome { get; set; }
        public int Over45CardsForPercentageHome { get; set; }
        public int Over55CardsForPercentageHome { get; set; }
        public int Over65CardsForPercentageHome { get; set; }
        public int Over05CardsForAway { get; set; }
        public int Over15CardsForAway { get; set; }
        public int Over25CardsForAway { get; set; }
        public int Over35CardsForAway { get; set; }
        public int Over45CardsForAway { get; set; }
        public int Over55CardsForAway { get; set; }
        public int Over65CardsForAway { get; set; }
        public int Over05CardsForPercentageAway { get; set; }
        public int Over15CardsForPercentageAway { get; set; }
        public int Over25CardsForPercentageAway { get; set; }
        public int Over35CardsForPercentageAway { get; set; }
        public int Over45CardsForPercentageAway { get; set; }
        public int Over55CardsForPercentageAway { get; set; }
        public int Over65CardsForPercentageAway { get; set; }
        public int Over05CardsAgainstOverall { get; set; }
        public int Over15CardsAgainstOverall { get; set; }
        public int Over25CardsAgainstOverall { get; set; }
        public int Over35CardsAgainstOverall { get; set; }
        public int Over45CardsAgainstOverall { get; set; }
        public int Over55CardsAgainstOverall { get; set; }
        public int Over65CardsAgainstOverall { get; set; }
        public int Over05CardsAgainstPercentageOverall { get; set; }
        public int Over15CardsAgainstPercentageOverall { get; set; }
        public int Over25CardsAgainstPercentageOverall { get; set; }
        public int Over35CardsAgainstPercentageOverall { get; set; }
        public int Over45CardsAgainstPercentageOverall { get; set; }
        public int Over55CardsAgainstPercentageOverall { get; set; }
        public int Over65CardsAgainstPercentageOverall { get; set; }
        public int Over05CardsAgainstHome { get; set; }
        public int Over15CardsAgainstHome { get; set; }
        public int Over25CardsAgainstHome { get; set; }
        public int Over35CardsAgainstHome { get; set; }
        public int Over45CardsAgainstHome { get; set; }
        public int Over55CardsAgainstHome { get; set; }
        public int Over65CardsAgainstHome { get; set; }
        public int Over05CardsAgainstPercentageHome { get; set; }
        public int Over15CardsAgainstPercentageHome { get; set; }
        public int Over25CardsAgainstPercentageHome { get; set; }
        public int Over35CardsAgainstPercentageHome { get; set; }
        public int Over45CardsAgainstPercentageHome { get; set; }
        public int Over55CardsAgainstPercentageHome { get; set; }
        public int Over65CardsAgainstPercentageHome { get; set; }
        public int Over05CardsAgainstAway { get; set; }
        public int Over15CardsAgainstAway { get; set; }
        public int Over25CardsAgainstAway { get; set; }
        public int Over35CardsAgainstAway { get; set; }
        public int Over45CardsAgainstAway { get; set; }
        public int Over55CardsAgainstAway { get; set; }
        public int Over65CardsAgainstAway { get; set; }
        public int Over05CardsAgainstPercentageAway { get; set; }
        public int Over15CardsAgainstPercentageAway { get; set; }
        public int Over25CardsAgainstPercentageAway { get; set; }
        public int Over35CardsAgainstPercentageAway { get; set; }
        public int Over45CardsAgainstPercentageAway { get; set; }
        public int Over55CardsAgainstPercentageAway { get; set; }
        public int Over65CardsAgainstPercentageAway { get; set; }
        public int FirstGoalScoredPercentageOverall { get; set; }
        public int FirstGoalScoredPercentageHome { get; set; }
        public int FirstGoalScoredPercentageAway { get; set; }
        public double ShotsPerMatchOverall { get; set; }
        public double ShotsPerMatchHome { get; set; }
        public double ShotsPerMatchAway { get; set; }
        public double ShotsOnTargetPerMatchOverall { get; set; }
        public double ShotsOnTargetPerMatchHome { get; set; }
        public double ShotsOnTargetPerMatchAway { get; set; }
        public double ShotsOffTargetPerMatchOverall { get; set; }
        public double ShotsOffTargetPerMatchHome { get; set; }
        public double ShotsOffTargetPerMatchAway { get; set; }
        public int FoulsByThisTeamOverall { get; set; }
        public int FoulsByThisTeamHome { get; set; }
        public int FoulsByThisTeamAway { get; set; }
        public double FoulsPerMatchOverall { get; set; }
        public double FoulsPerMatchHome { get; set; }
        public double FoulsPerMatchAway { get; set; }
        public int OffsidesTotalOverall { get; set; }
        public int OffsidesTotalHome { get; set; }
        public int OffsidesTotalAway { get; set; }
        public int OffsidesThisTeamOverall { get; set; }
        public int OffsidesThisTeamHome { get; set; }
        public int OffsidesThisTeamAway { get; set; }
        public int OffsidesRecordedMatchesOverall { get; set; }
        public int OffsidesRecordedMatchesHome { get; set; }
        public int OffsidesRecordedMatchesAway { get; set; }
        public double OffsidesTotalPerMatchOverall { get; set; }
        public double OffsidesTotalPerMatchHome { get; set; }
        public double OffsidesTotalPerMatchAway { get; set; }
        public double OffsidesThisTeamPerMatchOverall { get; set; }
        public double OffsidesThisTeamPerMatchHome { get; set; }
        public double OffsidesThisTeamPerMatchAway { get; set; }
        public int OffsidesTotalOver05Overall { get; set; }
        public int OffsidesTotalOver15Overall { get; set; }
        public int OffsidesTotalOver25Overall { get; set; }
        public int OffsidesTotalOver35Overall { get; set; }
        public int OffsidesTotalOver45Overall { get; set; }
        public int ScoredBothHalvesOverall { get; set; }
        public int ScoredBothHalvesHome { get; set; }
        public int ScoredBothHalvesAway { get; set; }
        public int ScoredBothHalvesPercentageOverall { get; set; }
        public int ScoredBothHalvesPercentageHome { get; set; }
        public int ScoredBothHalvesPercentageAway { get; set; }
        public int BTTSBothHalvesOverall { get; set; }
        public int BTTSBothHalvesHome { get; set; }
        public int BTTSBothHalvesAway { get; set; }
        public int BTTSAndWinOverall { get; set; }
        public int BTTSAndWinHome { get; set; }
        public int BTTSAndWinAway { get; set; }
        public int BTTSAndWinPercentageOverall { get; set; }
        public int BTTSAndWinPercentageHome { get; set; }
        public int BTTSAndWinPercentageAway { get; set; }
        public int BTTSAndDrawOverall { get; set; }
        public int BTTSAndDrawHome { get; set; }
        public int BTTSAndDrawAway { get; set; }
        public int BTTSAndDrawPercentageOverall { get; set; }
        public int BTTSAndDrawPercentageHome { get; set; }
        public int BTTSAndDrawPercentageAway { get; set; }
        public int BTTSAndLoseOverall { get; set; }
        public int BTTSAndLoseHome { get; set; }
        public int BTTSAndLoseAway { get; set; }
        public int BTTSAndLosePercentageOverall { get; set; }
        public int BTTSAndLosePercentageHome { get; set; }
        public int BTTSAndLosePercentageAway { get; set; }
        public int MatchesGoalTimingsRecordedOverall { get; set; }
        public int MatchesGoalTimingsRecordedHome { get; set; }
        public int MatchesGoalTimingsRecordedAway { get; set; }
        public int TotalGoals2hOverall { get; set; }
        public int TotalGoals2hHome { get; set; }
        public int TotalGoals2hAway { get; set; }
        public double AverageTotalGoals2hPerMatchOverall { get; set; }
        public double AverageTotalGoals2hPerMatchHome { get; set; }
        public double AverageTotalGoals2hPerMatchAway { get; set; }
        public int GoalsScored2hOverall { get; set; }
        public int GoalsScored2hHome { get; set; }
        public int GoalsScored2hAway { get; set; }
        public double GoalsScored2hPerMatchOverall { get; set; }
        public double GoalsScored2hPerMatchHome { get; set; }
        public double GoalsScored2hPerMatchAway { get; set; }
        public int GoalsConceded2hOverall { get; set; }
        public int GoalsConceded2hHome { get; set; }
        public int GoalsConceded2hAway { get; set; }
        public double GoalsConceded2hPerMatchOverall { get; set; }
        public double GoalsConceded2hPerMatchHome { get; set; }
        public double GoalsConceded2hPerMatchAway { get; set; }
        public int Over052hgMatchesOverall { get; set; }
        public int Over152hgMatchesOverall { get; set; }
        public int Over252hgMatchesOverall { get; set; }
        public int Over052hgPercentageOverall { get; set; }
        public int Over152hgPercentageOverall { get; set; }
        public int Over252hgPercentageOverall { get; set; }
        public int Points2hOverall { get; set; }
        public int Points2hHome { get; set; }
        public int Points2hAway { get; set; }
        public double Ppg2hOverall { get; set; }
        public double Ppg2hHome { get; set; }
        public double Ppg2hAway { get; set; }
        public int Wins2hOverall { get; set; }
        public int Wins2hHome { get; set; }
        public int Wins2hAway { get; set; }
        public int Wins2hPercentageOverall { get; set; }
        public int Wins2hPercentageHome { get; set; }
        public int Wins2hPercentageAway { get; set; }
        public int Draws2hOverall { get; set; }
        public int Draws2hHome { get; set; }
        public int Draws2hAway { get; set; }
        public int Losses2hOverall { get; set; }
        public int Losses2hHome { get; set; }
        public int Losses2hAway { get; set; }
        public int Btts2hOverall { get; set; }
        public int Btts2hHome { get; set; }
        public int Btts2hAway { get; set; }
        public int Btts2hPercentageOverall { get; set; }
        public int Btts2hPercentageHome { get; set; }
        public int Btts2hPercentageAway { get; set; }
        public int CleanSheets2hOverall { get; set; }
        public int CleanSheets2hHome { get; set; }
        public int CleanSheets2hAway { get; set; }
        public int FailedToScore2hOverall { get; set; }
        public int FailedToScore2hHome { get; set; }
        public int FailedToScore2hAway { get; set; }
    }

    public class Teams2ClassMap : ClassMap<Teams2>
    {
        public Teams2ClassMap()
        {
            Map(m => m.TeamName).Name("team_name");
            Map(m => m.CommonName).Name("common_name");
            Map(m => m.Season).Name("season");
            Map(m => m.Country).Name("country");
            Map(m => m.AverageAttendanceOverall).Name("average_attendance_overall");
            Map(m => m.AverageAttendanceHome).Name("average_attendance_home");
            Map(m => m.AverageAttendanceAway).Name("average_attendance_away");
            Map(m => m.MinutesPerGoalScoredOverall).Name("minutes_per_goal_scored_overall");
            Map(m => m.MinutesPerGoalScoredHome).Name("minutes_per_goal_scored_home");
            Map(m => m.MinutesPerGoalScoredAway).Name("minutes_per_goal_scored_away");
            Map(m => m.MinutesPerGoalConcededOverall).Name("minutes_per_goal_conceded_overall");
            Map(m => m.MinutesPerGoalConcededHome).Name("minutes_per_goal_conceded_home");
            Map(m => m.MinutesPerGoalConcededAway).Name("minutes_per_goal_conceded_away");
            Map(m => m.HighestGoalsScoredHome).Name("highest_goals_scored_home");
            Map(m => m.HighestGoalsScoredAway).Name("highest_goals_scored_away");
            Map(m => m.HighestGoalsConcededHome).Name("highest_goals_conceded_home");
            Map(m => m.HighestGoalsConcededAway).Name("highest_goals_conceded_away");
            Map(m => m.HalfTimePointsOverall).Name("half_time_points_overall");
            Map(m => m.HalfTimePointsHome).Name("half_time_points_home");
            Map(m => m.HalfTimePointsAway).Name("half_time_points_away");
            Map(m => m.CornersRecordedMatchesNumOverall).Name("corners_recorded_matches_num_overall");
            Map(m => m.CornersRecordedMatchesNumHome).Name("corners_recorded_matches_num_home");
            Map(m => m.CornersRecordedMatchesAway).Name("cornersRecorded_matches_away");
            Map(m => m.CornersTotalPerMatchOverall).Name("corners_total_per_match_overall");
            Map(m => m.CornersTotalPerMatchHome).Name("corners_total_per_match_home");
            Map(m => m.CornersTotalPerMatchAway).Name("corners_total_per_match_away");
            Map(m => m.CornersAgainstOverall).Name("corners_against_overall");
            Map(m => m.CornersAgainstHome).Name("corners_against_home");
            Map(m => m.CornersAgainstAway).Name("corners_against_away");
            Map(m => m.CornersAgainstPerMatchOverall).Name("corners_against_per_match_overall");
            Map(m => m.CornersAgainstPerMatchHome).Name("corners_against_per_match_home");
            Map(m => m.CornersAgainstPerMatchAway).Name("corners_against_per_match_away");
            Map(m => m.Over65CornersNumOverall).Name("over65_corners_num_overall");
            Map(m => m.Over75CornersNumOverall).Name("over75_corners_num_overall");
            Map(m => m.Over85CornersNumOverall).Name("over85_corners_num_overall");
            Map(m => m.Over95CornersNumOverall).Name("over95_corners_num_overall");
            Map(m => m.Over105CornersNumOverall).Name("over105_corners_num_overall");
            Map(m => m.Over115CornersNumOverall).Name("over115_corners_num_overall");
            Map(m => m.Over125CornersNumOverall).Name("over125_corners_num_overall");
            Map(m => m.Over135CornersNumOverall).Name("over135_corners_num_overall");
            Map(m => m.Over145CornersNumOverall).Name("over145_corners_num_overall");
            Map(m => m.Over65CornersNumHome).Name("over65_corners_num_home");
            Map(m => m.Over75CornersNumHome).Name("over75_corners_num_home");
            Map(m => m.Over85CornersNumHome).Name("over85_corners_num_home");
            Map(m => m.Over95CornersNumHome).Name("over95_corners_num_home");
            Map(m => m.Over105CornersNumHome).Name("over105_corners_num_home");
            Map(m => m.Over115CornersNumHome).Name("over115_corners_num_home");
            Map(m => m.Over125CornersNumHome).Name("over125_corners_num_home");
            Map(m => m.Over135CornersNumHome).Name("over135_corners_num_home");
            Map(m => m.Over145CornersNumHome).Name("over145_corners_num_home");
            Map(m => m.Over65CornersPercentageHome).Name("over65_corners_percentage_home");
            Map(m => m.Over75CornersPercentageHome).Name("over75_corners_percentage_home");
            Map(m => m.Over85CornersPercentageHome).Name("over85_corners_percentage_home");
            Map(m => m.Over95CornersPercentageHome).Name("over95_corners_percentage_home");
            Map(m => m.Over105CornersPercentageHome).Name("over105_corners_percentage_home");
            Map(m => m.Over115CornersPercentageHome).Name("over115_corners_percentage_home");
            Map(m => m.Over125CornersPercentageHome).Name("over125_corners_percentage_home");
            Map(m => m.Over135CornersPercentageHome).Name("over135_corners_percentage_home");
            Map(m => m.Over145CornersPercentageHome).Name("over145_corners_percentage_home");
            Map(m => m.Over65CornersNumAway).Name("over65_corners_num_away");
            Map(m => m.Over75CornersNumAway).Name("over75_corners_num_away");
            Map(m => m.Over85CornersNumAway).Name("over85_corners_num_away");
            Map(m => m.Over95CornersNumAway).Name("over95_corners_num_away");
            Map(m => m.Over105CornersNumAway).Name("over105_corners_num_away");
            Map(m => m.Over115CornersNumAway).Name("over115_corners_num_away");
            Map(m => m.Over125CornersNumAway).Name("over125_corners_num_away");
            Map(m => m.Over135CornersNumAway).Name("over135_corners_num_away");
            Map(m => m.Over145CornersNumAway).Name("over145_corners_num_away");
            Map(m => m.Over65CornersPercentageAway).Name("over65_corners_percentage_away");
            Map(m => m.Over75CornersPercentageAway).Name("over75_corners_percentage_away");
            Map(m => m.Over85CornersPercentageAway).Name("over85_corners_percentage_away");
            Map(m => m.Over95CornersPercentageAway).Name("over95_corners_percentage_away");
            Map(m => m.Over105CornersPercentageAway).Name("over105_corners_percentage_away");
            Map(m => m.Over115CornersPercentageAway).Name("over115_corners_percentage_away");
            Map(m => m.Over125CornersPercentageAway).Name("over125_corners_percentage_away");
            Map(m => m.Over135CornersPercentageAway).Name("over135_corners_percentage_away");
            Map(m => m.Over145CornersPercentageAway).Name("over145_corners_percentage_away");
            Map(m => m.Over25CornersForOverall).Name("over25_corners_for_overall");
            Map(m => m.Over35CornersForOverall).Name("over35_corners_for_overall");
            Map(m => m.Over45CornersForOverall).Name("over45_corners_for_overall");
            Map(m => m.Over55CornersForOverall).Name("over55_corners_for_overall");
            Map(m => m.Over65CornersForOverall).Name("over65_corners_for_overall");
            Map(m => m.Over75CornersForOverall).Name("over75_corners_for_overall");
            Map(m => m.Over85CornersForOverall).Name("over85_corners_for_overall");
            Map(m => m.Over25CornersForPercentageOverall).Name("over25_corners_for_percentage_overall");
            Map(m => m.Over35CornersForPercentageOverall).Name("over35_corners_for_percentage_overall");
            Map(m => m.Over45CornersForPercentageOverall).Name("over45_corners_for_percentage_overall");
            Map(m => m.Over55CornersForPercentageOverall).Name("over55_corners_for_percentage_overall");
            Map(m => m.Over65CornersForPercentageOverall).Name("over65_corners_for_percentage_overall");
            Map(m => m.Over75CornersForPercentageOverall).Name("over75_corners_for_percentage_overall");
            Map(m => m.Over85CornersForPercentageOverall).Name("over85_corners_for_percentage_overall");
            Map(m => m.Over25CornersForHome).Name("over25_corners_for_home");
            Map(m => m.Over35CornersForHome).Name("over35_corners_for_home");
            Map(m => m.Over45CornersForHome).Name("over45_corners_for_home");
            Map(m => m.Over55CornersForHome).Name("over55_corners_for_home");
            Map(m => m.Over65CornersForHome).Name("over65_corners_for_home");
            Map(m => m.Over75CornersForHome).Name("over75_corners_for_home");
            Map(m => m.Over85CornersForHome).Name("over85_corners_for_home");
            Map(m => m.Over25CornersForPercentageHome).Name("over25_corners_for_percentage_home");
            Map(m => m.Over35CornersForPercentageHome).Name("over35_corners_for_percentage_home");
            Map(m => m.Over45CornersForPercentageHome).Name("over45_corners_for_percentage_home");
            Map(m => m.Over55CornersForPercentageHome).Name("over55_corners_for_percentage_home");
            Map(m => m.Over65CornersForPercentageHome).Name("over65_corners_for_percentage_home");
            Map(m => m.Over75CornersForPercentageHome).Name("over75_corners_for_percentage_home");
            Map(m => m.Over85CornersForPercentageHome).Name("over85_corners_for_percentage_home");
            Map(m => m.Over25CornersForAway).Name("over25_corners_for_away");
            Map(m => m.Over35CornersForAway).Name("over35_corners_for_away");
            Map(m => m.Over45CornersForAway).Name("over45_corners_for_away");
            Map(m => m.Over55CornersForAway).Name("over55_corners_for_away");
            Map(m => m.Over65CornersForAway).Name("over65_corners_for_away");
            Map(m => m.Over75CornersForAway).Name("over75_corners_for_away");
            Map(m => m.Over85CornersForAway).Name("over85_corners_for_away");
            Map(m => m.Over25CornersForPercentageAway).Name("over25_corners_for_percentage_away");
            Map(m => m.Over35CornersForPercentageAway).Name("over35_corners_for_percentage_away");
            Map(m => m.Over45CornersForPercentageAway).Name("over45_corners_for_percentage_away");
            Map(m => m.Over55CornersForPercentageAway).Name("over55_corners_for_percentage_away");
            Map(m => m.Over65CornersForPercentageAway).Name("over65_corners_for_percentage_away");
            Map(m => m.Over75CornersForPercentageAway).Name("over75_corners_for_percentage_away");
            Map(m => m.Over85CornersForPercentageAway).Name("over85_corners_for_percentage_away");
            Map(m => m.Over25CornersAgainstOverall).Name("over25_corners_against_overall");
            Map(m => m.Over35CornersAgainstOverall).Name("over35_corners_against_overall");
            Map(m => m.Over45CornersAgainstOverall).Name("over45_corners_against_overall");
            Map(m => m.Over55CornersAgainstOverall).Name("over55_corners_against_overall");
            Map(m => m.Over65CornersAgainstOverall).Name("over65_corners_against_overall");
            Map(m => m.Over75CornersAgainstOverall).Name("over75_corners_against_overall");
            Map(m => m.Over85CornersAgainstOverall).Name("over85_corners_against_overall");
            Map(m => m.Over25CornersAgainstPercentageOverall).Name("over25_corners_against_percentage_overall");
            Map(m => m.Over35CornersAgainstPercentageOverall).Name("over35_corners_against_percentage_overall");
            Map(m => m.Over45CornersAgainstPercentageOverall).Name("over45_corners_against_percentage_overall");
            Map(m => m.Over55CornersAgainstPercentageOverall).Name("over55_corners_against_percentage_overall");
            Map(m => m.Over65CornersAgainstPercentageOverall).Name("over65_corners_against_percentage_overall");
            Map(m => m.Over75CornersAgainstPercentageOverall).Name("over75_corners_against_percentage_overall");
            Map(m => m.Over85CornersAgainstPercentageOverall).Name("over85_corners_against_percentage_overall");
            Map(m => m.Over25CornersAgainstHome).Name("over25_corners_against_home");
            Map(m => m.Over35CornersAgainstHome).Name("over35_corners_against_home");
            Map(m => m.Over45CornersAgainstHome).Name("over45_corners_against_home");
            Map(m => m.Over55CornersAgainstHome).Name("over55_corners_against_home");
            Map(m => m.Over65CornersAgainstHome).Name("over65_corners_against_home");
            Map(m => m.Over75CornersAgainstHome).Name("over75_corners_against_home");
            Map(m => m.Over85CornersAgainstHome).Name("over85_corners_against_home");
            Map(m => m.Over25CornersAgainstPercentageHome).Name("over25_corners_against_percentage_home");
            Map(m => m.Over35CornersAgainstPercentageHome).Name("over35_corners_against_percentage_home");
            Map(m => m.Over45CornersAgainstPercentageHome).Name("over45_corners_against_percentage_home");
            Map(m => m.Over55CornersAgainstPercentageHome).Name("over55_corners_against_percentage_home");
            Map(m => m.Over65CornersAgainstPercentageHome).Name("over65_corners_against_percentage_home");
            Map(m => m.Over75CornersAgainstPercentageHome).Name("over75_corners_against_percentage_home");
            Map(m => m.Over85CornersAgainstPercentageHome).Name("over85_corners_against_percentage_home");
            Map(m => m.Over25CornersAgainstAway).Name("over25_corners_against_away");
            Map(m => m.Over35CornersAgainstAway).Name("over35_corners_against_away");
            Map(m => m.Over45CornersAgainstAway).Name("over45_corners_against_away");
            Map(m => m.Over55CornersAgainstAway).Name("over55_corners_against_away");
            Map(m => m.Over65CornersAgainstAway).Name("over65_corners_against_away");
            Map(m => m.Over75CornersAgainstAway).Name("over75_corners_against_away");
            Map(m => m.Over85CornersAgainstAway).Name("over85_corners_against_away");
            Map(m => m.Over25CornersAgainstPercentageAway).Name("over25_corners_against_percentage_away");
            Map(m => m.Over35CornersAgainstPercentageAway).Name("over35_corners_against_percentage_away");
            Map(m => m.Over45CornersAgainstPercentageAway).Name("over45_corners_against_percentage_away");
            Map(m => m.Over55CornersAgainstPercentageAway).Name("over55_corners_against_percentage_away");
            Map(m => m.Over65CornersAgainstPercentageAway).Name("over65_corners_against_percentage_away");
            Map(m => m.Over75CornersAgainstPercentageAway).Name("over75_corners_against_percentage_away");
            Map(m => m.Over85CornersAgainstPercentageAway).Name("over85_corners_against_percentage_away");
            Map(m => m.CornerTimingRecordedMatchesOverall).Name("cornerTimingRecorded_matches_overall");
            Map(m => m.CornerTimingRecordedMatchesHome).Name("cornerTimingRecorded_matches_home");
            Map(m => m.CornerTimingRecordedMatchesAway).Name("cornerTimingRecorded_matches_away");
            Map(m => m.CornersTotalFhOverall).Name("corners_total_fh_overall");
            Map(m => m.CornersTotalFhHome).Name("corners_total_fh_home");
            Map(m => m.CornersTotalFhAway).Name("corners_total_fh_away");
            Map(m => m.CornersTotal2hOverall).Name("corners_total_2h_overall");
            Map(m => m.CornersTotal2hHome).Name("corners_total_2h_home");
            Map(m => m.CornersTotal2hAway).Name("corners_total_2h_away");
            Map(m => m.CornersTotalPerMatchFhOverall).Name("corners_total_per_match_fh_overall");
            Map(m => m.CornersTotalPerMatchFhHome).Name("corners_total_per_match_fh_home");
            Map(m => m.CornersTotalPerMatchFhAway).Name("corners_total_per_match_fh_away");
            Map(m => m.CornersTotalPerMatch2hOverall).Name("corners_total_per_match_2h_overall");
            Map(m => m.CornersTotalPerMatch2hHome).Name("corners_total_per_match_2h_home");
            Map(m => m.CornersTotalPerMatch2hAway).Name("corners_total_per_match_2h_away");
            Map(m => m.CornersTotalFhOver4Overall).Name("corners_total_fh_over4_overall");
            Map(m => m.CornersTotalFhOver5Overall).Name("corners_total_fh_over5_overall");
            Map(m => m.CornersTotalFhOver6Overall).Name("corners_total_fh_over6_overall");
            Map(m => m.CornersTotal2hOver4Overall).Name("corners_total_2h_over4_overall");
            Map(m => m.CornersTotal2hOver5Overall).Name("corners_total_2h_over5_overall");
            Map(m => m.CornersTotal2hOver6Overall).Name("corners_total_2h_over6_overall");
            Map(m => m.Over05CardsTotalOverall).Name("over05_cards_total_overall");
            Map(m => m.Over15CardsTotalOverall).Name("over15_cards_total_overall");
            Map(m => m.Over25CardsTotalOverall).Name("over25_cards_total_overall");
            Map(m => m.Over35CardsTotalOverall).Name("over35_cards_total_overall");
            Map(m => m.Over45CardsTotalOverall).Name("over45_cards_total_overall");
            Map(m => m.Over55CardsTotalOverall).Name("over55_cards_total_overall");
            Map(m => m.Over65CardsTotalOverall).Name("over65_cards_total_overall");
            Map(m => m.Over75CardsTotalOverall).Name("over75_cards_total_overall");
            Map(m => m.Over85CardsTotalOverall).Name("over85_cards_total_overall");
            Map(m => m.Over05CardsTotalPercentageOverall).Name("over05_cards_total_percentage_overall");
            Map(m => m.Over15CardsTotalPercentageOverall).Name("over15_cards_total_percentage_overall");
            Map(m => m.Over25CardsTotalPercentageOverall).Name("over25_cards_total_percentage_overall");
            Map(m => m.Over35CardsTotalPercentageOverall).Name("over35_cards_total_percentage_overall");
            Map(m => m.Over45CardsTotalPercentageOverall).Name("over45_cards_total_percentage_overall");
            Map(m => m.Over55CardsTotalPercentageOverall).Name("over55_cards_total_percentage_overall");
            Map(m => m.Over65CardsTotalPercentageOverall).Name("over65_cards_total_percentage_overall");
            Map(m => m.Over75CardsTotalPercentageOverall).Name("over75_cards_total_percentage_overall");
            Map(m => m.Over85CardsTotalPercentageOverall).Name("over85_cards_total_percentage_overall");
            Map(m => m.Over05CardsTotalHome).Name("over05_cards_total_home");
            Map(m => m.Over15CardsTotalHome).Name("over15_cards_total_home");
            Map(m => m.Over25CardsTotalHome).Name("over25_cards_total_home");
            Map(m => m.Over35CardsTotalHome).Name("over35_cards_total_home");
            Map(m => m.Over45CardsTotalHome).Name("over45_cards_total_home");
            Map(m => m.Over55CardsTotalHome).Name("over55_cards_total_home");
            Map(m => m.Over65CardsTotalHome).Name("over65_cards_total_home");
            Map(m => m.Over75CardsTotalHome).Name("over75_cards_total_home");
            Map(m => m.Over85CardsTotalHome).Name("over85_cards_total_home");
            Map(m => m.Over05CardsTotalPercentageHome).Name("over05_cards_total_percentage_home");
            Map(m => m.Over15CardsTotalPercentageHome).Name("over15_cards_total_percentage_home");
            Map(m => m.Over25CardsTotalPercentageHome).Name("over25_cards_total_percentage_home");
            Map(m => m.Over35CardsTotalPercentageHome).Name("over35_cards_total_percentage_home");
            Map(m => m.Over45CardsTotalPercentageHome).Name("over45_cards_total_percentage_home");
            Map(m => m.Over55CardsTotalPercentageHome).Name("over55_cards_total_percentage_home");
            Map(m => m.Over65CardsTotalPercentageHome).Name("over65_cards_total_percentage_home");
            Map(m => m.Over75CardsTotalPercentageHome).Name("over75_cards_total_percentage_home");
            Map(m => m.Over85CardsTotalPercentageHome).Name("over85_cards_total_percentage_home");
            Map(m => m.Over05CardsTotalAway).Name("over05_cards_total_away");
            Map(m => m.Over15CardsTotalAway).Name("over15_cards_total_away");
            Map(m => m.Over25CardsTotalAway).Name("over25_cards_total_away");
            Map(m => m.Over35CardsTotalAway).Name("over35_cards_total_away");
            Map(m => m.Over45CardsTotalAway).Name("over45_cards_total_away");
            Map(m => m.Over55CardsTotalAway).Name("over55_cards_total_away");
            Map(m => m.Over65CardsTotalAway).Name("over65_cards_total_away");
            Map(m => m.Over75CardsTotalAway).Name("over75_cards_total_away");
            Map(m => m.Over85CardsTotalAway).Name("over85_cards_total_away");
            Map(m => m.Over05CardsTotalPercentageAway).Name("over05_cards_total_percentage_away");
            Map(m => m.Over15CardsTotalPercentageAway).Name("over15_cards_total_percentage_away");
            Map(m => m.Over25CardsTotalPercentageAway).Name("over25_cards_total_percentage_away");
            Map(m => m.Over35CardsTotalPercentageAway).Name("over35_cards_total_percentage_away");
            Map(m => m.Over45CardsTotalPercentageAway).Name("over45_cards_total_percentage_away");
            Map(m => m.Over55CardsTotalPercentageAway).Name("over55_cards_total_percentage_away");
            Map(m => m.Over65CardsTotalPercentageAway).Name("over65_cards_total_percentage_away");
            Map(m => m.Over75CardsTotalPercentageAway).Name("over75_cards_total_percentage_away");
            Map(m => m.Over85CardsTotalPercentageAway).Name("over85_cards_total_percentage_away");
            Map(m => m.Over05CardsForOverall).Name("over05_cards_for_overall");
            Map(m => m.Over15CardsForOverall).Name("over15_cards_for_overall");
            Map(m => m.Over25CardsForOverall).Name("over25_cards_for_overall");
            Map(m => m.Over35CardsForOverall).Name("over35_cards_for_overall");
            Map(m => m.Over45CardsForOverall).Name("over45_cards_for_overall");
            Map(m => m.Over55CardsForOverall).Name("over55_cards_for_overall");
            Map(m => m.Over65CardsForOverall).Name("over65_cards_for_overall");
            Map(m => m.Over05CardsForPercentageOverall).Name("over05_cards_for_percentage_overall");
            Map(m => m.Over15CardsForPercentageOverall).Name("over15_cards_for_percentage_overall");
            Map(m => m.Over25CardsForPercentageOverall).Name("over25_cards_for_percentage_overall");
            Map(m => m.Over35CardsForPercentageOverall).Name("over35_cards_for_percentage_overall");
            Map(m => m.Over45CardsForPercentageOverall).Name("over45_cards_for_percentage_overall");
            Map(m => m.Over55CardsForPercentageOverall).Name("over55_cards_for_percentage_overall");
            Map(m => m.Over65CardsForPercentageOverall).Name("over65_cards_for_percentage_overall");
            Map(m => m.Over05CardsForHome).Name("over05_cards_for_home");
            Map(m => m.Over15CardsForHome).Name("over15_cards_for_home");
            Map(m => m.Over25CardsForHome).Name("over25_cards_for_home");
            Map(m => m.Over35CardsForHome).Name("over35_cards_for_home");
            Map(m => m.Over45CardsForHome).Name("over45_cards_for_home");
            Map(m => m.Over55CardsForHome).Name("over55_cards_for_home");
            Map(m => m.Over65CardsForHome).Name("over65_cards_for_home");
            Map(m => m.Over05CardsForPercentageHome).Name("over05_cards_for_percentage_home");
            Map(m => m.Over15CardsForPercentageHome).Name("over15_cards_for_percentage_home");
            Map(m => m.Over25CardsForPercentageHome).Name("over25_cards_for_percentage_home");
            Map(m => m.Over35CardsForPercentageHome).Name("over35_cards_for_percentage_home");
            Map(m => m.Over45CardsForPercentageHome).Name("over45_cards_for_percentage_home");
            Map(m => m.Over55CardsForPercentageHome).Name("over55_cards_for_percentage_home");
            Map(m => m.Over65CardsForPercentageHome).Name("over65_cards_for_percentage_home");
            Map(m => m.Over05CardsForAway).Name("over05_cards_for_away");
            Map(m => m.Over15CardsForAway).Name("over15_cards_for_away");
            Map(m => m.Over25CardsForAway).Name("over25_cards_for_away");
            Map(m => m.Over35CardsForAway).Name("over35_cards_for_away");
            Map(m => m.Over45CardsForAway).Name("over45_cards_for_away");
            Map(m => m.Over55CardsForAway).Name("over55_cards_for_away");
            Map(m => m.Over65CardsForAway).Name("over65_cards_for_away");
            Map(m => m.Over05CardsForPercentageAway).Name("over05_cards_for_percentage_away");
            Map(m => m.Over15CardsForPercentageAway).Name("over15_cards_for_percentage_away");
            Map(m => m.Over25CardsForPercentageAway).Name("over25_cards_for_percentage_away");
            Map(m => m.Over35CardsForPercentageAway).Name("over35_cards_for_percentage_away");
            Map(m => m.Over45CardsForPercentageAway).Name("over45_cards_for_percentage_away");
            Map(m => m.Over55CardsForPercentageAway).Name("over55_cards_for_percentage_away");
            Map(m => m.Over65CardsForPercentageAway).Name("over65_cards_for_percentage_away");
            Map(m => m.Over05CardsAgainstOverall).Name("over05_cards_against_overall");
            Map(m => m.Over15CardsAgainstOverall).Name("over15_cards_against_overall");
            Map(m => m.Over25CardsAgainstOverall).Name("over25_cards_against_overall");
            Map(m => m.Over35CardsAgainstOverall).Name("over35_cards_against_overall");
            Map(m => m.Over45CardsAgainstOverall).Name("over45_cards_against_overall");
            Map(m => m.Over55CardsAgainstOverall).Name("over55_cards_against_overall");
            Map(m => m.Over65CardsAgainstOverall).Name("over65_cards_against_overall");
            Map(m => m.Over05CardsAgainstPercentageOverall).Name("over05_cards_against_percentage_overall");
            Map(m => m.Over15CardsAgainstPercentageOverall).Name("over15_cards_against_percentage_overall");
            Map(m => m.Over25CardsAgainstPercentageOverall).Name("over25_cards_against_percentage_overall");
            Map(m => m.Over35CardsAgainstPercentageOverall).Name("over35_cards_against_percentage_overall");
            Map(m => m.Over45CardsAgainstPercentageOverall).Name("over45_cards_against_percentage_overall");
            Map(m => m.Over55CardsAgainstPercentageOverall).Name("over55_cards_against_percentage_overall");
            Map(m => m.Over65CardsAgainstPercentageOverall).Name("over65_cards_against_percentage_overall");
            Map(m => m.Over05CardsAgainstHome).Name("over05_cards_against_home");
            Map(m => m.Over15CardsAgainstHome).Name("over15_cards_against_home");
            Map(m => m.Over25CardsAgainstHome).Name("over25_cards_against_home");
            Map(m => m.Over35CardsAgainstHome).Name("over35_cards_against_home");
            Map(m => m.Over45CardsAgainstHome).Name("over45_cards_against_home");
            Map(m => m.Over55CardsAgainstHome).Name("over55_cards_against_home");
            Map(m => m.Over65CardsAgainstHome).Name("over65_cards_against_home");
            Map(m => m.Over05CardsAgainstPercentageHome).Name("over05_cards_against_percentage_home");
            Map(m => m.Over15CardsAgainstPercentageHome).Name("over15_cards_against_percentage_home");
            Map(m => m.Over25CardsAgainstPercentageHome).Name("over25_cards_against_percentage_home");
            Map(m => m.Over35CardsAgainstPercentageHome).Name("over35_cards_against_percentage_home");
            Map(m => m.Over45CardsAgainstPercentageHome).Name("over45_cards_against_percentage_home");
            Map(m => m.Over55CardsAgainstPercentageHome).Name("over55_cards_against_percentage_home");
            Map(m => m.Over65CardsAgainstPercentageHome).Name("over65_cards_against_percentage_home");
            Map(m => m.Over05CardsAgainstAway).Name("over05_cards_against_away");
            Map(m => m.Over15CardsAgainstAway).Name("over15_cards_against_away");
            Map(m => m.Over25CardsAgainstAway).Name("over25_cards_against_away");
            Map(m => m.Over35CardsAgainstAway).Name("over35_cards_against_away");
            Map(m => m.Over45CardsAgainstAway).Name("over45_cards_against_away");
            Map(m => m.Over55CardsAgainstAway).Name("over55_cards_against_away");
            Map(m => m.Over65CardsAgainstAway).Name("over65_cards_against_away");
            Map(m => m.Over05CardsAgainstPercentageAway).Name("over05_cards_against_percentage_away");
            Map(m => m.Over15CardsAgainstPercentageAway).Name("over15_cards_against_percentage_away");
            Map(m => m.Over25CardsAgainstPercentageAway).Name("over25_cards_against_percentage_away");
            Map(m => m.Over35CardsAgainstPercentageAway).Name("over35_cards_against_percentage_away");
            Map(m => m.Over45CardsAgainstPercentageAway).Name("over45_cards_against_percentage_away");
            Map(m => m.Over55CardsAgainstPercentageAway).Name("over55_cards_against_percentage_away");
            Map(m => m.Over65CardsAgainstPercentageAway).Name("over65_cards_against_percentage_away");
            Map(m => m.FirstGoalScoredPercentageOverall).Name("firstGoalScoredPercentage_overall");
            Map(m => m.FirstGoalScoredPercentageHome).Name("firstGoalScoredPercentage_home");
            Map(m => m.FirstGoalScoredPercentageAway).Name("firstGoalScoredPercentage_away");
            Map(m => m.ShotsPerMatchOverall).Name("shots_per_match_overall");
            Map(m => m.ShotsPerMatchHome).Name("shots_per_match_home");
            Map(m => m.ShotsPerMatchAway).Name("shots_per_match_away");
            Map(m => m.ShotsOnTargetPerMatchOverall).Name("shots_on_target_per_match_overall");
            Map(m => m.ShotsOnTargetPerMatchHome).Name("shots_on_target_per_match_home");
            Map(m => m.ShotsOnTargetPerMatchAway).Name("shots_on_target_per_match_away");
            Map(m => m.ShotsOffTargetPerMatchOverall).Name("shots_off_target_per_match_overall");
            Map(m => m.ShotsOffTargetPerMatchHome).Name("shots_off_target_per_match_home");
            Map(m => m.ShotsOffTargetPerMatchAway).Name("shots_off_target_per_match_away");
            Map(m => m.FoulsByThisTeamOverall).Name("fouls_by_this_team_overall");
            Map(m => m.FoulsByThisTeamHome).Name("fouls_by_this_team_home");
            Map(m => m.FoulsByThisTeamAway).Name("fouls_by_this_team_away");
            Map(m => m.FoulsPerMatchOverall).Name("fouls_per_match_overall");
            Map(m => m.FoulsPerMatchHome).Name("fouls_per_match_home");
            Map(m => m.FoulsPerMatchAway).Name("fouls_per_match_away");
            Map(m => m.OffsidesTotalOverall).Name("offsides_total_overall");
            Map(m => m.OffsidesTotalHome).Name("offsides_total_home");
            Map(m => m.OffsidesTotalAway).Name("offsides_total_away");
            Map(m => m.OffsidesThisTeamOverall).Name("offsides_this_team_overall");
            Map(m => m.OffsidesThisTeamHome).Name("offsides_this_team_home");
            Map(m => m.OffsidesThisTeamAway).Name("offsides_this_team_away");
            Map(m => m.OffsidesRecordedMatchesOverall).Name("offsidesRecorded_matches_overall");
            Map(m => m.OffsidesRecordedMatchesHome).Name("offsidesRecorded_matches_home");
            Map(m => m.OffsidesRecordedMatchesAway).Name("offsidesRecorded_matches_away");
            Map(m => m.OffsidesTotalPerMatchOverall).Name("offsides_total_per_match_overall");
            Map(m => m.OffsidesTotalPerMatchHome).Name("offsides_total_per_match_home");
            Map(m => m.OffsidesTotalPerMatchAway).Name("offsides_total_per_match_away");
            Map(m => m.OffsidesThisTeamPerMatchOverall).Name("offsides_this_team_per_match_overall");
            Map(m => m.OffsidesThisTeamPerMatchHome).Name("offsides_this_team_per_match_home");
            Map(m => m.OffsidesThisTeamPerMatchAway).Name("offsides_this_team_per_match_away");
            Map(m => m.OffsidesTotalOver05Overall).Name("offsides_total_over05_overall");
            Map(m => m.OffsidesTotalOver15Overall).Name("offsides_total_over15_overall");
            Map(m => m.OffsidesTotalOver25Overall).Name("offsides_total_over25_overall");
            Map(m => m.OffsidesTotalOver35Overall).Name("offsides_total_over35_overall");
            Map(m => m.OffsidesTotalOver45Overall).Name("offsides_total_over45_overall");
            Map(m => m.ScoredBothHalvesOverall).Name("scoredBothHalves_overall");
            Map(m => m.ScoredBothHalvesHome).Name("scoredBothHalves_home");
            Map(m => m.ScoredBothHalvesAway).Name("scoredBothHalves_away");
            Map(m => m.ScoredBothHalvesPercentageOverall).Name("scoredBothHalvesPercentage_overall");
            Map(m => m.ScoredBothHalvesPercentageHome).Name("scoredBothHalvesPercentage_home");
            Map(m => m.ScoredBothHalvesPercentageAway).Name("scoredBothHalvesPercentage_away");
            Map(m => m.BTTSBothHalvesOverall).Name("BTTS_both_halves_overall");
            Map(m => m.BTTSBothHalvesHome).Name("BTTS_both_halves_home");
            Map(m => m.BTTSBothHalvesAway).Name("BTTS_both_halves_away");
            Map(m => m.BTTSAndWinOverall).Name("BTTS_and_win_overall");
            Map(m => m.BTTSAndWinHome).Name("BTTS_and_win_home");
            Map(m => m.BTTSAndWinAway).Name("BTTS_and_win_away");
            Map(m => m.BTTSAndWinPercentageOverall).Name("BTTS_and_win_percentage_overall");
            Map(m => m.BTTSAndWinPercentageHome).Name("BTTS_and_win_percentage_home");
            Map(m => m.BTTSAndWinPercentageAway).Name("BTTS_and_win_percentage_away");
            Map(m => m.BTTSAndDrawOverall).Name("BTTS_and_draw_overall");
            Map(m => m.BTTSAndDrawHome).Name("BTTS_and_draw_home");
            Map(m => m.BTTSAndDrawAway).Name("BTTS_and_draw_away");
            Map(m => m.BTTSAndDrawPercentageOverall).Name("BTTS_and_draw_percentage_overall");
            Map(m => m.BTTSAndDrawPercentageHome).Name("BTTS_and_draw_percentage_home");
            Map(m => m.BTTSAndDrawPercentageAway).Name("BTTS_and_draw_percentage_away");
            Map(m => m.BTTSAndLoseOverall).Name("BTTS_and_lose_overall");
            Map(m => m.BTTSAndLoseHome).Name("BTTS_and_lose_home");
            Map(m => m.BTTSAndLoseAway).Name("BTTS_and_lose_away");
            Map(m => m.BTTSAndLosePercentageOverall).Name("BTTS_and_lose_percentage_overall");
            Map(m => m.BTTSAndLosePercentageHome).Name("BTTS_and_lose_percentage_home");
            Map(m => m.BTTSAndLosePercentageAway).Name("BTTS_and_lose_percentage_away");
            Map(m => m.MatchesGoalTimingsRecordedOverall).Name("matches_goal_timings_recorded_overall");
            Map(m => m.MatchesGoalTimingsRecordedHome).Name("matches_goal_timings_recorded_home");
            Map(m => m.MatchesGoalTimingsRecordedAway).Name("matches_goal_timings_recorded_away");
            Map(m => m.TotalGoals2hOverall).Name("total_goals_2h_overall");
            Map(m => m.TotalGoals2hHome).Name("total_goals_2h_home");
            Map(m => m.TotalGoals2hAway).Name("total_goals_2h_away");
            Map(m => m.AverageTotalGoals2hPerMatchOverall).Name("average_total_goals_2h_per_match_overall");
            Map(m => m.AverageTotalGoals2hPerMatchHome).Name("average_total_goals_2h_per_match_home");
            Map(m => m.AverageTotalGoals2hPerMatchAway).Name("average_total_goals_2h_per_match_away");
            Map(m => m.GoalsScored2hOverall).Name("goals_scored_2h_overall");
            Map(m => m.GoalsScored2hHome).Name("goals_scored_2h_home");
            Map(m => m.GoalsScored2hAway).Name("goals_scored_2h_away");
            Map(m => m.GoalsScored2hPerMatchOverall).Name("goals_scored_2h_per_match_overall");
            Map(m => m.GoalsScored2hPerMatchHome).Name("goals_scored_2h_per_match_home");
            Map(m => m.GoalsScored2hPerMatchAway).Name("goals_scored_2h_per_match_away");
            Map(m => m.GoalsConceded2hOverall).Name("goals_conceded_2h_overall");
            Map(m => m.GoalsConceded2hHome).Name("goals_conceded_2h_home");
            Map(m => m.GoalsConceded2hAway).Name("goals_conceded_2h_away");
            Map(m => m.GoalsConceded2hPerMatchOverall).Name("goals_conceded_2h_per_match_overall");
            Map(m => m.GoalsConceded2hPerMatchHome).Name("goals_conceded_2h_per_match_home");
            Map(m => m.GoalsConceded2hPerMatchAway).Name("goals_conceded_2h_per_match_away");
            Map(m => m.Over052hgMatchesOverall).Name("over05_2hg_matches_overall");
            Map(m => m.Over152hgMatchesOverall).Name("over15_2hg_matches_overall");
            Map(m => m.Over252hgMatchesOverall).Name("over25_2hg_matches_overall");
            Map(m => m.Over052hgPercentageOverall).Name("over05_2hg_percentage_overall");
            Map(m => m.Over152hgPercentageOverall).Name("over15_2hg_percentage_overall");
            Map(m => m.Over252hgPercentageOverall).Name("over25_2hg_percentage_overall");
            Map(m => m.Points2hOverall).Name("points_2h_overall");
            Map(m => m.Points2hHome).Name("points_2h_home");
            Map(m => m.Points2hAway).Name("points_2h_away");
            Map(m => m.Ppg2hOverall).Name("ppg_2h_overall");
            Map(m => m.Ppg2hHome).Name("ppg_2h_home");
            Map(m => m.Ppg2hAway).Name("ppg_2h_away");
            Map(m => m.Wins2hOverall).Name("wins_2h_overall");
            Map(m => m.Wins2hHome).Name("wins_2h_home");
            Map(m => m.Wins2hAway).Name("wins_2h_away");
            Map(m => m.Wins2hPercentageOverall).Name("wins_2h_percentage_overall");
            Map(m => m.Wins2hPercentageHome).Name("wins_2h_percentage_home");
            Map(m => m.Wins2hPercentageAway).Name("wins_2h_percentage_away");
            Map(m => m.Draws2hOverall).Name("draws_2h_overall");
            Map(m => m.Draws2hHome).Name("draws_2h_home");
            Map(m => m.Draws2hAway).Name("draws_2h_away");
            Map(m => m.Losses2hOverall).Name("losses_2h_overall");
            Map(m => m.Losses2hHome).Name("losses_2h_home");
            Map(m => m.Losses2hAway).Name("losses_2h_away");
            Map(m => m.Btts2hOverall).Name("btts_2h_overall");
            Map(m => m.Btts2hHome).Name("btts_2h_home");
            Map(m => m.Btts2hAway).Name("btts_2h_away");
            Map(m => m.Btts2hPercentageOverall).Name("btts_2h_percentage_overall");
            Map(m => m.Btts2hPercentageHome).Name("btts_2h_percentage_home");
            Map(m => m.Btts2hPercentageAway).Name("btts_2h_percentage_away");
            Map(m => m.CleanSheets2hOverall).Name("clean_sheets_2h_overall");
            Map(m => m.CleanSheets2hHome).Name("clean_sheets_2h_home");
            Map(m => m.CleanSheets2hAway).Name("clean_sheets_2h_away");
            Map(m => m.FailedToScore2hOverall).Name("failed_to_score_2h_overall");
            Map(m => m.FailedToScore2hHome).Name("failed_to_score_2h_home");
            Map(m => m.FailedToScore2hAway).Name("failed_to_score_2h_away");
        }
    }

}
