using Microsoft.AspNetCore.Mvc;

namespace MyCvProjectSite.ViewComponents.StayConnect
{
    public class StayConnectTheme : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
