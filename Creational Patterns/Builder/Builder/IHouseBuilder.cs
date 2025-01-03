namespace Builder;

public interface IHouseBuilder
{
    void BuildFoundation();
    void BuildStructure();
    void BuildRoof();
    void PaintHouse();
    void FurnishHouse();
    House GetHouse();

}