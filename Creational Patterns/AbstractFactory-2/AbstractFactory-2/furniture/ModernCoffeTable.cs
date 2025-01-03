using System;

namespace AbstractFactory_2.Chair;

public class ModernCoffeTable : ICoffeTable
{
    public void DrinkCoffe()
    {
        Console.WriteLine("Modern coffeTable soon");
    }
}