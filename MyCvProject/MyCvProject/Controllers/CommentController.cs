using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using MyCvProjectEntityLayer.Concrate;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyCvProjectSite.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult AddCommentPartial()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<PartialViewResult> AddCommentPartial(Comment comment)
        {
            comment.MyProjectId = 1;
            comment.UserId = 7;

            var jsonClass = JsonConvert.SerializeObject(comment);
            var content = new StringContent(jsonClass, Encoding.UTF8, "application/json");

            var responseMessage = await UtilityLibrary._httpClient.PostAsync("https://localhost:44356/api/Comment", content);

            if (responseMessage.IsSuccessStatusCode)
            {
                return PartialView();
            }

            return PartialView();
        }
    }
}