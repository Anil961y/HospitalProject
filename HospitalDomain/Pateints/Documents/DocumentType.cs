using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDomain.Pateints.Documents
{
    public class DocumentType
    {
        [Key]
        public string Id { get; set; }
        public string DocumentName { get; set; }
        public Document Document { get; set; }  

    }
}
