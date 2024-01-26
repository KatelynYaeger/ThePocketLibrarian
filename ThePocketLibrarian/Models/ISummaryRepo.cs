namespace ThePocketLibrarian.Models
{
	public interface ISummaryRepo
	{
        public string GetSummary(string ISBN, string Title, string Author);
    }
}

