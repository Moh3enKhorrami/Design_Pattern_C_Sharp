namespace AbstractFactory_1.IDialog;

public class LightDialog : IDialog
{
    public void ShowDialog()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Light Dialog");
    }
}