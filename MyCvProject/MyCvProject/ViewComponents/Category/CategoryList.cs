using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using MyCvProjectEntityLayer.Concrate;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyCvProjectSite.ViewComponents.Category
{
    public class CategoryList : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var _responseMessage = await UtilityLibrary._httpClient.GetAsync("https://localhost:44356/api/Category");
            var _jsonClass = await _responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<MyCvProjectEntityLayer.Concrate.Category>>(_jsonClass);
            return View(values);
        }
    }
}