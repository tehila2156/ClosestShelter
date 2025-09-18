using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Models
{
    public class Address
    {

        public int Id { get; set; }
        public string Location { get; set; }
        public int StructureTypeId { get; set; }
        public StructureType StructureType { get; set; }
        public double Latitude { get; set; }   // חדש
        public double Longitude { get; set; }  // חדש
        public bool IsAlwaysOpen { get; set; }
        public string ContactPerson { get; set; }
        public string Phone { get; set; }
        public string Sms { get; set; }
        public int Capacity { get; set; }
        public int CurrentPeople { get; set; }
        public DateTime AddedDate { get; set; }
        public ICollection<Review> Reviews { get; set; }

    }
}
