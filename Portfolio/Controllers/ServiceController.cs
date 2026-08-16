using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context = new AppDbContext();

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var services = _context.Services.ToList();
            return View(services);
        }
        public IActionResult CreateService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateService(Service service)
        {
            if (ModelState.IsValid)
            {
                _context.Services.Add(service);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult UpdateService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            if (ModelState.IsValid)
            {
                _context.Services.Update(service);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult DeleteService(int id)
        {
            var deleteService = _context.Services.Find(id);
            _context.Services.Remove(deleteService);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
