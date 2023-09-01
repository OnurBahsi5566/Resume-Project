using BusinessLayer.Abstract;
using BusinessLayer.Concrate;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyCvProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : GenericController<Comment>
    {
        public CommentController(IGenericService<Comment> genericRepository) : base(genericRepository)
        {
        }

        private CommentRepository _commentRepository;


        [Route("GetCommentsByMyProjectId")]
        [HttpGet]
        public IActionResult GetCommentsByMyProjectId(int myProjectId)
        {
            _commentRepository = new CommentRepository();
            var t_List = _commentRepository.GetCommentsByMyProjectId(myProjectId);
            return Ok(t_List);
        }

        [Route("GetCommentCountByMyProjectId")]
        [HttpGet]
        public IActionResult GetCommentCountByMyProjectId(int myProjectId)
        {
            _commentRepository = new CommentRepository();
            var t_List = _commentRepository.GetCommentCountByMyProjectId(myProjectId);
            return Ok(t_List);
        }
    }
}