using System.Web.Mvc;

namespace People.Controllers
{
    public class PeopleLookupController : Controller
    {
        /// <summary>
        /// Invokes the external ID number lookup service
        /// using the idNumber parameter as the id number to search for
        /// </summary>
        [HttpGet]
        public ActionResult Get(string idNumber)
        {
            return View();
        }
    }
}