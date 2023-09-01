using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq.Expressions;

namespace MyCvProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class GenericController<T> : ControllerBase where T : class
    {
        private readonly IGenericService<T> _genericService;

        public GenericController(IGenericService<T> genericService)
        {
            _genericService = genericService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var t_List = _genericService.GetAllList();
            return Ok(t_List);
        }

        [HttpPost]
        public IActionResult Post([FromBody] T t, int id)
        {
            var added_T = _genericService.Insert(t);
            return Ok(added_T);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var get_T = _genericService.GetById(id);

            if (get_T == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(get_T);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted_T = _genericService.GetById(id);

            if (deleted_T == null)
            {
                return NotFound();
            }
            else
            {
                _genericService.Delete(deleted_T);

                return Ok();
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] T t)
        {
            _genericService.Update(t);

            return Ok(t);
        }
    }
}
