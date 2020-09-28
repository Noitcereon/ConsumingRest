﻿using System;
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
        private const string URI = "http://noitrest.azurewebsites.net/api/localItems/";

        public async Task<IList<Item>> GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                string content = await client.GetStringAsync(new Uri(URI));
                IList<Item> items = JsonConvert.DeserializeObject<IList<Item>>(content);

                return items;
            }
        }
        public async Task<Item> GetOne(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(new Uri(URI + id));
                string jsonContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    Item item = JsonConvert.DeserializeObject<Item>(jsonContent);
                    return item;
                }

                throw new KeyNotFoundException($"Status code: {response.StatusCode}\n Message: {jsonContent}");
            }
        }

        public async Task<string> Post(Item item)
        {
            throw new NotImplementedException();
        }

        public async Task<string> Put(int id, Item item)
        {
            throw new NotImplementedException();
        }

        public async Task<string> Delete(int id)
        {
            throw new NotImplementedException();
            return $"Deleted item nr. {id}";
        }
    }
}
