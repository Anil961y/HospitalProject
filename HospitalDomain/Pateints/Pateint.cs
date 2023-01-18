using HospitalDomain.Hospitals;
using HospitalDomain.OPDS;
using HospitalDomain.Pateints.Documents;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDomain.Pateints
{
    public class Pateint
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateFormat DOB { get; set; }
        public string MaritalStatus { get; set; }
        public Int64 Mobile_No { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public ICollection<Document> Documents { get; set; }
        public ICollection<OPD> OPD { get; set; }
        public Hospital Hospital { get; set; }

    }
}
