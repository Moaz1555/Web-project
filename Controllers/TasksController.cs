using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TasksController : Controller
    {
        public Maindb _context = new Maindb();
        public IActionResult Index()
        {
            List<Tasks> tasks = _context.Tasks.Include(e=> e.TeamMember).ToList();
          
            return View(tasks);
        }
        public IActionResult update(int id)
        {
            Tasks tasks= _context.Tasks.FirstOrDefault(e=> e.Id==id); 
            return View(tasks);
        }
        [HttpPost]
        public IActionResult update(Tasks tasks)
        {
            _context.Tasks.Update(tasks);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
