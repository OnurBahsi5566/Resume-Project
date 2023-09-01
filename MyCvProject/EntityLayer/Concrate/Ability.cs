using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCvProjectEntityLayer.Concrate
{
	public class Ability : FullLog
	{
		public string Name { get; set; }

		public int Level { get; set; }
	}
}