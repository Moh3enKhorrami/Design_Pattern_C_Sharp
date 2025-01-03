namespace Builder;

public class PrefabricateHouseBuilder : IHouseBuilder
{
    private House _house;

    public PrefabricateHouseBuilder()
    {
        _house = new House();
    }
    public void BuildFoundation()
    {
        _house.Foundation = "Wood, laminate, and PVC flooring";
        Console.WriteLine("PrefabricateHouseBuilder: foundation complete ...");
    }

    public void BuildStructure()
    {
        _house.Structure = "Structure steels and wood wall panels";
        Console.WriteLine("PrefabricateHouseBuilder: structure complete ...");
    }

    public void BuildRoof()
    {
        _house.Roof = "Roof sheets";
        Console.WriteLine("PrefabricateHouseBuilder: roof complete ...");
    }

    public void PaintHouse()
    {
        _house.Painted = false;
        Console.WriteLine("PrefabricateHouseBuilder: paint not required");
    }

    public void FurnishHouse()
    {
        _house.Furnished = false;
        Console.WriteLine("PrefabricateHouseBuilder: furnished not required");
    }

    public House GetHouse()
    {
        Console.WriteLine("PrefabricateHouseBuilder: Prefabricated house ...");
        return _house;
    }
}