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
            SetList setList = new SetList();
            setList = await _legoApiService.SetListDetails(userToken, listId);

            return View(setList);
        }
        
        public async Task<IActionResult> Post(string userToken, string Name)
        {
            SetList newList = new SetList();
            newList = await _legoApiService.CreateNewSetList(userToken, Name);

            return View(newList);
        }

        public async Task<IActionResult> Delete(string userToken, string listId)
        {
            SetList deleteList = new SetList();
            deleteList = await _legoApiService.DeleteSetList(userToken, listId);

            return View(deleteList);
        }
    }
}
