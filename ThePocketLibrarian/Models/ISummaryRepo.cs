using System;
namespace ThePocketLibrarian.Models
{
	public interface ISummaryRepo
	{
        public string GetSummary(string title, string author);
    }
}

