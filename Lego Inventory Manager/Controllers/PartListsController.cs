using LegoInventoryManager.Models;
using LegoInventoryManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace LegoInventoryManager.Controllers
{
    public class PartListsController : Controller
    {
        private readonly ILegoApiService _legoApiService;

        public PartListsController(ILegoApiService legoApiService)
        {
            _legoApiService = legoApiService;
        }

        public async Task<IActionResult> Show(string listId, string userToken)
        {
            PartList myList = new PartList();
            myList = await _legoApiService.ShowList(listId, userToken);

            return View(myList);
        }
        public async Task<IActionResult> Post(string userToken, string listId, string partNumber, int Quantity, int colorId)
        {
            PartList myParts = new PartList();
            myParts = await _legoApiService.AddPartsToList(userToken, listId, partNumber, Quantity, colorId);
            return View(myParts);
        }

        public async Task<IActionResult> Put(string colorId, string userToken, string listId, string partNumber, int Quantity)
        {
            PartList part = new PartList();
            part = await _legoApiService.EditList(colorId, userToken, listId, partNumber, Quantity);

            return View(part);
        }
    }
}
