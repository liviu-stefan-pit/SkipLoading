using IBetForYou.Models;
using PuppeteerSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBetForYou.Scrappers
{
    public class ForebetScrapper : IScrapper
    {
        private static string TeamsQuery =
           "document.querySelectorAll(\".homeTeam, .awayTeam\")";
        private string ScoreQuery =
            "document.querySelectorAll(\".ex_sc.tabonly\")";

        private IBrowser? _browser;

        public ForebetScrapper(IBrowser? browser)
        {
            _browser = browser;
        }

        public async Task<string[]> GetQueryResultTeams(IPage page)
        {
            var jsSelectAllAnchors = $@"Array.from({TeamsQuery})
                            .map(t => t.firstChild.innerText);";
            var queryResult = await page.EvaluateExpressionAsync<string[]>(jsSelectAllAnchors);
            return queryResult;
        }

        public async Task<string[]> GetQueryResultScore(IPage page)
        {
            var jsSelectAllAnchors = $@"Array.from({ScoreQuery})
                            .map(t => t.outerText);";
            var queryResult = await page.EvaluateExpressionAsync<string[]>(jsSelectAllAnchors);
            return queryResult;
        }

        public async Task<QueryResult> GetWebsiteData()
        {
            using (var page = await _browser.NewPageAsync())
            {
                var waitUntil = new WaitUntilNavigation[] { WaitUntilNavigation.Networkidle2 };

                await page.GoToAsync(Constants.Forebet, waitUntil: waitUntil);

                await page.SetViewportAsync(new ViewPortOptions
                {
                    Width = 1000,
                    Height = 500
                });

                string[] teams = await GetQueryResultTeams(page);
                string[] scores = await GetQueryResultScore(page);

                return new QueryResult(teams, scores, Models.Enums.Website.Forebet);
            }
        }
    }
}
