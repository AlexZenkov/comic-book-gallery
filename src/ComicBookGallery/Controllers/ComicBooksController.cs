using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            //if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
            //    return Redirect("/");

            //return Content("Hello from ComicBooksController");

            return View();
        }
    }
}