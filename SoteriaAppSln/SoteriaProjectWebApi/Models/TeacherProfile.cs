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
        public string UserName { get; set; }
        public string   TeacherName { get; set; }
        public string TeacherSurname { get; set; }
        public string TeacherCellNumber { get; set; }

        [ForeignKey("Authentication")]

        public int AuthenticationId { get; set; }
        public Authentication? Authentications { get; set; }
        public ICollection<LearnerProfile> Learners  { get; set; }


    }
}
