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
    }
}