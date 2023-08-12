using System;
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
            var books = repo.GetAllBooks();

            return View(books);
        }
    }
}

