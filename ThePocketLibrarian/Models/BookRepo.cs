using System;
using System.Data;
using System.Data.Common;
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

        public IEnumerable<Book> GetTheRightBook(string[] Genre, string[] Attributes)
        {
            var attribString = "MATCH(CHARACTERISTICS) against ('" + Attributes.Aggregate((p, n) => p + "' '" + n) + "')";
            var genreString = "genre in ('" + Genre.Aggregate((p, n) => p + "','" + n) + "')";
            string qry = string.Format("SELECT TITLE, AUTHOR, {0} as scores FROM BOOKBASE.ATTRIBUTES where {1} order by scores DESC limit 5;", attribString, genreString);

            return _connection.Query<Book>(qry);
        } 
    }
}

//Full-Text Search Statement
//SELECT TITLE, AUTHOR, MATCH(CHARACTERISTICS)
//AGAINST('Romance1-12' 'POV1-4' 'Setting1-3' 'Protatonist1-2' 'Tropes1-10') 
//AS SCORES FROM BOOKBASE.ATTRIBUTES
//WHERE GENRE = "YOUNG ADULT"
//ORDER BY scores DESC;