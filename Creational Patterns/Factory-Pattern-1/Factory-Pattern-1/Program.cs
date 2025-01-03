

// superclass obj = new subclass();

using Factory_Pattern_1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the radius of the circle");
        string radius = Console.ReadLine();

        ShapeFactory shapeFactory = new ShapeFactory();
        IShape shape1 = shapeFactory.GetShape(radius);
        shape1.Draw();
    }
}
