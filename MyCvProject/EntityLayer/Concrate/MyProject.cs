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
    public class MyProject:FullLog
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Abilities { get; set; }
 
        public string Image { get; set; }

        public int CategoryId { get; set; } //Development Category

        public int? ProjectCategoryId { get; set; }

        [ForeignKey("ProjectCategoryId")]
        public ProjectCategory ProjectCategory { get; set; }

        [ForeignKey("CategoryId")]
		public Category Category { get; set; }

    }
}