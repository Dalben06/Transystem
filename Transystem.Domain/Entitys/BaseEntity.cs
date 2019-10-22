using System;
using System.Collections.Generic;
using System.Text;

namespace Transystem.Domain.Entitys
{
    public class BaseEntity
    {

        public virtual int Id { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual DateTime UpdateDate { get; set; }
        public virtual DateTime? DeleteDate { get; set; }
        public virtual int IsDeleted { get; set; }
    }
}
