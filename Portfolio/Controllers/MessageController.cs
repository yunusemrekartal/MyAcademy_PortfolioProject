using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class MessageController : Controller
    {
        private readonly AppDbContext _context;

        public MessageController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string filter="all")
        {
            if (filter=="all")
            {
                var messages = _context.UserMessages.ToList();
                return View(messages);
            }
            else if (filter=="unread")
            {
                var messages = _context.UserMessages.Where(msg => msg.IsRead == false).ToList();
                return View(messages);
            }
            else if (filter=="read")
            {
                var messages = _context.UserMessages.Where(msg => msg.IsRead == true).ToList();
                return View(messages);
            }
            else
            {
                return NoContent();
            }
            
        }
        public IActionResult MessageDetails(int id)
        {
            var userMessage = _context.UserMessages.Find(id);
            if (!userMessage.IsRead)
            {
                userMessage.IsRead = true;
                _context.SaveChanges();
            }
            return View(userMessage);
        }
    }
}
