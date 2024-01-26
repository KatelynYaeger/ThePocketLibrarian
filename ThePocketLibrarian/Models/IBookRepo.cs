namespace ThePocketLibrarian
{
    public interface IBookRepo
    {
        IEnumerable<Book> GetTheRightBook(string[] Genre, string[] Attributes);
        IEnumerable<Book> BookWithoutAttrib(string[] Genre);
        IEnumerable<Book> BookWithoutGenre(string[] Attributes);
        IEnumerable<Book> NoOptionsChosen();

    }
}