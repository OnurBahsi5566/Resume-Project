using EntityLayer.Abstract;
using MyCvProjectEntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class About:FullLog
    {
        public string Details1 { get; set; }

        public string Details2 { get; set; }

        public string Image1 { get; set; }

        public string Image2 { get; set; }

        public string MapLocation { get; set; }

    }
}
