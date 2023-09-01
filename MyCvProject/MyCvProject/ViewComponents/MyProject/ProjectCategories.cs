using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCvProjectSite.ViewComponents.MyProject
{
    public class ProjectCategories : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var _responseMessage = await UtilityLibrary._httpClient.GetAsync("https://localhost:44356/api/MyProject/GetAllListWithProjectCategoryName");
            var _jsonClass = await _responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<EntityLayer.Concrate.MyProject>>(_jsonClass);
            return View(values);
        }

    }
}
