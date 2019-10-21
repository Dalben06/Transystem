using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Transystem.API.Models
{
    public class AddressModel
    {

        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsDeleted { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string ZipCode { get; set; }
    }
}
