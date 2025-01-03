using System;

namespace AbstractFactory_2.Chair;

public class ModernChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine("Modern chair soon");
    }
}