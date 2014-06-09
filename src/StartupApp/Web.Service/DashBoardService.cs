using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Web.Services.Models;

namespace Web.Service
{
    public class DashBoardService : IDashBoardService
    {
        public IEnumerable<DashBoardItemDto> GetDashBoardItems()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55665/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                var response = client.GetAsync("api/dashboard").Result;
                if (response.IsSuccessStatusCode)
                {
                    IEnumerable<DashBoardItemDto> product = response.Content.ReadAsAsync<IEnumerable<DashBoardItemDto>>().Result;
                    //Console.WriteLine("{0}\t${1}\t{2}", product.Name, product.Price, product.Category);
                    return product;
                }
            }

            return null;
        }
    }
}