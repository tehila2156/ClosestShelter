using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Dto_Resorses
{
    public class AddressDto
    {

        public string Location { get; set; }
        public string StructureTypeName { get; set; }
        public string StructureTypeLevel { get; set; } // חדש
        public double Latitude { get; set; }   // חדש
        public double Longitude { get; set; }  // חדש
        public bool IsAlwaysOpen { get; set; }
        public string ContactPerson { get; set; }
        public string Phone { get; set; }
        public string Sms { get; set; }
        public int Capacity { get; set; }
        public int CurrentPeople { get; set; }

    }
}
