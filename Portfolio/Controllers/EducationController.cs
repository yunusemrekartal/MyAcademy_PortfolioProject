using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class EducationController : Controller
    {
        private readonly AppDbContext _context = new AppDbContext();

        public EducationController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var educations = _context.Educations.ToList();
            return View(educations);
        }
        public IActionResult CreateEducation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEducation(Education education)
        {
            if (ModelState.IsValid)
            {
                _context.Educations.Add(education);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult UpdateEducation(int id)
        {
            var education = _context.Educations.Find(id);
            return View(education);
        }
        [HttpPost]
        public IActionResult UpdateEducation(Education education)
        {
            if (ModelState.IsValid)
            {
                _context.Educations.Update(education);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult DeleteEducation(int id)
        {
            var deleteEducation = _context.Educations.Find(id);
            _context.Educations.Remove(deleteEducation);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
