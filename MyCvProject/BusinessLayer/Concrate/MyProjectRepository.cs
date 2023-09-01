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
	public class MyProjectRepository : GenericRepository<MyProject>, IMyProjectService
	{
        public List<MyProject> GetAllListWithCategoryName()
		{
			return _database.MyProjects.Include(mp => mp.Category).OrderByDescending(mp => mp.CreatedDate).ToList();
		}

        public List<MyProject> GetAllListWithProjectCategoryName()
        {
            return _database.MyProjects.Include(mp => mp.ProjectCategory).OrderByDescending(mp => mp.CreatedDate).ToList();
        }

        public MyProject GetByIdWithCategoryName(int id)
        {
            return _database.MyProjects.Include(mp => mp.Category).Where(mp => mp.Id == id).FirstOrDefault();
        }

        public int GetCountByCategoryId(int categoryId)
        {
            return _database.MyProjects.Where(mp => mp.Category.Id == categoryId).Count();
        }

        public List<MyProject> GetLast3Projects()
        {
            return _database.MyProjects.Where(mp => mp.Status == true).OrderByDescending(mp => mp.CreatedDate).Take(3).ToList();
        }

        public MyProject GetLastProject()
        {
            return _database.MyProjects.Where(mp => mp.Status == true).ToList().Last();
        }
    }
}