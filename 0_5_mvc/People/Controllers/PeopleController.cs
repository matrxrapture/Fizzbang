using System.Web.Mvc;
using People.Models;

namespace People.Controllers
{
    public class PeopleController : Controller
    {
        /// <summary>
        /// List the people in the database as per the screenshots
        /// </summary>
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View(new PersonFormModel());
        }

        /// <summary>
        /// Stores a selected person to the database
        /// </summary>
        [HttpPost]
        public ActionResult Create(PersonFormModel formModel)
        {
            return RedirectToAction("Index");
        }
    }
}