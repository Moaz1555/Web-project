using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProjectController : Controller
    {
        public Maindb _context = new Maindb();
        public IActionResult Index()
        {
            List<Project> projects = _context.Project.ToList();
            return View(projects);
            
        }
        public IActionResult details(int id)
        {
           
            List < Tasks > g= _context.Tasks.Where(e =>e.ProjectId == id).Include(l=>l.TeamMember).ToList();
            //ViewBag.detail = g;
            return View(g);
            
        }

        public IActionResult create()
        {
          
            return View();

        }
        [HttpPost]
        public IActionResult create(Project project)
        {
           
            _context.Project.Add(project);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult update(int id)
        {
            Project project = _context.Project.FirstOrDefault(m => m.ProjectId == id);


            return View(project);
            

        }
        [HttpPost]
        public IActionResult update(Project project)
        {
          _context.Project.Update(project);
            _context.SaveChanges();
            return RedirectToAction("Index");


        }

        public IActionResult delete(int id) 
        {
        var project = _context.Project.FirstOrDefault(x => x.ProjectId == id);
            _context.Project.Remove(project);
            _context.SaveChanges();
            return RedirectToAction("Index");
        
        }


    }
}
