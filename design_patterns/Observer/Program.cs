using Observer.Pattern;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snippet for implementing Observer pattern");

            var ibm = new Stock("IBM", 100.00);
            ibm.Attach(new Investor("Barclays"));
            ibm.Attach(new Investor("Accel Partners"));

            ibm.Price = 120.05;
            ibm.Price = 119.75;
            ibm.Price = 118.06;
            ibm.Price = 123.75;

            Console.ReadKey();
        }
    }
}
