using System;
namespace ThePocketLibrarian
{
	public interface IBookRepo
	{
        IEnumerable<Book> GetAllBooks();
    }
}

