using System.Web.Mvc;
using ComicBookGallery.Data;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private readonly ComicBookRepository m_ComicBookRepository = new ComicBookRepository();

        public ActionResult Index()
        {
            return View(new ComicBookRepository().GetComicBooks());
        }

        public ActionResult Detail(int? id)
        {
            if (id == null) return HttpNotFound("Please specify issue number");
            return View(m_ComicBookRepository.GetComicBookById(id.Value));

            //if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
            //    return Redirect("/");

            //return Content("Hello from ComicBooksController");
        }
    }
}