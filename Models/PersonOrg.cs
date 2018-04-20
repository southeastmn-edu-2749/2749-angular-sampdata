using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WideWorld.Models
{
    public class PersonOrg {
        public int PersonId { get; set; }
        public int OrgId { get; set; }
        public int LastEditedBy { get; set; }
        public Person Person { get; set; }
        public Organization Organization { get; set; }
    }

}