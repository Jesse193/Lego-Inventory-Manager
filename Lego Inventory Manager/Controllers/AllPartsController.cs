using LegoInventoryManager.Models;
using LegoInventoryManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace LegoInventoryManager.Controllers
{
    public class AllPartsController : Controller
    {
        private readonly ILegoApiService _legoApiService;

        public AllPartsController(ILegoApiService legoApiService)
        {
            _legoApiService = legoApiService;
        }

        public async Task<IActionResult> Index(string userToken, int page = 1)
        {
            AllPart allParts = new AllPart();
            allParts = await _legoApiService.AllParts(userToken, page);

            return View(allParts);
        }
    }
}
