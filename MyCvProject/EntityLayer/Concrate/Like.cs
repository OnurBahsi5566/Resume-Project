using EntityLayer.Abstract;
using EntityLayer.Concrate;
using MyCvProjectEntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCvProjectEntityLayer.Concrate
{
	public class Like : FullLog
	{

		public int MyProjectId { get; set; }

		public int UserId { get; set; }

		public bool LikeorDislike { get; set; }

		[ForeignKey("MyProjectId")]
		public MyProject MyProject { get; set; }

		[ForeignKey("UserId")]
		public User User { get; set; }

	}
}