using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly AppDbContext _context = new AppDbContext();

        public TestimonialController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var testimonials = _context.Testimonials.ToList();
            return View(testimonials);
        }
        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            var testimonialViewModel = new TestimonialViewModel
            {
                RatingList = new List<SelectListItem>
                {
                    new SelectListItem { Text = "1 Yıldız", Value = "1" },
                    new SelectListItem { Text = "2 Yıldız", Value = "2" },
                    new SelectListItem { Text = "3 Yıldız", Value = "3" },
                    new SelectListItem { Text = "4 Yıldız", Value = "4" },
                    new SelectListItem { Text = "5 Yıldız", Value = "5" }
                }
            };

            return View(testimonialViewModel);
        }
        [HttpPost]
        public IActionResult CreateTestimonial(TestimonialViewModel testimonialViewModel)
        {
            if (ModelState.IsValid)
            {
                var testimonial = new Testimonial
                {
                    FirstName = testimonialViewModel.FirstName,
                    LastName = testimonialViewModel.LastName,
                    Title = testimonialViewModel.Title,
                    Comment = testimonialViewModel.Comment,
                    Rating = testimonialViewModel.SelectedRating.Value
                };

                _context.Testimonials.Add(testimonial);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            testimonialViewModel.RatingList = new List<SelectListItem>
            {
                new SelectListItem { Text = "1 Yıldız", Value = "1" },
                new SelectListItem { Text = "2 Yıldız", Value = "2" },
                new SelectListItem { Text = "3 Yıldız", Value = "3" },
                new SelectListItem { Text = "4 Yıldız", Value = "4" },
                new SelectListItem { Text = "5 Yıldız", Value = "5" }
            };
            return View(testimonialViewModel);
        }
        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var testimonial = _context.Testimonials.Find(id);
            TestimonialViewModel testimonialViewModel = new TestimonialViewModel
            {
                Comment = testimonial.Comment,
                FirstName = testimonial.FirstName,
                LastName = testimonial.LastName,
                Title = testimonial.Title,
                SelectedRating = testimonial.Rating,
                RatingList = new List<SelectListItem>
                {
                    new SelectListItem { Text = "1 Yıldız", Value = "1" },
                    new SelectListItem { Text = "2 Yıldız", Value = "2" },
                    new SelectListItem { Text = "3 Yıldız", Value = "3" },
                    new SelectListItem { Text = "4 Yıldız", Value = "4" },
                    new SelectListItem { Text = "5 Yıldız", Value = "5" }
                }
            };
            return View(testimonialViewModel);
        }
        [HttpPost]
        public IActionResult UpdateTestimonial(TestimonialViewModel testimonialViewModel)
        {
            if (ModelState.IsValid==true)
            {
                var testimonial = new Testimonial
                {
                    Id=testimonialViewModel.Id,
                    FirstName = testimonialViewModel.FirstName,
                    LastName = testimonialViewModel.LastName,
                    Rating = testimonialViewModel.SelectedRating.Value,
                    Comment = testimonialViewModel.Comment,
                    Title = testimonialViewModel.Title
                };
                _context.Testimonials.Update(testimonial);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(testimonialViewModel);
        }
        public IActionResult DeleteTestimonial(int id)
        {
            var deleteTestimonial = _context.Testimonials.Find(id);
            _context.Testimonials.Remove(deleteTestimonial);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
