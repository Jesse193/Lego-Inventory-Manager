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

        public async Task<IActionResult> Index(string userToken)
        {
            SetList setLists = new SetList();
            setLists = await _legoApiService.GetSetLists(userToken);

            return View(setLists);
        }

        public async Task<IActionResult> Show(string userToken, string listId)
        {
            SetListShow setListSets = new SetListShow();
            setListSets = await _legoApiService.GetSetListSets(userToken, listId);

            return View(setListSets);
        }
        public async Task<IActionResult> Post(string userToken, string Name)
        {
            SetList newList = new SetList();
            newList = await _legoApiService.CreateNewSetList(userToken, Name);

            return View(newList);
        }
    }
}
