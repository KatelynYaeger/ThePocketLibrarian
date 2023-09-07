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
            return _connection.Query<Book>("SELECT TITLE, AUTHOR FROM BOOKBASE.ATTRIBUTES" +
                " where Genre = @genre1 or Genre = @genre2 or Genre = @genre3 or Genre = @genre4" +
                " or Genre = @genre5 or Genre = @genre6 or Genre = @genre7 or Genre = @genre8" +
                " or Genre = @genre9 or Genre = @genre10 or Genre = @genre11 or Genre = @genre12" +
                " or Genre = @genre13 or Genre = @genre14;");
        }
    }
}

