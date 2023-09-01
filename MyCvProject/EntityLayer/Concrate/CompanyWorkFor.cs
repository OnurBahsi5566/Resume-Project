using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCvProjectEntityLayer.Concrate
{
    public class CompanyWorkFor : FullLog
    {
        public string Name { get; set; }

        public string Detail { get; set; }

        public string Image { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
