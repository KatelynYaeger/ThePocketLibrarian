using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ThePocketLibrarian;
using ThePocketLibrarian.Models;

namespace ThePocketLibrarian.Controllers
{
    public class FormController : Controller
    {
        [HttpPost]
        public IActionResult FormOptions(string[] Genre, string[] Attributes)
        {
            string genreString = "genre in ('" + Genre.Aggregate((p, n) => p + "','" + n) + "')";
            string attribString = "MATCH(CHARACTERISTICS) against ('" + Attributes.Aggregate((p, n) => p + "','" + n) + "')";

            return View();
        }

        private readonly IBookRepo repo;

        public IActionResult Index()
        {
            var books = repo.GetTheRightBook();

            return View(books);
        }
    }

}






//for (int i = 0; i < Genre.Count(); i++)
//{

//}


//Need to :
//- Pull items from array and use for query
//  * Maybe use array.Count to see how many elements there are and then put them as variables?
//  *
//- Query database
//- Use title and authorname pulled from database to get summary from API
//- Return the title/author/summary in View.

////foreach (var attrib in attributes)
//{
// 
//}

//Full-Text Search Statement
//SELECT TITLE, AUTHOR, MATCH(CHARACTERISTICS)
//AGAINST(characteristics[i]) 
//AS SCORES FROM BOOKBASE.ATTRIBUTES
//WHERE GENRE = "genre[i]"
//ORDER BY scores DESC;

