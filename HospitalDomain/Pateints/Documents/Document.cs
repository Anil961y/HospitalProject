using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDomain.Pateints.Documents
{
    public class Document
    {
        [Key]
        public int Id { get; set; }
        public string Url { get; set; }
        public ICollection<DocumentType> documentTypes { get; set; }

        public ICollection<Pateint> Pateints { get; set; }  

    }
}
