using EntityLayer.Concrate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCvProjectBusinessLayer.ValidationRules;
using MyCvProjectEntityLayer.Concrate;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyCvProjectSite.Controllers
{
    public class RegisterController : Controller
    {

        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            if (id != 0)
            {
                var responseMessage = await UtilityLibrary._httpClient.GetAsync("https://localhost:44356/api/User/" + id);

                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonClass = await responseMessage.Content.ReadAsStringAsync();
                    var value = JsonConvert.DeserializeObject<User>(jsonClass);
                    return View(value);
                }
            }
            else
            {
                return View();
            }

            return RedirectToAction("Index", "MyProject");
        }


        [HttpPost]
        public async Task<IActionResult> AddorEditUser(User user, int id)
        {
            UserValidator userValidations = new UserValidator();
            ValidationResult validationResult = userValidations.Validate(user);

            if (validationResult.IsValid)
            {
                var jsonClassAddorEditUser = JsonConvert.SerializeObject(user);
                var contentAddorEditUser = new StringContent(jsonClassAddorEditUser, Encoding.UTF8, "application/json");

                if (id == 0)
                {
                    var responseMessagePutUser = await UtilityLibrary._httpClient.PostAsync("https://localhost:44356/api/User", contentAddorEditUser);

					var responseMessageGetIdLastUser = await UtilityLibrary._httpClient.GetAsync("https://localhost:44356/api/User/GetIdLastuser");
					var jsonClassGetIdLastUser = await responseMessageGetIdLastUser.Content.ReadAsStringAsync();
					int lastUserId = Convert.ToInt32(jsonClassGetIdLastUser);

					var responseMessageGetProjects = await UtilityLibrary._httpClient.GetAsync("https://localhost:44356/api/MyProject");
					var jsonClassMyProjects = await responseMessageGetProjects.Content.ReadAsStringAsync();
					var myProjectIdList = JsonConvert.DeserializeObject<List<MyProject>>(jsonClassMyProjects);

                    Like like= new Like();

                    foreach (var item in myProjectIdList)
                    {
                        like.MyProjectId = item.Id;
                        like.UserId = lastUserId;
						like.LikeorDislike = false;

						var jsonClassAddLike = JsonConvert.SerializeObject(like);
						var contentAddLike = new StringContent(jsonClassAddLike, Encoding.UTF8, "application/json");

						var responseMessageAddLike = await UtilityLibrary._httpClient.PostAsync("https://localhost:44356/api/Like", contentAddLike);
					}

					if (responseMessagePutUser.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index","MyProject");
                    }

                }
                else
                {
                    var responseMessageEditUser = await UtilityLibrary._httpClient.PutAsync("https://localhost:44356/api/User", contentAddorEditUser);


					if (responseMessageEditUser.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index","MyProject");
                    }
                }
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View("Index");
        }
    }
}