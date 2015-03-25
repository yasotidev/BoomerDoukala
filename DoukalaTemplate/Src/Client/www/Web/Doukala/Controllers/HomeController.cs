using System.Web.Mvc;
using Doukala.Services;
using Doukala.ViewModels;

namespace Doukala.Controllers
{
 
    public class HomeController : Controller
    {
        protected ICompagnyService CompagnyService;

        public HomeController()
            :this(new CompagnyService())
        {
            
        }

        public HomeController(ICompagnyService service)
        {
            CompagnyService = service;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var model = new DashboardViewModel()
            {
               
            };
            return View();
        }
    }
}
