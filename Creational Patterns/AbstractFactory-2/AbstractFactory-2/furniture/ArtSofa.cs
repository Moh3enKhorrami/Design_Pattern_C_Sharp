using System;

namespace AbstractFactory_2.Chair;

public class ArtSofa : ISofa
{
    public void SitOn()
    {
        Console.WriteLine("Art sofa sits on");
    }
}