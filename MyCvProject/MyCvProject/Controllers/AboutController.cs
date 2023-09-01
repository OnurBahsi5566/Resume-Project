using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyCvProjectSite.Controllers
{
    public class AboutController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var _responseMessage = await UtilityLibrary._httpClient.GetAsync("https://localhost:44356/api/About");
            var _jsonClass = await _responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<About>>(_jsonClass);
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> GetAboutById(int id)
        {
            if (id != 0)
            {
                var responseMessage = await UtilityLibrary._httpClient.GetAsync("https://localhost:44356/api/About/" + id);

                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonClass = await responseMessage.Content.ReadAsStringAsync();
                    var value = JsonConvert.DeserializeObject<About>(jsonClass);
                    return View(value);
                }
            }
            else
            {
                return View();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> AddAbout(About about, int id)
        {
            var jsonClass = JsonConvert.SerializeObject(about);
            var content = new StringContent(jsonClass, Encoding.UTF8, "application/json");

            if (id == 0)
            {
                var responseMessage = await UtilityLibrary._httpClient.PostAsync("https://localhost:44356/api/About", content);

                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }

            }
            else
            {
                var responseMessage = await UtilityLibrary._httpClient.PutAsync("https://localhost:44356/api/About", content);

                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            return View(about);
        }

        public async Task<IActionResult> DeleteAbout(int id)
        {
            var responseMessage = await UtilityLibrary._httpClient.DeleteAsync("https://localhost:44356/api/About/" + id);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
       
        public class Class1
        {

        }
    }
}