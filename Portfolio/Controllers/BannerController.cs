using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class BannerController : Controller
    {
        private readonly AppDbContext _context;

        public BannerController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var banner = _context.Banners.FirstOrDefault();
            return View(banner);
        }
        [HttpGet]
        public IActionResult CreateBanner()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateBanner(Banner banner)
        {
            if (!ModelState.IsValid)
            {
                return View(banner);
            }
            _context.Banners.Add(banner);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateBanner(int id)
        {
            var bannner = _context.Banners.Find(id);
            return View(bannner);
        }
        [HttpPost]
        public IActionResult UpdateBanner(Banner banner)
        {
            if (!ModelState.IsValid)
            {
                return View(banner);
            }
            _context.Banners.Update(banner);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult DeleteBanner(Banner banner)
        {
            var deleteBanner = _context.Banners.Find(banner.Id);
            _context.Remove(deleteBanner);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
