using System.Data;
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

        public IEnumerable<Book> GetTheRightBook(string[] Genre, string[] Attributes)
        {
            var attribString = "MATCH(CHARACTERISTICS) against ('" + Attributes.Aggregate((p, n) => p + "' '" + n) + "')";
            var genreString = "genre in ('" + Genre.Aggregate((p, n) => p + "','" + n) + "')";
            string qry = string.Format("SELECT TITLE, AUTHOR, {0} as scores FROM BOOKBASE.ATTRIBUTES where {1} order by scores DESC limit 5;", attribString, genreString);

            return _connection.Query<Book>(qry);
        }

        public IEnumerable<Book> BookWithoutGenre(string[] Attributes)
        {
            var attribString = "MATCH(CHARACTERISTICS) against ('" + Attributes.Aggregate((p, n) => p + "' '" + n) + "')";

            string qry = string.Format("SELECT TITLE, AUTHOR, {0} as scores FROM BOOKBASE.ATTRIBUTES order by scores DESC limit 5;", attribString);

            return _connection.Query<Book>(qry);
        }

        public IEnumerable<Book> BookWithoutAttrib(string[] Genre)
        {
            var genreString = "genre in ('" + Genre.Aggregate((p, n) => p + "','" + n) + "')";

            string qry = string.Format("SELECT TITLE, AUTHOR FROM BOOKBASE.ATTRIBUTES where {0} order by author DESC limit 5;", genreString);

            return _connection.Query<Book>(qry);
        }

        public IEnumerable<Book> NoOptionsChosen()
        {
            string qry = string.Format("SELECT TITLE, AUTHOR FROM BOOKBASE.ATTRIBUTES order by title limit 5;");

            return _connection.Query<Book>(qry);
        }
    }
}
