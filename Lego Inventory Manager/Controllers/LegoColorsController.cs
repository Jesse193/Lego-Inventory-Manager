using LegoInventoryManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace LegoInventoryManager.Controllers
{
    public class LegoColorsController : Controller
    {
        private readonly ILegoApiService _legoApiService;

        public LegoColorsController(ILegoApiService legoApiService)
        {
            _legoApiService = legoApiService;
        }
        public async Task<IActionResult> Show(string elementNumber)
        {
            LegoColorDetails colorDetails = new LegoColorDetails();
            colorDetails = await _legoApiService.GetColorDetails(elementNumber);

            return View(colorDetails);
        }
    }
}
