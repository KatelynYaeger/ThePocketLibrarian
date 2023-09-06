using Newtonsoft.Json.Linq;

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
        public string Characteristics { get; set; }
    }

}




//Need To:
//1. Check which boxes are checked for genres - DONE
//2. Full text search based on characteristics checked.
//3. Return top three books with title, author, genre, and characteristics, and summary.  


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
//SELECT TITLE, AUTHOR, MATCH(CHARACTERISTICS)
//AGAINST('Romance1-12' 'POV1-4' 'Setting1-3' 'Protatonist1-2' 'Tropes1-10') 
//AS SCORES FROM BOOKBASE.ATTRIBUTES
//WHERE GENRE = "YOUNG ADULT"
//ORDER BY scores DESC;


//select *,
//MATCH(CHARACTERISTICS)
//AGAINST('Romance1' 'Romance2' 'Romance3' 'Romance4' 'Romance5' 'Romance6' 'Romance7' 'Romance8' 'Romance9' 
//'Romance10' 'Romance11' 'Romance12' 'POV1' 'POV2' 'POV3' 'POV4' 'Setting1' 'Setting2' 'Setting3' 'Protagonist1' 
//'Protagonist2' 'Tropes1' 'Tropes2' 'Tropes3' 'Tropes4' 'Tropes5' 'Tropes6' 'Tropes7' 'Tropes8' 'Tropes9' 'Tropes10') 
//AS SCORES from bookbase.attributes
//where Genre = @genre1 or Genre = @genre2 or Genre = @genre3 or Genre = @genre4 or Genre = @genre5 or Genre = @genre6
//or Genre = @genre7 or Genre = @genre8 or Genre = @genre9 or Genre = @genre10 or Genre = @genre11 or Genre = @genre12 
//or Genre = @genre13 or Genre = @genre14
//ORDER BY scores DESC
//limit 3;