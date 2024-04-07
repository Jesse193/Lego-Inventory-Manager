using LegoInventoryManager.Models;
using LegoInventoryManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace LegoInventoryManager.Controllers
{
    public class SetListSetsController : Controller
    {
        private readonly ILegoApiService _legoApiService;

        public SetListSetsController(ILegoApiService legoApiService)
        {
            _legoApiService = legoApiService;
        }

        public async Task<IActionResult> Post(string userToken, string setListNumber, string setNumber)
        {
            SetListSet newList = new SetListSet();
            newList = await _legoApiService.AddSetToSetList(userToken, setListNumber, setNumber);

            return View(newList);
        }
    }
}
