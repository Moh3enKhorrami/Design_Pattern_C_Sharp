using System;

namespace AbstractFactory_2.Chair;

public class VictorianChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine("Victorian sofa sits on");
    }
}