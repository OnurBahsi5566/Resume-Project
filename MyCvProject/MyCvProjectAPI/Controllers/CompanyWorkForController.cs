using BusinessLayer.Abstract;
using BusinessLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCvProjectBusinessLayer.Concrate;
using MyCvProjectEntityLayer.Concrate;

namespace MyCvProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyWorkForController : GenericController<CompanyWorkFor>
    {
        public CompanyWorkForController(IGenericService<CompanyWorkFor> genericService) : base(genericService)
        {

        }

        private CompanyWorkForRepository _companyWorkForRepository;

        [Route("GetAllListDescending")]
        [HttpGet]
        public IActionResult GetAllListDescending()
        {
            _companyWorkForRepository = new CompanyWorkForRepository();
            var t_List = _companyWorkForRepository.GetAllListDescending();
            return Ok(t_List);
        }
    }
}
