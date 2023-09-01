using BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class GenericRepository<T> : IGenericService<T> where T : class
    {
        public Context _database = new Context();

		public void Delete(T t)
        {
            _database.Remove(t);
            _database.SaveChanges();
        }

		public List<T> GetFilterList(Expression<Func<T, bool>> filter)
		{
			return _database.Set<T>().Where(filter).ToList();
		}

		public List<T> GetAllList()
        {
            return _database.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _database.Set<T>().Find(id);
        }

        public T Insert(T t)
        {
            _database.Add(t);
            _database.SaveChanges();
            return t;
        }

        public T Update(T t)
        {
            _database.Update(t);
            _database.SaveChanges();
            return t;
        }
    }
}