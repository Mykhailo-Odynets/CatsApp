using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatsApp.Models;
using System.Net.Http.Json;

namespace CatsApp.Data
{
    public class CatAPI
    {
        HttpClient client;
        List<Cat> cats = new List<Cat>();
        public CatAPI()
        {
            client = new HttpClient();
        }
        public async Task<List<Cat>?> GetData()
        {
            if (cats?.Count > 0)
                return cats;

            string api_key = "live_omdMPf8o2Xg7RLPKPFw1ppuihuQy663vVmbNnR2j7a58qDqC4PWm6DRtBV8u0eyh";
            int data_count = 10;
            string url = $"https://api.thecatapi.com/v1/images/search?limit={data_count}&api_key={api_key}";

            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                cats = await response.Content.ReadFromJsonAsync<List<Cat>>();
            }

            return cats;
        }
    }
}
