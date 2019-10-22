using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Transystem.API.Models
{
    public class DriverModel
    {

        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public int IsDeleted { get; set; }
        public string Name { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string DriverLicense { get; set; }
        public List<TruckModel> Trucks { get; set; }
    }
}
