using Microsoft.EntityFrameworkCore;

namespace SoteriaProjectWebApi.Data
{
    public class SoteriaContext 
        : DbContext
    {
        public SoteriaContext(DbContextOptions options)
            : base(options)
        {

        }
    }
}
