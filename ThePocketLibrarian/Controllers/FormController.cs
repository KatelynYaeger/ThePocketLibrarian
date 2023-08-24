using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Org.BouncyCastle.Asn1.Ocsp;
using ThePocketLibrarian;

namespace ThePocketLibrarian.Controllers
{
    public class FormController : Controller
    {
        [HttpPost]

        public IActionResult Index(FormModel model)
        {
            return Content($"You've chosen {model.genre2}");
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Genres()
        {
            FormModel objGenreModel = new FormModel();
            List<SelectListItem> genres = new List<SelectListItem>();
            genres.Add(new SelectListItem { Text = "genre1", Value = "Alternate History" });
            genres.Add(new SelectListItem { Text = "genre2", Value = "Apocalyptic" });
            genres.Add(new SelectListItem { Text = "genre3", Value = "Childrens" });
            genres.Add(new SelectListItem { Text = "genre4", Value = "Fairytale" });
            genres.Add(new SelectListItem { Text = "genre5", Value = "Fantasy" });
            genres.Add(new SelectListItem { Text = "genre6", Value = "General Fiction" });
            genres.Add(new SelectListItem { Text = "genre7", Value = "Gothic" });
            genres.Add(new SelectListItem { Text = "genre8", Value = "Historical Fiction" });
            genres.Add(new SelectListItem { Text = "genre9", Value = "Legal Thriller" });
            genres.Add(new SelectListItem { Text = "genre10", Value = "Mystery" });
            genres.Add(new SelectListItem { Text = "genre11", Value = "Romance" });
            genres.Add(new SelectListItem { Text = "genre12", Value = "Science Fiction" });
            genres.Add(new SelectListItem { Text = "genre13", Value = "Thriller" });
            genres.Add(new SelectListItem { Text = "genre14", Value = "Young Adult" });
            objGenreModel.Genres = genres;
            return View(objGenreModel);
        }

        public IActionResult Attributes()
        {
            FormModel objAttributeModel = new FormModel();
            List<SelectListItem> attributes = new List<SelectListItem>();

            attributes.Add(new SelectListItem { Text = "romance1", Value = "DARK/SUNNY" });
            attributes.Add(new SelectListItem { Text = "romance2", Value = "ENEMIES TO LOVERS" });
            attributes.Add(new SelectListItem { Text = "romance3", Value = "FAIRYTALE" });
            attributes.Add(new SelectListItem { Text = "romance4", Value = "FAKE RELATIONSHIP" });
            attributes.Add(new SelectListItem { Text = "romance5", Value = "FORBIDDEN LOVE" });
            attributes.Add(new SelectListItem { Text = "romance6", Value = "FRIENDS TO LOVERS" });
            attributes.Add(new SelectListItem { Text = "romance7", Value = "GOTHIC" });
            attributes.Add(new SelectListItem { Text = "romance8", Value = "LOVE TRIANGLE" });
            attributes.Add(new SelectListItem { Text = "romance9", Value = "ROYALTY/COMMONER" });
            attributes.Add(new SelectListItem { Text = "romance10", Value = "SLOW BURN" });
            attributes.Add(new SelectListItem { Text = "romance11", Value = "STAR CROSSED LOVERS" });
            attributes.Add(new SelectListItem { Text = "romance12", Value = "STUCK TOGETHER" });

            attributes.Add(new SelectListItem { Text = "pov1", Value = "FIRST PERSON" });
            attributes.Add(new SelectListItem { Text = "pov2", Value = "DEEP THIRD PERSON" });
            attributes.Add(new SelectListItem { Text = "pov3", Value = "OMNISCIENT" });
            attributes.Add(new SelectListItem { Text = "pov4", Value = "MULTIPLE POINTS OF VIEW" });
            attributes.Add(new SelectListItem { Text = "protagonist1", Value = "FEMALE PROTAGONIST" });
            attributes.Add(new SelectListItem { Text = "protagonist2", Value = "POC PROTAGONIST" });
            attributes.Add(new SelectListItem { Text = "setting1", Value = "FANTASY WORLD" });
            attributes.Add(new SelectListItem { Text = "setting2", Value = "REAL WORLD" });
            attributes.Add(new SelectListItem { Text = "setting3", Value = "DYSTOPIAN" });
            attributes.Add(new SelectListItem { Text = "tropes1", Value = "AMATEUR SLEUTH" });
            attributes.Add(new SelectListItem { Text = "tropes2", Value = "BADA** FEMALE LEAD" });
            attributes.Add(new SelectListItem { Text = "tropes3", Value = "CHOSEN ONE" });
            attributes.Add(new SelectListItem { Text = "tropes4", Value = "DAMSEL IN DISTRESS" });
            attributes.Add(new SelectListItem { Text = "tropes5", Value = "FOUND FAMILY" });
            attributes.Add(new SelectListItem { Text = "tropes6", Value = "QUEST" });
            attributes.Add(new SelectListItem { Text = "tropes7", Value = "REVOLUTION" });
            attributes.Add(new SelectListItem { Text = "tropes8", Value = "RIVALS TO FRIENDS" });
            attributes.Add(new SelectListItem { Text = "tropes9", Value = "SECRET IDENTITY" });
            attributes.Add(new SelectListItem { Text = "tropes10", Value = "UNLIKELY HERO" });
            attributes.Add(new SelectListItem { Text = "tropes11", Value = "FANTASY CREATURES" });

            objAttributeModel.Attributes = attributes;
            return View(objAttributeModel);
        }

    }

}















//[HttpPost]
//public ActionResult Index(UserModel u)
//{
//    ViewBag.Tea = u.Tea;
//    ViewBag.Loundry = u.Loundry;
//    ViewBag.Breakfast = u.Breakfast;
//    return View();
//}







//public ActionResult Index()
//{
//    List<FormModel> obj = new List<FormModel>()
//           {
//               new FormModel {genre1="Latur", IsChecked=false },
//               new FormModel {Text="Mumbai",Value=2,IsChecked=true },
//               new FormModel {Text="Pune",Value=2,IsChecked=false },
//               new FormModel {Text="Noida",Value=2,IsChecked=false },
//           };
//    Genre objBind = new Genre();
//    objBind.Cities = obj;
//    return View(objBind);
//}
////Post and get checkbox checked records
//[HttpPost]
//public ActionResult Index(CityList Obj)
//{
//    StringBuilder sb = new StringBuilder();
//    foreach (var item in Obj.Cities)
//    {

//        if (item.IsChecked)
//        {
//            //append each checked records into StringBuilder
//            sb.Append(item.Text + ",");

//        }


//    }
//    //store location into viewbag
//    ViewBag.Loc = "Your preferred work locations are " + sb.ToString();
//    //return location view to display checked records using viewbag
//    return View("Locations");

//}
//public ActionResult Index()
//{
//    return View();
//}


//var checkbox = Request.Form.Get("DeluxeFeature");
//if (checkbox.Contains("true"))
//{
//    //Whatever code if the checkbox is checked.
//}

//Html.CheckBox("DeluxeFeature")

//            var checkbox = Request.Form.TryGetValue("");

//if (checkbox.Contains("true"))
//{
//    //then do stuff;
//}

//Request.Form.Get("")