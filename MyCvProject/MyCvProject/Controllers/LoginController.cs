using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCvProjectEntityLayer.Concrate;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyCvProjectSite.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(User user)
        {
            var responseMessage = await UtilityLibrary._httpClient.GetAsync("https://localhost:44356/api/User/SessionUser?email=" + user.Email + "&password=" + user.Password);

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonClass = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<User>(jsonClass);

                if (value != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,user.Email)
                    };
                    var userIdentity = new ClaimsIdentity(claims, "a");
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                    await HttpContext.SignInAsync(principal);

                    return RedirectToAction("Index", "MyProject");
                }
            }

            return View();
        }
    }
}