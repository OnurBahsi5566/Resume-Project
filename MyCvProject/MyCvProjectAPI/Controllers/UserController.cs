using BusinessLayer.Abstract;
using BusinessLayer.Concrate;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCvProjectBusinessLayer.Concrate;
using MyCvProjectEntityLayer.Concrate;

namespace MyCvProjectAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : GenericController<User>
	{
		public UserController(IGenericService<User> genericService) : base(genericService)
		{

		}

		UserRepository _userRepository;


		[Route("GetIdLastuser")]
		[HttpGet]
		public IActionResult GetIdLastUser()
		{
			_userRepository = new UserRepository();
			var get_T = _userRepository.GetIdLastUser();

			return Ok(get_T);
		}

        [Route("SessionUser")]
        [HttpGet]
        public IActionResult SessionUser(string email,string password)
        {
            _userRepository = new UserRepository();
            var get_T = _userRepository.SessionUser(email,password);

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