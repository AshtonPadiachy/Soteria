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

        public string Email { get; set; }   
        public string Password { get; set; }

        [ForeignKey("Authentication")]

        public int AuthenticationId { get; set; }
        public  Authentication? Authentications { get; set; }
        public ICollection<TeacherProfile> TeacherProfiles { get; set; }
         


    }
}
