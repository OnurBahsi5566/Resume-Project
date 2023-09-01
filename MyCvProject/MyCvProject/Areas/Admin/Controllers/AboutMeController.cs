using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyCvProjectEntityLayer.Concrate;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCvProjectSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class AboutMeController : Controller
    {
        public  IActionResult Index()
        {
            return View();
        }

        public async Task<JsonResult> loadData()
        {
            var _responseMessage = await UtilityLibrary._httpClient.GetAsync("https://localhost:44356/api/AboutMe");
            var _jsonClass = await _responseMessage.Content.ReadAsStringAsync();
            
            return Json(_jsonClass, new Newtonsoft.Json.JsonSerializerSettings());
        }
    }
}