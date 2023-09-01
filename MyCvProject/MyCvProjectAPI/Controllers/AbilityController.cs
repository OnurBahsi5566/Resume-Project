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
	public class AbilityController : GenericController<Ability>
	{
		public AbilityController(IGenericService<Ability> genericService) : base(genericService)
		{

		}

		private AbilityRepository _abilityRepository;


		[Route("GetAbilitiesCount")]
		[HttpGet]
		public IActionResult GetAbilitiesCount()
		{
			_abilityRepository = new AbilityRepository();
			var t_List = _abilityRepository.GetAbilitiesCount();
			return Ok(t_List);
		}
	}
}