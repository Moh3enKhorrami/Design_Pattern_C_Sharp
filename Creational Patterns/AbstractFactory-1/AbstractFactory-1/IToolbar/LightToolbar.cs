namespace AbstractFactory_1.IToolbar;

public class LightToolbar : IToolbar
{
    public void ShowToolbar()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Light Toolbar");
    }
}