using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Transystem.API.Models
{
    public class ClientModel
    {
        public int Id { get ; set ; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public string DocumentNumber { get; set; }
        public bool IsTypePerson { get; set; }
        public List<AddressModel> Addresses { get; set; }

    }
}
