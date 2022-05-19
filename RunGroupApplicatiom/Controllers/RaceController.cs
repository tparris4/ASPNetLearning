using Microsoft.AspNetCore.Mvc;

namespace RunGroupApplicatiom.Controllers
{
    public class RaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
