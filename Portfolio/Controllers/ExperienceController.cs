using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly AppDbContext _context = new AppDbContext();

        public ExperienceController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var experiences = _context.Experiences.ToList();
            return View(experiences);
        }
        public IActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            if (ModelState.IsValid)
            {
                _context.Experiences.Add(experience);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult UpdateExperience(int id)
        {
            var updateExperience = _context.Experiences.Find(id);
            return View(updateExperience);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            if (ModelState.IsValid)
            {
                _context.Experiences.Update(experience);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult DeleteExperience(int id)
        {
            var deleteExperience = _context.Experiences.Find(id);
            _context.Experiences.Remove(deleteExperience);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
