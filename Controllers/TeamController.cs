using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TeamController : Controller
    {
        public Maindb _context= new Maindb();
        public IActionResult Index()
        {
            List<TeamMember> member = _context.TeamMember.Include(e => e.tasks).ToList();
            return View(member);
           
        }
        public IActionResult details(int id)
        {

            List<Tasks> k = _context.Tasks.Where(e => e.MemberId == id).Include(s=>s.Project).ToList();
            //ViewBag.detail = g;
            return View(k);

        }


        public IActionResult update(int id)
        {
            Tasks teamm = _context.Tasks.FirstOrDefault(e => e.MemberId == id);
            return View(teamm);
            //TeamMember teamm = _context.TeamMember.FirstOrDefault(e => e.MemberId == id);
            //return View(teamm);
        }
        [HttpPost]
        public IActionResult update(/*TeamMember teamm*/ Tasks teamm)
        {
            _context.Tasks.Update(teamm);
          //_context.TeamMember.Update(teamm);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
