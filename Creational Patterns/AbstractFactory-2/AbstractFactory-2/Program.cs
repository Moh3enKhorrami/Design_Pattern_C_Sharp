using AbstractFactory_2;
using AbstractFactory_2.Chair;

IFurnitureAbstractFactory furnitureAbstractFactory = FactoryProvider.GetFurnitureFactory(FurnitureType.Modern);
IChair chair= furnitureAbstractFactory.CreateChair();
    chair.SitOn();
ICoffeTable coffeTable = furnitureAbstractFactory.CreateCoffee();
    coffeTable.DrinkCoffe();
ISofa sofa = furnitureAbstractFactory.CreateSofa();
    sofa.SitOn();



public enum FurnitureType
{
    Art = 100,
    Victorian = 200,
    Modern = 300,
}