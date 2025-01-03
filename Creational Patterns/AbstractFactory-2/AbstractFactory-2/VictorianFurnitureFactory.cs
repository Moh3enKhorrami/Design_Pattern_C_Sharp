using AbstractFactory_2.Chair;

namespace AbstractFactory_2;

public class VictorianFurnitureFactory : IFurnitureAbstractFactory
{
    public IChair CreateChair()
    {
        IChair victorianChair = new VictorianChair();
        return victorianChair;
    }

    public ICoffeTable CreateCoffee()
    {
        ICoffeTable victorianCoffe = new VictorianCoffeTable();
        return victorianCoffe;
    }

    public ISofa CreateSofa()
    {
        ISofa victorianSofa = new VictorianSofa();
        return victorianSofa;
    }
}