using System;

namespace AbstractFactory_2.Chair;

public class VictorianSofa : ISofa
{
    public void SitOn()
    {
        Console.WriteLine("Victorian Sofa is sitting on");
    }
}