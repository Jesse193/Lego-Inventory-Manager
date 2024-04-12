using LegoInventoryManager.Models;
using LegoInventoryManager.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LegoInventoryManager.Controllers
{
    public class PartListsController : Controller
    {
        private readonly ILegoApiService _legoApiService;

        public PartListsController(ILegoApiService legoApiService)
        {
            _legoApiService = legoApiService;
        }

        public async Task<IActionResult> Index(string userToken)
        {
            PartList myLists = new PartList();
            myLists = await _legoApiService.GetAllLists(userToken);

            return View(myLists);
        }

        public async Task<IActionResult> Show(string userToken, string listId)
        {
            PartList myLists = new PartList();
            myLists = await _legoApiService.PartListDetails(userToken, listId);

            return View(myLists);
        }

        public async Task<IActionResult> Post(string userToken, string Name)
        {
            PartList newList = new PartList();
            newList = await _legoApiService.CreateNewList(userToken, Name);

            return View(newList);
        }

        public async Task<IActionResult> Delete(string userToken, string listId)
        {
            PartList deleteList = new PartList();
            deleteList = await _legoApiService.DeletePartList(userToken, listId);

            return View(deleteList);
        }
    }
}