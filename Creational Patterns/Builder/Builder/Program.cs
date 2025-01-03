

using Builder;

System.Console.WriteLine("--------------- Concrete House Builder ---------------");

IHouseBuilder concreteHouseBuilder = new ConcreteHauseBuilder();
ConstructionEngineer engineerA = new ConstructionEngineer(concreteHouseBuilder);

House houseA = engineerA.ConstructHouse();
System.Console.WriteLine("House A: " + houseA);


System.Console.WriteLine("--------------- Prefabricate House Builder ---------------");
IHouseBuilder prefabricateHouseBuilder = new PrefabricateHouseBuilder();
ConstructionEngineer engineerB = new ConstructionEngineer(prefabricateHouseBuilder);

House houseB = engineerB.ConstructHouse();
System.Console.WriteLine("House B: " + houseB);