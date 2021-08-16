using FactoryMethod.Domain.Interface;

namespace FactoryMethod.Services.Product
{
    public class ConcreteProduct1 : IProduct
    {
        public string Operation()
            => "Result of ConcreteProduct1";
    }
}