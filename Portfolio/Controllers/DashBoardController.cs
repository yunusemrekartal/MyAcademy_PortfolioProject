using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class DashBoardController : Controller
    {
        private readonly AppDbContext _context;

        public DashBoardController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var adminDashBoardModel = new AdminDashboardViewModel()
            {
                TotalProjects = _context.Projects.Count(),
                TotalMessages = _context.UserMessages.Count(),
                UnreadMessagesCount = _context.UserMessages.Where(msg => msg.IsRead == false).Count(),
                Testimonials = _context.Testimonials.Count()
            };
            ViewBag.projects = _context.Projects.ToList();
            return View(adminDashBoardModel);
        }
    }
}
