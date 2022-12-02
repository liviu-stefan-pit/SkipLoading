using IBetForYou.Models;
using ICSharpCode.SharpZipLib.Core;
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

        public async Task<IEnumerable<string>> GetQueryResultTeams(IPage page)
        {
            var jsSelectAllAnchors = $@"Array.from({TeamsQuery})
                            .map(t => t.firstChild.innerText);";
            var queryResult = await page.EvaluateExpressionAsync<string[]>(jsSelectAllAnchors);
            return queryResult;
        }

        public async Task<IEnumerable<Score>> QueryTest(IPage page)
        {
            var jsCode = @"() => {
                            const selectors = Array.from(document.querySelectorAll("".ex_sc.tabonly""));
                            return selectors.map( t => {return { queryResultScore: t.outerText }});
                        }";
            var queryResult = await page.EvaluateFunctionAsync<Score[]>(jsCode);
            return queryResult;
        }

        public async Task<IEnumerable<string>> GetQueryResultScore(IPage page)
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

                var test = await QueryTest(page);

                var teams = await GetQueryResultTeams(page);
                var scores = await GetQueryResultScore(page);

                return new QueryResult(teams, scores, Models.Enums.Website.Forebet);
            }
        }
    }
}
