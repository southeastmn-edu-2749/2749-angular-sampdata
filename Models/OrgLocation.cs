using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WideWorld.Models
{
    public class OrgLocation
    {
        public OrgLocation()
        {

        }
        
        [Required]
        [Key]
        public int OrgLocationId { get; set; }
        
        public int OrgId { get; set; }

        [Required]
        [StringLength(35)]
        public string Address1 { get; set; }

        [StringLength(35)]
        public string Address2 { get; set; }

        [Required]
        [StringLength(30)]
        public string City { get; set; }

        [Required]
        [StringLength(3)]
        public string StateRegion { get; set; }

        [Required]
        [StringLength(15)]
        public string PostalCode { get; set; }

        [StringLength(30)]
        public string Country { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }
        
        [Column(TypeName = "datetime2(7)")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Updated { get; set; }
        public int UpdatedByUserId { get; set; }

        [StringLength(50)]
        public string OrgLocationName { get; set; }
        
        [StringLength(100)]
        public string OrgLocationWebAddress { get; set; }
        public int UpdatedByRoleKey { get; set; }
        public Organization Organization { get; set; }
    }
}
