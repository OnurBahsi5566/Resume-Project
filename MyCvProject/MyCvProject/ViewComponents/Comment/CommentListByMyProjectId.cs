using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyCvProjectSite.ViewComponents
{
    public class CommentListByMyProjectId : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int myProjectId)
        {
            var _responseMessage = await UtilityLibrary._httpClient.GetAsync("https://localhost:44356/api/Comment/GetCommentsByMyProjectId?myProjectId=" + myProjectId);
            var _jsonClass = await _responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<EntityLayer.Concrate.Comment>>(_jsonClass);
            return View(values);            
        }
    }
}