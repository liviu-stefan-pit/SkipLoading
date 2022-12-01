using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PuppeteerSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace IBetForYou
{
    public class Scrapper
    {
        private static string CallUrl(string fullUrl)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("user-agent",
        "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)");
            var response = client.GetStringAsync(fullUrl).Result;
            return response;
        }

        public async Task<string> GetPageAsStringAsync(string url)
        {
            HttpClient x = new HttpClient();
            x.DefaultRequestHeaders.Add("user-agent",
                "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)");
            HttpResponseMessage response = await x.GetAsync(url);
            string content = await response.Content.ReadAsStringAsync();
            return content;
        }

        public async Task Scrape()
        {
            string url = Constants.PredictZ;
            var response = GetPageAsStringAsync(url);
            //var test = ParseHtml(response);

            string site = await GetPageAsStringAsync(Constants.PredictZ);

            //SeleniumScrape();
            //await ScrapingPuppets();
        }

        private List<string> ParseHtml(string html)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

           // var programmerLinks1 = htmlDoc.DocumentNode.SelectNodes("//li[not(contains(@class, 'tocsection'))]");

            var programmerLinks = htmlDoc.DocumentNode.Descendants("li")
                .Where(node => !node.GetAttributeValue("class", "").Contains("tocsection"))
                .ToList();

            List<string> wikiLink = new List<string>();

            foreach (var link in programmerLinks)
            {
                if (link.FirstChild.Attributes.Count > 0) wikiLink.Add("https://en.wikipedia.org/" + link.FirstChild.Attributes[0].Value);
            }

            return wikiLink;
        }

        private void WriteToCsv(List<string> links)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var link in links)
            {
                sb.AppendLine(link);
            }

            System.IO.File.WriteAllText("links.csv", sb.ToString());
        }

        public void SeleniumScrape()
        {
            string fullUrl = Constants.PredictZ;
            List<string> footballGames = new List<string>();

            var options = new ChromeOptions()
            {
                BinaryLocation = @"C:\Program Files\Google\Chrome\Application\chrome.exe"
            };

            options.AddArguments(new List<string>() { "headless", "disable-gpu" });

            var browser = new ChromeDriver(options);
            browser.Navigate().GoToUrl(fullUrl);

            var links = browser.FindElements(By.CssSelector("pttr.ptcnt"));
            foreach (var url in links)
            {
                footballGames.Add(url.GetAttribute("href"));
            }

            //WriteToCsv(footballGames);
        }

        public async Task ScrapingPuppets()
        {
            string fullUrl = Constants.PredictZ;

            List<string> programmerLinks = new List<string>();

            var options = new LaunchOptions()
            {
                Headless = true,
                ExecutablePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe"
            };

            var browser = await Puppeteer.LaunchAsync(options);
            var page = await browser.NewPageAsync();
            await page.GoToAsync(fullUrl);

            var links = @"Array.from(document.querySelectorAll('li:not([class^=""toc""]) a')).map(a => a.href);";
            var urls = await page.EvaluateExpressionAsync<string[]>(links);

            foreach (string url in urls)
            {
                programmerLinks.Add(url);
            }

            WriteToCsv(programmerLinks);
        }

        public async Task TakeScreenshot()
        {
            using var browserFetcher = new BrowserFetcher();
            await browserFetcher.DownloadAsync(BrowserFetcher.DefaultChromiumRevision);
            var url = "https://www.predictz.com/predictions/";
            var file = "test.jpg";

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

                var jsSelectAllAnchors = @"Array.from(document.querySelectorAll("".pttd.ptmobh, .pttd.ptmoba, .pttd.ptprd""))
                            .map(d => d.innerText);";
                var queryResult = await page.EvaluateExpressionAsync<string[]>(jsSelectAllAnchors);

                for (int i = 0; i < queryResult.Length; i+=3)
                {
                    string[] result = queryResult[i + 1].Split(" ");
                    int finalResult = 0;

                    if (result[0] == "Home")
                    {
                        finalResult = 1;
                    }else if (result[0] == "Away")
                    {
                        finalResult = 2;
                    }
                    else
                    {
                        finalResult = 0;
                    }

                    string score = result[1].Split('\n').FirstOrDefault();

                    //predictions.Add(new GamePrediction
                    //{
                    //    HomeTeam = queryResult[i],
                    //    AwayTeam = queryResult[i + 2],
                    //    FinalResult = finalResult,
                    //    Score = score
                    //});
                }

                var t = predictions.Count;
                //await page.ScreenshotAsync(file);
            }
        }
    }
}
