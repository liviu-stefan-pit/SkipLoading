namespace StuffGenerator.API_Football
{
    public class FootballApi
    {
        public async Task TestAPI()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api-football-v1.p.rapidapi.com/v3/timezone"),
                Headers =
    {
        { "X-RapidAPI-Key", "e987beb6a8msh8846b7b8ed2a572p1d5b76jsnb50f3925e59a" },
        { "X-RapidAPI-Host", "api-football-v1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }
        }
    }
}