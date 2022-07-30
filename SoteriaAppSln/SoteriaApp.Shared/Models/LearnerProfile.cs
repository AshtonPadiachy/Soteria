using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoteriaProjectWebApi.Models
{
    public class LearnerProfile
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LearnerId { get; set; }

        public string LearnerName { get; set; }
        public string LearnerSurname { get; set; }
        public int LearnerGender { get; set; }
        public int LearnerAge { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdNumber { get; set; }
        public int LearnerGrade { get; set; }
        public string ParentName { get; set; }
        public string ParentSurname { get; set; }
        public string Email { get; set; }
        public int ParentAge { get; set; }
        public int MaritalStatus { get; set; }
        public string ParentCellNumber { get; set; }

        [ForeignKey("TeacherProfile")]
        public int TeacherProfileId { get; set; }

        public ICollection <Report> Reports { get; set; }
        



    }
}
