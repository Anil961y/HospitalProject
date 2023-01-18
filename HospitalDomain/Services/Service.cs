using HospitalDomain.Hospitals;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDomain.Services
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Decimal Amount { get; set; }
        public Boolean IsDiscountable { get; set; }
        public int Creator_Id { get; set; }
        public DateTime Created_Date { get; set; }
        public string ValidDay { get; set; }
        public ICollection<ServiceType> serviceTypes {get; set; }   
        public Hospital Hospital { get; set; }
        public Service service { get; set; }
            }
}
