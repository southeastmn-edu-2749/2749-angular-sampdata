using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace WideWorld.Models
{
    public class Person
    {
        [Required]
        [Key]
        public int PersonId { get; set; }
        
        [Timestamp]
        public byte[] RowVersion { get; set; }
        
        [Required]
        public int LastEditedBy { get; set; }
    }
}