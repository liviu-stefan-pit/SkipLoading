using IBetForYou.Models;
using IBetForYou.Models.ScrapperModels;
using IBetForYou.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IBetForYou
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ScrappersManagingService managingService;

        public MainWindow()
        {
            InitializeComponent();

            managingService = new ScrappersManagingService();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //PredictzService predictzService = new PredictzService();
            //var games = await predictzService.GetAlmostSurebets(true);

            //FootballPredictionsService footballPredictionsService = new FootballPredictionsService();
            //var games2 = await footballPredictionsService.GetWebsiteData();
            //Forebet forebet = new Forebet();
            //await forebet.GetWebsiteData();

            //ScrappersManagingService managingService = new ScrappersManagingService();

            List<MatchPrediction> games = new List<MatchPrediction>();

            var res = managingService.Results;

            foreach (var r in res)
            {
                foreach (var game in r.Games)
                {
                    games.Add(new MatchPrediction
                    {
                        HomeTeam = game.HomeTeam,
                        AwayTeam = game.AwayTeam,
                        ScorePrediction = game.Score
                    });
                }
            }

            SerializeToJson(games);

            List<ListViewItem> viewItems = new();

            foreach (var item in games)
            {
                ListViewItem game = new ListViewItem();
                game.Content = item;

                string[] score = item.ScorePrediction.Split("-");
                int.TryParse(score.FirstOrDefault(), out int hts);
                int.TryParse(score.LastOrDefault(), out int ats);

                if (hts == ats)
                {
                    game.Background = Brushes.Yellow;
                }
                else if (hts > ats)
                {
                    game.Background = Brushes.LightGreen;
                }
                else
                {
                    game.Background = Brushes.Red;
                }

                viewItems.Add(game);
            }

            this.lstGames.ItemsSource = viewItems;
        }

        private void SerializeToJson(List<MatchPrediction> viewItems)
        {
            string json = JsonSerializer.Serialize(viewItems);

            File.WriteAllText($"SafePredictions-{DateTime.Now.Day}-{DateTime.Now.Month}.json", json);
        }

        private void btnTestData_Click(object sender, RoutedEventArgs e)
        {

            List<string> lines = File.ReadAllLines("TestData.txt").ToList();
            List<MatchPrediction> predictions = new List<MatchPrediction>();

            foreach (var line in lines)
            {
                string[] data = line.Split(" ");

                MatchPrediction matchPrediction = new MatchPrediction
                {
                    HomeTeam = data.FirstOrDefault(),
                    AwayTeam = data.LastOrDefault(),
                    ScorePrediction = data[1]
                };

                predictions.Add(matchPrediction);
            }

            var grouped = predictions.GroupBy(x => x.GameId);

            List<Prediction> finalPredictions = new();

            foreach (var group in grouped)
            {
                var games = group.ToList();

                Prediction pred = new Prediction(games);
                finalPredictions.Add(pred);
            }

            _ = finalPredictions.Count();
        }

        public MatchPrediction GetGroupPrediction(List<MatchPrediction> groupedPredictions)
        {
            int awayTeamWins = groupedPredictions.GetAwayTeamWins();
            int homeTeamWins = groupedPredictions.GetHomeTeamWins();

            List<string> scores = new();

            foreach (var item in groupedPredictions)
            {
                scores.Add(item.ScorePrediction);
            }

            string finalScore = scores.GetFinalScore();

            return null;
        }
    }
}
