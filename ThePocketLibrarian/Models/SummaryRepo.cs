using System;
using Newtonsoft.Json.Linq;
using Org.BouncyCastle.Utilities;

namespace ThePocketLibrarian.Models
{
	public class SummaryRepo: ISummaryRepo
	{
        public string GetSummary(string title, string author)
        {
            var client = new HttpClient();

            var googleAPIKey = "GoogleApiKey";

            var googleURL = $"https://www.googleapis.com/books/v1/volumes?q=\"{title}\"+inauthor:{author}&key={googleAPIKey}";

            var googleResponse = client.GetStringAsync(googleURL).Result;

            var googleObject = JObject.Parse(googleResponse);

            Summary result = googleObject.ToObject(typeof(Summary)) as Summary;

            return result.items[0].volumeInfo.description;
        } 
    }
}
// need to make sure something will happen if no attributes selected or no genres selected
