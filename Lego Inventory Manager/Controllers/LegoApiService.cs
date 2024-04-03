using LegoInventoryManager.Models;
using Microsoft.Extensions.Hosting;
using System.IO;
using System.Text.Json;
using System.Text;
using System;

namespace LegoInventoryManager.Controllers
{
    public interface ILegoApiService
    {
        Task<LegoModel> GetPart(string partNumber);
        Task<RootObject> GetPartColors(string partNumber);
        Task<LegoColorDetails> GetColorDetails(string elementNumber);
        Task<PartList> AddPartsToList(string userToken, string listId, string partNumber, int Quantity, int colorId);
        Task<AllList> GetAllLists(string userToken);
        Task<MyList> ShowList(string listId, string userToken);
        Task<PartList> EditPart(string colorId, string userToken, string listId, string partNumber, int Quantity);
    }
    public class LegoApiService : ILegoApiService
    {
        private readonly IConfiguration _config;

        public LegoApiService(IConfiguration config)
        {
            _config = config;
        }

        private static readonly HttpClient client;
        static LegoApiService()
        {
            client = new HttpClient()
            {
                BaseAddress = new Uri("https://rebrickable.com")
            };
        }

        public async Task<LegoModel> GetPart(string partNumber)
        {
            var apiKey = _config["API_KEY"];
            var url = string.Format($"/api/v3/lego/parts/{partNumber}?key={apiKey}");
            var result = new LegoModel();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();           

                result = JsonSerializer.Deserialize<LegoModel>(stringResponse);
            }
            return result;
        }

        public async Task<RootObject> GetPartColors(string partNumber)
        {
            var apiKey = _config["API_KEY"];
            var url = string.Format($"/api/v3/lego/parts/{partNumber}/colors?key={apiKey}");
            var result = new RootObject();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                result = JsonSerializer.Deserialize<RootObject>(stringResponse);
            }
            return result;
        }

        public async Task<LegoColorDetails> GetColorDetails(string elementNumber)
        {
            var apiKey = _config["API_KEY"];
            var url = string.Format($"/api/v3/lego/elements/{elementNumber}/?key={apiKey}");
            var result = new LegoColorDetails();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                result = JsonSerializer.Deserialize<LegoColorDetails>(stringResponse);
            }
            return result;
        }

        public async Task<PartList> AddPartsToList(string userToken, string listId, string partNumber, int Quantity, int colorId)
        {
            var apiKey = _config["API_KEY"];
            var url = string.Format($"/api/v3/users/{userToken}/partlists/{listId}/parts/?key={apiKey}");
            var postData = new PartList
            {
                PartNumber = partNumber,
                ColorId = colorId,
                Quantity = Quantity
            };
            var json = JsonSerializer.Serialize(postData);
            Console.WriteLine(json);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync(url, content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                var postResponse = JsonSerializer.Deserialize<PostResponse>(responseContent);
                Console.WriteLine(response.StatusCode);
            }
            else
            {
                Console.WriteLine(response.StatusCode);
            }
            return postData;
        }

        public async Task<AllList> GetAllLists(string userToken)
        {
            var apiKey = _config["API_KEY"];
            var url = string.Format($"/api/v3/users/{userToken}/partlists/?key={apiKey}");
            var result = new AllList();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                result = JsonSerializer.Deserialize<AllList>(stringResponse);
                Console.WriteLine(response.StatusCode);
            }
            return result;
        }

        public async Task<MyList> ShowList(string listId, string userToken)
        {
            var apiKey = _config["API_KEY"];
            var url = string.Format($"/api/v3/users/{userToken}/partlists/{listId}/parts?key={apiKey}");
            var result = new MyList();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                result = JsonSerializer.Deserialize<MyList>(stringResponse);
                Console.WriteLine(response.StatusCode);
            }
            return result;
        }

        public async Task<PartList> EditPart(string colorId, string userToken, string listId, string partNumber, int Quantity) 
        {
            var apiKey = _config["API_KEY"];
            var url = string.Format($"/api/v3/users/{userToken}/partlists/{listId}/parts/{partNumber}/{colorId}?key={apiKey}");
            var putData = new PartList
            {
                Quantity = Quantity
            };
            var json = JsonSerializer.Serialize(putData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PutAsync(url, content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                var postResponse = JsonSerializer.Deserialize<PostResponse>(responseContent);
                Console.WriteLine(response.StatusCode);
            }
            else
            {
                Console.WriteLine(response.StatusCode);
            }
            return putData;
        }
    }
}