using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PracticeRestLib;

namespace RestConsumptionConsoleUI
{
    public class RestConsumer
    {
        private const string URI = "http://noitrest.azurewebsites.net/api/localItems";

        public async Task<IList<Item>> GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                string content = await client.GetStringAsync(new Uri(URI));
                IList<Item> items = JsonConvert.DeserializeObject<IList<Item>>(content);

                return items;
            }

        }
    }
}
