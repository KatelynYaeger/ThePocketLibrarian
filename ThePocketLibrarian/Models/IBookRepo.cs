namespace ThePocketLibrarian
{
    public interface IBookRepo
    {
        IEnumerable<Book> GetBookWithGenreAndAttrib(string[] Genre, string[] Attributes);
        IEnumerable<Book> GetBookWithoutAttrib(string[] Genre);
        IEnumerable<Book> GetBookWithoutGenre(string[] Attributes);
        IEnumerable<Book> GetBookWithNoOptionsChosen();

    }
}