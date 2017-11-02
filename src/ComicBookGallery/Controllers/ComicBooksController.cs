using System.Web.Mvc;
using ComicBookGallery.Data;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        //public ActionResult Detail()
        //{
        //    return View(new ComicBookRepository().GetComicBook(0));
        //}

        public ActionResult Detail(int? id)
        {
            return View(new ComicBookRepository().GetComicBook(id ?? 0));

            //if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
            //    return Redirect("/");

            //return Content("Hello from ComicBooksController");
        }
    }
}