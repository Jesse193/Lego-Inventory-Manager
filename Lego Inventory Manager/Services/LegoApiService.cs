using LegoInventoryManager.Models;
using Microsoft.Extensions.Hosting;
using System.IO;
using System.Text.Json;
using System.Text;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace LegoInventoryManager.Services
{
    public interface ILegoApiService
    {
        Task<PartCatalog> GetParts(string partNumber);
        Task<PartColor> GetPartColors(string partNumber);
        Task<PartColorShow> GetColorDetails(string elementNumber);
        Task<PartListPart> AddPartsToList(string userToken, string listId, string partNumber, int Quantity, int colorId);
        Task<PartListPart> EditList(string colorId, string userToken, string listId, string partNumber, int Quantity);
        Task<PartListPart> ListParts(string listId, string userToken);
        Task<PartList> GetAllLists(string userToken);
        Task<PartList> CreateNewList(string userToken, string Name);
        Task<SetCatalog> GetSets(string searchTerm);
        Task<SetShow> SetDetails(string setNumber);
        Task<SetList> CreateNewSetList(string userToken, string Name);
        Task<SetListSet> AddSetToSetList(string userToken, string setListNumber, string setNumber);
        Task<SetList> GetSetLists(string userToken);
        Task<SetListSet> SetListSets(string userToken, string listId);
        Task<SetListSet> ChangeSetQuantity(string userToken, string listId, string setNumber, int Quantity);
        Task<AllPart> AllParts(string userToken, int page);
        Task<PartList> PartListDetails(string userToken, string listId);
        Task<SetList> SetListDetails(string userToken, string listId);
        Task<PartList> DeletePartList(string userId, string listId);
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

        public async Task<PartCatalog> GetParts(string partNumber)
        {
            var apiKey = _config["API_KEY"];
            var url = string.Format($"/api/v3/lego/parts/?search={partNumber}pr&key={apiKey}");
            var result = new PartCatalog();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();           

                result = JsonSerializer.Deserialize<PartCatalog>(stringResponse);
            }
            return result;
        }

        public async Task<PartColor> GetPartColors(string partNumber)
        {
            var apiKey = _config["API_KEY"];
            var url = string.Format($"/api/v3/lego/parts/{partNumber}/colors?key={apiKey}");
            var result = new PartColor();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                result = JsonSerializer.Deserialize<PartColor>(stringResponse);
            }
            return result;
        }

        public async Task<PartColorShow> GetColorDetails(string elementNumber)
        {
            var apiKey = _config["API_KEY"];
            var url = string.Format($"/api/v3/lego/elements/{elementNumber}/?key={apiKey}");
            var result = new PartColorShow();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                result = JsonSerializer.Deserialize<PartColorShow>(stringResponse);
            }
            return result;
        }

        public async Task<PartListPart> AddPartsToList(string userToken, string listId, string partNumber, int Quantity, int colorId)
        {
            var apiKey = _config["API_KEY"];
            var url = string.Format($"/api/v3/users/{userToken}/partlists/{listId}/parts/?key={apiKey}");
            var postData = new PartListPart
            {
                PartNumber = partNumber,
                ColorId = colorId,
                Quantity = Quantity
            };
            var json = JsonSerializer.Serialize(postData);
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

        public async Task<PartList> GetAllLists(string userToken)
        {
            var apiKey = _config["API_KEY"];
            var url = string.Format($"/api/v3/users/{userToken}/partlists/?key={apiKey}");
            var result = new PartList();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                result = JsonSerializer.Deserialize<PartList>(stringResponse);
                Console.WriteLine(response.StatusCode);
            }
            return result;
        }

        public async Task<PartListPart> ListParts(string listId, string userToken)
        {
            var apiKey = _config["API_KEY"];
            var url = string.Format($"/api/v3/users/{userToken}/partlists/{listId}/parts?key={apiKey}");
            var result = new PartListPart();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                result = JsonSerializer.Deserialize<PartListPart>(stringResponse);
                Console.WriteLine(response.StatusCode);
            }
            return result;
        }

        public async Task<PartListPart> EditList(string colorId, string userToken, string listId, string partNumber, int Quantity)
        {
            var apiKey = _config["API_KEY"];
            var url = string.Format($"/api/v3/users/{userToken}/partlists/{listId}/parts/{partNumber}/{colorId}?key={apiKey}");
            var putData = new PartListPart
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

        public async Task<PartList> CreateNewList(string userToken, string Name)
        {
            var apiKey = _config["API_KEY"];
            var url = string.Format($"/api/v3/users/{userToken}/partlists/?key={apiKey}");
            var postData = new PartList
            {
                Name = Name
            };
            var json = JsonSerializer.Serialize(postData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync(url, content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                var postResponse = JsonSerializer.Deserialize<PostResponse>(responseContent);
            } else
            {
                Console.WriteLine(response.StatusCode);
            }
            return postData;
        }

        public async Task<SetCatalog> GetSets(string searchTerm)
        {
            var apiKey = _config["API_KEY"];
            var url = string.Format($"/api/v3/lego/sets/?search={searchTerm}&key={apiKey}");
            var result = new SetCatalog();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                result = JsonSerializer.Deserialize<SetCatalog>(stringResponse);
                Console.WriteLine(response.StatusCode);
            }
            return result;
        }

        public async Task<SetShow> SetDetails(string setNumber)
        {
            var apiKey = _config["API_KEY"];
            var url = string.Format($"/api/v3/lego/sets/{setNumber}/parts/?key={apiKey}");
            var result = new SetShow();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                result = JsonSerializer.Deserialize<SetShow>(stringResponse);
                Console.WriteLine(response.StatusCode);
            }
            return result;
        }

        public async Task<SetList> CreateNewSetList(string userToken, string Name)
        {
            var apiKey = _config["API_KEY"];
            var url = string.Format($"/api/v3//users/{userToken}/setlists/?key={apiKey}");
            var postData = new SetList
            {
                Name = Name
            };
            var json = JsonSerializer.Serialize(postData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync(url, content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                var postResponse = JsonSerializer.Deserialize<PostResponse>(responseContent);
            }
            else
            {
                Console.WriteLine(response.StatusCode);
            }
            return postData;
        }

        public async Task<SetListSet> AddSetToSetList(string userToken, string setListNumber, string setNumber)
        {
            var apiKey = _config["API_KEY"];
            var url = string.Format($"/api/v3/users/{userToken}/setlists/{setListNumber}/sets/?key={apiKey}");
            var postData = new SetListSet
            {
                SetNumber = setNumber
            };
            var json = JsonSerializer.Serialize(postData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync(url, content).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                var postResponse = JsonSerializer.Deserialize<PostResponse>(responseContent);
            }
            else
            {
                Console.WriteLine(response.StatusCode);
            }
            return postData;
        }

        public async Task<SetList> GetSetLists(string userToken)
        {
            var apiKey = _config["API_KEY"];
            var url = string.Format($"/api/v3/users/{userToken}/setlists/?key={apiKey}");
            var result = new SetList();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                result = JsonSerializer.Deserialize<SetList>(stringResponse);
                Console.WriteLine(response.StatusCode);
            }
            return result;
        }

        public async Task<SetListSet> SetListSets(string userToken, string listId)
        {
            var apiKey = _config["API_KEY"];
            var url = string.Format($"/api/v3/users/{userToken}/setlists/{listId}/sets/?key={apiKey}");
            var result = new SetListSet();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                result = JsonSerializer.Deserialize<SetListSet>(stringResponse);
                Console.WriteLine(response.StatusCode);
            }
            return result;
        }

        public async Task<SetListSet> ChangeSetQuantity(string userToken, string listId, string setNumber, int Quantity)
        {
            var apiKey = _config["API_KEY"];
            var url = string.Format($"/api/v3/users/{userToken}/setlists/{listId}/sets/{setNumber}/?key={apiKey}");
            var putData = new SetListSet
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

        public async Task<AllPart> AllParts(string userToken, int page)
        {
            var apiKey = _config["API_KEY"];
            var url = string.Format($"/api/v3/users/{userToken}/allparts/?page={page}&key={apiKey}");
            var result = new AllPart();
            var response = await client.GetAsync(url);
            Console.WriteLine(url);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                result = JsonSerializer.Deserialize<AllPart>(stringResponse);
                Console.WriteLine(response.StatusCode);
            }
            return result;
        }

        public async Task<PartList> PartListDetails(string userToken, string listId)
        {
            var apiKey = _config["API_KEY"];
            var url = string.Format($"/api/v3/users/{userToken}/partlists/{listId}/&key={apiKey}");
            var result = new PartList();
            var response = await client.GetAsync(url);
            Console.WriteLine(url);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                result = JsonSerializer.Deserialize<PartList>(stringResponse);
                Console.WriteLine(response.StatusCode);
            }
            return result;

        }

        public async Task<SetList> SetListDetails(string userToken, string listId)
        {
            var apiKey = _config["API_KEY"];
            var url = string.Format($"/api/v3/users/{userToken}/setlists/{listId}/&key={apiKey}");
            var result = new SetList();
            var response = await client.GetAsync(url);
            Console.WriteLine(url);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                result = JsonSerializer.Deserialize<SetList>(stringResponse);
                Console.WriteLine(response.StatusCode);
            }
            return result;

        }

        public async Task<SetList> DeletePartList(string userToken, string listId)
        {
            var apiKey = _config["API_KEY"];
            var url = string.Format($"/api/v3/users/{userToken}/partlists/{listId}/&key={apiKey}");
            var result = new SetList();
            var response = await client.DeleteAsync(url);
            Console.WriteLine(url);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                result = JsonSerializer.Deserialize<SetList>(stringResponse);
                Console.WriteLine(response.StatusCode);
            }
            return result;
        }
    }
}