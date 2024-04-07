using LegoInventoryManager.Models;
using LegoInventoryManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace LegoInventoryManager.Controllers
{
    public class SetsController : Controller
    {
        private readonly ILegoApiService _legoApiService;

        public SetsController(ILegoApiService legoApiService)
        {
            _legoApiService = legoApiService;
        }

        public async Task<IActionResult> Index(string userToken)
        {
            Set getSets = new Set();
            getSets = await _legoApiService.GetSets(userToken);

            return View(getSets);
        }

        public async Task<IActionResult> Show(string setNumber)
        {
            Set Set = new Set();
            Set = await _legoApiService.SetDetails(setNumber);

            return View(Set);
        }
    }
}
