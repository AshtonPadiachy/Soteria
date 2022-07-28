using Microsoft.EntityFrameworkCore;
using SoteriaProjectWebApi.Models;

namespace SoteriaProjectWebApi.Data
{
    public class SoteriaContext
        : DbContext
    {
        public SoteriaContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<TeacherProfile> TeacherProfiles { get; set; }
        public DbSet<ParentProfile> ParentProfiles { get; set; }
        public DbSet<LearnerProfile> learnerProfiles { get; set; }
        public DbSet<Authentication> Authentications { get; set; }
        public DbSet<Report> Reports { get; set; } 
        public DbSet<Zone> Zones { get; set; }  
            
    }
}
 