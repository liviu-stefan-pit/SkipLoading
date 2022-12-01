using IBetForYou.Models;
using PuppeteerSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBetForYou.Scrappers
{
    public interface IScrapper
    {
        Task<string[]> GetQueryResultTeams(IPage page);

        Task<string[]> GetQueryResultScore(IPage page);

        Task<QueryResult> GetWebsiteData();
    }
}
