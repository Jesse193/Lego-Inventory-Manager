using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LegoInventoryManager.DataAccess;
using LegoInventoryManager.Models;

namespace LegoInventoryManager.Controllers
{
    public class SetsController : Controller
    {
        private readonly LegoInventoryManagerContext _context;

        public SetsController(LegoInventoryManagerContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
