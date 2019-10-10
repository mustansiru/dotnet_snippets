using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Pattern
{
    class Investor : IInvestor
    {
        public string Name { get; }
        public Stock Stock { get; set; }

        public Investor(string name)
        {
            this.Name = name;
        }

        public void Update(Stock stock)
        {
            // Here process based on the updates 
            // received for the observed object.
            Console.WriteLine(@"Notified {0} of {1}'s change to {2:C}",
                this.Name, stock.Symbol, stock.Price);
        }
    }
}
