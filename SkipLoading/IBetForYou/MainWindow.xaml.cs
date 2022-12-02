using IBetForYou.Models;
using IBetForYou.Models.ScrapperModels;
using IBetForYou.Services;
using IBetForYou.TestingLojic;
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

            //managingService = new ScrappersManagingService();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            List<GamePrediction> games = new List<GamePrediction>();

            List<Game> gameList = BuildGameList();
            var groupedGames = gameList.GroupBy(x => x.Id);

            List<Prediction> finalPredictions = new();

            foreach (var group in groupedGames)
            {
                //consider grups of 1 unsure
                if(group.Count() > 1)
                {
                    Prediction pred = new Prediction(group.ToList());
                    finalPredictions.Add(pred);
                }
            }

            _ = finalPredictions.Count();

            List<Prediction> mixedPredictions = finalPredictions.Where(p => p.MixedPrediction != 3).ToList();
            // SerializeToJson(games);

            //List<ListViewItem> viewItems = new();

            //foreach (var item in games)
            //{
            //    ListViewItem game = new ListViewItem();
            //    game.Content = item;

            //    string[] score = item.Score.Split("-");
            //    int.TryParse(score.FirstOrDefault(), out int hts);
            //    int.TryParse(score.LastOrDefault(), out int ats);

            //    if (hts == ats)
            //    {
            //        game.Background = Brushes.Yellow;
            //    }
            //    else if (hts > ats)
            //    {
            //        game.Background = Brushes.LightGreen;
            //    }
            //    else
            //    {
            //        game.Background = Brushes.Red;
            //    }

            //    viewItems.Add(game);
            //}

            this.lstGames.ItemsSource = mixedPredictions;
        }

        private List<Game> BuildGameList()
        {
            List<Game> gameList = new();

            foreach (var queryResult in managingService.Results)
            {
                foreach (var game in queryResult.Games)
                {
                    gameList.Add(game);
                }
            }

            return gameList;
        }

        private void SerializeToJson(List<GamePrediction> viewItems)
        {
            string json = JsonSerializer.Serialize(viewItems);

            File.WriteAllText($"SafePredictions-{DateTime.Now.Day}-{DateTime.Now.Month}.json", json);
        }

        private void btnTestData_Click(object sender, RoutedEventArgs e)
        {
            List<string> lines = File.ReadAllLines("TestData.txt").ToList();
            List<GameObject> gameObjects = new List<GameObject>();

            foreach (var line in lines)
            {
                string[] data = line.Split(":");

                GameObject gameObject = new GameObject()
                {
                    HomeTeam = data[0].Trim(),
                    AwayTeam = data[2].Trim(),
                    Score = data[1].Trim()
                };

                gameObjects.Add(gameObject);
            }

            for (int i = 0; i < gameObjects.Count - 1; i++)
            {
                for (int j = 1; j < gameObjects.Count; j++)
                {
                    if (gameObjects[i].HomeTeam == gameObjects[j].AwayTeam &&
                        gameObjects[i].AwayTeam == gameObjects[j].HomeTeam)
                    {
                        char[] charArray = gameObjects[j].Score.ToCharArray();
                        Array.Reverse(charArray);

                        gameObjects[j] = new GameObject
                        {
                            HomeTeam = gameObjects[j].AwayTeam,
                            AwayTeam = gameObjects[j].HomeTeam,
                            Score = new string(charArray)
                        };
                    }
                }
            }

            var grouped = gameObjects.GroupBy(x => x.Id);

            foreach (var group in grouped)
            {
                if (group.Count() < 2)
                    continue;

                var predictions = DoPrediction(group.ToList());
            }

            //foreach (var line in lines)
            //{
            //    string[] data = line.Split(" ");

            //    GamePrediction matchPrediction = new GamePrediction
            //    {
            //        HomeTeam = data.FirstOrDefault(),
            //        AwayTeam = data.LastOrDefault(),
            //        Score = data[1]
            //    };

            //    predictions.Add(matchPrediction);
            //}

            //var grouped = predictions.GroupBy(x => x.GameId);

            //List<Prediction> finalPredictions = new();

            //foreach (var group in grouped)
            //{
            //    var games = group.ToList();

            //    Prediction pred = new Prediction(games);
            //    finalPredictions.Add(pred);
            //}

            //_ = finalPredictions.Count();
        }

        private PredictionObject DoPrediction(List<GameObject> gameObjects)
        {
            string predictions = string.Empty;

            string homeTeam = gameObjects.FirstOrDefault().HomeTeam;
            string awayTeam = gameObjects.FirstOrDefault().AwayTeam;
            List<string> scores = new();

            for (int i = 0; i < gameObjects.Count; i++)
            {
                scores.Add(gameObjects[i].Score);
            }

            return new PredictionObject(homeTeam, awayTeam, scores);
        }

        public GamePrediction GetGroupPrediction(List<GamePrediction> groupedPredictions)
        {
            int awayTeamWins = groupedPredictions.GetAwayTeamWins();
            int homeTeamWins = groupedPredictions.GetHomeTeamWins();

            List<string> scores = new();

            foreach (var item in groupedPredictions)
            {
                scores.Add(item.Score);
            }

            string finalScore = scores.GetFinalScore();

            return null;
        }
    }
}
