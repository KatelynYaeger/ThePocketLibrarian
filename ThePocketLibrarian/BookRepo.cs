using System;
using System.Data;
using System.Data.Common;
using Dapper;

namespace ThePocketLibrarian
{
	public class BookRepo: IBookRepo
	{
        private readonly IDbConnection _connection;

        public BookRepo(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _connection.Query<Book>("SELECT * FROM BOOKBASE.ATTRIBUTES;");
        }
    }
}

