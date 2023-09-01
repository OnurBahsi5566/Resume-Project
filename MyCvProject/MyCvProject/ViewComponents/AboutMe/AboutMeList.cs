using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCvProjectSite.ViewComponents.AboutMe
{
    public class AboutMeList : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var _responseMessage = await UtilityLibrary._httpClient.GetAsync("https://localhost:44356/api/AboutMe/GetAboutMeFirst");
            var _jsonClass = await _responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<MyCvProjectEntityLayer.Concrate.AboutMe>(_jsonClass);
            
            return View(values);
        }
    }
}
