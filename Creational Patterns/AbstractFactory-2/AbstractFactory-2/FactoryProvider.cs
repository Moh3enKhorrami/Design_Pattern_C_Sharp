namespace AbstractFactory_2;

public class FactoryProvider
{
    public static IFurnitureAbstractFactory GetFurnitureFactory(FurnitureType furnitureType)
    {
        IFurnitureAbstractFactory factory = null;
        switch (furnitureType)
        {
            case FurnitureType.Art :
                factory = new ArtFurnitureFactory();
                break;
            case FurnitureType.Victorian:
                factory = new VictorianFurnitureFactory();
                break;
            case FurnitureType.Modern:
                factory = new ModernFurnitureFactory();
                break;
        }
        return factory;
    }
}