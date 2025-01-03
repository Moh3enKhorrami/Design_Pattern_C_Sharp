using AbstractFactory_2.Chair;

namespace AbstractFactory_2;

public class ModernFurnitureFactory : IFurnitureAbstractFactory
{
    public IChair CreateChair()
    {
        IChair chair = new ModernChair();
        return chair;
    }

    public ICoffeTable CreateCoffee()
    {
        ICoffeTable coffeTable = new ModernCoffeTable();
        return coffeTable;
    }

    public ISofa CreateSofa()
    {
        ISofa sofa = new ModernSofa();
        return sofa;
    }
}