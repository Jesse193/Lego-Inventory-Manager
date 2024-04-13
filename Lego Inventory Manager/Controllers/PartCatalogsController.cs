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

        public async Task<IActionResult> Index(string partNumber, int page = 1)
        {
            PartCatalog parts = new PartCatalog();
            parts = await _legoApiService.GetParts(partNumber, page);

            return View(parts);
        }
    }
}
