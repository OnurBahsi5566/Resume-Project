using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCvProjectSite.ViewComponents.Comment
{
    public class CommentCountByMyProjectId : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int myProjectId)
        {
            var _responseMessage = await UtilityLibrary._httpClient.GetAsync("https://localhost:44356/api/Comment/GetCommentCountByMyProjectId?myProjectId=" + myProjectId);
            var _jsonData = await _responseMessage.Content.ReadAsStringAsync();
            
            ViewBag.commentCount = _jsonData;
            
            return View();
        }
    }
}