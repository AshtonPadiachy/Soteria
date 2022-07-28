using SoteriaProjectWebApi.enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoteriaProjectWebApi.Models
{
    public class ParentProfile
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ParentProfileId { get; set; }  

        public string Password { get; set; }
        public string ParentName { get; set; }
        public string ParentSurname { get; set; }
        public string Email { get; set; }
        public int ParentAge { get; set; }
        public int MaritalStatus { get; set; }
        public string ParentCellNumber { get; set; }


        [ForeignKey("Authentication")]

        public int? AuthenticationId { get; set; }
        public  Authentication? Authentications { get; set; }
       // public ICollection<TeacherProfile>? TeacherProfiles { get; set; }
         


    }
}
