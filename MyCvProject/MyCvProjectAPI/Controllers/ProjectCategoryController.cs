using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCvProjectEntityLayer.Concrate;

namespace MyCvProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectCategoryController : GenericController<ProjectCategory>
    {
        public ProjectCategoryController(IGenericService<ProjectCategory> genericService) : base(genericService)
        {
        }

    }
}