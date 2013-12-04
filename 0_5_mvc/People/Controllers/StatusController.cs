using System.Web.Mvc;

namespace People.Controllers
{
    public class StatusController : Controller
    {
        /// <summary>
        /// Returns the stats about the number of successfull and failed ID number lookups
        /// </summary>
        public ActionResult Get()
        {
            return View();
        }
    }
}