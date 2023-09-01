using BusinessLayer.Abstract;
using BusinessLayer.Concrate;
using Microsoft.EntityFrameworkCore.Query.Internal;
using MyCvProjectBusinessLayer.Abstract;
using MyCvProjectEntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCvProjectBusinessLayer.Concrate
{
    public class AboutMeRepository : GenericRepository<AboutMe>, IAboutMeService
    {
        public AboutMe GetAboutMeFirst()
        {
            return _database.AboutsMe.Where(a => a.Status == true).FirstOrDefault();
        }

    }
}