using System;
using System.Collections.Generic;
using System.Text;

namespace Transystem.Domain.Entitys
{
    public class User : PersonBase
    {
        public override int Id { get => base.Id; set => base.Id = value; }
        public override DateTime CreateDate { get => base.CreateDate; set => base.CreateDate = value; }
        public override DateTime UpdateDate { get => base.UpdateDate; set => base.UpdateDate = value; }
        public override DateTime? DeleteDate { get => base.DeleteDate; set => base.DeleteDate = value; }
        public override int IsDeleted { get => base.IsDeleted; set => base.IsDeleted = value; }
        public override string Name { get => base.Name; set => base.Name = value; }
        public override string DocumentNumber { get => base.DocumentNumber; set => base.DocumentNumber = value; }

        public string Login { get; set; }
        public string  Password { get; set; }
    }
}
