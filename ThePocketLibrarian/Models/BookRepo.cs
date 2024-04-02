using System.Data;
using Dapper;
using Newtonsoft.Json.Linq;
using Org.BouncyCastle.Asn1.Cms;

namespace ThePocketLibrarian
{
    public class BookRepo : IBookRepo
    {
        private readonly IDbConnection _connection;

        public BookRepo(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Book> GetBookWithGenreAndAttrib(string[] Genre, string[] Attributes)
        {
            var attribString = "MATCH(CHARACTERISTICS) against ('" + Attributes.Aggregate((p, n) => p + "' '" + n) + "')";
            var genreString = "genre in ('" + Genre.Aggregate((p, n) => p + "','" + n) + "')";
            string qry = string.Format("SELECT TITLE, AUTHOR, ISBN, LINK, {0} as scores FROM BOOKBASE.ATTRIBUTES where {1} order " +
                "by scores DESC limit 5;", attribString, genreString);

            return _connection.Query<Book>(qry);
        }

        public IEnumerable<Book> GetBookWithoutGenre(string[] Attributes)
        {
            var attribString = "MATCH(CHARACTERISTICS) against ('" + Attributes.Aggregate((p, n) => p + "' '" + n) + "')";

            string qry = string.Format("SELECT TITLE, AUTHOR, ISBN, LINK, {0} as scores FROM BOOKBASE.ATTRIBUTES order by scores DESC limit " +
                "5;", attribString);

            return _connection.Query<Book>(qry);
        }

        public IEnumerable<Book> GetBookWithoutAttrib(string[] Genre)
        {
            var genreString = "genre in ('" + Genre.Aggregate((p, n) => p + "','" + n) + "')";

            string qry = string.Format("SELECT TITLE, AUTHOR, ISBN, LINK, FROM BOOKBASE.ATTRIBUTES where {0} order by RAND() LIMIT 5;", genreString);

            return _connection.Query<Book>(qry);
        }

        public IEnumerable<Book> GetBookWithNoOptionsChosen()
        {
            string qry = string.Format("SELECT TITLE, AUTHOR, ISBN, LINK, FROM BOOKBASE.ATTRIBUTES order by RAND() limit 5;");

            return _connection.Query<Book>(qry);
        }
    }
}
