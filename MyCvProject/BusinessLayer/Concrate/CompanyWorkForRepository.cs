using BusinessLayer.Concrate;
using MyCvProjectBusinessLayer.Abstract;
using MyCvProjectEntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCvProjectBusinessLayer.Concrate
{
    public class CompanyWorkForRepository : GenericRepository<CompanyWorkFor>, ICompanyWorkForService
    {
        public List<CompanyWorkFor> GetAllListDescending()
        {
            return _database.CompaniesWorkFor.Where(cwf => cwf.Status == true).OrderByDescending(cwf => cwf.StartDate).ToList();
        }

    }
}