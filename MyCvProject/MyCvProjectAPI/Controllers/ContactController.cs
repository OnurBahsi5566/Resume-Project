using BusinessLayer.Abstract;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyCvProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : GenericController<Contact>
    {
        public ContactController(IGenericService<Contact> genericRepository) : base(genericRepository)
        {
        }
    }
}
