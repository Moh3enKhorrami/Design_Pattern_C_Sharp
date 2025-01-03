namespace Builder;

public class ConstructionEngineer
{
    private IHouseBuilder _houseBuilder;
    public ConstructionEngineer(IHouseBuilder houseBuilder)
    {
        _houseBuilder = houseBuilder;
    }

    public House ConstructHouse()
    {
        _houseBuilder.BuildFoundation();
        _houseBuilder.BuildStructure();
        _houseBuilder.BuildRoof();
        _houseBuilder.PaintHouse();
        _houseBuilder.FurnishHouse();
        return _houseBuilder.GetHouse();
    }


}