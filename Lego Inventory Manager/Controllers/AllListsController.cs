using LegoInventoryManager.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LegoInventoryManager.Controllers
{
    public class AllListsController : Controller
    {
        private readonly ILegoApiService _legoApiService;

        public AllListsController(ILegoApiService legoApiService)
        {
            _legoApiService = legoApiService;
        }

        public async Task<IActionResult> Index(string userToken)
        {
            AllList myLists = new AllList();
            myLists = await _legoApiService.GetAllLists(userToken);

            return View(myLists);
        }

        public async Task<IActionResult> Show(string listId, string userToken)
        {
            MyList myList = new MyList();
            myList = await _legoApiService.ShowList(listId, userToken);

            return View(myList);
        }
    }
}