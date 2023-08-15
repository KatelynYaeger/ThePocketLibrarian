using System;
using System.Reflection.PortableExecutable;

namespace ThePocketLibrarian
{
	public class Book
	{
		public Book()
		{
		}

		public int BookID { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		public string Genre { get; set; }
		public bool IsSelected {get;set;}
		public string Characteristics { get; set; }

	}
}

//if (Genre.IsSelect = 0)
//{
//	then do move to full text search
//}

//if (Characteristics.IsSelected = 0)
//{
//	Then return top 3 books
//}

//Genre statement
//select* from bookbase.attributes
//where genre = "Alternate History" or genre = "Apocalyptic" or genre ="Childrens"
//or genre ="Fairytale" or genre ="Fantasy" or genre = "General Fiction" or
//genre = "Gothic" or genre = "Historical Fiction" or genre = "Legal Thriller" or 
//genre = "Mystery" or genre = "Romance" or genre = "Science Fiction" or genre
//= "Thriller" or genre = "Young Adult";

//Full-Text Search Statement
//SELECT bookid, TITLE, AUTHOR, MATCH(CHARACTERISTICS)
//AGAINST('FIRST PERSON' 'LOVE TRIANGLE' 'REVOLUTION' 'DARK/SUNNY' 'STAR CROSSED LOVERS') 
//AS SCORES FROM BOOKBASE.ATTRIBUTES
//WHERE GENRE = "YOUNG ADULT"
//ORDER BY scores DESC;