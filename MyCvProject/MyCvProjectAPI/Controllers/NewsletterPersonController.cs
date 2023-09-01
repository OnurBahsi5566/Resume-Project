using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCvProjectEntityLayer.Concrate;

namespace MyCvProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsletterPersonController : GenericController<NewsletterPerson>
    {
        public NewsletterPersonController(IGenericService<NewsletterPerson> genericService) : base(genericService)
        {
        }

    }
}
