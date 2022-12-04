using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBetForYou.FootyStats
{
    public class Matches
    {
        public int Timestamp { get; set; }
        public string DateGMT { get; set; }
        public string Status { get; set; }
        public int Attendance { get; set; }
        public string HomeTeamName { get; set; }
        public string AwayTeamName { get; set; }
        public string Referee { get; set; }
        public int GameWeek { get; set; }
        public double PreMatchPPGHome { get; set; }
        public double PreMatchPPGAway { get; set; }
        public double HomePpg { get; set; }
        public double AwayPpg { get; set; }
        public int HomeTeamGoalCount { get; set; }
        public int AwayTeamGoalCount { get; set; }
        public int TotalGoalCount { get; set; }
        public int TotalGoalsAtHalfTime { get; set; }
        public int HomeTeamGoalCountHalfTime { get; set; }
        public int AwayTeamGoalCountHalfTime { get; set; }
        public string HomeTeamGoalTimings { get; set; }
        public string AwayTeamGoalTimings { get; set; }
        public int HomeTeamCornerCount { get; set; }
        public int AwayTeamCornerCount { get; set; }
        public int HomeTeamYellowCards { get; set; }
        public int HomeTeamRedCards { get; set; }
        public int AwayTeamYellowCards { get; set; }
        public int AwayTeamRedCards { get; set; }
        public int HomeTeamFirstHalfCards { get; set; }
        public int HomeTeamSecondHalfCards { get; set; }
        public int AwayTeamFirstHalfCards { get; set; }
        public int AwayTeamSecondHalfCards { get; set; }
        public int HomeTeamShots { get; set; }
        public int AwayTeamShots { get; set; }
        public int HomeTeamShotsOnTarget { get; set; }
        public int AwayTeamShotsOnTarget { get; set; }
        public int HomeTeamShotsOffTarget { get; set; }
        public int AwayTeamShotsOffTarget { get; set; }
        public int HomeTeamFouls { get; set; }
        public int AwayTeamFouls { get; set; }
        public int HomeTeamPossession { get; set; }
        public int AwayTeamPossession { get; set; }
        public double HomeTeamPreMatchxG { get; set; }
        public double AwayTeamPreMatchxG { get; set; }
        public double TeamAXg { get; set; }
        public double TeamBXg { get; set; }
        public double AverageGoalsPerMatchPreMatch { get; set; }
        public int BttsPercentagePreMatch { get; set; }
        public int Over15PercentagePreMatch { get; set; }
        public int Over25PercentagePreMatch { get; set; }
        public int Over35PercentagePreMatch { get; set; }
        public int Over45PercentagePreMatch { get; set; }
        public int Over15HTFHGPercentagePreMatch { get; set; }
        public int Over05HTFHGPercentagePreMatch { get; set; }
        public int Over152HGPercentagePreMatch { get; set; }
        public int Over052HGPercentagePreMatch { get; set; }
        public double AverageCornersPerMatchPreMatch { get; set; }
        public double AverageCardsPerMatchPreMatch { get; set; }
        public double OddsFtHomeTeamWin { get; set; }
        public double OddsFtDraw { get; set; }
        public double OddsFtAwayTeamWin { get; set; }
        public double OddsFtOver15 { get; set; }
        public double OddsFtOver25 { get; set; }
        public double OddsFtOver35 { get; set; }
        public double OddsFtOver45 { get; set; }
        public double OddsBttsYes { get; set; }
        public double OddsBttsNo { get; set; }
        public string StadiumName { get; set; }
    }

    public class MatchesClassMap : ClassMap<Matches>
    {
        public MatchesClassMap()
        {
            Map(m => m.Timestamp).Name("timestamp");
            Map(m => m.DateGMT).Name("date_GMT");
            Map(m => m.Status).Name("status");
            Map(m => m.Attendance).Name("attendance");
            Map(m => m.HomeTeamName).Name("home_team_name");
            Map(m => m.AwayTeamName).Name("away_team_name");
            Map(m => m.Referee).Name("referee");
            Map(m => m.GameWeek).Name("Game Week");
            Map(m => m.PreMatchPPGHome).Name("Pre-Match PPG (Home)");
            Map(m => m.PreMatchPPGAway).Name("Pre-Match PPG (Away)");
            Map(m => m.HomePpg).Name("home_ppg");
            Map(m => m.AwayPpg).Name("away_ppg");
            Map(m => m.HomeTeamGoalCount).Name("home_team_goal_count");
            Map(m => m.AwayTeamGoalCount).Name("away_team_goal_count");
            Map(m => m.TotalGoalCount).Name("total_goal_count");
            Map(m => m.TotalGoalsAtHalfTime).Name("total_goals_at_half_time");
            Map(m => m.HomeTeamGoalCountHalfTime).Name("home_team_goal_count_half_time");
            Map(m => m.AwayTeamGoalCountHalfTime).Name("away_team_goal_count_half_time");
            Map(m => m.HomeTeamGoalTimings).Name("home_team_goal_timings");
            Map(m => m.AwayTeamGoalTimings).Name("away_team_goal_timings");
            Map(m => m.HomeTeamCornerCount).Name("home_team_corner_count");
            Map(m => m.AwayTeamCornerCount).Name("away_team_corner_count");
            Map(m => m.HomeTeamYellowCards).Name("home_team_yellow_cards");
            Map(m => m.HomeTeamRedCards).Name("home_team_red_cards");
            Map(m => m.AwayTeamYellowCards).Name("away_team_yellow_cards");
            Map(m => m.AwayTeamRedCards).Name("away_team_red_cards");
            Map(m => m.HomeTeamFirstHalfCards).Name("home_team_first_half_cards");
            Map(m => m.HomeTeamSecondHalfCards).Name("home_team_second_half_cards");
            Map(m => m.AwayTeamFirstHalfCards).Name("away_team_first_half_cards");
            Map(m => m.AwayTeamSecondHalfCards).Name("away_team_second_half_cards");
            Map(m => m.HomeTeamShots).Name("home_team_shots");
            Map(m => m.AwayTeamShots).Name("away_team_shots");
            Map(m => m.HomeTeamShotsOnTarget).Name("home_team_shots_on_target");
            Map(m => m.AwayTeamShotsOnTarget).Name("away_team_shots_on_target");
            Map(m => m.HomeTeamShotsOffTarget).Name("home_team_shots_off_target");
            Map(m => m.AwayTeamShotsOffTarget).Name("away_team_shots_off_target");
            Map(m => m.HomeTeamFouls).Name("home_team_fouls");
            Map(m => m.AwayTeamFouls).Name("away_team_fouls");
            Map(m => m.HomeTeamPossession).Name("home_team_possession");
            Map(m => m.AwayTeamPossession).Name("away_team_possession");
            Map(m => m.HomeTeamPreMatchxG).Name("Home Team Pre-Match xG");
            Map(m => m.AwayTeamPreMatchxG).Name("Away Team Pre-Match xG");
            Map(m => m.TeamAXg).Name("team_a_xg");
            Map(m => m.TeamBXg).Name("team_b_xg");
            Map(m => m.AverageGoalsPerMatchPreMatch).Name("average_goals_per_match_pre_match");
            Map(m => m.BttsPercentagePreMatch).Name("btts_percentage_pre_match");
            Map(m => m.Over15PercentagePreMatch).Name("over_15_percentage_pre_match");
            Map(m => m.Over25PercentagePreMatch).Name("over_25_percentage_pre_match");
            Map(m => m.Over35PercentagePreMatch).Name("over_35_percentage_pre_match");
            Map(m => m.Over45PercentagePreMatch).Name("over_45_percentage_pre_match");
            Map(m => m.Over15HTFHGPercentagePreMatch).Name("over_15_HT_FHG_percentage_pre_match");
            Map(m => m.Over05HTFHGPercentagePreMatch).Name("over_05_HT_FHG_percentage_pre_match");
            Map(m => m.Over152HGPercentagePreMatch).Name("over_15_2HG_percentage_pre_match");
            Map(m => m.Over052HGPercentagePreMatch).Name("over_05_2HG_percentage_pre_match");
            Map(m => m.AverageCornersPerMatchPreMatch).Name("average_corners_per_match_pre_match");
            Map(m => m.AverageCardsPerMatchPreMatch).Name("average_cards_per_match_pre_match");
            Map(m => m.OddsFtHomeTeamWin).Name("odds_ft_home_team_win");
            Map(m => m.OddsFtDraw).Name("odds_ft_draw");
            Map(m => m.OddsFtAwayTeamWin).Name("odds_ft_away_team_win");
            Map(m => m.OddsFtOver15).Name("odds_ft_over15");
            Map(m => m.OddsFtOver25).Name("odds_ft_over25");
            Map(m => m.OddsFtOver35).Name("odds_ft_over35");
            Map(m => m.OddsFtOver45).Name("odds_ft_over45");
            Map(m => m.OddsBttsYes).Name("odds_btts_yes");
            Map(m => m.OddsBttsNo).Name("odds_btts_no");
            Map(m => m.StadiumName).Name("stadium_name");
        }
    }

}
