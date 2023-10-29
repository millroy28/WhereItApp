using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using WhereItApp.Models;


namespace WhereItApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly WhereItAppContext _context;
        public HomeController(ILogger<HomeController> logger, WhereItAppContext context)
        {
            _logger = logger;
            _context = context;
        }
        
        [Authorize]
        public IActionResult Index()
        {
            int userId = GetUserId();
            if (userId == 0)
            {
                return RedirectToAction("SetupNewUser");
            } else if (userId == -1)
            {
                return RedirectToAction("NoAccount");
            }
            return View();
        }
        [Authorize]
        [HttpGet]
        public IActionResult SetupNewUser()
        {
            return View();
        }

        public IActionResult NoAccount()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public int GetUserId()
        {
            var aspNetUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            int currentUserId = 0;

            if (aspNetUserId != null)
            {
                currentUserId = _context.Users.Where(x => x.AspNetUserId == aspNetUserId).Select(x => x.Id).FirstOrDefault();
            }
            else
            {
                currentUserId = -1;
            }

            return currentUserId;
        }
    }
}