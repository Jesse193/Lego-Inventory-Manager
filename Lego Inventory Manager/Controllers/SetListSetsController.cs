﻿using LegoInventoryManager.Models;
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
        public async Task<IActionResult> Index(string userToken, string listId, int page = 1)
        {
            SetListSet setListSets = new SetListSet();
            setListSets = await _legoApiService.SetListSets(userToken, listId, page);

            return View(setListSets);
        }

        public async Task<IActionResult> Put(string userToken, string listId, string setNumber, int Quantity )
        {
            SetListSet updatedQuantity = new SetListSet();
            updatedQuantity = await _legoApiService.ChangeSetQuantity(userToken, listId, setNumber, Quantity);

            return View(updatedQuantity);
        }

        public async Task<IActionResult> Post(string userToken, string setListNumber, string setNumber)
        {
            SetListSet newList = new SetListSet();
            newList = await _legoApiService.AddSetToSetList(userToken, setListNumber, setNumber);

            return View(newList);
        }
    }
}
