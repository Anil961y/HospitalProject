using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDomain.Services
{
    public class ServiceType
    {
        [Key]
        public int Id { get; set; }
        public string Sevice_Type { get; set; }
        public Service Service { get; set; }  
    }
}
