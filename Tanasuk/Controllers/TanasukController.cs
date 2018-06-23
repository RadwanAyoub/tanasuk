using System.Web.Mvc;
using Tanasuk.Business;

namespace Tanasuk.Controllers
{
    public class TanasukController : Controller
    {
        // GET: Tanasuk
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HeaderNavigation()
        {
            Navigation _nav = new Navigation();
            return View(_nav.GetHeaderNavigation());
        }
        public ActionResult SideNavigation()
        {
            Navigation _nav = new Navigation();
            return View(_nav.GetSideNavigation());
        }
    }
}