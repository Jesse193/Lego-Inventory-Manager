using LegoInventoryManager.Models;
using LegoInventoryManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace LegoInventoryManager.Controllers
{
    public class PartColorsController : Controller
    {
        private readonly ILegoApiService _legoApiService;

        public PartColorsController(ILegoApiService legoApiService)
        {
            _legoApiService = legoApiService;
        }

        public async Task<IActionResult> Index(string partNumber)
        {
            PartColor colors = new PartColor();
            colors = await _legoApiService.GetPartColors(partNumber);

            return View(colors);
        }
        public async Task<IActionResult> Show(string elementNumber)
        {
            PartColorShow colorDetails = new PartColorShow();
            colorDetails = await _legoApiService.GetColorDetails(elementNumber);

            return View(colorDetails);
        }
    }
}
