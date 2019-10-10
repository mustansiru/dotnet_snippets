using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Pattern
{
    // This is the caller - can be a service or another UI level class
    class Client
    {
        private AbstractProductA _productA;
        private AbstractProductB _productB;

        public Client(AbstractFactory factory)
        {
            _productA = factory.CreateProductA();
            _productB = factory.CreateProductB();
        }

        public void Run()
        {
            // Replace this with actual interaction code
            // Currently this only prints a data type on console
            _productB.Interact(_productA);
        }
    }
}
