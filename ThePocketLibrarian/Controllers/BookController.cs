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

        public IActionResult Index()
        {
            var books = repo.GetTheRightBook();

            return View(books);
        }

        private readonly SummaryRepo repos;

        [HttpPost]

        public IActionResult ViewBook()
        {
            return Content("{genre1}");

            return View();
        }

        

        //[HttpPost]
        //public IActionResult GetDetails()
        //{
        //    UserDataModel umodel = new UserDataModel();
        //    umodel.Name = HttpContext.Request.Form["txtName"].ToString();
        //    umodel.Age = Convert.ToInt32(HttpContext.Request.Form["txtAge"]);
        //    umodel.City = HttpContext.Request.Form["txtCity"].ToString();
        //    int result = umodel.SaveDetails();
        //    if (result > 0)
        //    {
        //        ViewBag.Result = "Data Saved Successfully";
        //    }
        //    else
        //    {
        //        ViewBag.Result = "Something Went Wrong";
        //    }
        //    return View("Profile");
        //}


        //[HttpPost]
        //public ActionResult Index(CustomerModel customer)
        //{
        //    string constr = ConfigurationManager.ConnectionStrings["Constring"].ConnectionString;
        //    using (SqlConnection con = new SqlConnection(constr))
        //    {
        //        string query = "INSERT INTO Customers(Name, Country) VALUES(@Name, @Country)";
        //        query += " SELECT SCOPE_IDENTITY()";
        //        using (SqlCommand cmd = new SqlCommand(query))
        //        {
        //            cmd.Connection = con;
        //            con.Open();
        //            cmd.Parameters.AddWithValue("@Name", customer.Name);
        //            cmd.Parameters.AddWithValue("@Country", customer.Country);
        //            customer.CustomerId = Convert.ToInt32(cmd.ExecuteScalar());
        //            con.Close();
        //        }
        //    }

        //    return View(customer);
        //}



        //[HttpGet]
        //public ActionResult Index2()
        //{
        //    Book genres = new Book();
        //    return View(genres.Characteristics.ToList());
        //}

    }
}

