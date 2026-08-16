using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using System.Collections;

namespace Portfolio.ViewComponents.Default_Index
{
    public class _DefaultExperienceViewComponent : ViewComponent
    {
        private readonly AppDbContext _context = new AppDbContext();

        public _DefaultExperienceViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var experiences = _context.Experiences.ToList();
            return View(experiences);
        }
    }
}
