using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using MyCvProjectEntityLayer.Concrate;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System;

namespace MyCvProjectSite.Controllers
{
    public class NewsletterPersonController : Controller
    {

        [HttpGet]
        public PartialViewResult AddNewsletterPerson()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<PartialViewResult> AddNewsletterPerson(NewsletterPerson newsletterPerson)
        {
            var jsonClass = JsonConvert.SerializeObject(newsletterPerson);
            var content = new StringContent(jsonClass, Encoding.UTF8, "application/json");

            var responseMessage = await UtilityLibrary._httpClient.PostAsync("https://localhost:44356/api/NewsletterPerson", content);

            if (responseMessage.IsSuccessStatusCode)
            {
                return PartialView();
            }

            return PartialView();
        }
    }
}
