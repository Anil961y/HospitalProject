using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDomain.Hospitals
{
    public class HospitalAddress
    {
        [Key]
        public int Id { get; set; }

        public Int64 Contact_Number { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int Pin_Code { get; set; }
        public Double Longitude { get; set; }
        public Double Latitude { get; set; }
        [ForeignKey("Hospitals")]
        public int HospitalId { get; set; }
        public Hospital Hospitals { get; set; }
    }

}
