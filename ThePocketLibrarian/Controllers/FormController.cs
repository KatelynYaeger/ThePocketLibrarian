using System.Data.Common;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Org.BouncyCastle.Asn1.Cms;
using ThePocketLibrarian;
using ThePocketLibrarian.Models;

namespace ThePocketLibrarian.Controllers
{
    public class FormController : Controller
    {
        private readonly IBookRepo bookrepo;

        public FormController(IBookRepo repo)
        {
            this.bookrepo = repo;
        }

        [HttpPost]
        public IActionResult FormOptions(string[] Genre, string[] Attributes)
        {
            var results = bookrepo.GetTheRightBook(Genre, Attributes);

            SummaryRepo summaryRepo = new SummaryRepo();

            foreach(var book in results)
            { 
                book.Description = summaryRepo.GetSummary(book.Title, book.Author);
            }

            return View(results);
        }
    }

}

//

//Need to :
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

