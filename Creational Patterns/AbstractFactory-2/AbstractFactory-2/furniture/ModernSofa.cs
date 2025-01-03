using System;

namespace AbstractFactory_2.Chair;

public class ModernSofa : ISofa
{
    public void SitOn()
    {
        Console.WriteLine("Modern sofa soon");
    }
}