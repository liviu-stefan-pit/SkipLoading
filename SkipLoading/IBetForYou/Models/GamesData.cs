using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBetForYou.Models
{
    public class GamesData
    {
        private readonly string _filePath;

        public List<MatchPrediction> Games => GetGamesData();

        public GamesData(string dataFilePath)
        {
            _filePath = dataFilePath;
        }

        /// <summary>
        /// Gets the games data from txt file. Rows format must be "T1:Score:T2"
        /// </summary>
        /// <returns>The list of games</returns>
        private List<MatchPrediction> GetGamesData()
        {
            if (File.Exists(_filePath))
            {
                List<string> lines = File.ReadAllLines(_filePath).ToList();
                List<MatchPrediction> predictions = new List<MatchPrediction>();

                foreach (var line in lines)
                {
                    string[] data = line.Split(":");

                    MatchPrediction matchPrediction = new MatchPrediction
                    {
                        HomeTeam = data.FirstOrDefault(),
                        AwayTeam = data.LastOrDefault(),
                        ScorePrediction = data[1]
                    };

                    predictions.Add(matchPrediction);
                }

                return predictions;
            }

            return new List<MatchPrediction>();
        }
    }
}
