using System;
using Newtonsoft.Json.Linq;
using Org.BouncyCastle.Utilities;

namespace ThePocketLibrarian.Models
{
	public class SummaryRepo: ISummaryRepo
	{ 
        public void AnswerMethod()
        {
            var client = new HttpClient();

            var title = "";

            var author = "";

            var googleAPIKey = "YourGoogleBooksAPIKey";

            var googleURL = $"https://www.googleapis.com/books/v1/volumes?q={title}intitle+inauthor:{author}&key={googleAPIKey}";

            var googleResponse = client.GetStringAsync(googleURL).Result;

            var googleObject = JObject.Parse(googleResponse);

            Summary _result = googleObject.ToObject(typeof(Summary)) as Summary;

            if (_result != null) _result.GoogleMethod();
        }
    }
}

