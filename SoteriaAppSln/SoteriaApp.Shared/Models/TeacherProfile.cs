using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoteriaProjectWebApi.Models
{
    public class TeacherProfile
    {

        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherProfileId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }    
        public string  TeacherName { get; set; }
        public string TeacherSurname { get; set; }
        public string TeacherCellNumber { get; set; }

        [ForeignKey("profiletype")]
        public int ProfileTypeId { get; set; }
        public ProfileType ProfileTypes { get; set; }   

        [ForeignKey("Authentication")]

        public int? AuthenticationId { get; set; }
        public Authentication? Authentications { get; set; }
        public ICollection<LearnerProfile> LearnerProfiles  { get; set; }
        public ICollection<ParentProfile> ParentProfiles { get; set; }
        public ICollection<Report> Reports { get; set; }
        


    }
}
