using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoteriaProjectWebApi.Models
{
    public class Report
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ReportsId { get; set; }

       
        public string CommentOnZones { get; set; }

        public DateTime dateTime { get; set; } 

        [ForeignKey("LearnerProfile")]
        public int LearnerId { get; set; }

        public int Participation { get; set; }

        public string CommentOnParticipation { get; set; }
        public int SocialSkills { get; set; }
        public string CommentOnSocialSkills { get; set; }
        public int CreativitySkills { get; set; }
        public string CommentOnCreativitySkills { get; set; }
        public string Tips { get; set; }

        [ForeignKey("Zone")]

        public int ZoneId { get; set; } 

        public Zone? Zone { get; set; }  


       // public ICollection<Zone> Zones { get; set; }    
        //public ICollection<TeacherProfile> TeacherProfiles { get; set; }

       






    }
}
