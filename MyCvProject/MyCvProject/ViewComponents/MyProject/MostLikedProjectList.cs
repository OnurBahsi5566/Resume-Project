using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCvProjectSite.ViewComponents.MyProject
{
	public class MostLikedProjectList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}

	}
}
