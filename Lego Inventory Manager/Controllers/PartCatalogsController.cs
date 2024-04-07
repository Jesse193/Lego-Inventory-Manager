using LegoInventoryManager.Models;
using LegoInventoryManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace LegoInventoryManager.Controllers
{
    public class PartCatalogsController : Controller
    {
        private readonly ILegoApiService _legoApiService;

        public PartCatalogsController(ILegoApiService legoApiService)
        {
            _legoApiService = legoApiService;
        }

        public async Task<IActionResult> Index(string partNumber)
        {
            PartCatalog parts = new PartCatalog();
            parts = await _legoApiService.GetParts(partNumber);

            return View(parts);
        }
    }
}
