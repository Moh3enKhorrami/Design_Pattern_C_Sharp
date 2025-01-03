using AbstractFactory_2.Chair;

namespace AbstractFactory_2;

public interface IFurnitureAbstractFactory
{
    IChair CreateChair();
    ICoffeTable CreateCoffee();
    ISofa CreateSofa();
}