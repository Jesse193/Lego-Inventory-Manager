using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LegoInventoryManager.DataAccess;
using LegoInventoryManager.Models;

namespace LegoInventoryManager.Controllers
{
    public class PartsController : Controller
    {
        private readonly LegoInventoryManagerContext _context;

        public PartsController(LegoInventoryManagerContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var parts = _context.Parts.AsEnumerable();

            ViewData["AllParts"] = _context.Parts.Select(m => m.Name).Distinct().ToList();
            return View(parts);
        }

       /* [HttpPost]
        public IActionResult Index(Part part)
        {
      
            _context.Parts.Add(part);
            _context.SaveChanges();

            
            var newPartId = part.Id;
        }
       */
    }
}
