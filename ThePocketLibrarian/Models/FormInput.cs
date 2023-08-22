using Dapper;
using System.Data;

namespace ThePocketLibrarian.Models
{
	public class FormInput
	{
		public string Genre { get; set; }
        public string Characteristics { get; set; }

        private readonly IDbConnection _conn;

        public FormInput(IDbConnection connection)
        {
            _conn = connection;
        }

        public IEnumerable<Book> SaveDetails()
        {
            string query = "select title, author, genre, characteristics, MATCH(CHARACTERISTICS) AGAINST('Romance1' " +
                "'Romance2' 'Romance3' 'Romance4''Romance5' 'Romance6' 'Romance7' 'Romance8' 'Romance9' 'Romance10' " +
                "'Romance11' 'Romance12' 'POV1' 'POV2' 'POV3' 'POV4' 'Setting1' 'Setting2' 'Setting3' 'Protagonist1' " +
                "'Protagonist2' 'Tropes1' 'Tropes2' 'Tropes3' 'Tropes4' 'Tropes5' 'Tropes6' 'Tropes7' 'Tropes8' " +
                "'Tropes9' 'Tropes10') " +
                "AS SCORES from bookbase.attributes where Genre = @genre1 or Genre = @genre2 or Genre = @genre3 or " +
                "Genre = @genre4 or Genre = @genre5 or Genre = @genre6 or Genre = @genre7 or Genre = @genre8 or " +
                "Genre = @genre9 or Genre = @genre10 or Genre = @genre11 or Genre = @genre12 or Genre = @genre13 or " +
                "Genre = @genre14 " +
                "ORDER BY scores DESC limit 3;";

            return _conn.Query<Book>(query);

        }
    }
}


