using System;
using System.Collections.Generic;
using System.Text;

namespace Transystem.Domain.Entitys
{
    public class PersonBase : BaseEntity
    {
        public override int Id { get => base.Id; set => base.Id = value; }
        public override DateTime CreateDate { get => base.CreateDate; set => base.CreateDate = value; }
        public override DateTime UpdateDate { get => base.UpdateDate; set => base.UpdateDate = value; }
        public override DateTime? DeleteDate { get => base.DeleteDate; set => base.DeleteDate = value; }
        public override bool IsDeleted { get => base.IsDeleted; set => base.IsDeleted = value; }
        public virtual string DocumentNumber { get; set; }
        public virtual string Name { get; set; }



    }
}
