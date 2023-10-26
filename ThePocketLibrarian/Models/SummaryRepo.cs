using System;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using Org.BouncyCastle.Utilities;
using System.Configuration;

namespace ThePocketLibrarian.Models
{
    public class SummaryRepo : ISummaryRepo
    { 
        public string GetSummary(string ISBN, string Title, string Author)
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

            var apiKey = apiSettings.Value.GoogleAPIKey;

            var client = new HttpClient();

            var googleURL = $"https://www.googleapis.com/books/v1/volumes?q={Title}+inauthor:{Author}+isbn:{ISBN}&key={apiKey}";

            var googleResponse = client.GetStringAsync(googleURL).Result;

            var googleObject = JObject.Parse(googleResponse);

            Summary result = googleObject.ToObject(typeof(Summary)) as Summary;

            return result.items[0].volumeInfo.description;
        }
    }
}
