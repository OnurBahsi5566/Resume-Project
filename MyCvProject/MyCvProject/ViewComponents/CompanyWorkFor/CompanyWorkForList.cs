using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCvProjectSite.ViewComponents.CompanyWorkFor
{
    public class CompanyWorkForList : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var _responseMessage = await UtilityLibrary._httpClient.GetAsync("https://localhost:44356/api/CompanyWorkFor/GetAllListDescending");
            var _jsonClass = await _responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<MyCvProjectEntityLayer.Concrate.CompanyWorkFor>>(_jsonClass);
            return View(values);
        }
    }
}