using LegoInventoryManager.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LegoInventoryManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILegoApiService _legoApiService;

        public HomeController(ILegoApiService legoApiService)
        {
            _legoApiService = legoApiService;
        }

        public async Task<IActionResult> Index(string partNumber)
        {
            LegoModel part = new LegoModel();
            part = await _legoApiService.GetPart(partNumber);

            return View(part);
        }
    }
}
