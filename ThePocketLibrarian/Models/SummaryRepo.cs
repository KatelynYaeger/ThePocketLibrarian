using System;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using Org.BouncyCastle.Utilities;

namespace ThePocketLibrarian.Models
{
	public class SummaryRepo: ISummaryRepo
	{
        public string GetSummary(string ISBN, string Title, string Author)
        {
            var client = new HttpClient();

            var newKey = new GoogleApi();

            var apiKey = newKey.GoogleAPIKey;

            var googleURL = $"https://www.googleapis.com/books/v1/volumes?q={Title}+inauthor:{Author}+isbn:{ISBN}&key={apiKey}";

            var googleResponse = client.GetStringAsync(googleURL).Result;

            var googleObject = JObject.Parse(googleResponse);

            Summary result = googleObject.ToObject(typeof(Summary)) as Summary;

            return result.items[0].volumeInfo.description;
        } 
    }
}
