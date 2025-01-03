namespace Factory_Pattern_2;

public class Subtract:ICalculate
{
    public void Calculate(double num1, double num2)
    {
        Console.WriteLine(num1 - num2);
    }
}