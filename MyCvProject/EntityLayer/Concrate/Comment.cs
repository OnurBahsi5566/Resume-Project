using EntityLayer.Abstract;
using MyCvProjectEntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Comment:FullLog
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public int MyProjectId { get; set; }

        public int UserId { get; set; }

        [ForeignKey("MyProjectId")]
        public MyProject MyProject { get; set; }

		[ForeignKey("UserId")]
		public User User { get; set; }

	}
}