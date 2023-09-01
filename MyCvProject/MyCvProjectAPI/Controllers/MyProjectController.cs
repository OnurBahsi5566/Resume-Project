using BusinessLayer.Abstract;
using BusinessLayer.Concrate;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyCvProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyProjectController : GenericController<MyProject>
    {
        public MyProjectController(IGenericService<MyProject> genericRepository) : base(genericRepository)
        {

        }

        private MyProjectRepository _myProjectRepository;

        [Route("WithCategoryName")]
        [HttpGet]
        public IActionResult GetAllListWithCategoryName()
        {
            _myProjectRepository = new MyProjectRepository();
            var t_List = _myProjectRepository.GetAllListWithCategoryName();
            return Ok(t_List);
        }

        [Route("GetByIdWithCategoryName")]
        [HttpGet]
        public IActionResult GetByIdWithCategoryName(int id)
        {
            _myProjectRepository = new MyProjectRepository();
            var get_T = _myProjectRepository.GetByIdWithCategoryName(id);


            if (get_T == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(get_T);
            }
        }

        [Route("GetLastProject")]
        [HttpGet]
        public IActionResult GetLastProject()
        {
            _myProjectRepository = new MyProjectRepository();
            var get_T = _myProjectRepository.GetLastProject();

            if (get_T == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(get_T);
            }
        }

        [Route("GetCountByCategoryId")]
        [HttpGet]
        public IActionResult GetCountByCategoryId(int categoryId)
        {
            _myProjectRepository = new MyProjectRepository();
            var get_T = _myProjectRepository.GetCountByCategoryId(categoryId);

            return Ok(get_T);
        }

        [Route("GetLast3Projects")]
        [HttpGet]
        public IActionResult GetLast3Projects()
        {
            _myProjectRepository = new MyProjectRepository();
            var t_List = _myProjectRepository.GetLast3Projects();
            return Ok(t_List);
        }

        [Route("GetAllListWithProjectCategoryName")]
        [HttpGet]
        public IActionResult GetAllListWithProjectCategoryName()
        {
            _myProjectRepository = new MyProjectRepository();
            var t_List = _myProjectRepository.GetAllListWithProjectCategoryName();
            return Ok(t_List);
        }
    }
}