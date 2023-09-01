using Microsoft.AspNetCore.Mvc;
using MyCvProjectEntityLayer.Concrate;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCvProjectSite.ViewComponents.OurProgress
{
	public class OurProgressTheme : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{

			//var _responseMessageCount = await UtilityLibrary._httpClient.GetAsync("https://localhost:44356/api/Ability/GetAbilitiesCount");
			//var _jsonClassCount = await _responseMessageCount.Content.ReadAsStringAsync();
			//var value = _jsonClassCount;
			
			//ViewBag.AbilitiesCount = value;

			var _responseMessage = await UtilityLibrary._httpClient.GetAsync("https://localhost:44356/api/Ability");
			var _jsonClass = await _responseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<List<Ability>>(_jsonClass);

			return View(values);
		}
	}
}