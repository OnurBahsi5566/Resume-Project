using BusinessLayer.Abstract;
using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class CommentRepository : GenericRepository<Comment>, ICommentService
    {
        public int GetCommentCountByMyProjectId(int myProjectId)
        {
            return _database.Comments.Where(cm => cm.MyProject.Id == myProjectId).Count();
        }

        public List<Comment> GetCommentsByMyProjectId(int myProjectId)
        {
            return _database.Comments.Include(cm => cm.User).Where(cm => cm.MyProject.Id == myProjectId).ToList();
        }
    }
}
