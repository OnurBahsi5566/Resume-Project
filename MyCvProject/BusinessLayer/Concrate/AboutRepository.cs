using BusinessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class AboutRepository:GenericRepository<About>, IAboutService
    {
		public List<About> GetTop3()
        {
            return _database.Abouts.Take(3).ToList();
        }

    }
}
