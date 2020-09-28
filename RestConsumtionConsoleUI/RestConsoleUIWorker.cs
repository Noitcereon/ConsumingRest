using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PracticeRestLib;

namespace RestConsumptionConsoleUI
{
    internal class RestConsoleUIWorker
    {
        public async void Start()
        {
            RestConsumer consumer = new RestConsumer();
            var items = await consumer.GetAll();

            foreach (var item in items)
            {
                Console.WriteLine((item));
            }
        }
    }
}
