using LetsShopping.Models;
using LetsShopping.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace LetsShopping.Controllers
{
    public class ApiViewController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;
        private HttpClient Client => _clientFactory.CreateClient("api");

        public ApiViewController(IHttpClientFactory clientFactory) => _clientFactory = clientFactory;

        public async Task<IActionResult> Index()
        {
            var orders = await GetOrders();
            var orderedProd = await GetOrderedProduct();
            foreach(var ord in orders)
            {
                foreach (var ordProd in orderedProd)
                {
                    if (ord.OrderID == ordProd.OrderID)
                    {
                        ord.Quantity += ordProd.Quantity;
                    }
                }
            }
            return View(new ApiViewModel
            {
                Orders = orders
            });
        }

        public async Task<List<Order>> GetOrders()
        {
            var response = await Client.GetAsync($"api/order");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception();
            }
            var result = await response.Content.ReadAsStringAsync();
            var orders = JsonConvert.DeserializeObject<List<Order>>(result);
            return orders;
        }
        public async Task<List<OrderedProducts>> GetOrderedProduct()
        {
            var response = await Client.GetAsync($"api/OrderedProducts");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception();
            }
            var result = await response.Content.ReadAsStringAsync();
            var orders = JsonConvert.DeserializeObject<List<OrderedProducts>>(result);
            return orders;
        }
    }
}
