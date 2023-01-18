using HospitalDomain.Employees;
using HospitalDomain.Pateints;
using HospitalDomain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDomain.Hospitals
{
    public class Hospital
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string RegisterNumber { get; set; }
        public HospitalAddress HospitalAddress { get; set; }
        public ICollection<Employee> Employees { get; set; }    
        public ICollection<Service> Services { get; set; }

        public ICollection<Pateint> Pateints { get; set; }  

    }
}
