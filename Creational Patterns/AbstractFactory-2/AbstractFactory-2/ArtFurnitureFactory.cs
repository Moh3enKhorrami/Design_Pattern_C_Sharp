using AbstractFactory_2.Chair;

namespace AbstractFactory_2;

public class ArtFurnitureFactory : IFurnitureAbstractFactory
{
    public IChair CreateChair()
    {
        IChair artChair = new ArtChair();
        return artChair;
    }

    public ICoffeTable CreateCoffee()
    {
        ICoffeTable artCoffe = new ArtCoffeTable();
        return artCoffe;
    }

    public ISofa CreateSofa()
    {
        ISofa artSofa = new ArtSofa();
        return artSofa;
    }
}