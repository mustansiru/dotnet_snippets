namespace AbstractFactory.Pattern
{
    abstract class AbstractProductB
    {
        // Some operation that needs to be performed that 
        // uses another product. Optional, but shows
        // a relationship
        public abstract void Interact(AbstractProductA a);
    }
}