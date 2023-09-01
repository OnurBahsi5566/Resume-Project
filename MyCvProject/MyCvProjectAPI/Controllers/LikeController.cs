using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using MyCvProjectEntityLayer.Concrate;

namespace MyCvProjectAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LikeController : GenericController<Like>
	{
		public LikeController(IGenericService<Like> genericService) : base(genericService)
		{

		}

	}
}
