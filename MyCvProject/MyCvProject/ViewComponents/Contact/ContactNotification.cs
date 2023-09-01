using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MyCvProjectSite.ViewComponents.Contact
{
    public class ContactNotification : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }

    }
}
