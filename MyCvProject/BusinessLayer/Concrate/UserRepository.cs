using BusinessLayer.Abstract;
using BusinessLayer.Concrate;
using EntityLayer.Concrate;
using MyCvProjectBusinessLayer.Abstract;
using MyCvProjectEntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCvProjectBusinessLayer.Concrate
{
	public class UserRepository : GenericRepository<User>, IUserService
	{
		public int GetIdLastUser()
		{

			return _database.Users.Where(u => u.Status == true).OrderByDescending(u => u.Id).Select(u => u.Id).FirstOrDefault();

		}

        public User SessionUser(string email, string password)
        {
			return _database.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }

    }
}