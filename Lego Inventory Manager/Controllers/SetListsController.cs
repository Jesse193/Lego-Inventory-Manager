using LegoInventoryManager.Services;
using Microsoft.AspNetCore.Mvc;
using LegoInventoryManager.Models;

namespace LegoInventoryManager.Controllers
{
    public class SetListsController : Controller
    {
        private readonly ILegoApiService _legoApiService;

        public SetListsController(ILegoApiService legoApiService)
        {
            _legoApiService = legoApiService;
        }
        public async Task<IActionResult> Post(string userToken, string Name)
        {
            SetList newList = new SetList();
            newList = await _legoApiService.CreateNewSetList(userToken, Name);

            return View(newList);
        }
    }
}
