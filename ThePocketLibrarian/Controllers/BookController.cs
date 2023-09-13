using System;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using ThePocketLibrarian.Models;

namespace ThePocketLibrarian.Controllers
{
	public class BookController : Controller
	{
        private readonly IBookRepo repo;

        public BookController(IBookRepo repo)
        {
            this.repo = repo;
        }

        //public IActionResult Index()
        //{
        //    var books = repo.GetTheRightBook();

        //    return View(books);
        //}

        private readonly SummaryRepo repos;

        [HttpPost]

        public IActionResult ViewBook()
        {
            return Content("{genre1}");
        }
    }
}

