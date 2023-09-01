using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Contact : FullLog
    {
        public string FullName { get; set; }

        public string Email { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

    }
}