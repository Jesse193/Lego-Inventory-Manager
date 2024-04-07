using LegoInventoryManager.Models;
using LegoInventoryManager.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LegoInventoryManager.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
