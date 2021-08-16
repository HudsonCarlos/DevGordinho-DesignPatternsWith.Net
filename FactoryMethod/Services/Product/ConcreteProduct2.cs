using FactoryMethod.Domain.Interface;

namespace FactoryMethod.Services.Product
{
    public class ConcreteProduct2 : IProduct
    {
        public string Operation()
            => "Result of ConcreteProduct2";
    }
}
