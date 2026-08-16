using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;

namespace Portfolio.ViewComponents.Default_Index
{
    public class _DefaultProjectsViewComponent : ViewComponent
    {
        private readonly AppDbContext _context = new AppDbContext();

        public _DefaultProjectsViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var projects = _context.Projects.ToList();
            return View(projects);
        }
    }
}
