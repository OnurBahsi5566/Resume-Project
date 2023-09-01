using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyCvProjectSite.ViewComponents.Category
{
    public class CategoryCount : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int categoryId)
        {
            var _responseMessage = await UtilityLibrary._httpClient.GetAsync("https://localhost:44356/api/MyProject/GetCountByCategoryId?categoryId=" + categoryId);
            var _jsonClass = await _responseMessage.Content.ReadAsStringAsync();
            var value = _jsonClass;
            ViewBag.CategoryCount = value;
            return View();
        }
    }
}