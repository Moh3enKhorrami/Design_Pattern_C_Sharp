using System;

namespace AbstractFactory_2.Chair;

public class ArtChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine("Art chair sits on");
    }
}