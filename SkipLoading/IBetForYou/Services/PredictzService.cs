﻿using PuppeteerSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace IBetForYou.Services
{
    public class PredictzService
    {
        public async Task<List<GamePrediction>> GetAlmostSurebets(bool nextDay = false)
        {
            var predictions = await GetWebsiteData(nextDay);
            List<GamePrediction> sureGames = new List<GamePrediction>();

            foreach (var item in predictions)
            {
                string[] score = item.Score.Split("-");
                int.TryParse(score.FirstOrDefault(), out int hts);
                int.TryParse(score.LastOrDefault(), out int ats);

                if(Math.Abs(hts - ats) >= 2)
                {
                    sureGames.Add(item);

                    if(hts != 0 && ats != 0)
                    {
                        if(hts > ats)
                        {
                            item.SafeSuggestion = "1X";
                        }else
                        {
                            item.SafeSuggestion = "X2";
                        }
                    }
                }
            }

            return sureGames;
        }

        public async Task<List<GamePrediction>> GetWebsiteData(bool nextDay = false)
        {
            using var browserFetcher = new BrowserFetcher();
            await browserFetcher.DownloadAsync(BrowserFetcher.DefaultChromiumRevision);

            string url = nextDay ? Constants.PredictZTomorrow : Constants.PredictZ;

            List<GamePrediction> predictions = new List<GamePrediction>();

            var launchOptions = new LaunchOptions()
            {
                Headless = false
            };

            using (var browser = await Puppeteer.LaunchAsync(launchOptions))
            using (var page = await browser.NewPageAsync())
            {
                var waitUntil = new WaitUntilNavigation[] { WaitUntilNavigation.Networkidle2 };
                await page.GoToAsync(url, waitUntil: waitUntil);

                string[] queryResult = await GetQueryResultAsync(page);

                for (int i = 0; i < queryResult.Length; i += 3)
                {
                    string[] result = queryResult[i + 1].Split(" ");

                    //predictions.Add(new GamePrediction
                    //{
                    //    HomeTeam = queryResult[i],
                    //    AwayTeam = queryResult[i + 2],
                    //    FinalResult = GetFinalResult(result[0]),
                    //    Score = GetScore(result[1])
                    //});
                }
            }

            return predictions;
        }

        private static async Task<string[]> GetQueryResultAsync(IPage page)
        {
            var jsSelectAllAnchors = @"Array.from(document.querySelectorAll("".pttd.ptmobh, .pttd.ptmoba, .pttd.ptprd""))
                            .map(d => d.innerText);";
            var queryResult = await page.EvaluateExpressionAsync<string[]>(jsSelectAllAnchors);
            return queryResult;
        }

        private string? GetScore(string result)
        {
            return result.Split('\n').FirstOrDefault();
        }

        private int GetFinalResult(string result)
        {
            int finalResult;

            if (result == "Home")
            {
                finalResult = 1;
            }
            else if (result == "Away")
            {
                finalResult = 2;
            }
            else
            {
                finalResult = 0;
            }

            return finalResult;
        }
    }
}
