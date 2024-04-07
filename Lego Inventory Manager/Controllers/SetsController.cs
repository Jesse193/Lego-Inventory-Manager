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
            Set getSet = new Set();
            getSet = await _legoApiService.GetSet(userToken);

            return View(getSet);
        }
    }
}
