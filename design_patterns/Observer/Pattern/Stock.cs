using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Pattern
{
    class Stock
    {
        private double _price;
        private List<IInvestor> _investors;

        public Stock(string symbol, double price)
        {
            _investors = new List<IInvestor>();

            // list starting price of stock
            this.Symbol = symbol;
            this._price = price;
        }

        public void Attach(IInvestor investor)
        {
            _investors.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            _investors.Remove(investor);
        }

        public void Notify()
        {
            // notifications about changes to object
            foreach (var investor in _investors)
            {
                investor.Update(this);
            }

            Console.WriteLine("");
        }

        // Price property
        public double Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify();   // Notify observers of changes to this object
                }
            }
        }

        // Read-only property
        public string Symbol { get; }
    }
}
