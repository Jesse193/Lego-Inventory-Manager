using LegoInventoryManager.Models;
using LegoInventoryManager.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LegoInventoryManager.Controllers
{
    public class ListsController : Controller
    {
        private readonly ILegoApiService _legoApiService;

        public ListsController(ILegoApiService legoApiService)
        {
            _legoApiService = legoApiService;
        }

        public async Task<IActionResult> Index(string userToken)
        {
            List myLists = new List();
            myLists = await _legoApiService.GetAllLists(userToken);

            return View(myLists);
        }
    }
}