namespace AbstractFactory_1.IToolbar;

public class DarkToolbar : IToolbar
{
    public void ShowToolbar()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Dark Toolbar");
    }
}