using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyCvProjectSite.Controllers
{
    public class MyProjectController : Controller
    {
		public async Task<IActionResult> Index()
		{
			var _responseMessage = await UtilityLibrary._httpClient.GetAsync("https://localhost:44356/api/MyProject/WithCategoryName");
			var _jsonClass = await _responseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<List<MyProject>>(_jsonClass);
			return View(values);
		}


		[HttpGet]
		public async Task<IActionResult> GetMyProjectById(int id)
		{
			ViewBag.Id = id;

			if (id != 0)
			{
				var responseMessage = await UtilityLibrary._httpClient.GetAsync("https://localhost:44356/api/MyProject/GetByIdWithCategoryName?id=" + id);

				if (responseMessage.IsSuccessStatusCode)
				{
					var jsonClass = await responseMessage.Content.ReadAsStringAsync();
					var value = JsonConvert.DeserializeObject<MyProject>(jsonClass);
					return View(value);
				}
			}
			else
			{
				return View();
			}

			return RedirectToAction("Index");
		}
	}
}