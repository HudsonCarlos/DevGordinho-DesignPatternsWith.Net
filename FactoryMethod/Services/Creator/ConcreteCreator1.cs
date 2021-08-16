using FactoryMethod.Domain.Abstract;
using FactoryMethod.Domain.Interface;
using FactoryMethod.Services.Product;

namespace FactoryMethod.Services.Creator
{
    public class ConcreteCreator1 : Creators
    {
        public override IProduct FactoryMethod()
            => new ConcreteProduct1();
    }
}
