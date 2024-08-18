using _11_MVC_FulboolOrnek.Context;
using _11_MVC_FulboolOrnek.Models;
using _11_MVC_FulboolOrnek.Models.VM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace _11_MVC_FulboolOrnek.Controllers
{
    public class FutbolcuController : Controller
    {
        private readonly ApplicationDbContext _context;//field
        public FutbolcuController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Futbolcu>futbolcular=_context.Futbolcu.ToList();    
            return View(futbolcular);
        }
        public IActionResult Create()
        {
            VMCreateFutbolcu vMCreateFutbolcu = new VMCreateFutbolcu();
            vMCreateFutbolcu.Mevkiler=_context.Mevki.ToList();
            vMCreateFutbolcu.Takimlar=_context.Takim.ToList();
            return View(vMCreateFutbolcu);

        }

        [HttpPost] 
        public  IActionResult Create(Futbolcu futbolcu)
        {
            _context.Futbolcu.Add(futbolcu);
            _context.SaveChanges();
            return RedirectToAction("Index");   

        }
    }
}
