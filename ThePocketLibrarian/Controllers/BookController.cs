using System;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace ThePocketLibrarian.Controllers
{
	public class BookController : Controller
	{
        private readonly IBookRepo repo;

        public BookController(IBookRepo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var books = repo.GetTheRightBook();

            return View(books);
        }

        [HttpGet]
        public ActionResult Index2()
        {
            Book genres = new Book();
            return View(genres.Characteristics.ToList());
        }

        [HttpPost]
        public string Index2(IEnumerable<Book> Genre)
        {
            if (Genre.Count(x => x.IsSelected) == 0)
            {
                return "You have not selected any genre";
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("You selected - ");

                foreach (Book genre in Genre)
                {
                    if (genre.IsSelected)
                    {
                        sb.Append(genre.Genre + ", ");
                    }
                }
                sb.Remove(sb.ToString().LastIndexOf(","), 1);
                return sb.ToString();
            }
        }
    }
}

