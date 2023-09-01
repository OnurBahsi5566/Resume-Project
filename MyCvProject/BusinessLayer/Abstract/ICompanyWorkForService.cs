using BusinessLayer.Abstract;
using MyCvProjectEntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCvProjectBusinessLayer.Abstract
{
    public interface ICompanyWorkForService : IGenericService<CompanyWorkFor>
    {
        List<CompanyWorkFor> GetAllListDescending();

    }
}
