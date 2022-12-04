using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBetForYou.FootyStats
{
    public class Teams
    {
        public string TeamName { get; set; }
        public string CommonName { get; set; }
        public string Season { get; set; }
        public string Country { get; set; }
        public int MatchesPlayed { get; set; }
        public int MatchesPlayedHome { get; set; }
        public int MatchesPlayedAway { get; set; }
        public int SuspendedMatches { get; set; }
        public int Wins { get; set; }
        public int WinsHome { get; set; }
        public int WinsAway { get; set; }
        public int Draws { get; set; }
        public int DrawsHome { get; set; }
        public int DrawsAway { get; set; }
        public int Losses { get; set; }
        public int LossesHome { get; set; }
        public int LossesAway { get; set; }
        public double PointsPerGame { get; set; }
        public double PointsPerGameHome { get; set; }
        public double PointsPerGameAway { get; set; }
        public int LeaguePosition { get; set; }
        public int LeaguePositionHome { get; set; }
        public int LeaguePositionAway { get; set; }
        public int PerformanceRank { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsConceded { get; set; }
        public int GoalDifference { get; set; }
        public int TotalGoalCount { get; set; }
        public int TotalGoalCountHome { get; set; }
        public int TotalGoalCountAway { get; set; }
        public int GoalsScoredHome { get; set; }
        public int GoalsScoredAway { get; set; }
        public int GoalsConcededHome { get; set; }
        public int GoalsConcededAway { get; set; }
        public int GoalDifferenceHome { get; set; }
        public int GoalDifferenceAway { get; set; }
        public int MinutesPerGoalScored { get; set; }
        public int MinutesPerGoalScoredHome { get; set; }
        public int MinutesPerGoalScoredAway { get; set; }
        public int MinutesPerGoalConceded { get; set; }
        public int MinutesPerGoalConcededHome { get; set; }
        public int MinutesPerGoalConcededAway { get; set; }
        public int CleanSheets { get; set; }
        public int CleanSheetsHome { get; set; }
        public int CleanSheetsAway { get; set; }
        public int BttsCount { get; set; }
        public int BttsCountHome { get; set; }
        public int BttsCountAway { get; set; }
        public int FtsCount { get; set; }
        public int FtsCountHome { get; set; }
        public int FtsCountAway { get; set; }
        public int FirstTeamToScoreCount { get; set; }
        public int FirstTeamToScoreCountHome { get; set; }
        public int FirstTeamToScoreCountAway { get; set; }
        public int CornersTotal { get; set; }
        public int CornersTotalHome { get; set; }
        public int CornersTotalAway { get; set; }
        public int CardsTotal { get; set; }
        public int CardsTotalHome { get; set; }
        public int CardsTotalAway { get; set; }
        public int AveragePossession { get; set; }
        public int AveragePossessionHome { get; set; }
        public int AveragePossessionAway { get; set; }
        public int Shots { get; set; }
        public int ShotsHome { get; set; }
        public int ShotsAway { get; set; }
        public int ShotsOnTarget { get; set; }
        public int ShotsOnTargetHome { get; set; }
        public int ShotsOnTargetAway { get; set; }
        public int ShotsOffTarget { get; set; }
        public int ShotsOffTargetHome { get; set; }
        public int ShotsOffTargetAway { get; set; }
        public int Fouls { get; set; }
        public int FoulsHome { get; set; }
        public int FoulsAway { get; set; }
        public int GoalsScoredHalfTime { get; set; }
        public int GoalsScoredHalfTimeHome { get; set; }
        public int GoalsScoredHalfTimeAway { get; set; }
        public int GoalsConcededHalfTime { get; set; }
        public int GoalsConcededHalfTimeHome { get; set; }
        public int GoalsConcededHalfTimeAway { get; set; }
        public int GoalDifferenceHalfTime { get; set; }
        public int GoalDifferenceHalfTimeHome { get; set; }
        public int GoalDifferenceHalfTimeAway { get; set; }
        public int LeadingAtHalfTime { get; set; }
        public int LeadingAtHalfTimeHome { get; set; }
        public int LeadingAtHalfTimeAway { get; set; }
        public int DrawAtHalfTime { get; set; }
        public int DrawAtHalfTimeHome { get; set; }
        public int DrawAtHalfTimeAway { get; set; }
        public int LosingAtHalfTime { get; set; }
        public int LosingAtHalfTimeHome { get; set; }
        public int LosingAtHalfTimeAway { get; set; }
        public double PointsPerGameHalfTime { get; set; }
        public double PointsPerGameHalfTimeHome { get; set; }
        public double PointsPerGameHalfTimeAway { get; set; }
        public double AverageTotalGoalsPerMatch { get; set; }
        public double AverageTotalGoalsPerMatchHome { get; set; }
        public double AverageTotalGoalsPerMatchAway { get; set; }
        public double GoalsScoredPerMatch { get; set; }
        public double GoalsScoredPerMatchHome { get; set; }
        public double GoalsScoredPerMatchAway { get; set; }
        public double GoalsConcededPerMatch { get; set; }
        public double GoalsConcededPerMatchHome { get; set; }
        public double GoalsConcededPerMatchAway { get; set; }
        public double TotalGoalsPerMatchHalfTime { get; set; }
        public double TotalGoalsPerMatchHalfTimeHome { get; set; }
        public double TotalGoalsPerMatchHalfTimeAway { get; set; }
        public double GoalsScoredPerMatchHalfTime { get; set; }
        public double GoalsScoredPerMatchHalfTimeHome { get; set; }
        public double GoalsScoredPerMatchHalfTimeAway { get; set; }
        public double GoalsConcededPerMatchHalfTime { get; set; }
        public double GoalsConcededPerMatchHalfTimeHome { get; set; }
        public double GoalsConcededPerMatchHalfTimeAway { get; set; }
        public int Over05Count { get; set; }
        public int Over15Count { get; set; }
        public int Over25Count { get; set; }
        public int Over35Count { get; set; }
        public int Over45Count { get; set; }
        public int Over55Count { get; set; }
        public int Over05CountHome { get; set; }
        public int Over15CountHome { get; set; }
        public int Over25CountHome { get; set; }
        public int Over35CountHome { get; set; }
        public int Over45CountHome { get; set; }
        public int Over55CountHome { get; set; }
        public int Over05CountAway { get; set; }
        public int Over15CountAway { get; set; }
        public int Over25CountAway { get; set; }
        public int Over35CountAway { get; set; }
        public int Over45CountAway { get; set; }
        public int Over55CountAway { get; set; }
        public int Under05Count { get; set; }
        public int Under15Count { get; set; }
        public int Under25Count { get; set; }
        public int Under35Count { get; set; }
        public int Under45Count { get; set; }
        public int Under55Count { get; set; }
        public int Under05CountHome { get; set; }
        public int Under15CountHome { get; set; }
        public int Under25CountHome { get; set; }
        public int Under35CountHome { get; set; }
        public int Under45CountHome { get; set; }
        public int Under55CountHome { get; set; }
        public int Under05CountAway { get; set; }
        public int Under15CountAway { get; set; }
        public int Under25CountAway { get; set; }
        public int Under35CountAway { get; set; }
        public int Under45CountAway { get; set; }
        public int Under55CountAway { get; set; }
        public int Over05Percentage { get; set; }
        public int Over15Percentage { get; set; }
        public int Over25Percentage { get; set; }
        public int Over35Percentage { get; set; }
        public int Over45Percentage { get; set; }
        public int Over55Percentage { get; set; }
        public int Over05PercentageHome { get; set; }
        public int Over15PercentageHome { get; set; }
        public int Over25PercentageHome { get; set; }
        public int Over35PercentageHome { get; set; }
        public int Over45PercentageHome { get; set; }
        public int Over55PercentageHome { get; set; }
        public int Over05PercentageAway { get; set; }
        public int Over15PercentageAway { get; set; }
        public int Over25PercentageAway { get; set; }
        public int Over35PercentageAway { get; set; }
        public int Over45PercentageAway { get; set; }
        public int Over55PercentageAway { get; set; }
        public int Under05Percentage { get; set; }
        public int Under15Percentage { get; set; }
        public int Under25Percentage { get; set; }
        public int Under35Percentage { get; set; }
        public int Under45Percentage { get; set; }
        public int Under55Percentage { get; set; }
        public int Under05PercentageHome { get; set; }
        public int Under15PercentageHome { get; set; }
        public int Under25PercentageHome { get; set; }
        public int Under35PercentageHome { get; set; }
        public int Under45PercentageHome { get; set; }
        public int Under55PercentageHome { get; set; }
        public int Under05PercentageAway { get; set; }
        public int Under15PercentageAway { get; set; }
        public int Under25PercentageAway { get; set; }
        public int Under35PercentageAway { get; set; }
        public int Under45PercentageAway { get; set; }
        public int Under55PercentageAway { get; set; }
        public int Over05CountHalfTime { get; set; }
        public int Over15CountHalfTime { get; set; }
        public int Over25CountHalfTime { get; set; }
        public int Over05CountHalfTimeHome { get; set; }
        public int Over15CountHalfTimeHome { get; set; }
        public int Over25CountHalfTimeHome { get; set; }
        public int Over05CountHalfTimeAway { get; set; }
        public int Over15CountHalfTimeAway { get; set; }
        public int Over25CountHalfTimeAway { get; set; }
        public int Over05HalfTimePercentage { get; set; }
        public int Over15HalfTimePercentage { get; set; }
        public int Over25HalfTimePercentage { get; set; }
        public int Over05HalfTimePercentageHome { get; set; }
        public int Over15HalfTimePercentageHome { get; set; }
        public int Over25HalfTimePercentageHome { get; set; }
        public int Over05HalfTimePercentageAway { get; set; }
        public int Over15HalfTimePercentageAway { get; set; }
        public int Over25HalfTimePercentageAway { get; set; }
        public int WinPercentage { get; set; }
        public int WinPercentageHome { get; set; }
        public int WinPercentageAway { get; set; }
        public int HomeAdvantagePercentage { get; set; }
        public int CleanSheetPercentage { get; set; }
        public int CleanSheetPercentageHome { get; set; }
        public int CleanSheetPercentageAway { get; set; }
        public int BttsPercentage { get; set; }
        public int BttsPercentageHome { get; set; }
        public int BttsPercentageAway { get; set; }
        public int FtsPercentage { get; set; }
        public int FtsPercentageHome { get; set; }
        public int FtsPercentageAway { get; set; }
        public int FirstTeamToScorePercentage { get; set; }
        public int FirstTeamToScorePercentageHome { get; set; }
        public int FirstTeamToScorePercentageAway { get; set; }
        public int CleanSheetHalfTime { get; set; }
        public int CleanSheetHalfTimeHome { get; set; }
        public int CleanSheetHalfTimeAway { get; set; }
        public int CleanSheetHalfTimePercentage { get; set; }
        public int CleanSheetHalfTimePercentageHome { get; set; }
        public int CleanSheetHalfTimePercentageAway { get; set; }
        public int FtsHalfTime { get; set; }
        public int FtsHalfTimeHome { get; set; }
        public int FtsHalfTimeAway { get; set; }
        public int FtsHalfTimePercentage { get; set; }
        public int FtsHalfTimePercentageHome { get; set; }
        public int FtsHalfTimePercentageAway { get; set; }
        public int BttsHalfTime { get; set; }
        public int BttsHalfTimeHome { get; set; }
        public int BttsHalfTimeAway { get; set; }
        public int BttsHalfTimePercentage { get; set; }
        public int BttsHalfTimePercentageHome { get; set; }
        public int BttsHalfTimePercentageAway { get; set; }
        public int LeadingAtHalfTimePercentage { get; set; }
        public int LeadingAtHalfTimePercentageHome { get; set; }
        public int LeadingAtHalfTimePercentageAway { get; set; }
        public int DrawAtHalfTimePercentage { get; set; }
        public int DrawAtHalfTimePercentageHome { get; set; }
        public int DrawAtHalfTimePercentageAway { get; set; }
        public int LosingAtHalfTimePercentage { get; set; }
        public int LosingAtHalfTimePercentageHome { get; set; }
        public int LosingAtHalfTimePercentageAway { get; set; }
        public double CornersPerMatch { get; set; }
        public double CornersPerMatchHome { get; set; }
        public double CornersPerMatchAway { get; set; }
        public double CardsPerMatch { get; set; }
        public double CardsPerMatchHome { get; set; }
        public double CardsPerMatchAway { get; set; }
        public int Over65CornersPercentage { get; set; }
        public int Over75CornersPercentage { get; set; }
        public int Over85CornersPercentage { get; set; }
        public int Over95CornersPercentage { get; set; }
        public int Over105CornersPercentage { get; set; }
        public int Over115CornersPercentage { get; set; }
        public int Over125CornersPercentage { get; set; }
        public int Over135CornersPercentage { get; set; }
        public double XgForAvgOverall { get; set; }
        public double XgForAvgHome { get; set; }
        public double XgForAvgAway { get; set; }
        public double XgAgainstAvgOverall { get; set; }
        public double XgAgainstAvgHome { get; set; }
        public double XgAgainstAvgAway { get; set; }
        public int PredictionRisk { get; set; }
        public int GoalsScoredMin0To10 { get; set; }
        public int GoalsScoredMin11To20 { get; set; }
        public int GoalsScoredMin21To30 { get; set; }
        public int GoalsScoredMin31To40 { get; set; }
        public int GoalsScoredMin41To50 { get; set; }
        public int GoalsScoredMin51To60 { get; set; }
        public int GoalsScoredMin61To70 { get; set; }
        public int GoalsScoredMin71To80 { get; set; }
        public int GoalsScoredMin81To90 { get; set; }
        public int GoalsConcededMin0To10 { get; set; }
        public int GoalsConcededMin11To20 { get; set; }
        public int GoalsConcededMin21To30 { get; set; }
        public int GoalsConcededMin31To40 { get; set; }
        public int GoalsConcededMin41To50 { get; set; }
        public int GoalsConcededMin51To60 { get; set; }
        public int GoalsConcededMin61To70 { get; set; }
        public int GoalsConcededMin71To80 { get; set; }
        public int GoalsConcededMin81To90 { get; set; }
        public int DrawPercentageOverall { get; set; }
        public int DrawPercentageHome { get; set; }
        public int DrawPercentageAway { get; set; }
        public int LossPercentageOvearll { get; set; }
        public int LossPercentageHome { get; set; }
        public int LossPercentageAway { get; set; }
        public int Over145CornersPercentage { get; set; }
    }

    public class TeamsClassMap : ClassMap<Teams>
    {
        public TeamsClassMap()
        {
            Map(m => m.TeamName).Name("team_name");
            Map(m => m.CommonName).Name("common_name");
            Map(m => m.Season).Name("season");
            Map(m => m.Country).Name("country");
            Map(m => m.MatchesPlayed).Name("matches_played");
            Map(m => m.MatchesPlayedHome).Name("matches_played_home");
            Map(m => m.MatchesPlayedAway).Name("matches_played_away");
            Map(m => m.SuspendedMatches).Name("suspended_matches");
            Map(m => m.Wins).Name("wins");
            Map(m => m.WinsHome).Name("wins_home");
            Map(m => m.WinsAway).Name("wins_away");
            Map(m => m.Draws).Name("draws");
            Map(m => m.DrawsHome).Name("draws_home");
            Map(m => m.DrawsAway).Name("draws_away");
            Map(m => m.Losses).Name("losses");
            Map(m => m.LossesHome).Name("losses_home");
            Map(m => m.LossesAway).Name("losses_away");
            Map(m => m.PointsPerGame).Name("points_per_game");
            Map(m => m.PointsPerGameHome).Name("points_per_game_home");
            Map(m => m.PointsPerGameAway).Name("points_per_game_away");
            Map(m => m.LeaguePosition).Name("league_position");
            Map(m => m.LeaguePositionHome).Name("league_position_home");
            Map(m => m.LeaguePositionAway).Name("league_position_away");
            Map(m => m.PerformanceRank).Name("performance_rank");
            Map(m => m.GoalsScored).Name("goals_scored");
            Map(m => m.GoalsConceded).Name("goals_conceded");
            Map(m => m.GoalDifference).Name("goal_difference");
            Map(m => m.TotalGoalCount).Name("total_goal_count");
            Map(m => m.TotalGoalCountHome).Name("total_goal_count_home");
            Map(m => m.TotalGoalCountAway).Name("total_goal_count_away");
            Map(m => m.GoalsScoredHome).Name("goals_scored_home");
            Map(m => m.GoalsScoredAway).Name("goals_scored_away");
            Map(m => m.GoalsConcededHome).Name("goals_conceded_home");
            Map(m => m.GoalsConcededAway).Name("goals_conceded_away");
            Map(m => m.GoalDifferenceHome).Name("goal_difference_home");
            Map(m => m.GoalDifferenceAway).Name("goal_difference_away");
            Map(m => m.MinutesPerGoalScored).Name("minutes_per_goal_scored");
            Map(m => m.MinutesPerGoalScoredHome).Name("minutes_per_goal_scored_home");
            Map(m => m.MinutesPerGoalScoredAway).Name("minutes_per_goal_scored_away");
            Map(m => m.MinutesPerGoalConceded).Name("minutes_per_goal_conceded");
            Map(m => m.MinutesPerGoalConcededHome).Name("minutes_per_goal_conceded_home");
            Map(m => m.MinutesPerGoalConcededAway).Name("minutes_per_goal_conceded_away");
            Map(m => m.CleanSheets).Name("clean_sheets");
            Map(m => m.CleanSheetsHome).Name("clean_sheets_home");
            Map(m => m.CleanSheetsAway).Name("clean_sheets_away");
            Map(m => m.BttsCount).Name("btts_count");
            Map(m => m.BttsCountHome).Name("btts_count_home");
            Map(m => m.BttsCountAway).Name("btts_count_away");
            Map(m => m.FtsCount).Name("fts_count");
            Map(m => m.FtsCountHome).Name("fts_count_home");
            Map(m => m.FtsCountAway).Name("fts_count_away");
            Map(m => m.FirstTeamToScoreCount).Name("first_team_to_score_count");
            Map(m => m.FirstTeamToScoreCountHome).Name("first_team_to_score_count_home");
            Map(m => m.FirstTeamToScoreCountAway).Name("first_team_to_score_count_away");
            Map(m => m.CornersTotal).Name("corners_total");
            Map(m => m.CornersTotalHome).Name("corners_total_home");
            Map(m => m.CornersTotalAway).Name("corners_total_away");
            Map(m => m.CardsTotal).Name("cards_total");
            Map(m => m.CardsTotalHome).Name("cards_total_home");
            Map(m => m.CardsTotalAway).Name("cards_total_away");
            Map(m => m.AveragePossession).Name("average_possession");
            Map(m => m.AveragePossessionHome).Name("average_possession_home");
            Map(m => m.AveragePossessionAway).Name("average_possession_away");
            Map(m => m.Shots).Name("shots");
            Map(m => m.ShotsHome).Name("shots_home");
            Map(m => m.ShotsAway).Name("shots_away");
            Map(m => m.ShotsOnTarget).Name("shots_on_target");
            Map(m => m.ShotsOnTargetHome).Name("shots_on_target_home");
            Map(m => m.ShotsOnTargetAway).Name("shots_on_target_away");
            Map(m => m.ShotsOffTarget).Name("shots_off_target");
            Map(m => m.ShotsOffTargetHome).Name("shots_off_target_home");
            Map(m => m.ShotsOffTargetAway).Name("shots_off_target_away");
            Map(m => m.Fouls).Name("fouls");
            Map(m => m.FoulsHome).Name("fouls_home");
            Map(m => m.FoulsAway).Name("fouls_away");
            Map(m => m.GoalsScoredHalfTime).Name("goals_scored_half_time");
            Map(m => m.GoalsScoredHalfTimeHome).Name("goals_scored_half_time_home");
            Map(m => m.GoalsScoredHalfTimeAway).Name("goals_scored_half_time_away");
            Map(m => m.GoalsConcededHalfTime).Name("goals_conceded_half_time");
            Map(m => m.GoalsConcededHalfTimeHome).Name("goals_conceded_half_time_home");
            Map(m => m.GoalsConcededHalfTimeAway).Name("goals_conceded_half_time_away");
            Map(m => m.GoalDifferenceHalfTime).Name("goal_difference_half_time");
            Map(m => m.GoalDifferenceHalfTimeHome).Name("goal_difference_half_time_home");
            Map(m => m.GoalDifferenceHalfTimeAway).Name("goal_difference_half_time_away");
            Map(m => m.LeadingAtHalfTime).Name("leading_at_half_time");
            Map(m => m.LeadingAtHalfTimeHome).Name("leading_at_half_time_home");
            Map(m => m.LeadingAtHalfTimeAway).Name("leading_at_half_time_away");
            Map(m => m.DrawAtHalfTime).Name("draw_at_half_time");
            Map(m => m.DrawAtHalfTimeHome).Name("draw_at_half_time_home");
            Map(m => m.DrawAtHalfTimeAway).Name("draw_at_half_time_away");
            Map(m => m.LosingAtHalfTime).Name("losing_at_half_time");
            Map(m => m.LosingAtHalfTimeHome).Name("losing_at_half_time_home");
            Map(m => m.LosingAtHalfTimeAway).Name("losing_at_half_time_away");
            Map(m => m.PointsPerGameHalfTime).Name("points_per_game_half_time");
            Map(m => m.PointsPerGameHalfTimeHome).Name("points_per_game_half_time_home");
            Map(m => m.PointsPerGameHalfTimeAway).Name("points_per_game_half_time_away");
            Map(m => m.AverageTotalGoalsPerMatch).Name("average_total_goals_per_match");
            Map(m => m.AverageTotalGoalsPerMatchHome).Name("average_total_goals_per_match_home");
            Map(m => m.AverageTotalGoalsPerMatchAway).Name("average_total_goals_per_match_away");
            Map(m => m.GoalsScoredPerMatch).Name("goals_scored_per_match");
            Map(m => m.GoalsScoredPerMatchHome).Name("goals_scored_per_match_home");
            Map(m => m.GoalsScoredPerMatchAway).Name("goals_scored_per_match_away");
            Map(m => m.GoalsConcededPerMatch).Name("goals_conceded_per_match");
            Map(m => m.GoalsConcededPerMatchHome).Name("goals_conceded_per_match_home");
            Map(m => m.GoalsConcededPerMatchAway).Name("goals_conceded_per_match_away");
            Map(m => m.TotalGoalsPerMatchHalfTime).Name("total_goals_per_match_half_time");
            Map(m => m.TotalGoalsPerMatchHalfTimeHome).Name("total_goals_per_match_half_time_home");
            Map(m => m.TotalGoalsPerMatchHalfTimeAway).Name("total_goals_per_match_half_time_away");
            Map(m => m.GoalsScoredPerMatchHalfTime).Name("goals_scored_per_match_half_time");
            Map(m => m.GoalsScoredPerMatchHalfTimeHome).Name("goals_scored_per_match_half_time_home");
            Map(m => m.GoalsScoredPerMatchHalfTimeAway).Name("goals_scored_per_match_half_time_away");
            Map(m => m.GoalsConcededPerMatchHalfTime).Name("goals_conceded_per_match_half_time");
            Map(m => m.GoalsConcededPerMatchHalfTimeHome).Name("goals_conceded_per_match_half_time_home");
            Map(m => m.GoalsConcededPerMatchHalfTimeAway).Name("goals_conceded_per_match_half_time_away");
            Map(m => m.Over05Count).Name("over05_count");
            Map(m => m.Over15Count).Name("over15_count");
            Map(m => m.Over25Count).Name("over25_count");
            Map(m => m.Over35Count).Name("over35_count");
            Map(m => m.Over45Count).Name("over45_count");
            Map(m => m.Over55Count).Name("over55_count");
            Map(m => m.Over05CountHome).Name("over05_count_home");
            Map(m => m.Over15CountHome).Name("over15_count_home");
            Map(m => m.Over25CountHome).Name("over25_count_home");
            Map(m => m.Over35CountHome).Name("over35_count_home");
            Map(m => m.Over45CountHome).Name("over45_count_home");
            Map(m => m.Over55CountHome).Name("over55_count_home");
            Map(m => m.Over05CountAway).Name("over05_count_away");
            Map(m => m.Over15CountAway).Name("over15_count_away");
            Map(m => m.Over25CountAway).Name("over25_count_away");
            Map(m => m.Over35CountAway).Name("over35_count_away");
            Map(m => m.Over45CountAway).Name("over45_count_away");
            Map(m => m.Over55CountAway).Name("over55_count_away");
            Map(m => m.Under05Count).Name("under05_count");
            Map(m => m.Under15Count).Name("under15_count");
            Map(m => m.Under25Count).Name("under25_count");
            Map(m => m.Under35Count).Name("under35_count");
            Map(m => m.Under45Count).Name("under45_count");
            Map(m => m.Under55Count).Name("under55_count");
            Map(m => m.Under05CountHome).Name("under05_count_home");
            Map(m => m.Under15CountHome).Name("under15_count_home");
            Map(m => m.Under25CountHome).Name("under25_count_home");
            Map(m => m.Under35CountHome).Name("under35_count_home");
            Map(m => m.Under45CountHome).Name("under45_count_home");
            Map(m => m.Under55CountHome).Name("under55_count_home");
            Map(m => m.Under05CountAway).Name("under05_count_away");
            Map(m => m.Under15CountAway).Name("under15_count_away");
            Map(m => m.Under25CountAway).Name("under25_count_away");
            Map(m => m.Under35CountAway).Name("under35_count_away");
            Map(m => m.Under45CountAway).Name("under45_count_away");
            Map(m => m.Under55CountAway).Name("under55_count_away");
            Map(m => m.Over05Percentage).Name("over05_percentage");
            Map(m => m.Over15Percentage).Name("over15_percentage");
            Map(m => m.Over25Percentage).Name("over25_percentage");
            Map(m => m.Over35Percentage).Name("over35_percentage");
            Map(m => m.Over45Percentage).Name("over45_percentage");
            Map(m => m.Over55Percentage).Name("over55_percentage");
            Map(m => m.Over05PercentageHome).Name("over05_percentage_home");
            Map(m => m.Over15PercentageHome).Name("over15_percentage_home");
            Map(m => m.Over25PercentageHome).Name("over25_percentage_home");
            Map(m => m.Over35PercentageHome).Name("over35_percentage_home");
            Map(m => m.Over45PercentageHome).Name("over45_percentage_home");
            Map(m => m.Over55PercentageHome).Name("over55_percentage_home");
            Map(m => m.Over05PercentageAway).Name("over05_percentage_away");
            Map(m => m.Over15PercentageAway).Name("over15_percentage_away");
            Map(m => m.Over25PercentageAway).Name("over25_percentage_away");
            Map(m => m.Over35PercentageAway).Name("over35_percentage_away");
            Map(m => m.Over45PercentageAway).Name("over45_percentage_away");
            Map(m => m.Over55PercentageAway).Name("over55_percentage_away");
            Map(m => m.Under05Percentage).Name("under05_percentage");
            Map(m => m.Under15Percentage).Name("under15_percentage");
            Map(m => m.Under25Percentage).Name("under25_percentage");
            Map(m => m.Under35Percentage).Name("under35_percentage");
            Map(m => m.Under45Percentage).Name("under45_percentage");
            Map(m => m.Under55Percentage).Name("under55_percentage");
            Map(m => m.Under05PercentageHome).Name("under05_percentage_home");
            Map(m => m.Under15PercentageHome).Name("under15_percentage_home");
            Map(m => m.Under25PercentageHome).Name("under25_percentage_home");
            Map(m => m.Under35PercentageHome).Name("under35_percentage_home");
            Map(m => m.Under45PercentageHome).Name("under45_percentage_home");
            Map(m => m.Under55PercentageHome).Name("under55_percentage_home");
            Map(m => m.Under05PercentageAway).Name("under05_percentage_away");
            Map(m => m.Under15PercentageAway).Name("under15_percentage_away");
            Map(m => m.Under25PercentageAway).Name("under25_percentage_away");
            Map(m => m.Under35PercentageAway).Name("under35_percentage_away");
            Map(m => m.Under45PercentageAway).Name("under45_percentage_away");
            Map(m => m.Under55PercentageAway).Name("under55_percentage_away");
            Map(m => m.Over05CountHalfTime).Name("over05_count_half_time");
            Map(m => m.Over15CountHalfTime).Name("over15_count_half_time");
            Map(m => m.Over25CountHalfTime).Name("over25_count_half_time");
            Map(m => m.Over05CountHalfTimeHome).Name("over05_count_half_time_home");
            Map(m => m.Over15CountHalfTimeHome).Name("over15_count_half_time_home");
            Map(m => m.Over25CountHalfTimeHome).Name("over25_count_half_time_home");
            Map(m => m.Over05CountHalfTimeAway).Name("over05_count_half_time_away");
            Map(m => m.Over15CountHalfTimeAway).Name("over15_count_half_time_away");
            Map(m => m.Over25CountHalfTimeAway).Name("over25_count_half_time_away");
            Map(m => m.Over05HalfTimePercentage).Name("over05_half_time_percentage");
            Map(m => m.Over15HalfTimePercentage).Name("over15_half_time_percentage");
            Map(m => m.Over25HalfTimePercentage).Name("over25_half_time_percentage");
            Map(m => m.Over05HalfTimePercentageHome).Name("over05_half_time_percentage_home");
            Map(m => m.Over15HalfTimePercentageHome).Name("over15_half_time_percentage_home");
            Map(m => m.Over25HalfTimePercentageHome).Name("over25_half_time_percentage_home");
            Map(m => m.Over05HalfTimePercentageAway).Name("over05_half_time_percentage_away");
            Map(m => m.Over15HalfTimePercentageAway).Name("over15_half_time_percentage_away");
            Map(m => m.Over25HalfTimePercentageAway).Name("over25_half_time_percentage_away");
            Map(m => m.WinPercentage).Name("win_percentage");
            Map(m => m.WinPercentageHome).Name("win_percentage_home");
            Map(m => m.WinPercentageAway).Name("win_percentage_away");
            Map(m => m.HomeAdvantagePercentage).Name("home_advantage_percentage");
            Map(m => m.CleanSheetPercentage).Name("clean_sheet_percentage");
            Map(m => m.CleanSheetPercentageHome).Name("clean_sheet_percentage_home");
            Map(m => m.CleanSheetPercentageAway).Name("clean_sheet_percentage_away");
            Map(m => m.BttsPercentage).Name("btts_percentage");
            Map(m => m.BttsPercentageHome).Name("btts_percentage_home");
            Map(m => m.BttsPercentageAway).Name("btts_percentage_away");
            Map(m => m.FtsPercentage).Name("fts_percentage");
            Map(m => m.FtsPercentageHome).Name("fts_percentage_home");
            Map(m => m.FtsPercentageAway).Name("fts_percentage_away");
            Map(m => m.FirstTeamToScorePercentage).Name("first_team_to_score_percentage");
            Map(m => m.FirstTeamToScorePercentageHome).Name("first_team_to_score_percentage_home");
            Map(m => m.FirstTeamToScorePercentageAway).Name("first_team_to_score_percentage_away");
            Map(m => m.CleanSheetHalfTime).Name("clean_sheet_half_time");
            Map(m => m.CleanSheetHalfTimeHome).Name("clean_sheet_half_time_home");
            Map(m => m.CleanSheetHalfTimeAway).Name("clean_sheet_half_time_away");
            Map(m => m.CleanSheetHalfTimePercentage).Name("clean_sheet_half_time_percentage");
            Map(m => m.CleanSheetHalfTimePercentageHome).Name("clean_sheet_half_time_percentage_home");
            Map(m => m.CleanSheetHalfTimePercentageAway).Name("clean_sheet_half_time_percentage_away");
            Map(m => m.FtsHalfTime).Name("fts_half_time");
            Map(m => m.FtsHalfTimeHome).Name("fts_half_time_home");
            Map(m => m.FtsHalfTimeAway).Name("fts_half_time_away");
            Map(m => m.FtsHalfTimePercentage).Name("fts_half_time_percentage");
            Map(m => m.FtsHalfTimePercentageHome).Name("fts_half_time_percentage_home");
            Map(m => m.FtsHalfTimePercentageAway).Name("fts_half_time_percentage_away");
            Map(m => m.BttsHalfTime).Name("btts_half_time");
            Map(m => m.BttsHalfTimeHome).Name("btts_half_time_home");
            Map(m => m.BttsHalfTimeAway).Name("btts_half_time_away");
            Map(m => m.BttsHalfTimePercentage).Name("btts_half_time_percentage");
            Map(m => m.BttsHalfTimePercentageHome).Name("btts_half_time_percentage_home");
            Map(m => m.BttsHalfTimePercentageAway).Name("btts_half_time_percentage_away");
            Map(m => m.LeadingAtHalfTimePercentage).Name("leading_at_half_time_percentage");
            Map(m => m.LeadingAtHalfTimePercentageHome).Name("leading_at_half_time_percentage_home");
            Map(m => m.LeadingAtHalfTimePercentageAway).Name("leading_at_half_time_percentage_away");
            Map(m => m.DrawAtHalfTimePercentage).Name("draw_at_half_time_percentage");
            Map(m => m.DrawAtHalfTimePercentageHome).Name("draw_at_half_time_percentage_home");
            Map(m => m.DrawAtHalfTimePercentageAway).Name("draw_at_half_time_percentage_away");
            Map(m => m.LosingAtHalfTimePercentage).Name("losing_at_half_time_percentage");
            Map(m => m.LosingAtHalfTimePercentageHome).Name("losing_at_half_time_percentage_home");
            Map(m => m.LosingAtHalfTimePercentageAway).Name("losing_at_half_time_percentage_away");
            Map(m => m.CornersPerMatch).Name("corners_per_match");
            Map(m => m.CornersPerMatchHome).Name("corners_per_match_home");
            Map(m => m.CornersPerMatchAway).Name("corners_per_match_away");
            Map(m => m.CardsPerMatch).Name("cards_per_match");
            Map(m => m.CardsPerMatchHome).Name("cards_per_match_home");
            Map(m => m.CardsPerMatchAway).Name("cards_per_match_away");
            Map(m => m.Over65CornersPercentage).Name("over65_corners_percentage");
            Map(m => m.Over75CornersPercentage).Name("over75_corners_percentage");
            Map(m => m.Over85CornersPercentage).Name("over85_corners_percentage");
            Map(m => m.Over95CornersPercentage).Name("over95_corners_percentage");
            Map(m => m.Over105CornersPercentage).Name("over105_corners_percentage");
            Map(m => m.Over115CornersPercentage).Name("over115_corners_percentage");
            Map(m => m.Over125CornersPercentage).Name("over125_corners_percentage");
            Map(m => m.Over135CornersPercentage).Name("over135_corners_percentage");
            Map(m => m.XgForAvgOverall).Name("xg_for_avg_overall");
            Map(m => m.XgForAvgHome).Name("xg_for_avg_home");
            Map(m => m.XgForAvgAway).Name("xg_for_avg_away");
            Map(m => m.XgAgainstAvgOverall).Name("xg_against_avg_overall");
            Map(m => m.XgAgainstAvgHome).Name("xg_against_avg_home");
            Map(m => m.XgAgainstAvgAway).Name("xg_against_avg_away");
            Map(m => m.PredictionRisk).Name("prediction_risk");
            Map(m => m.GoalsScoredMin0To10).Name("goals_scored_min_0_to_10");
            Map(m => m.GoalsScoredMin11To20).Name("goals_scored_min_11_to_20");
            Map(m => m.GoalsScoredMin21To30).Name("goals_scored_min_21_to_30");
            Map(m => m.GoalsScoredMin31To40).Name("goals_scored_min_31_to_40");
            Map(m => m.GoalsScoredMin41To50).Name("goals_scored_min_41_to_50");
            Map(m => m.GoalsScoredMin51To60).Name("goals_scored_min_51_to_60");
            Map(m => m.GoalsScoredMin61To70).Name("goals_scored_min_61_to_70");
            Map(m => m.GoalsScoredMin71To80).Name("goals_scored_min_71_to_80");
            Map(m => m.GoalsScoredMin81To90).Name("goals_scored_min_81_to_90");
            Map(m => m.GoalsConcededMin0To10).Name("goals_conceded_min_0_to_10");
            Map(m => m.GoalsConcededMin11To20).Name("goals_conceded_min_11_to_20");
            Map(m => m.GoalsConcededMin21To30).Name("goals_conceded_min_21_to_30");
            Map(m => m.GoalsConcededMin31To40).Name("goals_conceded_min_31_to_40");
            Map(m => m.GoalsConcededMin41To50).Name("goals_conceded_min_41_to_50");
            Map(m => m.GoalsConcededMin51To60).Name("goals_conceded_min_51_to_60");
            Map(m => m.GoalsConcededMin61To70).Name("goals_conceded_min_61_to_70");
            Map(m => m.GoalsConcededMin71To80).Name("goals_conceded_min_71_to_80");
            Map(m => m.GoalsConcededMin81To90).Name("goals_conceded_min_81_to_90");
            Map(m => m.DrawPercentageOverall).Name("draw_percentage_overall");
            Map(m => m.DrawPercentageHome).Name("draw_percentage_home");
            Map(m => m.DrawPercentageAway).Name("draw_percentage_away");
            Map(m => m.LossPercentageOvearll).Name("loss_percentage_ovearll");
            Map(m => m.LossPercentageHome).Name("loss_percentage_home");
            Map(m => m.LossPercentageAway).Name("loss_percentage_away");
            Map(m => m.Over145CornersPercentage).Name("over145_corners_percentage");
        }
    }

}
