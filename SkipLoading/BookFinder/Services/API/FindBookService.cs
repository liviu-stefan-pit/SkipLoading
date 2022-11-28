using BookFinder.Services.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookFinder.Services.API
{
    public class FindBookService
    {
        public async Task GetBook(string isbn)
        {
            using (HttpClient client = new HttpClient())
            {
                string requestUri = $"https://www.googleapis.com/books/v1/volumes?q={isbn}+isbn";

                HttpResponseMessage apiResponse = await client.GetAsync(requestUri);

                string jsonResponse = await apiResponse.Content.ReadAsStringAsync();

                Root apiCountries = JsonSerializer.Deserialize<Root>(jsonResponse, new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });

                //return apiCountries.Take(amountOfCountries).Select(apiCountry => new CoronavirusCountry()
                //{
                //    CountryName = apiCountry.Country,
                //    CaseCount = apiCountry.Cases,
                //    FlagUri = apiCountry.CountryInfo.Flag
                //});
            }
        }
    }
}
