using System;
using Newtonsoft.Json.Linq;

namespace ThePocketLibrarian
{
    public interface IBookRepo
    {
        IEnumerable<Book> GetTheRightBook(string[] Genre, string[] Attributes);   
    }
}