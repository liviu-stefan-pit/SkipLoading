using IBetForYou.Models;
using IBetForYou.Scrappers;
using PuppeteerSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IBetForYou.Services
{
    public class ScrappersManagingService
    {
        private ForebetScrapper _forebetScrapper;

        private PredictzScrapper _predictzScrapper;

        private WinDrawWinScrapper _winDrawWinScrapper;

        private IBrowser? _browser;

        private List<QueryResult?> _results;

        public List<QueryResult?> Results => _results;

        public ScrappersManagingService()
        {
            _results = new();

            InitializeWebBrowser();

            _forebetScrapper = new ForebetScrapper(_browser);
            _predictzScrapper = new PredictzScrapper(_browser);
            _winDrawWinScrapper = new WinDrawWinScrapper(_browser);

            _ = GetData();
        }

        private async Task GetData()
        {
            var forebetResult = await _forebetScrapper.GetWebsiteData();
            var predictzResult = await  _predictzScrapper.GetWebsiteData();
            var wdwResult = await _winDrawWinScrapper.GetWebsiteData();

            _results.Add(forebetResult);
            _results.Add(predictzResult);
            _results.Add(wdwResult);

            await _browser.CloseAsync();
        }

        private void InitializeWebBrowser()
        {
            using var browserFetcher = new BrowserFetcher();
            browserFetcher.DownloadAsync(BrowserFetcher.DefaultChromiumRevision);

            var launchOptions = new LaunchOptions()
            {
                Headless = false
            };

            _browser = Puppeteer.LaunchAsync(launchOptions).Result;
        }
    }
}