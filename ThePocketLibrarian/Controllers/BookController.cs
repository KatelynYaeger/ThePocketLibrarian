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

        //[HttpGet]
        //public ActionResult Index2()
        //{
        //    Book genres = new Book();
        //    return View(genres.Characteristics.ToList());
        //}

    }
}

