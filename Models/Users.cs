using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WideWorld.Models
{
    public class Users {
        [Required]
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "bit")]
        public bool IsSuperUser { get; set; }

        public int? AffiliateId { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        [Required]
        [StringLength(128)]
        public string DisplayName { get; set; }

        [Required]
        [Column(TypeName = "bit")]
        public bool UpdatePassword { get; set; }

        [StringLength(50)]
        public string LastIpAddress { get; set; }

        [Required]
        [Column(TypeName = "bit")]
        public bool IsDeleted { get; set; }

        public int? CreatedByUserId { get; set; }
        
        [Column(TypeName = "datetime2(7)")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? CreatedOnDate { get; set; }

        public int? LastModifiedByUserID { get; set; }
        
        [Column(TypeName = "datetime2(7)")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? LastModifiedOnDate { get; set; }
        public System.Guid? PasswordResetToken { get; set; }
        
        [Column(TypeName = "datetime2(7)")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? PasswordResetExpiration { get; set; }

        [StringLength(256)]
        public string LowerEmail { get; set; }
}

}