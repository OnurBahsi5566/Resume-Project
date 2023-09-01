using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyCvProjectEntityLayer.Concrate;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyCvProjectSite.Controllers
{
    [AllowAnonymous]
    public class AboutMeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var _responseMessage = await UtilityLibrary._httpClient.GetAsync("https://localhost:44356/api/AboutMe/GetAboutMeFirst");
            var _jsonClass = await _responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<AboutMe>(_jsonClass);

            return View(values);
        }



        public async Task<IActionResult> AdminAboutMeList()
        {
            var _responseMessage = await UtilityLibrary._httpClient.GetAsync("https://localhost:44356/api/AboutMe");
            var _jsonClass = await _responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<AboutMe>>(_jsonClass);

            return View(values);
        }


        [HttpGet]
        public async Task<IActionResult> GetAboutMeByIdForAdmin(int id)
        {
            if (id != 0)
            {
                var responseMessage = await UtilityLibrary._httpClient.GetAsync("https://localhost:44356/api/AboutMe/" + id);

                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonClass = await responseMessage.Content.ReadAsStringAsync();
                    var value = JsonConvert.DeserializeObject<AboutMe>(jsonClass);
                    return View(value);
                }
            }

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AdminAddOrEdit(AboutMe aboutMe, int id)
        {
            var jsonClass = JsonConvert.SerializeObject(aboutMe);
            var content = new StringContent(jsonClass, Encoding.UTF8, "application/json");

            if (id == 0)
            {
                var responseMessage = await UtilityLibrary._httpClient.PostAsync("https://localhost:44356/api/AboutMe", content);

                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("AdminAboutMeList");
                }

            }
            else
            {
                var responseMessage = await UtilityLibrary._httpClient.PutAsync("https://localhost:44356/api/AboutMe", content);

                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("AdminAboutMeList");
                }
            }

            return RedirectToAction("AdminAboutMeList");
        }

        public async Task<IActionResult> PassiveDelete(int id)
        {
            var _responseMessage = await UtilityLibrary._httpClient.GetAsync("https://localhost:44356/api/AboutMe/" + id);
            var _jsonClass = await _responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<AboutMe>(_jsonClass);

            values.Status = false;

            var jsonClass = JsonConvert.SerializeObject(values);
            var content = new StringContent(jsonClass, Encoding.UTF8, "application/json");

            var responseMessage = await UtilityLibrary._httpClient.PutAsync("https://localhost:44356/api/AboutMe", content);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AdminAboutMeList");
            }

            return RedirectToAction("AdminAboutMeList");
        }
    }
}