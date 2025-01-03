namespace Builder;

public class ConcreteHauseBuilder : IHouseBuilder
{
    private House _house;

    public ConcreteHauseBuilder()
    {
        _house = new House();
    }
    public void BuildFoundation()
    {
        _house.Foundation = "Concrete, brick, and stone";
        Console.WriteLine("ConcreteHauseBuilder: Foundation is complete...");
    }

    public void BuildStructure()
    {
        _house.Structure = "Concrete, mortar, brick, and reinforced steel";
        Console.WriteLine("ConcreteHauseBuilder: Structure is complete...");
    }

    public void BuildRoof()
    {
        _house.Roof = "Concrete and reinforced steel";
        Console.WriteLine("ConcreteHauseBuilder: Roof is complete...");
    }

    public void PaintHouse()
    {
        _house.Painted = true;
        System.Console.WriteLine("ConcreteHauseBuilder: Painting is complete...");
    }

    public void FurnishHouse()
    {
        _house.Furnished = true;
        System.Console.WriteLine("ConcreteHauseBuilder: Furnishing is complete...");
    }

    public House GetHouse()
    {
        Console.WriteLine("ConcreteHauseBuilder: Concrete house ...");
        return _house;
    }
}