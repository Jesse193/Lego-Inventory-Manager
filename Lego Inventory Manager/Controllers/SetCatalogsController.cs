using LegoInventoryManager.Models;
using LegoInventoryManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace LegoInventoryManager.Controllers
{
    public class SetCatalogsController : Controller
    {
        private readonly ILegoApiService _legoApiService;

        public SetCatalogsController(ILegoApiService legoApiService)
        {
            _legoApiService = legoApiService;
        }

        public async Task<IActionResult> Index(string searchTerm, int page = 1)
        {
            SetCatalog getSets = new SetCatalog();
            getSets = await _legoApiService.GetSets(searchTerm, page);

            return View(getSets);
        }

        public async Task<IActionResult> Show(string setNumber, int page = 1)
        {
            SetShow Set = new SetShow();
            Set = await _legoApiService.SetDetails(setNumber, page);

            return View(Set);
        }
    }
}
