using MyCvProjectEntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCvProjectEntityLayer.Concrate
{
	public  class User:HalfLog
	{
        public string Email { get; set; }

        public string FullName { get; set; }

        public string Password { get; set; }

	}
}