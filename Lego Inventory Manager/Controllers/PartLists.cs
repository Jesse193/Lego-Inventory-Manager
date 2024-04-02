using LegoInventoryManager.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LegoInventoryManager.Controllers
{
	public class PartLists : Controller
	{
		private readonly ILegoApiService _legoApiService;

		public PartLists(ILegoApiService legoApiService)
		{
			_legoApiService = legoApiService;
		}

		public async Task<IActionResult> Post(string userToken, string listId, string partNumber, int Quantity, int colorId)
		{
			PartList myParts = new PartList();
			myParts = await _legoApiService.AddPartsToList(userToken, listId, partNumber, Quantity, colorId);

			return View(myParts);
		}
	}
}
