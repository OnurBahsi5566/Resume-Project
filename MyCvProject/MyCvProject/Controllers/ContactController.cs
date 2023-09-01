using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using MyCvProjectEntityLayer.Concrate;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyCvProjectSite.Controllers
{
    public class ContactController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var _responseMessage = await UtilityLibrary._httpClient.GetAsync("https://localhost:44356/api/AboutMe/GetAboutMeFirst");
            var _jsonClass = await _responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<AboutMe>(_jsonClass);

            return View(values);
        }

        [HttpGet]
        public IActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddContact(Contact contact)
        {
            var jsonClass = JsonConvert.SerializeObject(contact);
            var content = new StringContent(jsonClass, Encoding.UTF8, "application/json");

            var responseMessage = await UtilityLibrary._httpClient.PostAsync("https://localhost:44356/api/Contact", content);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "MyProject");
            }

            return RedirectToAction("Index", "MyProject");
        }
    }
}