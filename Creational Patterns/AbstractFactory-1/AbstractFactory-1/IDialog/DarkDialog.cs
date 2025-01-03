namespace AbstractFactory_1.IDialog;

public class DarkDialog : IDialog
{
    public void ShowDialog()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Dark Blue Dialog");
    }
}