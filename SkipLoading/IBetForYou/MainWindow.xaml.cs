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
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //PredictzService predictzService = new PredictzService();
            //var games = await predictzService.GetAlmostSurebets(true);

            FootballPredictionsService footballPredictionsService = new FootballPredictionsService();
            var games2 = await footballPredictionsService.GetWebsiteData();

            //SerializeToJson(games);

            //List<ListViewItem> viewItems = new();

            //foreach (var item in games)
            //{
            //    ListViewItem game = new ListViewItem();
            //    game.Content = item;

            //    string[] score = item.ScorePrediction.Split("-");
            //    int.TryParse(score.FirstOrDefault(), out int hts);
            //    int.TryParse(score.LastOrDefault(), out int ats);

            //    if(hts == ats)
            //    {
            //        game.Background = Brushes.Yellow;
            //    }else if(hts > ats)
            //    {
            //        game.Background = Brushes.LightGreen;
            //    }
            //    else
            //    {
            //        game.Background = Brushes.Red;
            //    }

            //    viewItems.Add(game);
            //}

            //this.lstGames.ItemsSource = viewItems;
        }

        private void SerializeToJson(List<MatchPrediction> viewItems)
        {
            string json = JsonSerializer.Serialize(viewItems);

            File.WriteAllText($"SafePredictions-{DateTime.Now.Day}-{DateTime.Now.Month}.json", json);
        }
    }
}
