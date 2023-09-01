using BusinessLayer.Abstract;
using BusinessLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCvProjectAPI.Filters;
using MyCvProjectBusinessLayer.Concrate;
using MyCvProjectEntityLayer.Concrate;

namespace MyCvProjectAPI.Controllers
{
    [Route("api/[controller]")]
    //[LogFilter]
    [ApiController]
    public class AboutMeController : GenericController<AboutMe>
    {
        public AboutMeController(IGenericService<AboutMe> genericService) : base(genericService)
        {
        }

        AboutMeRepository _aboutMeRepository;

        [Route("GetAboutMeFirst")]
        [HttpGet]
        public IActionResult GetAboutMeFirst()
        {
            _aboutMeRepository = new AboutMeRepository();
            var get_T = _aboutMeRepository.GetAboutMeFirst();

            if (get_T == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(get_T);
            }
        }
    }
}