namespace Factory_Pattern_1;

public class ShapeFactory
{
    public IShape GetShape(string type)
    {
        
        if (type.ToLower() == "rectangle")
        {
            return new Rectangle();
        }else if (type.ToLower() == "squre")
        {
            return new Squre();
        }else if (type.ToLower() == "circle")
        {
            return new Circle();

        }
        
        return null;
    }
}