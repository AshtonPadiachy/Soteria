using SoteriaProjectWebApi.Models;

namespace SoteriaProjectWebApi.Data
{
    public class DbInitialiser
    {
        private readonly SoteriaContext _context;

        public DbInitialiser(SoteriaContext context)
        {
            _context = context;
        }

        public void Run()
        {
            if (!_context.Zones.Any())
            {
                var zone = new Zone();
                zone.Description = "Green";
                _context.Zones.Add(zone);

                zone = new Zone();
                zone.Description = "Yellow";
                _context.Zones.Add(zone);

                zone = new Zone();
                zone.Description = "Blue";
                _context.Zones.Add(zone);

                zone = new Zone();
                zone.Description = "Red";
                _context.Zones.Add(zone);


                _context.SaveChanges();

            }


            

            //if ()
        }
        
    }
}
