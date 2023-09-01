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
	public class AbilityRepository : GenericRepository<Ability>, IAbilityService
	{
		public int GetAbilitiesCount()
		{
			return _database.Abilities.Where(a => a.Status == true).Count();
		}
	}
}
