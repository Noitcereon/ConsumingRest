using System;
using System.Runtime.InteropServices.ComTypes;

namespace RestConsumptionConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            RestConsoleUIWorker worker = new RestConsoleUIWorker();
            worker.Start();

            Console.Read();
        }
    }
}
