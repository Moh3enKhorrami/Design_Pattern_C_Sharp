namespace Factory_Pattern_2;

public class CalculateFactory
{
    public ICalculate GetCalculate(string type)
    {
        ICalculate calculate = null;
        if (type.ToLower() == "diver")
        {
            calculate = new Diver();
        }else if (type.ToLower() == "add")
        {
            calculate = new Add();
        }else if (type.ToLower() == "multiply")
        {
            calculate = new Multiply();
        }else if (type.ToLower() == "subtract")
        {
            calculate = new Subtract();
        }
        return calculate;
    }
}