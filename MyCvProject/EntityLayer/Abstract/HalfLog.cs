using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCvProjectEntityLayer.Abstract
{
    public abstract class HalfLog
    {
        [Key]
        public int Id { get; set; }

        public bool Status { get; set; } = true;

        public int CreatedUserId { get; set; } = 0; //0 bu sistemin sistem yöneticisi

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public int? LastModifiedUserId { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public int? DeletedUserId { get; set; }

        public DateTime? DeletedDate { get; set; }

    }
}