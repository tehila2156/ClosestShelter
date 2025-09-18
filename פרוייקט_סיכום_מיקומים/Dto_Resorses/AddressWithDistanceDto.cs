using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Dto_Resorses
{
    public class AddressWithDistanceDto
    {
        public string Location { get; set; }
        public string StructureTypeName { get; set; }
        public string StructureTypeLevel { get; set; }
        public bool IsAlwaysOpen { get; set; }
        public string ContactPerson { get; set; }
        public string Phone { get; set; }
        public string Sms { get; set; }
        public int Capacity { get; set; }
        public int CurrentPeople { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double DistanceInKm { get; set; }




    }
}
