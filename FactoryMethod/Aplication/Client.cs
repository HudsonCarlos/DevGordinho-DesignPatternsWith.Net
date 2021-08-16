using FactoryMethod.Domain.Abstract;
using FactoryMethod.Services.Creator;
using System;

namespace FactoryMethod.Aplication
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the ConcreteCreator1");
            ClientCode(new ConcreteCreator1());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ConcreteCreator2");
            ClientCode(new ConcreteCreator2());
        }

        public static void ClientCode(Creators creator)
        {
            Console.WriteLine("Client: I'm not aware of the creator's class, bus it still works.\n" + creator.SomeOperation());
        }
    }
}
