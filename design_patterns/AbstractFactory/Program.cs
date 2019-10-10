using AbstractFactory.Pattern;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract factory #1

            // Using fully qualified name here. But replace with proper namespace
            AbstractFactory.Pattern.AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            // Abstract factory #2

            AbstractFactory.Pattern.AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();

            // Wait for user input

            Console.ReadKey();
        }
    }
}
