using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using System.Net.WebSockets;

namespace Portfolio.ViewComponents.Default_Index
{
    public class _DefaultTestimonialViewComponent:ViewComponent
    {
        private readonly AppDbContext _context = new AppDbContext();

        public _DefaultTestimonialViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var testimonial = _context.Testimonials.ToList();
            return View(testimonial);
        }
    }
}
