using System;

namespace AbstractFactory.Pattern
{
    class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(@"{0} interacts with {1}",
                this.GetType().Name, a.GetType().Name);
        }
    }
}