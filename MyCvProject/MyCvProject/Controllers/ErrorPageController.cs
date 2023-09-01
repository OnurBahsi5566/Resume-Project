using Microsoft.AspNetCore.Mvc;

namespace MyCvProjectSite.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}