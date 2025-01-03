namespace Factory_Pattern_2;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("add , subtract , multiply , divide: ");
        string type = Console.ReadLine();
        CalculateFactory calculate = new CalculateFactory();
        ICalculate obj =calculate.GetCalculate(type);
        obj.Calculate(4, 5);
    }
    
}