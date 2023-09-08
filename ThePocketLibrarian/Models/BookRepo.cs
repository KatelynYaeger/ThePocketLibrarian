using System;
using System.Data;
using System.Data.Common;
using Dapper;
using Newtonsoft.Json.Linq;

namespace ThePocketLibrarian
{
    public class BookRepo : IBookRepo
    {
        private readonly IDbConnection _connection;

        public BookRepo(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Book> GetTheRightBook()
        {
            return _connection.Query<Book>("SELECT TITLE, AUTHOR attribString as scores" +
                "FROM BOOKBASE.ATTRIBUTES where genreString order by scores DESC;");
        }

        // genreString= "genre in ('" + Genre.Aggregate((p, n) => p + "','" + n) + "')";
        // attribString = "MATCH(CHARACTERISTICS) against ('" + Attributes.Aggregate((p, n) => p + "','" + n) + "')";

    }
}

//Full-Text Search Statement
//SELECT TITLE, AUTHOR, MATCH(CHARACTERISTICS)
//AGAINST('Romance1-12' 'POV1-4' 'Setting1-3' 'Protatonist1-2' 'Tropes1-10') 
//AS SCORES FROM BOOKBASE.ATTRIBUTES
//WHERE GENRE = "YOUNG ADULT"
//ORDER BY scores DESC;