using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WideWorld.Models
{
    public class OrgRole
    {
        public OrgRole()
        {
            Organizations = new HashSet<Organization>();
        }
        
        [Required]
        [Key]
        public int OrgRoleId { get; set; }

        [Required]
        [StringLength(15)]
        public string OrgRoleName { get; set; }
        public int UpdatedByUserId { get; set; }
        
        [Column(TypeName = "datetime2(7)")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Updated { get; set; }
        public ICollection<Organization> Organizations { get; set; }
    }
}
