using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MyCvProjectSite.ViewComponents.Notification
{
    public class NotificationList : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }

    }
}
