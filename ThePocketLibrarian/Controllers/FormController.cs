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
            return View();
        }

    }

}
