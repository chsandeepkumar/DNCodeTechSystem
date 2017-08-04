using System.Web.Mvc;

namespace DNCode.Website.Controllers
{
	public class AboutController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
        public ActionResult GetDetails()
        {
            return null;
        }
	}
}