using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Transystem.API.Models
{
    public class TrailerModel
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public int IsDeleted { get; set; }
        public int TruckId { get; set; }
        public string Name { get; set; }
    }
}
