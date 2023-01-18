using HospitalDomain.Pateints;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDomain.OPDS
{
    public class OPD
    {
        [Key]
        public int Id { get; set; }
        public  DateTime Date { get; set; }
        public DateTime ValidUptoDate { get; set; }
        public Int64 Invoice_Number { get; set; }
        public int DayNumber { get; set; }
        public Int64 DoctorId { get; set; }
        public Int64 OperatorId { get; set; }
        public string Description { get; set; }
        public int Weight { get; set; }
        public int BP { get; set; }
        public int Temprature { get; set; }
        public Decimal Discount { get; set; }
        public Decimal Amount { get; set; }
        public Pateint Pateint { get; set; }

    }
}
