using BusinessLayer.Abstract;
using EntityLayer.Concrate;
using MyCvProjectEntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCvProjectBusinessLayer.Abstract
{
    public interface IUserService : IGenericService<User>
    {
        int GetIdLastUser();

        User SessionUser(string email,string password);

    }
}
