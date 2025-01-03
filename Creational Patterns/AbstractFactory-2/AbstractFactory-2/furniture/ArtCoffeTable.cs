using System;

namespace AbstractFactory_2.Chair;

public class ArtCoffeTable : ICoffeTable
{
    public void DrinkCoffe()
    {
        Console.WriteLine("Art coffe drinks");
    }
}