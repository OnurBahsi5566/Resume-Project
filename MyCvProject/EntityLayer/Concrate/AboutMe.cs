using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCvProjectEntityLayer.Concrate
{
    public class AboutMe : FullLog
    {
        public string FullName { get; set; }

        public string Profession { get; set; }

        public DateTime BirthDate { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Details { get; set; }

        public string Image { get; set; }

    }
}