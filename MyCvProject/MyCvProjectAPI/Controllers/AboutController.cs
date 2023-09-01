using BusinessLayer.Abstract;
using BusinessLayer.Concrate;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyCvProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : GenericController<About>
    {
        public AboutController(IGenericService<About> genericRepository) : base(genericRepository)
        {

		}

        private AboutRepository _aboutRepository;

		[Route("Top3")]
        [HttpGet]
        public IActionResult GetAllTop3()
        {
			_aboutRepository = new AboutRepository();
			var t_List = _aboutRepository.GetTop3();
            return Ok(t_List);
        }
    }
}