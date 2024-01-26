using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;

namespace ThePocketLibrarian.Models
{
    public class SummaryRepo : ISummaryRepo
    {
        public string GetSummary(string ISBN, string Title, string Author)
        {
            var apiKey = apikey;

            var client = new HttpClient();

            var googleURL = $"https://www.googleapis.com/books/v1/volumes?q={Title}+inauthor:{Author}+isbn:{ISBN}&key={apiKey}";

            var googleResponse = client.GetStringAsync(googleURL).Result;

            var googleObject = JObject.Parse(googleResponse);

            Summary result = googleObject.ToObject(typeof(Summary)) as Summary;

            return result.items[0].volumeInfo.description;
        }

        private static string _apikey = null;

        public static string apikey
        {
            get
            {
                if (_apikey == null)
                {
                    var config = new ConfigurationBuilder()
                      .SetBasePath(Directory.GetCurrentDirectory())
                      .AddJsonFile("appsettings.json")
                      .Build();

                    var services = new ServiceCollection()
                       .AddOptions()
                       .Configure<GoogleApi>(config.GetSection("GoogleApi"))
                       .BuildServiceProvider();

                    var apiSettings = services.GetService<IOptions<GoogleApi>>();

                    _apikey = apiSettings.Value.GoogleAPIKey;
                }
                return _apikey;
            }
        }
    }
}
