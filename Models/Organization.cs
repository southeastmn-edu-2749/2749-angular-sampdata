using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WideWorld.Models
{
    public class Organization
    {
        public Organization()
        {
            OrgLocations = new HashSet<OrgLocation>();
            PeopleOrgs = new HashSet<PersonOrg>();
        }
        
        [Required]
        [Key]
        public int OrgId { get; set; }
        
        public int OrgRoleId { get; set; }

        [Required]
        [StringLength(50)]
        public string OrgName { get; set; }
        
        [StringLength(100)]
        public string WebAddress { get; set; }
        public int UpdatedByUserId { get; set; }
        
        [Column(TypeName = "datetime2(7)")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Updated { get; set; }
        public OrgRole OrgRole { get; set; }
        public int UpdatedByRoleKey { get; set; }
        public ICollection<OrgLocation> OrgLocations { get; set; }
        public ICollection<PersonOrg> PeopleOrgs { get; set; }
    }
}
