using CatBet.Models.Enums;
using System.Text.Json;

namespace CatBet.Services
{
    public class DataService
    {
        public T? GetLocalData<T>(JsonSelector json)
        {
            //for every new json you add, do not forget to set its properties to copy if newer or always
            if (json == JsonSelector.Fixtures)
            {
                return JsonSerializer.Deserialize<T>(GetJson(@"ApiData\fixtures.json"), new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }
            else if (json == JsonSelector.FixturesHeadToHead)
            {
                return JsonSerializer.Deserialize<T>(GetJson(@"ApiData\fixturesHeadToHead.json"), new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }
            else
            {
                return default(T);
            }
        }

        private string GetJson(string filePath)
        {
            if (File.Exists(filePath))
            {
                string result = File.ReadAllText(filePath);
                return result;
            }

            return string.Empty;
        }
    }
}