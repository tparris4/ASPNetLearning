using Microsoft.AspNetCore.Mvc;
using RunGroupApplicatiom.Data;
using RunGroupApplicatiom.Models;

namespace RunGroupApplicatiom.Controllers
{
    public class ClubController: Controller
    {
        private readonly ApplicationDbContext _context;
        // database
        // controls access to db
        public ClubController(ApplicationDbContext context)
        {
            // inject 
            
            _context = context;

        }

        public IActionResult Index()  // Controller
        {
            // going to the database, bringing a table back
            // ToList, need to call in order to execute the sql
            // var clubws is also List<Club> club
            List<Club> clubs = _context.Clubs.ToList();  // Model
            return View(clubs); // View
        }
    }
}
