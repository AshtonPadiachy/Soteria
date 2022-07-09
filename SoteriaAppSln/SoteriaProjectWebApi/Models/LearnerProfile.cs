using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoteriaProjectWebApi.Models
{
    public class LearnerProfile
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int learnerId { get; set; }
        public string LearnerName { get; set; }
        public string LearnerSurname { get; set; }
        public Enum LearnerGender { get; set; }
        public Enum learnerAge { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string LearnerIdNumber { get; set; }
        public string LearnerGrade { get; set; }
        public int ParentId { get; set; }
        public string ParentName { get; set; }
        public string ParentSurname { get; set; }
        public string ParentEmail { get; set; }    
        public Enum ParentAge { get; set; }
        public Enum MaritalStatus { get; set; }
        public string CellNumber { get; set; }
        public ICollection<TeacherProfile> Teachers { get; set; }
        



    }
}
