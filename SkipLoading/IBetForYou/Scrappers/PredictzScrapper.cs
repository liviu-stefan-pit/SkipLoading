using IBetForYou.Models;
using PuppeteerSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBetForYou.Scrappers
{
    public class PredictzScrapper 
    {
        private static string TeamsQuery =
           "document.querySelectorAll(\".pttd.ptgame\")";
        private string ScoreQuery =
            "document.querySelectorAll(\".pttd.ptprd\")";

        private IBrowser? _browser;

        public PredictzScrapper(IBrowser? browser)
        {
            _browser = browser;
        }

        public async Task<IEnumerable<string>> GetQueryResultTeams(IPage page)
        {
            var jsSelectAllAnchors = $@"Array.from({TeamsQuery})
                            .map(t => t.firstChild.innerText);";
            var queryResult = await page.EvaluateExpressionAsync<string[]>(jsSelectAllAnchors);
            return queryResult;
        }

        public async Task<IEnumerable<string>> GetQueryResultScore(IPage page)
        {
            var jsSelectAllAnchors = $@"Array.from({ScoreQuery})
                            .map(t => t.firstChild.innerText);";
            var queryResult = await page.EvaluateExpressionAsync<string[]>(jsSelectAllAnchors);
            return queryResult;
        }

        public async Task<QueryResult> GetWebsiteData()
        {
            using (var page = await _browser.NewPageAsync())
            {
                var waitUntil = new WaitUntilNavigation[] { WaitUntilNavigation.Networkidle2 };

                await page.GoToAsync(Constants.PredictZ, waitUntil: waitUntil);

                await page.SetViewportAsync(new ViewPortOptions
                {
                    Width = 1000,
                    Height = 500
                });

                IEnumerable<string> teams = await GetQueryResultTeams(page);
                IEnumerable<string> scores = await GetQueryResultScore(page);

                return new QueryResult(teams, scores, Models.Enums.Website.PredictZ);
            }
        }
    }
}
