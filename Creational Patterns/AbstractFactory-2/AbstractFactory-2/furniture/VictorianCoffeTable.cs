using System;

namespace AbstractFactory_2.Chair;

public class VictorianCoffeTable : ICoffeTable
{
    public void DrinkCoffe()
    {
        Console.WriteLine("Victorian Sofa is drinking");
    }
}