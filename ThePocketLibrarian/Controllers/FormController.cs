using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ThePocketLibrarian;
using ThePocketLibrarian.Models;

namespace ThePocketLibrarian.Controllers
{
    public class FormController : Controller
    {
        public IActionResult FormResults(FormModel model)
        {
            return Content($"You have chosen {model.Genre}");
        }

        
    }

}
