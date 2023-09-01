using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMyProjectService:IGenericService<MyProject>
    {
         List<MyProject> GetAllListWithCategoryName();

         MyProject GetByIdWithCategoryName(int Id);

         int GetCountByCategoryId(int categoryId);

         MyProject GetLastProject();

         List<MyProject> GetLast3Projects();

         List<MyProject> GetAllListWithProjectCategoryName();
    }
}