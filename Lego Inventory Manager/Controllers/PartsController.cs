using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LegoInventoryManager.DataAccess;
using LegoInventoryManager.Models;

namespace Lego_Inventory_Manager.Controllers
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
            return View();
        }
    }
}
