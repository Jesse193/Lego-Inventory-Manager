using LegoInventoryManager.Models;
using LegoInventoryManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace LegoInventoryManager.Controllers
{
    public class PartListPartsController : Controller
    {
        private readonly ILegoApiService _legoApiService;

        public PartListPartsController(ILegoApiService legoApiService)
        {
            _legoApiService = legoApiService;
        }

        public async Task<IActionResult> Index(string listId, string userToken)
        {
            PartListPart myList = new PartListPart();
            myList = await _legoApiService.ListParts(listId, userToken);

            return View(myList);
        }
        public async Task<IActionResult> Post(string userToken, string listId, string partNumber, int Quantity, int colorId)
        {
            PartListPart myParts = new PartListPart();
            myParts = await _legoApiService.AddPartsToList(userToken, listId, partNumber, Quantity, colorId);
            return View(myParts);
        }

        public async Task<IActionResult> Put(string colorId, string userToken, string listId, string partNumber, int Quantity)
        {
            PartListPart part = new PartListPart();
            part = await _legoApiService.EditList(colorId, userToken, listId, partNumber, Quantity);

            return View(part);
        }
    }
}
