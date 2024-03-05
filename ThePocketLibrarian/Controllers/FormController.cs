using Microsoft.AspNetCore.Mvc;
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
            if (Genre.Length == 0 || Genre is null && Attributes.Length == 0 || Attributes is null)
                {
                var results = bookrepo.GetBookWithNoOptionsChosen();

                SummaryRepo summaryRepo = new SummaryRepo();

                foreach (var book in results)
                {
                    book.Description = summaryRepo.GetSummary(book.ISBN, book.Title, book.Author);
                        
                }
                return View(results);
                }

            if (Genre.Length == 0 || Genre == null)
            {
                var results = bookrepo.GetBookWithoutGenre(Attributes);

                SummaryRepo summaryRepo = new SummaryRepo();

                foreach (var book in results)
                {
                    book.Description = summaryRepo.GetSummary(book.ISBN, book.Title, book.Author);
                }
                return View(results);
            }

            if (Attributes.Length == 0 || Attributes == null)
            {
                var results = bookrepo.GetBookWithoutAttrib(Genre);

                SummaryRepo summaryRepo = new SummaryRepo();

                foreach (var book in results)
                {
                    book.Description = summaryRepo.GetSummary(book.ISBN, book.Title, book.Author);
                }
                return View(results);
            }

            else
            {
                var results = bookrepo.GetBookWithGenreAndAttrib(Genre, Attributes);

                SummaryRepo summaryRepo = new SummaryRepo();

                foreach (var book in results)
                { 
                    book.Description = summaryRepo.GetSummary(book.ISBN, book.Title, book.Author);
                }
                return View(results);
            }
        }
    }
}

