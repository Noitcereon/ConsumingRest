using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var items = await consumer.GetAll();
            watch.Stop();
            Console.WriteLine($"GetAll finished after {watch.Elapsed.Milliseconds} milliseconds");
            foreach (var item in items)
            {
                Console.WriteLine(JsonConvert.SerializeObject(item));
            }

            Console.WriteLine();

            Item oneItem = await consumer.GetOne(2);

            Console.WriteLine();

            Console.WriteLine(await consumer.Post(new Item(6, "myItemName", "Low", 50)));

            Console.WriteLine();

            //consumer.Put(4, new Item(4, "xName", "asdf", 20));

            //consumer.Delete(4);
        }
    }
}
