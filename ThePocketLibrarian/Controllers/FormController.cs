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
            //string genre1 = Genre[0];
            //string genre2 = Genre[1];
            //string genre3 = Genre[2];
            //string genre4 = Genre[3];
            //string genre5 = Genre[4];
            //string genre6 = Genre[5];
            //string genre7 = Genre[6];
            //string genre8 = Genre[7];
            //string genre9 = Genre[8];
            //string genre10 = Genre[9];
            //string genre11 = Genre[10];
            //string genre12 = Genre[11];
            //string genre13 = Genre[12];
            //string genre14 = Genre[13];
            string instmt = "genre in ('" + Genre.Aggregate((p, n) => p + "','" + n) + "')";
            return View();
        }
    }

}



//for (int i = 0; i < Genre.Count(); i++)
//{

//}


//Need to :
//- Pull items from array and use for query
//  * Maybe use array.Count to see how many elements there are and then put them as variables?
//  *
//- Query database
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

